namespace SistemaCaixaWinForms
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
        private void InitializeComponent() {
            lblSaldo = new Label();
            btnEntrada = new Button();
            btnSaida = new Button();
            btnRelatorio = new Button();
            btnCobranca = new Button();
            btnAlertas = new Button();
            SuspendLayout();
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(70, 438);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(141, 20);
            lblSaldo.TabIndex = 0;
            lblSaldo.Text = "Saldo Atual: R$ 0,00";
           
            // 
            // btnEntrada
            // 
            btnEntrada.Location = new Point(51, 155);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(191, 29);
            btnEntrada.TabIndex = 1;
            btnEntrada.Text = "Nova Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnSaida
            // 
            btnSaida.Location = new Point(70, 291);
            btnSaida.Name = "btnSaida";
            btnSaida.Size = new Size(94, 29);
            btnSaida.TabIndex = 2;
            btnSaida.Text = "Nova Saída";
            btnSaida.UseVisualStyleBackColor = true;
            btnSaida.Click += btnSaida_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Location = new Point(470, 339);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(169, 29);
            btnRelatorio.TabIndex = 3;
            btnRelatorio.Text = "Relatório Mensal";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnCobranca
            // 
            btnCobranca.Location = new Point(405, 402);
            btnCobranca.Name = "btnCobranca";
            btnCobranca.Size = new Size(185, 29);
            btnCobranca.TabIndex = 4;
            btnCobranca.Text = "Registrar Cobrança";
            btnCobranca.UseVisualStyleBackColor = true;
            btnCobranca.Click += btnCobranca_Click;
            // 
            // btnAlertas
            // 
            btnAlertas.Location = new Point(310, 115);
            btnAlertas.Name = "btnAlertas";
            btnAlertas.Size = new Size(94, 29);
            btnAlertas.TabIndex = 5;
            btnAlertas.Text = "Ver Alertas";
            btnAlertas.UseVisualStyleBackColor = true;
            btnAlertas.Click += btnAlertas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 647);
            Controls.Add(btnAlertas);
            Controls.Add(btnCobranca);
            Controls.Add(btnRelatorio);
            Controls.Add(btnSaida);
            Controls.Add(btnEntrada);
            Controls.Add(lblSaldo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaldo;
        private Button btnEntrada;
        private Button btnSaida;
        private Button btnRelatorio;
        private Button btnCobranca;
        private Button btnAlertas;
    }
}
