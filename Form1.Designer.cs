
namespace MojBroj
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Button deleteBtn;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.stopBtn = new System.Windows.Forms.Button();
			this.plusBtn = new System.Windows.Forms.Button();
			this.minusBtn = new System.Windows.Forms.Button();
			this.multBtn = new System.Windows.Forms.Button();
			this.divBtn = new System.Windows.Forms.Button();
			this.closedBtn = new System.Windows.Forms.Button();
			this.openBtn = new System.Windows.Forms.Button();
			this.expTb = new System.Windows.Forms.TextBox();
			this.compTb = new System.Windows.Forms.TextBox();
			this.a1Btn = new System.Windows.Forms.Button();
			this.a2Btn = new System.Windows.Forms.Button();
			this.a3Btn = new System.Windows.Forms.Button();
			this.a4Btn = new System.Windows.Forms.Button();
			this.bBtn = new System.Windows.Forms.Button();
			this.cBtn = new System.Windows.Forms.Button();
			this.n100tb = new System.Windows.Forms.Button();
			this.n10tb = new System.Windows.Forms.Button();
			this.n1tb = new System.Windows.Forms.Button();
			this.pointsLabel = new System.Windows.Forms.Label();
			this.timerBg = new System.Windows.Forms.TextBox();
			this.timerFg = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			deleteBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// deleteBtn
			// 
			deleteBtn.BackColor = System.Drawing.Color.RoyalBlue;
			deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			deleteBtn.FlatAppearance.BorderSize = 2;
			deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			deleteBtn.Location = new System.Drawing.Point(204, 293);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new System.Drawing.Size(99, 35);
			deleteBtn.TabIndex = 27;
			deleteBtn.Text = "←";
			deleteBtn.UseVisualStyleBackColor = false;
			deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// stopBtn
			// 
			this.stopBtn.BackColor = System.Drawing.Color.RoyalBlue;
			this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stopBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.stopBtn.Location = new System.Drawing.Point(339, 372);
			this.stopBtn.Name = "stopBtn";
			this.stopBtn.Size = new System.Drawing.Size(146, 50);
			this.stopBtn.TabIndex = 0;
			this.stopBtn.Text = "СТОЈ!";
			this.stopBtn.UseMnemonic = false;
			this.stopBtn.UseVisualStyleBackColor = false;
			this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
			// 
			// plusBtn
			// 
			this.plusBtn.BackColor = System.Drawing.Color.RoyalBlue;
			this.plusBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.plusBtn.FlatAppearance.BorderSize = 2;
			this.plusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.plusBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.plusBtn.Location = new System.Drawing.Point(82, 230);
			this.plusBtn.Name = "plusBtn";
			this.plusBtn.Size = new System.Drawing.Size(35, 35);
			this.plusBtn.TabIndex = 10;
			this.plusBtn.Text = "+";
			this.plusBtn.UseVisualStyleBackColor = false;
			this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
			// 
			// minusBtn
			// 
			this.minusBtn.BackColor = System.Drawing.Color.RoyalBlue;
			this.minusBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.minusBtn.FlatAppearance.BorderSize = 2;
			this.minusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minusBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.minusBtn.Location = new System.Drawing.Point(143, 230);
			this.minusBtn.Name = "minusBtn";
			this.minusBtn.Size = new System.Drawing.Size(35, 35);
			this.minusBtn.TabIndex = 11;
			this.minusBtn.Text = "-";
			this.minusBtn.UseVisualStyleBackColor = false;
			this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
			// 
			// multBtn
			// 
			this.multBtn.BackColor = System.Drawing.Color.RoyalBlue;
			this.multBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.multBtn.FlatAppearance.BorderSize = 2;
			this.multBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.multBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.multBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.multBtn.Location = new System.Drawing.Point(204, 230);
			this.multBtn.Name = "multBtn";
			this.multBtn.Size = new System.Drawing.Size(35, 35);
			this.multBtn.TabIndex = 12;
			this.multBtn.Text = "*";
			this.multBtn.UseVisualStyleBackColor = false;
			this.multBtn.Click += new System.EventHandler(this.multBtn_Click);
			// 
			// divBtn
			// 
			this.divBtn.BackColor = System.Drawing.Color.RoyalBlue;
			this.divBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.divBtn.FlatAppearance.BorderSize = 2;
			this.divBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.divBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.divBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.divBtn.Location = new System.Drawing.Point(268, 230);
			this.divBtn.Name = "divBtn";
			this.divBtn.Size = new System.Drawing.Size(35, 35);
			this.divBtn.TabIndex = 13;
			this.divBtn.Text = "/";
			this.divBtn.UseVisualStyleBackColor = false;
			this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
			// 
			// closedBtn
			// 
			this.closedBtn.BackColor = System.Drawing.Color.RoyalBlue;
			this.closedBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.closedBtn.FlatAppearance.BorderSize = 2;
			this.closedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.closedBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.closedBtn.Location = new System.Drawing.Point(143, 293);
			this.closedBtn.Name = "closedBtn";
			this.closedBtn.Size = new System.Drawing.Size(35, 35);
			this.closedBtn.TabIndex = 14;
			this.closedBtn.Text = ")";
			this.closedBtn.UseVisualStyleBackColor = false;
			this.closedBtn.Click += new System.EventHandler(this.closedBtn_Click);
			// 
			// openBtn
			// 
			this.openBtn.BackColor = System.Drawing.Color.RoyalBlue;
			this.openBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.openBtn.FlatAppearance.BorderSize = 2;
			this.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.openBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.openBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.openBtn.Location = new System.Drawing.Point(82, 293);
			this.openBtn.Name = "openBtn";
			this.openBtn.Size = new System.Drawing.Size(35, 35);
			this.openBtn.TabIndex = 15;
			this.openBtn.Text = "(";
			this.openBtn.UseVisualStyleBackColor = false;
			this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
			// 
			// expTb
			// 
			this.expTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.expTb.Location = new System.Drawing.Point(379, 230);
			this.expTb.Name = "expTb";
			this.expTb.ReadOnly = true;
			this.expTb.Size = new System.Drawing.Size(347, 32);
			this.expTb.TabIndex = 16;
			// 
			// compTb
			// 
			this.compTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.compTb.Location = new System.Drawing.Point(377, 296);
			this.compTb.Name = "compTb";
			this.compTb.ReadOnly = true;
			this.compTb.Size = new System.Drawing.Size(347, 32);
			this.compTb.TabIndex = 17;
			// 
			// a1Btn
			// 
			this.a1Btn.BackColor = System.Drawing.Color.White;
			this.a1Btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.a1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.a1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.a1Btn.Location = new System.Drawing.Point(82, 140);
			this.a1Btn.Name = "a1Btn";
			this.a1Btn.Size = new System.Drawing.Size(35, 35);
			this.a1Btn.TabIndex = 18;
			this.a1Btn.UseVisualStyleBackColor = false;
			this.a1Btn.Click += new System.EventHandler(this.a1Btn_Click);
			// 
			// a2Btn
			// 
			this.a2Btn.BackColor = System.Drawing.Color.White;
			this.a2Btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.a2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.a2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.a2Btn.Location = new System.Drawing.Point(143, 140);
			this.a2Btn.Name = "a2Btn";
			this.a2Btn.Size = new System.Drawing.Size(35, 35);
			this.a2Btn.TabIndex = 19;
			this.a2Btn.UseVisualStyleBackColor = false;
			this.a2Btn.Click += new System.EventHandler(this.a2Btn_Click);
			// 
			// a3Btn
			// 
			this.a3Btn.BackColor = System.Drawing.Color.White;
			this.a3Btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.a3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.a3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.a3Btn.Location = new System.Drawing.Point(204, 140);
			this.a3Btn.Name = "a3Btn";
			this.a3Btn.Size = new System.Drawing.Size(35, 35);
			this.a3Btn.TabIndex = 20;
			this.a3Btn.UseVisualStyleBackColor = false;
			this.a3Btn.Click += new System.EventHandler(this.a3Btn_Click);
			// 
			// a4Btn
			// 
			this.a4Btn.BackColor = System.Drawing.Color.White;
			this.a4Btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.a4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.a4Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.a4Btn.Location = new System.Drawing.Point(268, 140);
			this.a4Btn.Name = "a4Btn";
			this.a4Btn.Size = new System.Drawing.Size(35, 35);
			this.a4Btn.TabIndex = 21;
			this.a4Btn.UseVisualStyleBackColor = false;
			this.a4Btn.Click += new System.EventHandler(this.a4Btn_Click);
			// 
			// bBtn
			// 
			this.bBtn.BackColor = System.Drawing.Color.White;
			this.bBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.bBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bBtn.Location = new System.Drawing.Point(412, 140);
			this.bBtn.Name = "bBtn";
			this.bBtn.Size = new System.Drawing.Size(73, 35);
			this.bBtn.TabIndex = 22;
			this.bBtn.UseVisualStyleBackColor = false;
			this.bBtn.Click += new System.EventHandler(this.bBtn_Click);
			// 
			// cBtn
			// 
			this.cBtn.BackColor = System.Drawing.Color.White;
			this.cBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.cBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cBtn.Location = new System.Drawing.Point(591, 140);
			this.cBtn.Name = "cBtn";
			this.cBtn.Size = new System.Drawing.Size(82, 35);
			this.cBtn.TabIndex = 23;
			this.cBtn.UseVisualStyleBackColor = false;
			this.cBtn.Click += new System.EventHandler(this.cBtn_Click);
			// 
			// n100tb
			// 
			this.n100tb.BackColor = System.Drawing.Color.White;
			this.n100tb.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.n100tb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.n100tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.n100tb.Location = new System.Drawing.Point(284, 50);
			this.n100tb.Name = "n100tb";
			this.n100tb.Size = new System.Drawing.Size(41, 38);
			this.n100tb.TabIndex = 24;
			this.n100tb.UseVisualStyleBackColor = false;
			// 
			// n10tb
			// 
			this.n10tb.BackColor = System.Drawing.Color.White;
			this.n10tb.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.n10tb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.n10tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.n10tb.Location = new System.Drawing.Point(360, 50);
			this.n10tb.Name = "n10tb";
			this.n10tb.Size = new System.Drawing.Size(41, 38);
			this.n10tb.TabIndex = 25;
			this.n10tb.UseVisualStyleBackColor = false;
			// 
			// n1tb
			// 
			this.n1tb.BackColor = System.Drawing.Color.White;
			this.n1tb.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.n1tb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.n1tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.n1tb.Location = new System.Drawing.Point(444, 50);
			this.n1tb.Name = "n1tb";
			this.n1tb.Size = new System.Drawing.Size(41, 38);
			this.n1tb.TabIndex = 26;
			this.n1tb.UseVisualStyleBackColor = false;
			// 
			// pointsLabel
			// 
			this.pointsLabel.AutoSize = true;
			this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pointsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.pointsLabel.Location = new System.Drawing.Point(618, 370);
			this.pointsLabel.Name = "pointsLabel";
			this.pointsLabel.Size = new System.Drawing.Size(0, 39);
			this.pointsLabel.TabIndex = 28;
			// 
			// timerBg
			// 
			this.timerBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.timerBg.Enabled = false;
			this.timerBg.Location = new System.Drawing.Point(790, 50);
			this.timerBg.Multiline = true;
			this.timerBg.Name = "timerBg";
			this.timerBg.Size = new System.Drawing.Size(20, 300);
			this.timerBg.TabIndex = 29;
			// 
			// timerFg
			// 
			this.timerFg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.timerFg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.timerFg.Enabled = false;
			this.timerFg.Location = new System.Drawing.Point(790, 50);
			this.timerFg.Multiline = true;
			this.timerFg.Name = "timerFg";
			this.timerFg.Size = new System.Drawing.Size(20, 0);
			this.timerFg.TabIndex = 30;
			// 
			// timer1
			// 
			this.timer1.Interval = 2000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(857, 461);
			this.Controls.Add(this.timerFg);
			this.Controls.Add(this.timerBg);
			this.Controls.Add(this.pointsLabel);
			this.Controls.Add(deleteBtn);
			this.Controls.Add(this.n1tb);
			this.Controls.Add(this.n10tb);
			this.Controls.Add(this.n100tb);
			this.Controls.Add(this.cBtn);
			this.Controls.Add(this.bBtn);
			this.Controls.Add(this.a4Btn);
			this.Controls.Add(this.a3Btn);
			this.Controls.Add(this.a2Btn);
			this.Controls.Add(this.a1Btn);
			this.Controls.Add(this.compTb);
			this.Controls.Add(this.expTb);
			this.Controls.Add(this.openBtn);
			this.Controls.Add(this.closedBtn);
			this.Controls.Add(this.divBtn);
			this.Controls.Add(this.multBtn);
			this.Controls.Add(this.minusBtn);
			this.Controls.Add(this.plusBtn);
			this.Controls.Add(this.stopBtn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Мој број";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button stopBtn;
		private System.Windows.Forms.Button plusBtn;
		private System.Windows.Forms.Button minusBtn;
		private System.Windows.Forms.Button multBtn;
		private System.Windows.Forms.Button divBtn;
		private System.Windows.Forms.Button closedBtn;
		private System.Windows.Forms.Button openBtn;
		private System.Windows.Forms.TextBox expTb;
		private System.Windows.Forms.TextBox compTb;
		private System.Windows.Forms.Button a1Btn;
		private System.Windows.Forms.Button a2Btn;
		private System.Windows.Forms.Button a3Btn;
		private System.Windows.Forms.Button a4Btn;
		private System.Windows.Forms.Button bBtn;
		private System.Windows.Forms.Button cBtn;
		private System.Windows.Forms.Button n100tb;
		private System.Windows.Forms.Button n10tb;
		private System.Windows.Forms.Button n1tb;
		private System.Windows.Forms.Label pointsLabel;
		private System.Windows.Forms.TextBox timerBg;
		private System.Windows.Forms.TextBox timerFg;
		private System.Windows.Forms.Timer timer1;
	}
}

