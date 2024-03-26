namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            trackBar1 = new TrackBar();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(23, 116);
            label2.Name = "label2";
            label2.Size = new Size(15, 17);
            label2.TabIndex = 5;
            label2.Text = "8";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(16, 87);
            trackBar1.Maximum = 20;
            trackBar1.Minimum = 8;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(329, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.FromArgb(0, 3, 102, 111);
            checkBox1.ForeColor = SystemColors.ControlLightLight;
            checkBox1.Location = new Point(16, 11);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(113, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Include Symbols";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = SystemColors.ControlLightLight;
            checkBox2.Location = new Point(16, 33);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(117, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Include Numbers";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(426, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(18, 60);
            label1.Name = "label1";
            label1.Size = new Size(81, 17);
            label1.TabIndex = 4;
            label1.Text = "Max Length";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(322, 116);
            label3.Name = "label3";
            label3.Size = new Size(22, 17);
            label3.TabIndex = 6;
            label3.Text = "20";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(354, 19);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(652, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(118, 171, 174);
            button1.Location = new Point(269, 60);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(688, 140);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(trackBar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
    }
}
