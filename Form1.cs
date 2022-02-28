using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojBroj
{
	public partial class Form1 : Form
	{
		string[] ntbs = { "n100tb", "n10tb", "n1tb" };
		string[] atbs = { "a1Btn", "a2Btn", "a3Btn", "a4Btn" };
		string[] opbtns = { "plusBtn", "minusBtn", "multBtn", "divBtn", "openBtn", "closedBtn" };

		bool stopBtnPressed = false;
		bool confirmButton = false;
		bool playAgainButton = false;

		int intervalCnt = 0;

		Stack<string> expStack;

		int[] nums;

		private async Task<int> GetValue(Button tb, char type)
		{
			List<int> values = new List<int>();
			if (type == 'n')
			{
				for (int i = 0; i < 10; i++) { values.Add(i); }
			} else if (type == 'a') {
				for (int i = 1; i < 10; i++) { values.Add(i); }
			}
			else if (type == 'b')
			{
				values.Add(10); values.Add(15); values.Add(20);
			}
			else if (type == 'c')
			{
				values.Add(25); values.Add(50); values.Add(75); values.Add(100);
			}

			while (!stopBtnPressed)
			{
				foreach(var v in values)
				{
					tb.Text = v.ToString();
					if (stopBtnPressed) break;
					await Task.Delay(20);
				}
			}

			var random = new Random();
			int valIdx = random.Next(values.Count);
			tb.Text = values[valIdx].ToString();
			return values[valIdx];
		}

		private async Task GetAllNums()
		{
			foreach(var tbName in ntbs)
			{
				Button txtBox = this.Controls[tbName] as Button;
				await GetValue(txtBox, 'n');
				stopBtnPressed = false;
			}

			int idx=0;
			nums = new int[6];

			foreach(var tbName in atbs)
			{
				Button txtBox = this.Controls[tbName] as Button;
				nums[idx++] = await GetValue(txtBox, 'a');
				stopBtnPressed = false;
			}

			nums[idx++] = await GetValue(bBtn, 'b');
			stopBtnPressed = false;

			nums[idx++] = await GetValue(cBtn, 'c');
			stopBtnPressed = false;
		}

		private void clearOutput()
		{
			n100tb.Text = n10tb.Text = n1tb.Text =
				a1Btn.Text = a2Btn.Text = a3Btn.Text =
				a4Btn.Text = bBtn.Text = cBtn.Text = "";
			expTb.Text = compTb.Text = "";
			pointsLabel.Text = "";
			timerFg.Height = 0;
		}
		
		private struct From
		{
			public int a1, a2, mask1, mask2;
			public bool p1, p2;
			public char op;

			public From(int A1, int A2, int m1, int m2, bool P1, bool P2, char OP)
			{
				a1 = A1; a2 = A2;
				mask1 = m1; mask2 = m2;
				p1 = P1; p2 = P2;
				op = OP;
			}

		}
		
		private string getExp(int i, int mask, From[,] from)
		{
			if(from[i, mask].op == '.')
			{
				int idx;
				for (idx = -1; mask > 0; idx++, mask >>= 1) ;
				return nums[idx].ToString();
			}

			From cf = from[i, mask];

			string s1 = "", s2 = "";
			if (cf.p1) s1 = "(";
			if (cf.p2) s2 = "(";

			s1 += getExp(cf.a1, cf.mask1, from);
			s2 += getExp(cf.a2, cf.mask2, from);

			if (cf.p1) s1 += ")";
			if (cf.p2) s2 += ")";

			return s1 + cf.op + s2;
		}

		private int calculate()
		{
			const int MAXN = 2000;

			bool[,] dp = new bool[MAXN+1, 1<<6];
			From[,] from = new From[MAXN+1, 1 << 6];

			int n = 100 * Int32.Parse(n100tb.Text) + 10 * Int32.Parse(n10tb.Text) + Int32.Parse(n1tb.Text);

			for(int i=0; i<6; i++)
			{
				dp[nums[i], 1 << i] = true;
				from[nums[i], 1 << i] = new From(-1, -1, 0, 0, false, false, '.');
			}

			for(int mask1=0; mask1<(1<<6); mask1++) {
				for(int mask2=0; mask2<(1<<6); mask2++)
				{
					if ((mask1 & mask2) != 0) continue;

					int mask = mask1 | mask2;

					for (int i=0; i<=MAXN; i++)
					{
						if (!dp[i, mask1]) continue;
						bool p1 = (from[i, mask1].op == '+' || from[i, mask1].op == '-');

						for (int j=0; j<=MAXN; j++)
						{
							if (!dp[j, mask2]) continue;

							bool p2 = (from[j, mask2].op == '+' || from[j, mask2].op == '-');

							if (i + j < MAXN)
							{
								dp[i + j, mask] = true;
								from[i + j, mask] = new From(i, j, mask1, mask2, false, false, '+');
							}

							if (i - j > 0)
							{
								dp[i - j, mask] = true;
								from[i - j, mask] = new From(i, j, mask1, mask2, false, false, '-');
							}

							if (i * j < MAXN)
							{
								dp[i * j, mask] = true;
								from[i * j, mask] = new From(i, j, mask1, mask2, p1, p2, '*');
							}

							if (i % j == 0)
							{
								dp[i / j, mask] = true;
								from[i / j, mask] = new From(i, j, mask1, mask2, p1, p2, '/');
							}
						}
					}
				}
			}

			string res = "";

			int b = Math.Min(n, MAXN - n);
			for(int i=0; i<b; i++)
			{
				bool found = false;

				for (int mask = 0; mask < (1 << 6); mask++)
				{
					if (dp[n+i, mask])
					{
						res = getExp(n+i, mask, from);
						found = true;
						break;
					}
				}

				if (found)
				{
					compTb.Text = res + "=" + (n + i).ToString();
					return (n + i);
				}

				for (int mask = 0; mask < (1 << 6); mask++)
				{
					if (dp[n - i, mask])
					{
						res = getExp(n - i, mask, from);
						found = true;
						break;
					}
				}

				if (found)
				{
					compTb.Text = res + "=" + (n - i).ToString();
					return (n - i);
				}
			}

			return 0;
		}

		private async void StartGame()
		{
			disableAllButtons();
			stopBtnPressed = confirmButton = playAgainButton = false;
			intervalCnt = 0;

			clearOutput();

			await GetAllNums();

			await Task.Delay(1000);
			stopBtn.Text = "Потврди";
			stopBtnPressed = false;
			confirmButton = true;

			enableAllButtons();

			expStack = new Stack<string>();

			timer1.Start();

		}

		public Form1()
		{
			InitializeComponent();
			StartGame();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timerFg.Height += 10;

			intervalCnt++;
			if(intervalCnt == 30)
			{
				timer1.Stop();
				confirmBtnHandler();
			}
		}
		
		private void stopBtnHandler()
		{
			stopBtnPressed = true;
		}

		private void confirmBtnHandler()
		{
			if (stopBtnPressed) return; // ako 2 puta klkne "potvrdi"

			disableAllButtons();

			timer1.Stop();

			int ures = evaluateExpression();
			int compres = calculate();

			int pts = 0;

			if (ures == int.MinValue)
			{
				MessageBox.Show("Неисправан израз!");
			}
			else
			{
				expTb.Text += "=" + ures.ToString();

				int correct = 100 * Int32.Parse(n100tb.Text) + 10 * Int32.Parse(n10tb.Text) + Int32.Parse(n1tb.Text);

				int dist = Math.Abs(ures - correct) - Math.Abs(compres - correct);

				if (dist == 0)
					pts = 20;
				else if (dist == 1)
					pts = 15;
				else if (dist <= 5)
					pts = 10;
				else if (dist <= 10)
					pts = 5;
			}

			pointsLabel.Text = pts.ToString();

			stopBtnPressed = true;

			Task.Delay(1000);
			stopBtn.Text = "Играј поново";
			playAgainButton = true;
		}

		private void playAgainBtnHandler()
		{
			stopBtn.Text = "СТОЈ!";
			StartGame();
		}
		
		private void disableAllButtons()
		{
			foreach (var tbName in atbs)
			{
				Button btn = this.Controls[tbName] as Button;
				btn.Enabled = false;
			}
			bBtn.Enabled = false;
			cBtn.Enabled = false;
		}

		private void enableAllButtons()
		{
			foreach (var tbName in atbs)
			{
				Button btn = this.Controls[tbName] as Button;
				btn.Enabled = true;
			}
			bBtn.Enabled = true;
			cBtn.Enabled = true;
		}

		private int precedance(char op)
		{
			if (op == '+' || op == '-')
				return 1;
			if (op == '*' || op == '/')
				return 2;
			return 0;
		}

		private int applyOperation(int val1, int val2, char op)
		{
			// TODO: floating point division?
			if(op == '+')
			{
				return val1 + val2;
			} else if(op == '-')
			{
				return val1 - val2;
			} else if(op == '*')
			{
				return val1 * val2;
			} else if(op == '/')
			{
				return val1 / val2;
			}
			return 0;
		}

		private int evaluateExpression()
		{
			if (expStack.Count == 0) return 0;

			string top = expStack.Peek();
			if (top == "plusBtn" || top == "minusBtn" || top == "multBtn" || top == "divBtn")
				return int.MinValue;

			Stack<string> tokenStack = new Stack<string>();
			int openp = 0, closedp = 0;
			while(expStack.Count > 0)
			{
				Button btn = this.Controls[expStack.Pop()] as Button; 
				tokenStack.Push(btn.Text);
				if (btn.Text == "(")
					openp++;
				else if (btn.Text == ")")
					closedp++;
			}

			if (openp != closedp)
				return int.MinValue;

			Stack<int> numst = new Stack<int>();
			Stack<char> opst = new Stack<char>();

			while(tokenStack.Count > 0)
			{
				string token = tokenStack.Pop();

				if(token[0] == '(')
				{
					opst.Push('(');
				} 
				else if (token[0] >= '0' && token[0] <= '9')
				{
					numst.Push(Int32.Parse(token));
				}
				else if (token[0] == ')')
				{
					while(opst.Count > 0 && opst.Peek() != '(')
					{
						int val2 = numst.Pop();
						int val1 = numst.Pop();
						char op = opst.Pop();
						numst.Push(applyOperation(val1, val2, op));
					}
					if (opst.Count == 0)
					{
						return int.MinValue;
					}
					opst.Pop();
				}
				else
				{
					while(opst.Count > 0 && precedance(opst.Peek()) >= precedance(token[0]))
					{
						int val2 = numst.Pop();
						int val1 = numst.Pop();
						char op = opst.Pop();
						numst.Push(applyOperation(val1, val2, op));
					}
					opst.Push(token[0]);
				}
			}

			while(opst.Count > 0)
			{
				int val2 = numst.Pop();
				int val1 = numst.Pop();
				char op = opst.Pop();
				numst.Push(applyOperation(val1, val2, op));
			}

			return numst.Pop();
		}

		private void stopBtn_Click(object sender, EventArgs e)
		{
			if (playAgainButton) // ako je postalo "igraj ponovo" dugme
			{
				playAgainBtnHandler();
			}
			else if (confirmButton) // ako je postalo "potvrdi" dugme
			{
				confirmBtnHandler();
			} else
			{
				stopBtnHandler();
			}
		}

		private void onNumClick(Button btn)
		{
			bool ok = false;

			if (expStack.Count() == 0)
			{
				ok = true;
			} else
			{
				foreach (var op in opbtns)
				{
					if (expStack.Peek() == op)
					{
						ok = true;
						break;
					}
				}
			}

			if (!ok) return;

			expTb.Text += btn.Text;
			btn.Enabled = false;
			expStack.Push(btn.Name);
		}

		private void onOpClick(Button btn)
		{
			if (!confirmButton) return;

			bool ok = false;

			if (expStack.Count() == 0)
			{
				if (btn.Name == "openBtn") ok = true;
				else ok = false;
			}
			else
			{
				string last = expStack.Peek(),
					curr = btn.Name;
				if (last == "openBtn")
				{
					if (curr == "openBtn")
						ok = true;
					else ok = false;
				} else if (curr == "openBtn")
				{
					foreach (var op in opbtns)
					{
						if (last == op && op != "closedBtn")
						{
							ok = true;
							break;
						}
					}
				}
				else
				{
					ok = true;
					foreach (var op in opbtns)
					{
						if (last == op && op != "closedBtn")
						{
							ok = false;
							break;
						}
					}
				}
			}

			if (!ok) return;

			expTb.Text += btn.Text;
			expStack.Push(btn.Name);
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			if (!confirmButton) return;
			if (expStack.Count == 0) return;
			Button btn = this.Controls[expStack.Peek()] as Button;
			btn.Enabled = true;
			int l = btn.Text.Length;
			expTb.Text = expTb.Text.Substring(0, expTb.Text.Length - l);
			expStack.Pop();
		}

		private void a1Btn_Click(object sender, EventArgs e)
		{
			onNumClick(a1Btn);
		}

		private void a2Btn_Click(object sender, EventArgs e)
		{
			onNumClick(a2Btn);
		}

		private void a3Btn_Click(object sender, EventArgs e)
		{
			onNumClick(a3Btn);
		}

		private void a4Btn_Click(object sender, EventArgs e)
		{
			onNumClick(a4Btn);
		}

		private void bBtn_Click(object sender, EventArgs e)
		{
			onNumClick(bBtn);
		}

		private void cBtn_Click(object sender, EventArgs e)
		{
			onNumClick(cBtn);
		}

		private void plusBtn_Click(object sender, EventArgs e)
		{
			onOpClick(plusBtn);
		}

		private void minusBtn_Click(object sender, EventArgs e)
		{
			onOpClick(minusBtn);
		}

		private void multBtn_Click(object sender, EventArgs e)
		{
			onOpClick(multBtn);
		}

		private void divBtn_Click(object sender, EventArgs e)
		{
			onOpClick(divBtn);
		}

		private void openBtn_Click(object sender, EventArgs e)
		{
			onOpClick(openBtn);
		}

		private void closedBtn_Click(object sender, EventArgs e)
		{
			onOpClick(closedBtn);
		}
	}
}
