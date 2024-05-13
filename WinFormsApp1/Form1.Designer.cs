namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            descBox1 = new PictureBox();
            descBox2 = new PictureBox();
            descBox3 = new PictureBox();
            descBox4 = new PictureBox();
            accPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)descBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)descBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)descBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)descBox4).BeginInit();
            accPanel.SuspendLayout();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top;
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(2, 11);
            button5.Name = "button5";
            button5.Size = new Size(84, 79);
            button5.TabIndex = 7;
            button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = SystemColors.ActiveBorder;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(9, 195);
            button1.Name = "button1";
            button1.Size = new Size(210, 320);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseHover += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(262, 195);
            button2.Name = "button2";
            button2.Size = new Size(210, 320);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(516, 195);
            button3.Name = "button3";
            button3.Size = new Size(210, 320);
            button3.TabIndex = 10;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(772, 195);
            button4.Name = "button4";
            button4.Size = new Size(210, 320);
            button4.TabIndex = 11;
            button4.UseVisualStyleBackColor = true;
            // 
            // descBox1
            // 
            descBox1.BackgroundImageLayout = ImageLayout.Stretch;
            descBox1.Cursor = Cursors.No;
            descBox1.Image = Properties.Resources.jisa;
            descBox1.Location = new Point(34, 441);
            descBox1.Name = "descBox1";
            descBox1.Size = new Size(156, 62);
            descBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            descBox1.TabIndex = 12;
            descBox1.TabStop = false;
            // 
            // descBox2
            // 
            descBox2.BackgroundImageLayout = ImageLayout.Stretch;
            descBox2.Cursor = Cursors.No;
            descBox2.Image = Properties.Resources.jisa;
            descBox2.Location = new Point(287, 441);
            descBox2.Name = "descBox2";
            descBox2.Size = new Size(156, 62);
            descBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            descBox2.TabIndex = 12;
            descBox2.TabStop = false;
            // 
            // descBox3
            // 
            descBox3.BackgroundImageLayout = ImageLayout.Stretch;
            descBox3.Cursor = Cursors.No;
            descBox3.Image = Properties.Resources.jisa;
            descBox3.Location = new Point(544, 441);
            descBox3.Name = "descBox3";
            descBox3.Size = new Size(156, 62);
            descBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            descBox3.TabIndex = 12;
            descBox3.TabStop = false;
            // 
            // descBox4
            // 
            descBox4.BackgroundImageLayout = ImageLayout.Stretch;
            descBox4.Cursor = Cursors.No;
            descBox4.Image = Properties.Resources.jisa;
            descBox4.Location = new Point(797, 441);
            descBox4.Name = "descBox4";
            descBox4.Size = new Size(156, 62);
            descBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            descBox4.TabIndex = 12;
            descBox4.TabStop = false;
            // 
            // accPanel
            // 
            accPanel.BackColor = Color.FromArgb(231, 173, 68);
            accPanel.Controls.Add(button5);
            accPanel.Location = new Point(990, 0);
            accPanel.Name = "accPanel";
            accPanel.Size = new Size(260, 704);
            accPanel.TabIndex = 13;
            accPanel.MouseEnter += accPanel_MouseEnter;
            accPanel.MouseLeave += accPanel_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1089, 695);
            Controls.Add(accPanel);
            Controls.Add(descBox4);
            Controls.Add(descBox3);
            Controls.Add(descBox2);
            Controls.Add(descBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)descBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)descBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)descBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)descBox4).EndInit();
            accPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox descBox1;
        private PictureBox descBox2;
        private PictureBox descBox3;
        private PictureBox descBox4;
        private Panel accPanel;
    }
}