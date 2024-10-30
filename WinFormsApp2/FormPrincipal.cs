using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormPrincipal : Form
    {
        Database db = new Database();
        public FormPrincipal()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM Produto";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.GetConnection());
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch
            {
                MessageBox.Show("Erro ao carregar dados.");
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            if (formCadastro.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                string nome = dataGridView1.SelectedRows[0].Cells["Nome"].Value.ToString();
                decimal preco = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["Preco"].Value);

                FormCadastro formCadastro = new FormCadastro(id, nome, preco);
                if (formCadastro.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para editar.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    db.OpenConnection();
                    string query = "DELETE FROM Produto WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Erro ao excluir.");
                }
                finally
                {
                    db.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir.");
            }
        }
    }
}
