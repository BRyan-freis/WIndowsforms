using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class frmCadastrodeClientes : Form
    {

        //Conexão Com o banco de dados MySql
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=db_cadastro";
        public frmCadastrodeClientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validação de campos obrigatórios
                if (string.IsNullOrEmpty(txtNomeCompleto.Text.Trim()) ||
                    string.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                    string.IsNullOrEmpty(txtCPF.Text.Trim()))
                {
                    MessageBox.Show("Todos os campos devem ser preechidos.",
                                    "Validação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; //Impede o proseeguimento se algum campo estiver vazio
                }

                //Validação do CPF
                string cpf = txtCPF.Text.Trim();

                if (!isValidCPFLength(cpf))
                {
                    MessageBox.Show("CPF inválido. Certifique-se de que o CPF tenha 11 digítos Numéricos.",
                                    "Validação",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);
                    return; //Impede o prosseguimento se o CPF for inválido
                }

                //Cria conexão com banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Comando SQL para inserir um novo cliente no banco de dados
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Conexao
                };

                cmd.Prepare();
                cmd.CommandText = "INSERT INTO dadosdocliente(nomecompleto, nomesocial, email, cpf)" +
                    "VALUES(@nomecompleto, @nomesocial, @email, @cpf)";

                //Adiciona os parãmetros com os dados do formulário
                cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@cpf", cpf);

                //Executa o comando de inserção no banco
                cmd.ExecuteNonQuery();

                //Executa o comando de inserção no banco
                MessageBox.Show("Contato inserido com sucesso: ",
                                "Sucesso",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                // Trata Erros relacionados ao Mysql
                MessageBox.Show("Erro" + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                // Trata erros de outros tipos não relacioanados ao Database
                MessageBox.Show("Ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally 
            {
                //Garante que a conexão com o banco será fechada, mesmo se ocorrer erro
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }

        // Função para validar o comprimento e formato de CPF
        private bool isValidCPFLength(string cpf)
        {
            //Remove todos os caracteres não númericos
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Verifica se o CPF tem exatamente 11 dígitos
            return cpf.Length == 11;
        }

    }
}
