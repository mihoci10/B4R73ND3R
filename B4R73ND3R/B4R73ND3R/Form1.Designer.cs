namespace B4R73ND3R
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.Frequency = new System.Windows.Forms.Label();
            this.GlobalTimer = new System.Windows.Forms.Timer(this.components);
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.chunkTimer = new System.Windows.Forms.Timer(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.mood = new System.Windows.Forms.PictureBox();
            this.random = new System.Windows.Forms.PictureBox();
            this.gin1tonic1 = new System.Windows.Forms.PictureBox();
            this.gin1tonic3 = new System.Windows.Forms.PictureBox();
            this.gin1tonic5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.connect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.random)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gin1tonic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gin1tonic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gin1tonic5)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 120;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 140;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 160;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Frequency
            // 
            this.Frequency.AutoSize = true;
            this.Frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frequency.Location = new System.Drawing.Point(46, 35);
            this.Frequency.Name = "Frequency";
            this.Frequency.Size = new System.Drawing.Size(157, 32);
            this.Frequency.TabIndex = 4;
            this.Frequency.Text = "Frequency:";
            // 
            // GlobalTimer
            // 
            this.GlobalTimer.Enabled = true;
            this.GlobalTimer.Interval = 50;
            this.GlobalTimer.Tick += new System.EventHandler(this.GlobalTimer_Tick);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(814, 45);
            this.outputBox.Margin = new System.Windows.Forms.Padding(2);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(452, 456);
            this.outputBox.TabIndex = 9;
            this.outputBox.Text = "";
            // 
            // chunkTimer
            // 
            this.chunkTimer.Enabled = true;
            this.chunkTimer.Interval = 1000;
            this.chunkTimer.Tick += new System.EventHandler(this.ChunkTimer_Tick);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(936, 30);
            this.Header.TabIndex = 9;
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove_1);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Location = new System.Drawing.Point(876, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(30, 30);
            this.Minimize.TabIndex = 11;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(906, 0);
            this.close.Margin = new System.Windows.Forms.Padding(0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.TabIndex = 10;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // timer5
            // 
            this.timer5.Interval = 180;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // mood
            // 
            this.mood.Image = global::B4R73ND3R.Properties.Resources.insight_rich_change_poor_joelson;
            this.mood.Location = new System.Drawing.Point(297, 96);
            this.mood.Name = "mood";
            this.mood.Size = new System.Drawing.Size(200, 200);
            this.mood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mood.TabIndex = 12;
            this.mood.TabStop = false;
            // 
            // random
            // 
            this.random.Image = global::B4R73ND3R.Properties.Resources.EPIC_KUZARC2;
            this.random.Location = new System.Drawing.Point(551, 370);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(200, 200);
            this.random.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.random.TabIndex = 8;
            this.random.TabStop = false;
            // 
            // gin1tonic1
            // 
            this.gin1tonic1.Image = global::B4R73ND3R.Properties.Resources.EPIC_KUZARC2;
            this.gin1tonic1.Location = new System.Drawing.Point(551, 96);
            this.gin1tonic1.Name = "gin1tonic1";
            this.gin1tonic1.Size = new System.Drawing.Size(200, 200);
            this.gin1tonic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gin1tonic1.TabIndex = 7;
            this.gin1tonic1.TabStop = false;
            // 
            // gin1tonic3
            // 
            this.gin1tonic3.Image = global::B4R73ND3R.Properties.Resources.EPIC_KUZARC2;
            this.gin1tonic3.Location = new System.Drawing.Point(34, 370);
            this.gin1tonic3.Name = "gin1tonic3";
            this.gin1tonic3.Size = new System.Drawing.Size(200, 200);
            this.gin1tonic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gin1tonic3.TabIndex = 6;
            this.gin1tonic3.TabStop = false;
            // 
            // gin1tonic5
            // 
            this.gin1tonic5.BackColor = System.Drawing.Color.Transparent;
            this.gin1tonic5.Image = global::B4R73ND3R.Properties.Resources.EPIC_KUZARC2;
            this.gin1tonic5.Location = new System.Drawing.Point(34, 96);
            this.gin1tonic5.Name = "gin1tonic5";
            this.gin1tonic5.Size = new System.Drawing.Size(200, 200);
            this.gin1tonic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gin1tonic5.TabIndex = 5;
            this.gin1tonic5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "1:5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 573);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "1:3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(624, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "1:1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(579, 573);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "RANDOM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(342, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 33);
            this.label5.TabIndex = 17;
            this.label5.Text = "MOOD";
            // 
            // menu
            // 
            this.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu.Controls.Add(this.button1);
            this.menu.Controls.Add(this.textBox1);
            this.menu.Controls.Add(this.comboBox1);
            this.menu.Controls.Add(this.connect);
            this.menu.Controls.Add(this.label7);
            this.menu.Controls.Add(this.Username);
            this.menu.Location = new System.Drawing.Point(0, 30);
            this.menu.Margin = new System.Windows.Forms.Padding(0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(282, 622);
            this.menu.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(239, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(41, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 34);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 37);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.Color.Lime;
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.Location = new System.Drawing.Point(63, 284);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(169, 30);
            this.connect.TabIndex = 2;
            this.connect.Text = "CONNECT";
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "COM Port";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(35, 47);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(130, 29);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1168, 653);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mood);
            this.Controls.Add(this.close);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.random);
            this.Controls.Add(this.gin1tonic1);
            this.Controls.Add(this.gin1tonic3);
            this.Controls.Add(this.gin1tonic5);
            this.Controls.Add(this.Frequency);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "/";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.random)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gin1tonic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gin1tonic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gin1tonic5)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label Frequency;
        private System.Windows.Forms.PictureBox gin1tonic5;
        private System.Windows.Forms.PictureBox gin1tonic3;
        private System.Windows.Forms.PictureBox gin1tonic1;
        private System.Windows.Forms.PictureBox random;
        private System.Windows.Forms.Timer GlobalTimer;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Timer chunkTimer;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox mood;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button button2;
    }
}
