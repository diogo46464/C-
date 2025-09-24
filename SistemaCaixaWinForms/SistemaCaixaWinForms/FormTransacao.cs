using System;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;


namespace SistemaCaixaWinForms {
    public partial class FormTransacao : Form {

        private string _caminhoBanco = "Data Source=caixa.db";
        public FormTransacao() {
            InitializeComponent();
        }
        public FormTransacao(string tipo) : this() {
            if (tipo.ToLower() == "entrada")
                rdbEntrada.Checked = true;
            else if (tipo.ToLower() == "saida" || tipo.ToLower() == "saída")
                rdbSaida.Checked = true;
        }


        private void btnSalvar_Click(object sender, EventArgs e) {
            if (!decimal.TryParse(txtValor.Text, out decimal valor)) {

                MessageBox.Show("Digite um valor válido. ");
                return;
            }

            string descricao = txtDescricao.Text;
            DateTime data = dtpData.Value;
            string tipo = rdbEntrada.Checked ? "Entrada" : "Saída";

            using (var conexao = new SqliteConnection(_caminhoBanco)) {

                conexao.Open();
                var comando = conexao.CreateCommand();
                comando.CommandText = @"INSERT INTO Transacoes (Tipo, Valor, Descricao, Data)
                                        VALUES (@tipo, @valor, @descricao, @data)";

                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@valor", valor);
                comando.Parameters.AddWithValue("@descricao", descricao);
                comando.Parameters.AddWithValue("@data", data.ToString("yyyy-MM-dd"));
                comando.ExecuteNonQuery();
            }

            MessageBox.Show("Transação salva com sucesso!");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
