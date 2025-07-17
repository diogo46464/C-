namespace SistemaCaixaWinForms {
    partial class FormTransacao {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            txtValor = new Label();
            textValor = new TextBox();
            label2 = new Label();
            txtDescricao = new TextBox();
            label3 = new Label();
            dtpData = new DateTimePicker();
            rdbEntrada = new RadioButton();
            rdbSaida = new RadioButton();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtValor
            // 
            txtValor.AutoSize = true;
            txtValor.Location = new Point(287, 364);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(46, 20);
            txtValor.TabIndex = 0;
            txtValor.Text = "Valor:";
            // 
            // textValor
            // 
            textValor.Location = new Point(339, 361);
            textValor.Name = "textValor";
            textValor.Size = new Size(125, 27);
            textValor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 311);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(350, 308);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(125, 27);
            txtDescricao.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 229);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 4;
            label3.Text = "Data:";
            // 
            // dtpData
            // 
            dtpData.Location = new Point(338, 229);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(250, 27);
            dtpData.TabIndex = 5;
            // 
            // rdbEntrada
            // 
            rdbEntrada.AutoSize = true;
            rdbEntrada.Location = new Point(203, 70);
            rdbEntrada.Name = "rdbEntrada";
            rdbEntrada.Size = new Size(81, 24);
            rdbEntrada.TabIndex = 6;
            rdbEntrada.TabStop = true;
            rdbEntrada.Text = "Entrada";
            rdbEntrada.UseVisualStyleBackColor = true;
            // 
            // rdbSaida
            // 
            rdbSaida.AutoSize = true;
            rdbSaida.Location = new Point(315, 70);
            rdbSaida.Name = "rdbSaida";
            rdbSaida.Size = new Size(67, 24);
            rdbSaida.TabIndex = 7;
            rdbSaida.TabStop = true;
            rdbSaida.Text = "Saída";
            rdbSaida.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(478, 68);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(635, 65);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormTransacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(rdbSaida);
            Controls.Add(rdbEntrada);
            Controls.Add(dtpData);
            Controls.Add(label3);
            Controls.Add(txtDescricao);
            Controls.Add(label2);
            Controls.Add(textValor);
            Controls.Add(txtValor);
            Name = "FormTransacao";
            Text = "FormTransacao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtValor;
        private TextBox textValor;
        private Label label2;
        private TextBox txtDescricao;
        private Label label3;
        private DateTimePicker dtpData;
        private RadioButton rdbEntrada;
        private RadioButton rdbSaida;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}