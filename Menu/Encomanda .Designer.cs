namespace Menu
{
    partial class Encomanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encomanda));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnEstoqueEnco = new Button();
            pictureBox2 = new PictureBox();
            BtnMenuEnco = new Button();
            panel3 = new Panel();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            label4 = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-47, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(1399, 132);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(596, 25);
            label1.Name = "label1";
            label1.Size = new Size(369, 80);
            label1.TabIndex = 2;
            label1.Text = "Encomendas";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnEstoqueEnco);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(BtnMenuEnco);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-6, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 783);
            panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 422);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 224);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnEstoqueEnco
            // 
            btnEstoqueEnco.BackColor = Color.FromArgb(64, 64, 64);
            btnEstoqueEnco.FlatStyle = FlatStyle.Popup;
            btnEstoqueEnco.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEstoqueEnco.ForeColor = Color.White;
            btnEstoqueEnco.Location = new Point(3, 212);
            btnEstoqueEnco.Name = "btnEstoqueEnco";
            btnEstoqueEnco.Size = new Size(197, 66);
            btnEstoqueEnco.TabIndex = 4;
            btnEstoqueEnco.Text = "Estoque";
            btnEstoqueEnco.UseVisualStyleBackColor = false;
            btnEstoqueEnco.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(169, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // BtnMenuEnco
            // 
            BtnMenuEnco.BackColor = Color.FromArgb(64, 64, 64);
            BtnMenuEnco.FlatStyle = FlatStyle.Popup;
            BtnMenuEnco.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnMenuEnco.ForeColor = Color.White;
            BtnMenuEnco.Location = new Point(3, 408);
            BtnMenuEnco.Name = "BtnMenuEnco";
            BtnMenuEnco.Size = new Size(197, 66);
            BtnMenuEnco.TabIndex = 5;
            BtnMenuEnco.Text = "Menu";
            BtnMenuEnco.UseVisualStyleBackColor = false;
            BtnMenuEnco.Click += BtnMenuEnco_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.OrangeRed;
            panel3.Location = new Point(90, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(16, 567);
            panel3.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(318, 157);
            button3.Name = "button3";
            button3.Size = new Size(207, 76);
            button3.TabIndex = 6;
            button3.Text = "Pizza de calabresa";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGray;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(318, 344);
            button4.Name = "button4";
            button4.Size = new Size(207, 76);
            button4.TabIndex = 7;
            button4.Text = "Pastel de calabresa";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(318, 551);
            button2.Name = "button2";
            button2.Size = new Size(207, 76);
            button2.TabIndex = 10;
            button2.Text = "Coca 1L";
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 388);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 11;
            // 
            // button5
            // 
            button5.BackColor = Color.LightGray;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(629, 551);
            button5.Name = "button5";
            button5.Size = new Size(207, 70);
            button5.TabIndex = 12;
            button5.Text = "Sprite 1L";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.LightGray;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(629, 344);
            button6.Name = "button6";
            button6.Size = new Size(207, 76);
            button6.TabIndex = 13;
            button6.Text = "Pastel de frango c/ catutipy";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.LightGray;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(629, 157);
            button7.Name = "button7";
            button7.Size = new Size(207, 76);
            button7.TabIndex = 14;
            button7.Text = "Pizza de frango c/ catupiry";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.LightGray;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(933, 157);
            button8.Name = "button8";
            button8.Size = new Size(207, 76);
            button8.TabIndex = 15;
            button8.Text = "Pizza de queijo ";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.LightGray;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(933, 545);
            button9.Name = "button9";
            button9.Size = new Size(207, 76);
            button9.TabIndex = 16;
            button9.Text = "Pepsi 1L";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.LightGray;
            button10.FlatStyle = FlatStyle.Popup;
            button10.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.Location = new Point(933, 344);
            button10.Name = "button10";
            button10.Size = new Size(207, 76);
            button10.TabIndex = 17;
            button10.Text = "Pastel de queijo";
            button10.UseVisualStyleBackColor = false;
            // 
            // Encomanda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1347, 776);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Encomanda";
            Text = "Encomanda";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label1;
        private Button BtnMenuEnco;
        private Button btnEstoqueEnco;
        private Panel panel3;
        private Button button3;
        private Button button4;
        private Button button2;
        private Label label4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}