using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormCadastro : Form
    {
        private int? productId = null;
        Database db = new Database();

        public FormCadastro()
        {
            InitializeComponent();
        }

        // Construtor para edição
        public FormCadastro(int id, string nome, decimal preco)
        {
            InitializeComponent();
            productId = id;
            txtNome.Text = nome;
            txtPreco.Text = preco.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            decimal preco;

            try
            {
                // Tenta converter o preço para decimal
                preco = Convert.ToDecimal(txtPreco.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um valor numérico válido para o preço.", "Erro de Formato");
                return;
            }

            try
            {
                db.OpenConnection();
                string query;

                if (productId == null) // Inserção
                {
                    query = "INSERT INTO Produto (Nome, Preco) VALUES (@nome, @preco)";
                }
                else // Atualização
                {
                    query = "UPDATE Produto SET Nome = @nome, Preco = @preco WHERE Id = @id";
                }

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@preco", preco);

                if (productId != null)
                {
                    cmd.Parameters.AddWithValue("@id", productId);
                }

                cmd.ExecuteNonQuery();
                DialogResult = DialogResult.OK; // Fecha o formulário
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados: ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: ");
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
