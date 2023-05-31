namespace ListaDeCompras.View
{
    partial class ProdutoView
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
            lblCodigo = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txbCodigo = new TextBox();
            TxbNome = new TextBox();
            txbMarca = new TextBox();
            numericValor = new NumericUpDown();
            btnCadastrar = new Button();
            label1 = new Label();
            btnListar = new Button();
            dataGridViewProduto = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericValor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(29, 87);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            lblCodigo.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 147);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 200);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 253);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 3;
            label4.Text = "Valor";
            // 
            // txbCodigo
            // 
            txbCodigo.Location = new Point(98, 84);
            txbCodigo.Name = "txbCodigo";
            txbCodigo.Size = new Size(351, 27);
            txbCodigo.TabIndex = 4;
            // 
            // TxbNome
            // 
            TxbNome.Location = new Point(98, 140);
            TxbNome.Name = "TxbNome";
            TxbNome.Size = new Size(351, 27);
            TxbNome.TabIndex = 5;
            // 
            // txbMarca
            // 
            txbMarca.Location = new Point(98, 193);
            txbMarca.Name = "txbMarca";
            txbMarca.Size = new Size(351, 27);
            txbMarca.TabIndex = 6;
            // 
            // numericValor
            // 
            numericValor.Location = new Point(98, 251);
            numericValor.Name = "numericValor";
            numericValor.Size = new Size(150, 27);
            numericValor.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(98, 312);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Confirmar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 29);
            label1.Name = "label1";
            label1.Size = new Size(412, 29);
            label1.TabIndex = 9;
            label1.Text = "Cadastrar Informações do Produto";
            label1.Click += label1_Click_1;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(498, 32);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(94, 29);
            btnListar.TabIndex = 10;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dataGridViewProduto
            // 
            dataGridViewProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduto.Location = new Point(498, 90);
            dataGridViewProduto.Name = "dataGridViewProduto";
            dataGridViewProduto.RowHeadersWidth = 51;
            dataGridViewProduto.RowTemplate.Height = 29;
            dataGridViewProduto.Size = new Size(483, 308);
            dataGridViewProduto.TabIndex = 11;
            // 
            // ProdutoView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 461);
            Controls.Add(dataGridViewProduto);
            Controls.Add(btnListar);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(numericValor);
            Controls.Add(txbMarca);
            Controls.Add(TxbNome);
            Controls.Add(txbCodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblCodigo);
            Name = "ProdutoView";
            Text = "ProdutoView";
            ((System.ComponentModel.ISupportInitialize)numericValor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txbCodigo;
        private TextBox TxbNome;
        private TextBox txbMarca;
        private NumericUpDown numericValor;
        private Button btnCadastrar;
        private Label label1;
        private Button btnListar;
        private DataGridView dataGridViewProduto;
    }
}