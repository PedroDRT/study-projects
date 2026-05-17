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
    public partial class Medico : Form
    {
        public Medico()
        {
            InitializeComponent();
            txtNome.Select();
        }

        private void listargrid()
        {
            try
            {
                List<medicoENT> lista = new List<medicoENT>();
                lista = new medicoMODEL().Lista();
                grid.AutoGenerateColumns = false;
                grid.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        medicoENT objtabela = new medicoENT();

        private void btnInserir_Click(object sender, EventArgs e)
        {
            objtabela.nome = txtNome.Text;
            objtabela.idade = Convert.ToInt32(txtIdade.Text);
            objtabela.cpf = txtCPF.Text;
            objtabela.especialidade = txtEspecialidade.Text;
            objtabela.crm = txtCRM.Text;



            int x = medicoMODEL.Inserir(objtabela);

            if (x > 0)
            {
                MessageBox.Show(string.Format("Usuario {0} foi Inserido", txtNome.Text));
                
            }
            else
            {
                MessageBox.Show("Não foi Inserido!");
            }

            listargrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    objtabela.id = Convert.ToInt32(txtID.Text);
                    objtabela.nome = Convert.ToString(txtNome.Text);
                    objtabela.idade = Convert.ToInt32(txtIdade.Text);
                    objtabela.crm = Convert.ToString(txtCRM.Text);
                    objtabela.cpf = Convert.ToString(txtCPF.Text);
                    objtabela.especialidade = Convert.ToString(txtEspecialidade.Text);


                    int x = medicoENT.Alterar(objtabela);

                    if (x > 0)
                    {
                        MessageBox.Show(string.Format("Usuário {0} foi alterado !", txtNome.Text));
                        listargrid();

                    }
                    else
                    {
                        MessageBox.Show("Não alterado!");
                    }

                    listargrid();


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
                    objtabela.id = Convert.ToInt32(txtID.Text);
                    objtabela.nome = Convert.ToString(txtNome.Text);
                    objtabela.idade = Convert.ToInt32(txtIdade.Text);
                    objtabela.crm = Convert.ToString(txtCRM.Text);
                    objtabela.cpf = Convert.ToString(txtCPF.Text);
                    objtabela.especialidade = Convert.ToString(txtEspecialidade.Text);

                    int x = medicoMODEL.Deletar(objtabela);
                    if (x > 0)
                    {
                        MessageBox.Show(string.Format("O usuário {0} foi deletado com sucesso !", txtNome.Text));


                    }
                    else
                    {
                        MessageBox.Show("Usuario não foi deletado!");
                    }
                    
                    listargrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtIdade.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtCRM.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txtCPF.Text = grid.CurrentRow.Cells[4].Value.ToString();
            txtEspecialidade.Text = grid.CurrentRow.Cells[5].Value.ToString();

            listargrid();
        }

        private void Medico_Load(object sender, EventArgs e)
        {
            listargrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
