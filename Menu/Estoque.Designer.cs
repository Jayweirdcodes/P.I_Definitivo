namespace Menu
{
    partial class Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnEncoEstoque = new Button();
            btnMenuEstoque = new Button();
            panel3 = new Panel();
            dgvTabelaEstoque = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Produto = new DataGridViewTextBoxColumn();
            Quant = new DataGridViewTextBoxColumn();
            Validade = new DataGridViewTextBoxColumn();
            EmFalta = new DataGridViewTextBoxColumn();
            txtNomeProduto = new TextBox();
            txtQuant = new TextBox();
            txtValidade = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTabelaEstoque).BeginInit();
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(680, 29);
            label1.Name = "label1";
            label1.Size = new Size(243, 80);
            label1.TabIndex = 0;
            label1.Text = "Estoque";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnEncoEstoque);
            panel2.Controls.Add(btnMenuEstoque);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-6, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 783);
            panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(18, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(169, 122);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 417);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 221);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnEncoEstoque
            // 
            btnEncoEstoque.FlatStyle = FlatStyle.Popup;
            btnEncoEstoque.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEncoEstoque.ForeColor = Color.White;
            btnEncoEstoque.Location = new Point(3, 212);
            btnEncoEstoque.Name = "btnEncoEstoque";
            btnEncoEstoque.Size = new Size(197, 66);
            btnEncoEstoque.TabIndex = 4;
            btnEncoEstoque.Text = "        Encomendas";
            btnEncoEstoque.UseVisualStyleBackColor = true;
            btnEncoEstoque.Click += btnEncoEstoque_Click;
            // 
            // btnMenuEstoque
            // 
            btnMenuEstoque.FlatStyle = FlatStyle.Popup;
            btnMenuEstoque.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuEstoque.ForeColor = Color.White;
            btnMenuEstoque.Location = new Point(3, 408);
            btnMenuEstoque.Name = "btnMenuEstoque";
            btnMenuEstoque.Size = new Size(197, 66);
            btnMenuEstoque.TabIndex = 2;
            btnMenuEstoque.Text = "Menu";
            btnMenuEstoque.UseVisualStyleBackColor = true;
            btnMenuEstoque.Click += btnMenuEstoque_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.OrangeRed;
            panel3.Location = new Point(90, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(16, 567);
            panel3.TabIndex = 11;
            // 
            // dgvTabelaEstoque
            // 
            dgvTabelaEstoque.AllowUserToOrderColumns = true;
            dgvTabelaEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabelaEstoque.Columns.AddRange(new DataGridViewColumn[] { ID, Produto, Quant, Validade, EmFalta });
            dgvTabelaEstoque.Location = new Point(260, 265);
            dgvTabelaEstoque.Name = "dgvTabelaEstoque";
            dgvTabelaEstoque.Size = new Size(1020, 453);
            dgvTabelaEstoque.TabIndex = 2;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 43;
            // 
            // Produto
            // 
            Produto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Produto.HeaderText = "Produto";
            Produto.Name = "Produto";
            // 
            // Quant
            // 
            Quant.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quant.HeaderText = "Quant";
            Quant.Name = "Quant";
            // 
            // Validade
            // 
            Validade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Validade.HeaderText = "Validade";
            Validade.Name = "Validade";
            // 
            // EmFalta
            // 
            EmFalta.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            EmFalta.HeaderText = "EmFalta";
            EmFalta.Name = "EmFalta";
            EmFalta.Width = 74;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(269, 196);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(231, 23);
            txtNomeProduto.TabIndex = 3;
            // 
            // txtQuant
            // 
            txtQuant.Location = new Point(568, 196);
            txtQuant.Name = "txtQuant";
            txtQuant.Size = new Size(124, 23);
            txtQuant.TabIndex = 4;
            // 
            // txtValidade
            // 
            txtValidade.Location = new Point(776, 196);
            txtValidade.Name = "txtValidade";
            txtValidade.Size = new Size(172, 23);
            txtValidade.TabIndex = 5;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.System;
            button3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1033, 190);
            button3.Name = "button3";
            button3.Size = new Size(101, 30);
            button3.TabIndex = 6;
            button3.Text = "ADICIONAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.System;
            button4.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(1152, 190);
            button4.Name = "button4";
            button4.Size = new Size(90, 30);
            button4.TabIndex = 7;
            button4.Text = "REMOVER";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(269, 169);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 8;
            label2.Text = "NOME DO PRODUTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(568, 169);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 9;
            label3.Text = "QUANTIDADE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(776, 169);
            label4.Name = "label4";
            label4.Size = new Size(143, 15);
            label4.TabIndex = 10;
            label4.Text = "DATA DE VALIDADE";
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1347, 776);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(txtValidade);
            Controls.Add(txtQuant);
            Controls.Add(txtNomeProduto);
            Controls.Add(dgvTabelaEstoque);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Estoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTabelaEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnEncoEstoque;
        private Button btnMenuEstoque;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dgvTabelaEstoque;
        private PictureBox pictureBox3;
        private TextBox txtNomeProduto;
        private TextBox txtQuant;
        private TextBox txtValidade;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Quant;
        private DataGridViewTextBoxColumn Validade;
        private DataGridViewTextBoxColumn EmFalta;
        private Panel panel3;
    }
}