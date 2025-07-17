using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaCaixaWinForms
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Database.CriarTabelas();
            AtualizarSaldo();
        }

        private void AtualizarSaldo() {

            using var conn = Database.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                    SELECT
                         IFNULL(SUM(CASE WHEN Tipo = 'entrada' THEN Valor ELSE 0 END), 0) AS ENTRADAS,
                         IFNULL(SUM(CASE WHEN Tipo = 'saida'    THEN Valor ELSE 0 END), 0) AS Saidas
                    FROM Transacoes;";

            using var reader = cmd.ExecuteReader();
            if (reader.Read()) {

                double entradas = reader.GetDouble(0);
                double saidas = reader.GetDouble(1);
                double saldo = entradas - saidas;

                lblSaldo.Text = $"Saldo Atual: R$ {saldo:F2}";



            }
            }

        private void btnEntrada_Click(object sender, EventArgs e) {

            var form = new FormTransacao("entrada");
            form.ShowDialog();
            AtualizarSaldo();
        }

        private void btnAlertas_Click(object sender, EventArgs e) {
            using var conn = Database.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT Cliente, Valor, DataVencimento
                FROM Cobrancas
                WHERE Pago = 0 AND date(DataVencimento) < date('now');";

            using  var reader = cmd.ExecuteReader();
            string alertas = "";

            while (reader.Read()) {
                alertas += $"Cliente: {reader.GetString(0)} | Valor: R$ {reader.GetDouble(1):F2} | Vencimento: {reader.GetString(2)}\n";  
            }
            if (string.IsNullOrWhiteSpace(alertas))
                alertas = "Nenhuma cobrança vencida";

            MessageBox.Show(alertas, "Alertas de cobrança");
            MessageBox.Show(alertas, "Alertas de cobrança");
        }

        private void btnRelatorio_Click(object sender, EventArgs e) {
            MessageBox.Show("Relatório mensal ainda será implementado.");
        }

        private void btnCobranca_Click(object sender, EventArgs e) {
            var form = new FormCobranca();
            form.ShowDialog();
        }

        private void btnEntrada_Click(object sender, EventArgs e) {
            var form = new FormTransacao("entrada"); // Já marca o rdbEntrada internamente
            form.ShowDialog();
        }

        private void btnSaida_Click(object sender, EventArgs e) {
            var form = new FormTransacao("saida"); // Já marca o rdbSaida internamente
            form.ShowDialog();
        }
    }
}
