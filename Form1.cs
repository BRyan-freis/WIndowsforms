using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CrudCreateConexus
{
    public partial class frmCadastrodeClientes : Form

    {
        //Conexão com o banco de dados MySQL
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
                if (string.IsNullOrEmpty(txtNomeCompleto.Text.Trim()) ||
                    string.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                    string.IsNullOrEmpty(txtCPF.Text.Trim()))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
         
                string cpf = txtCPF.Text.Trim();
                if (!isValidCPFLength(cpf))
                {
                    MessageBox.Show("CPF invalido. Certifique-se de que o CPF tenha 11 digitos numericos.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

            
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

               
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Conexao
                };

                cmd.Prepare();
                cmd.CommandText = "INSERT INTO dadosdocliente(nomecompleto, nomesocial, email, cpf) " +
                    "VALUES(@nomecompleto, @nomesocial, @email, @cpf)";

                
                cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@cpf", cpf);

               
                cmd.ExecuteNonQuery();

                
                MessageBox.Show("Contato inserido com Sucesso: ",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }


            catch (MySqlException ex)

            {   
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            catch (Exception ex)
            {   
                MessageBox.Show("Ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }

       
        private bool isValidCPFLength(string cpf)
        {
           
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

           
            return cpf.Length == 11;
        }

        
        private void CarregarDados()
        {
            try
            {
               
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                
                string sql = "SELECT idcliente, nomecompleto, nomesocial, email, cpf FROM dadosdocliente ORDER BY nomecompleto";

                
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, Conexao);

               
                DataTable dt = new DataTable();

               
                adapter.Fill(dt);

                // Define o DataTable como a fonte de dados do seu DataGridView
                dgvClientes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }

        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (tbControl.SelectedIndex == 1)
                {
                    CarregarDados();
                }
         }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dadosdocliente WHERE idcliente LIKE @q OR nomecompleto LIKE @q OR nomesocial LIKE @q ORDER BY idcliente DESC";
        }
    }
}

        

           