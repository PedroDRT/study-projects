using System;
using SistemaMedico.Entidades;
using SistemaMedico.Moldel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace SistemaMedico
{
    public partial class Agendacli : Form
    {
        public Agendacli()
        {
            InitializeComponent();
            txtMedico.Select();
        }

        private void LimparCampos()
        {
            txtAgenda.Clear();
            txtCliente.Text = "";
            txtMedico.Text = "";
            txtEspecialidade.Text = "";
            txtData.Text = "";
            txtHorario.Text = "";
            txtMedico.Focus();
        }

        private void ListarGrid()
        {

            try
            {
                List<agendaENT> lista = new List<agendaENT>();
                lista = new agendaMODEL().Lista();
                grid.AutoGenerateColumns = false;
                grid.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        agendaENT objtabela = new agendaENT();

        private void btnInserir_Click(object sender, EventArgs e)
        {

            objtabela.ID2 = Convert.ToInt32(txtCliente.Text);
            objtabela.medico = txtMedico.Text;
            objtabela.especialidade = txtEspecialidade.Text;
            objtabela.data = Convert.ToDateTime(txtData1.Text);
            objtabela.horario = txtHorario1.Text;

            int x = agendaMODEL.Inserir(objtabela);

            if (x > 0)
            {
                MessageBox.Show(string.Format("Horário agendado!"));

            }
            else
            {
                MessageBox.Show("Não foi Inserido!");
            }

            ListarGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    objtabela.ID = Convert.ToInt32(txtAgenda.Text);
                    objtabela.ID2 = Convert.ToInt32(txtCliente.Text);
                    objtabela.medico = txtMedico.Text;
                    objtabela.especialidade = txtEspecialidade.Text;
                    objtabela.data = Convert.ToDateTime(txtData.Text);
                    objtabela.horario = txtHorario1.Text;


                    int x = agendaENT.Alterar(objtabela);

                    if (x > 0)
                    {
                        MessageBox.Show(string.Format("Usuário {0} foi alterado !", txtMedico.Text));
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
                    objtabela.ID = Convert.ToInt32(txtAgenda.Text);
                    objtabela.ID2 = Convert.ToInt32(txtCliente.Text);
                    objtabela.medico = txtMedico.Text;
                    objtabela.especialidade = txtEspecialidade.Text;
                    objtabela.data = Convert.ToDateTime(txtData.Text);
                    objtabela.horario = txtHorario.Text;

                    int x = agendaMODEL.Deletar(objtabela);
                    if (x > 0)
                    {
                        MessageBox.Show(string.Format("O usuário {0} foi deletado com sucesso !", txtMedico.Text));


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

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAgenda.Text = grid.CurrentRow.Cells[0].Value.ToString();
            txtCliente.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtMedico.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtEspecialidade.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txtData.Text = grid.CurrentRow.Cells[4].Value.ToString();
            txtHorario.Text = grid.CurrentRow.Cells[5].Value.ToString();


        }

        private void Agendacli_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }
    }
}
