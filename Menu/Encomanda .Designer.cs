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
            label4 = new Label();
            label6 = new Label();
            panel5 = new Panel();
            button13 = new Button();
            label9 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            panel4 = new Panel();
            button3 = new Button();
            button7 = new Button();
            button8 = new Button();
            button1 = new Button();
            button2 = new Button();
            panel6 = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            button4 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            Pedido = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Obs = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
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
            panel2.Paint += panel2_Paint;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 394);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(892, 215);
            label6.Name = "label6";
            label6.Size = new Size(418, 43);
            label6.TabIndex = 19;
            label6.Text = "Total de pedidos de hoje";
            label6.Click += label6_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(button13);
            panel5.Location = new Point(563, 282);
            panel5.Name = "panel5";
            panel5.Size = new Size(273, 201);
            panel5.TabIndex = 20;
            // 
            // button13
            // 
            button13.BackColor = Color.LightGray;
            button13.FlatStyle = FlatStyle.Popup;
            button13.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.Location = new Point(36, 149);
            button13.Name = "button13";
            button13.Size = new Size(200, 31);
            button13.TabIndex = 14;
            button13.Text = "Confirmar ";
            button13.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Georgia", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(55, 7);
            label9.Name = "label9";
            label9.Size = new Size(149, 43);
            label9.TabIndex = 19;
            label9.Text = "Pedidos";
            label9.Click += label9_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 20;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Pedido, Quantidade, Obs });
            dataGridView1.Location = new Point(892, 282);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(418, 409);
            dataGridView1.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Georgia", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(25, 4);
            label5.Name = "label5";
            label5.Size = new Size(153, 43);
            label5.TabIndex = 21;
            label5.Text = "Combos";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Snow;
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button8);
            panel4.Controls.Add(button7);
            panel4.Location = new Point(271, 251);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 440);
            panel4.TabIndex = 18;
            panel4.Paint += panel4_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 59);
            button3.Name = "button3";
            button3.Size = new Size(200, 66);
            button3.TabIndex = 6;
            button3.Text = "Pizza de calabresa + coca2L";
            button3.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.LightGray;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(0, 202);
            button7.Name = "button7";
            button7.Size = new Size(200, 66);
            button7.TabIndex = 14;
            button7.Text = "Pizza de frango + coca 2L";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.LightGray;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(0, 130);
            button8.Name = "button8";
            button8.Size = new Size(200, 66);
            button8.TabIndex = 15;
            button8.Text = "Pizza de queijo + coca 2L ";
            button8.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 274);
            button1.Name = "button1";
            button1.Size = new Size(200, 66);
            button1.TabIndex = 22;
            button1.Text = "Pizza de Chocolate + Sprite 2L";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(0, 346);
            button2.Name = "button2";
            button2.Size = new Size(200, 66);
            button2.TabIndex = 23;
            button2.Text = "Pizza de Banana + Pepsi 2L";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.Controls.Add(textBox2);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(button4);
            panel6.Location = new Point(563, 506);
            panel6.Name = "panel6";
            panel6.Size = new Size(273, 158);
            panel6.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(25, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 23);
            textBox2.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(26, 7);
            label2.Name = "label2";
            label2.Size = new Size(210, 43);
            label2.TabIndex = 19;
            label2.Text = "Observação";
            // 
            // button4
            // 
            button4.BackColor = Color.LightGray;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(36, 82);
            button4.Name = "button4";
            button4.Size = new Size(200, 31);
            button4.TabIndex = 14;
            button4.Text = "Confirmar ";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(25, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 23);
            textBox3.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(55, 80);
            label3.Name = "label3";
            label3.Size = new Size(156, 31);
            label3.TabIndex = 22;
            label3.Text = "Quantidade";
            // 
            // Pedido
            // 
            Pedido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Pedido.HeaderText = "Pedido";
            Pedido.Name = "Pedido";
            // 
            // Quantidade
            // 
            Quantidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            Quantidade.Width = 94;
            // 
            // Obs
            // 
            Obs.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Obs.HeaderText = "Obs";
            Obs.Name = "Obs";
            // 
            // Encomanda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1347, 776);
            Controls.Add(panel6);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Encomanda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Encomanda";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private Label label4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label6;
        private Panel panel5;
        private TextBox textBox1;
        private Label label9;
        private Button button13;
        private DataGridView dataGridView1;
        private Label label5;
        private Panel panel4;
        private Button button3;
        private Button button7;
        private Button button8;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private Panel panel6;
        private TextBox textBox2;
        private Label label2;
        private Button button4;
        private Label label3;
        private DataGridViewTextBoxColumn Pedido;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Obs;
    }
}