namespace ListaDeCompras
{
    partial class CasaView
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
            label1 = new Label();
            txtApelido = new TextBox();
            label2 = new Label();
            txtEndereco = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimeDtRenovacao = new DateTimePicker();
            numericRenda = new NumericUpDown();
            btnConfirmar = new Button();
            label6 = new Label();
            numericQtdMoradores = new NumericUpDown();
            dataGridViewCasas = new DataGridView();
            Apelido = new DataGridViewTextBoxColumn();
            Endereco = new DataGridViewTextBoxColumn();
            QtdMoradores = new DataGridViewTextBoxColumn();
            Renda = new DataGridViewTextBoxColumn();
            DtRenovacao = new DataGridViewTextBoxColumn();
            btnListar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericRenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQtdMoradores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCasas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 89);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Apelido:";
            label1.Click += label1_Click;
            // 
            // txtApelido
            // 
            txtApelido.Location = new Point(168, 89);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(298, 27);
            txtApelido.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 135);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Endereço:";
            label2.Click += label2_Click;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(168, 135);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(298, 27);
            txtEndereco.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 185);
            label3.Name = "label3";
            label3.Size = new Size(187, 20);
            label3.TabIndex = 5;
            label3.Text = "Quantidade de moradores:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 232);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 6;
            label4.Text = "Renda mensal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 277);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 8;
            label5.Text = "Data renovação";
            label5.Click += label5_Click;
            // 
            // dateTimeDtRenovacao
            // 
            dateTimeDtRenovacao.Location = new Point(193, 276);
            dateTimeDtRenovacao.Name = "dateTimeDtRenovacao";
            dateTimeDtRenovacao.Size = new Size(250, 27);
            dateTimeDtRenovacao.TabIndex = 9;
            // 
            // numericRenda
            // 
            numericRenda.Location = new Point(193, 232);
            numericRenda.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericRenda.Name = "numericRenda";
            numericRenda.Size = new Size(150, 27);
            numericRenda.TabIndex = 10;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(193, 331);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(31, 27);
            label6.Name = "label6";
            label6.Size = new Size(435, 32);
            label6.TabIndex = 12;
            label6.Text = "Cadastrar informações da casa";
            label6.Click += cadastrarCasa_Click;
            // 
            // numericQtdMoradores
            // 
            numericQtdMoradores.Location = new Point(235, 183);
            numericQtdMoradores.Name = "numericQtdMoradores";
            numericQtdMoradores.Size = new Size(150, 27);
            numericQtdMoradores.TabIndex = 13;
            // 
            // dataGridViewCasas
            // 
            dataGridViewCasas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCasas.Columns.AddRange(new DataGridViewColumn[] { Apelido, Endereco, QtdMoradores, Renda, DtRenovacao });
            dataGridViewCasas.Location = new Point(525, 89);
            dataGridViewCasas.Name = "dataGridViewCasas";
            dataGridViewCasas.RowHeadersWidth = 51;
            dataGridViewCasas.RowTemplate.Height = 29;
            dataGridViewCasas.Size = new Size(679, 188);
            dataGridViewCasas.TabIndex = 14;
            // 
            // Apelido
            // 
            Apelido.HeaderText = "Apelido";
            Apelido.MinimumWidth = 6;
            Apelido.Name = "Apelido";
            Apelido.Width = 125;
            // 
            // Endereco
            // 
            Endereco.HeaderText = "Endereço";
            Endereco.MinimumWidth = 6;
            Endereco.Name = "Endereco";
            Endereco.Width = 125;
            // 
            // QtdMoradores
            // 
            QtdMoradores.HeaderText = "Quantidade de Moradores";
            QtdMoradores.MinimumWidth = 6;
            QtdMoradores.Name = "QtdMoradores";
            QtdMoradores.Width = 125;
            // 
            // Renda
            // 
            Renda.HeaderText = "Renda";
            Renda.MinimumWidth = 6;
            Renda.Name = "Renda";
            Renda.Width = 125;
            // 
            // DtRenovacao
            // 
            DtRenovacao.HeaderText = "Data Renovação";
            DtRenovacao.MinimumWidth = 6;
            DtRenovacao.Name = "DtRenovacao";
            DtRenovacao.Width = 125;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(614, 48);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(94, 29);
            btnListar.TabIndex = 15;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // CasaView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 411);
            Controls.Add(btnListar);
            Controls.Add(dataGridViewCasas);
            Controls.Add(numericQtdMoradores);
            Controls.Add(label6);
            Controls.Add(btnConfirmar);
            Controls.Add(numericRenda);
            Controls.Add(dateTimeDtRenovacao);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEndereco);
            Controls.Add(label2);
            Controls.Add(txtApelido);
            Controls.Add(label1);
            Name = "CasaView";
            Text = "Lista de Compras";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericRenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQtdMoradores).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCasas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtApelido;
        private Label label2;
        private TextBox txtEndereco;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimeDtRenovacao;
        private NumericUpDown numericRenda;
        private Button btnConfirmar;
        private Label label6;
        private NumericUpDown numericQtdMoradores;
        private DataGridView dataGridViewCasas;
        private Button btnListar;
        private DataGridViewTextBoxColumn Apelido;
        private DataGridViewTextBoxColumn Endereco;
        private DataGridViewTextBoxColumn QtdMoradores;
        private DataGridViewTextBoxColumn Renda;
        private DataGridViewTextBoxColumn DtRenovacao;
    }
}