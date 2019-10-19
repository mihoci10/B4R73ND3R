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
            this.freqOutput = new System.Windows.Forms.RichTextBox();
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
            this.Frequency.Location = new System.Drawing.Point(92, 68);
            this.Frequency.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Frequency.Name = "Frequency";
            this.Frequency.Size = new System.Drawing.Size(305, 63);
            this.Frequency.TabIndex = 4;
            this.Frequency.Text = "Frequency:";
            // 
            // GlobalTimer
            // 
            this.GlobalTimer.Enabled = true;
            this.GlobalTimer.Interval = 1;
            this.GlobalTimer.Tick += new System.EventHandler(this.GlobalTimer_Tick);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(1551, 90);
            this.outputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(597, 1122);
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
            this.Header.Size = new System.Drawing.Size(1872, 58);
            this.Header.TabIndex = 9;
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove_1);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Location = new System.Drawing.Point(1752, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(60, 58);
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
            this.close.Location = new System.Drawing.Point(1812, 0);
            this.close.Margin = new System.Windows.Forms.Padding(0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(60, 58);
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
            this.mood.Location = new System.Drawing.Point(594, 186);
            this.mood.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mood.Name = "mood";
            this.mood.Size = new System.Drawing.Size(400, 388);
            this.mood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mood.TabIndex = 12;
            this.mood.TabStop = false;
            // 
            // random
            // 
            this.random.InitialImage = null;
            this.random.Location = new System.Drawing.Point(1102, 717);
            this.random.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(400, 388);
            this.random.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.random.TabIndex = 8;
            this.random.TabStop = false;
            // 
            // gin1tonic1
            // 
            this.gin1tonic1.Location = new System.Drawing.Point(1102, 186);
            this.gin1tonic1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gin1tonic1.Name = "gin1tonic1";
            this.gin1tonic1.Size = new System.Drawing.Size(400, 388);
            this.gin1tonic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gin1tonic1.TabIndex = 7;
            this.gin1tonic1.TabStop = false;
            // 
            // gin1tonic3
            // 
            this.gin1tonic3.Location = new System.Drawing.Point(68, 717);
            this.gin1tonic3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gin1tonic3.Name = "gin1tonic3";
            this.gin1tonic3.Size = new System.Drawing.Size(400, 388);
            this.gin1tonic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gin1tonic3.TabIndex = 6;
            this.gin1tonic3.TabStop = false;
            // 
            // gin1tonic5
            // 
            this.gin1tonic5.BackColor = System.Drawing.Color.Transparent;
            this.gin1tonic5.Location = new System.Drawing.Point(68, 186);
            this.gin1tonic5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gin1tonic5.Name = "gin1tonic5";
            this.gin1tonic5.Size = new System.Drawing.Size(400, 388);
            this.gin1tonic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gin1tonic5.TabIndex = 5;
            this.gin1tonic5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 579);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 65);
            this.label1.TabIndex = 13;
            this.label1.Text = "1:5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 1110);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 65);
            this.label2.TabIndex = 14;
            this.label2.Text = "1:3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1248, 579);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 65);
            this.label3.TabIndex = 15;
            this.label3.Text = "1:1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1158, 1110);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 65);
            this.label4.TabIndex = 16;
            this.label4.Text = "RANDOM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(684, 579);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 65);
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
            this.menu.Location = new System.Drawing.Point(0, 58);
            this.menu.Margin = new System.Windows.Forms.Padding(0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(562, 1203);
            this.menu.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(478, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 78);
            this.button1.TabIndex = 5;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(82, 161);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 60);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 364);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(420, 62);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.Color.Lime;
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.Location = new System.Drawing.Point(126, 550);
            this.connect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(338, 58);
            this.connect.TabIndex = 2;
            this.connect.Text = "CONNECT";
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 294);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 58);
            this.label7.TabIndex = 1;
            this.label7.Text = "COM Port";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(70, 91);
            this.Username.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(257, 58);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 58);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 78);
            this.button2.TabIndex = 6;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // freqOutput
            // 
            this.freqOutput.Location = new System.Drawing.Point(2156, 90);
            this.freqOutput.Margin = new System.Windows.Forms.Padding(4);
            this.freqOutput.Name = "freqOutput";
            this.freqOutput.Size = new System.Drawing.Size(597, 1122);
            this.freqOutput.TabIndex = 19;
            this.freqOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2762, 1265);
            this.Controls.Add(this.freqOutput);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.RichTextBox freqOutput;
    }
}
