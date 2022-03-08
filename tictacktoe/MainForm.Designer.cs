namespace tictacktoe
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(328, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.gameToolStripMenuItem.Text = "Oyun";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.newGameToolStripMenuItem.Text = "Yeni Oyun";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.YeniOyunKısmı);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.exitToolStripMenuItem.Text = "Çıkış";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ÇıkısKısmı);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.optionsToolStripMenuItem.Text = "Zorluk Seviyesi";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Checked = true;
            this.easyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.easyToolStripMenuItem.Text = "       Kolay";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.KolaySecimKısmı);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.hardToolStripMenuItem.Text = "       Zor  ";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.ZorSecimKısmı);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.Kutu1Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 68);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.UseCompatibleTextRendering = true;
            this.label2.Click += new System.EventHandler(this.Kutu2Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(210, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 68);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseCompatibleTextRendering = true;
            this.label3.Click += new System.EventHandler(this.Kutu3Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(210, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 68);
            this.label4.TabIndex = 6;
            this.label4.Text = "X";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.UseCompatibleTextRendering = true;
            this.label4.Click += new System.EventHandler(this.Kutu4Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(131, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 68);
            this.label5.TabIndex = 5;
            this.label5.Text = "X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.UseCompatibleTextRendering = true;
            this.label5.Click += new System.EventHandler(this.Kutu5Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(51, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 68);
            this.label6.TabIndex = 4;
            this.label6.Text = "X";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.UseCompatibleTextRendering = true;
            this.label6.Click += new System.EventHandler(this.Kutu6Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(210, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 68);
            this.label7.TabIndex = 9;
            this.label7.Text = "X";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.UseCompatibleTextRendering = true;
            this.label7.Click += new System.EventHandler(this.Kutu7Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(131, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 68);
            this.label8.TabIndex = 8;
            this.label8.Text = "X";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.UseCompatibleTextRendering = true;
            this.label8.Click += new System.EventHandler(this.Kutu8Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(51, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 68);
            this.label9.TabIndex = 7;
            this.label9.Text = "X";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.UseCompatibleTextRendering = true;
            this.label9.Click += new System.EventHandler(this.Kutu9Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(-3, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(331, 22);
            this.label10.TabIndex = 10;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(122, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(6, 227);
            this.label11.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(201, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(6, 227);
            this.label12.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(51, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 6);
            this.label13.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(51, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(227, 6);
            this.label14.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(328, 341);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "X O X";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}
