using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public class Database
    {
        private MySqlConnection connection;

        public Database()
        {
            string connectionString = "server=localhost;database=CrudExample;user=***;password=*****;";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (MySqlException ex)
            {
                // Exibe a mensagem de erro específica do MySQL em um MessageBox
                MessageBox.Show("Erro ao abrir a conexão com o banco de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Exibe a mensagem de erro genérica para outras exceções em um MessageBox
                MessageBox.Show("Erro inesperado ao abrir a conexão: " + ex.Message, "Erro Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao fechar a conexão com o banco de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado ao fechar a conexão: " + ex.Message, "Erro Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
