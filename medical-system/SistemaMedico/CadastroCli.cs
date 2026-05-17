using System;
using SistemaMedico.Entidades;
using SistemaMedico.Moldel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMedico
{
    public partial class CadastroCli : Form
    {
        public CadastroCli()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtID.Clear();
            txtNome.Text = "";
            txtCPF.Text = "";
            txtConvenio.Text = "";
            txtIdade.Text = "";
            txtSexo.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtCEP.Text = "";
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        clienteENT objtabela = new clienteENT();

        private void btnInserir_Click(object sender, EventArgs e)
        {
            objtabela.nome = txtNome.Text;
            objtabela.cpf = txtCPF.Text;
            objtabela.idade = Convert.ToInt32(txtIdade.Text);
            objtabela.endereco = txtEndereco.Text;
            objtabela.telefone = txtTelefone.Text;
            objtabela.convenio = txtConvenio.Text;
            objtabela.sexo = txtSexo.Text;
            objtabela.cep = txtCEP.Text;
            objtabela.celular = txtCelular.Text;

            int x = clienteMODEL.Inserir(objtabela);

            if (x > 0)
            {
                MessageBox.Show(string.Format("Usuario {0} foi Inserido", txtNome.Text));
                ListarGrid();
            }
            else
            {
                MessageBox.Show("Não foi Inserido!");
            }
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtCPF.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtConvenio.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txtIdade.Text = grid.CurrentRow.Cells[4].Value.ToString();
            txtSexo.Text = grid.CurrentRow.Cells[5].Value.ToString();
            txtEndereco.Text = grid.CurrentRow.Cells[6].Value.ToString();
            txtTelefone.Text = grid.CurrentRow.Cells[7].Value.ToString();
            txtCelular.Text = grid.CurrentRow.Cells[8].Value.ToString();
            txtCEP.Text = grid.CurrentRow.Cells[9].Value.ToString();

        }

        private void ListarGrid()
        {

            try
            {
                List<clienteENT> lista = new List<clienteENT>();
                lista = new clienteMODEL().Lista();
                grid.AutoGenerateColumns = false;
                grid.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CadastroCli_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    objtabela.ID = Convert.ToInt32(txtID.Text);
                    objtabela.nome = txtNome.Text;
                    objtabela.cpf = txtCPF.Text;
                    objtabela.idade = Convert.ToInt32(txtIdade.Text);
                    objtabela.endereco = txtEndereco.Text;
                    objtabela.telefone = txtTelefone.Text;
                    objtabela.convenio = txtConvenio.Text;
                    objtabela.sexo = txtSexo.Text;
                    objtabela.cep = txtCEP.Text;
                    objtabela.celular = txtCelular.Text;

                    int x = clienteENT.Alterar(objtabela);

                    if (x > 0)
                    {
                        MessageBox.Show(string.Format("Usuário {0} foi alterado !", txtNome.Text));
                        ListarGrid();

                    }
                    else
                    {
                        MessageBox.Show("Não alterado!");
                    }
                    
                    ListarGrid();
                    LimparCampos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    objtabela.ID = Convert.ToInt32(txtID.Text);
                    objtabela.nome = txtNome.Text;
                    objtabela.cpf = txtCPF.Text;
                    objtabela.idade = Convert.ToInt32(txtIdade.Text);
                    objtabela.endereco = txtEndereco.Text;
                    objtabela.telefone = txtTelefone.Text;
                    objtabela.convenio = txtConvenio.Text;
                    objtabela.sexo = txtSexo.Text;
                    objtabela.cep = txtCEP.Text;
                    objtabela.celular = txtCelular.Text;

                    int x = clienteMODEL.Deletar(objtabela);
                    if (x > 0)
                    {
                        MessageBox.Show(string.Format("O usuário {0} foi deletado com sucesso !", txtNome.Text));


                    }
                    else
                    {
                        MessageBox.Show("Usuario não foi deletado!");
                    }
                    LimparCampos();
                    ListarGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
