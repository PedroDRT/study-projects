using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaMedico
{
    public partial class Login : Form
    {
        //Referencia da conexão
        SqlConnection Conexao = new SqlConnection("Data Source = PEDRO\\SQLEXPRESS; Initial Catalog = DBConsult; Integrated Security = True");
        public Login()
        {
            InitializeComponent();
            txtUsuario.Select();
        }

        //Verificação de campos vazios
        void verificar()
        {
            if(txtUsuario.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Select();
            }
        }

        //Botão Entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Conexao.Open(); //Abrir a conexão
            verificar();
            string query = "SELECT * FROM Usuario WHERE Username = '"+txtUsuario.Text +"' AND Password = '"+txtPassword.Text+"'";
            SqlDataAdapter dp = new SqlDataAdapter(query,Conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);


            try
            {
                if (dt.Rows.Count == 1)
                {
                    SistemaMedico sistemaMedico = new SistemaMedico();
                    this.Hide();
                    sistemaMedico.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha incorreta");
                    txtUsuario.Text = ""; //Limpar campos
                    txtPassword.Text = "";//Limpar campos
                    txtUsuario.Select();
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            Conexao.Close(); // Fecha a conexão
        }

        private void NameText_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Username")
            {
                txtUsuario.Text = "";

                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void NameText_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Username";

                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "********")
            {
                txtPassword.Text = "";

                txtPassword.ForeColor = Color.Black;
            }
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "********";

                txtPassword.ForeColor = Color.Silver;
            }
        }
    }
}
