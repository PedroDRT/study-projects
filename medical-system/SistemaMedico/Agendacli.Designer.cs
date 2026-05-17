namespace SistemaMedico
{
    partial class Agendacli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agendacli));
            this.txtAgenda = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.txtEspecialidade = new System.Windows.Forms.TextBox();
            this.lblIdAg = new System.Windows.Forms.Label();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.ID_agenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtHorario1 = new System.Windows.Forms.MaskedTextBox();
            this.txtData1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAgenda
            // 
            this.txtAgenda.Location = new System.Drawing.Point(178, 60);
            this.txtAgenda.Name = "txtAgenda";
            this.txtAgenda.Size = new System.Drawing.Size(100, 20);
            this.txtAgenda.TabIndex = 2;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(358, 60);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // txtMedico
            // 
            this.txtMedico.Location = new System.Drawing.Point(178, 94);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(280, 20);
            this.txtMedico.TabIndex = 4;
            // 
            // txtEspecialidade
            // 
            this.txtEspecialidade.Location = new System.Drawing.Point(178, 130);
            this.txtEspecialidade.Name = "txtEspecialidade";
            this.txtEspecialidade.Size = new System.Drawing.Size(280, 20);
            this.txtEspecialidade.TabIndex = 5;
            // 
            // lblIdAg
            // 
            this.lblIdAg.AutoSize = true;
            this.lblIdAg.BackColor = System.Drawing.Color.Transparent;
            this.lblIdAg.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAg.Location = new System.Drawing.Point(88, 60);
            this.lblIdAg.Name = "lblIdAg";
            this.lblIdAg.Size = new System.Drawing.Size(79, 15);
            this.lblIdAg.TabIndex = 6;
            this.lblIdAg.Text = "ID Agenda : ";
            // 
            // lblIdCli
            // 
            this.lblIdCli.AutoSize = true;
            this.lblIdCli.BackColor = System.Drawing.Color.Transparent;
            this.lblIdCli.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCli.Location = new System.Drawing.Point(281, 60);
            this.lblIdCli.Name = "lblIdCli";
            this.lblIdCli.Size = new System.Drawing.Size(71, 15);
            this.lblIdCli.TabIndex = 7;
            this.lblIdCli.Text = "ID Cliente :";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.BackColor = System.Drawing.Color.Transparent;
            this.lblMedico.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(104, 99);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(61, 15);
            this.lblMedico.TabIndex = 8;
            this.lblMedico.Text = "Médico : ";
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.BackColor = System.Drawing.Color.Transparent;
            this.lblEspecialidade.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidade.Location = new System.Drawing.Point(76, 132);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(96, 15);
            this.lblEspecialidade.TabIndex = 9;
            this.lblEspecialidade.Text = "Especialidade :";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(119, 167);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(42, 15);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data :";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(281, 167);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(62, 15);
            this.lblHorario.TabIndex = 11;
            this.lblHorario.Text = "Horário : ";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_agenda,
            this.ID_Cli,
            this.Medico,
            this.Especialidade,
            this.Data,
            this.Horario});
            this.grid.GridColor = System.Drawing.Color.LightBlue;
            this.grid.Location = new System.Drawing.Point(64, 291);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(457, 234);
            this.grid.TabIndex = 12;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // ID_agenda
            // 
            this.ID_agenda.DataPropertyName = "ID";
            this.ID_agenda.HeaderText = "ID_agenda";
            this.ID_agenda.Name = "ID_agenda";
            this.ID_agenda.ReadOnly = true;
            // 
            // ID_Cli
            // 
            this.ID_Cli.DataPropertyName = "ID2";
            this.ID_Cli.HeaderText = "ID_Cli";
            this.ID_Cli.Name = "ID_Cli";
            this.ID_Cli.ReadOnly = true;
            // 
            // Medico
            // 
            this.Medico.DataPropertyName = "Medico";
            this.Medico.HeaderText = "Médico";
            this.Medico.Name = "Medico";
            this.Medico.ReadOnly = true;
            // 
            // Especialidade
            // 
            this.Especialidade.DataPropertyName = "Especialidade";
            this.Especialidade.HeaderText = "Especialidade ";
            this.Especialidade.Name = "Especialidade";
            this.Especialidade.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Horario
            // 
            this.Horario.DataPropertyName = "Horario";
            this.Horario.HeaderText = "Horário";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Image = global::SistemaMedico.Properties.Resources.transfer_man_employee_user_avatar_arrow_refresh_icon_141997;
            this.btnAlterar.Location = new System.Drawing.Point(241, 239);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(98, 46);
            this.btnAlterar.TabIndex = 28;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.Transparent;
            this.btnInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Image = global::SistemaMedico.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.btnInserir.Location = new System.Drawing.Point(137, 239);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(98, 46);
            this.btnInserir.TabIndex = 27;
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Image = global::SistemaMedico.Properties.Resources.delete_delete_deleteusers_delete_male_user_maleclient_2348;
            this.btnExcluir.Location = new System.Drawing.Point(345, 239);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(98, 46);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = global::SistemaMedico.Properties.Resources.exitdoor_87195__1_;
            this.btnSair.Location = new System.Drawing.Point(545, 475);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(42, 50);
            this.btnSair.TabIndex = 29;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtHorario1
            // 
            this.txtHorario1.Location = new System.Drawing.Point(343, 164);
            this.txtHorario1.Mask = "00:00";
            this.txtHorario1.Name = "txtHorario1";
            this.txtHorario1.Size = new System.Drawing.Size(115, 20);
            this.txtHorario1.TabIndex = 30;
            this.txtHorario1.ValidatingType = typeof(System.DateTime);
            // 
            // txtData1
            // 
            this.txtData1.Location = new System.Drawing.Point(178, 165);
            this.txtData1.Mask = "00/00/0000";
            this.txtData1.Name = "txtData1";
            this.txtData1.Size = new System.Drawing.Size(100, 20);
            this.txtData1.TabIndex = 31;
            this.txtData1.ValidatingType = typeof(System.DateTime);
            // 
            // Agendacli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::SistemaMedico.Properties.Resources.OJ8XZR0;
            this.ClientSize = new System.Drawing.Size(599, 551);
            this.Controls.Add(this.txtData1);
            this.Controls.Add(this.txtHorario1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblEspecialidade);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.lblIdCli);
            this.Controls.Add(this.lblIdAg);
            this.Controls.Add(this.txtEspecialidade);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtAgenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agendacli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agendacli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAgenda;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.TextBox txtEspecialidade;
        private System.Windows.Forms.Label lblIdAg;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.MaskedTextBox txtHorario1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.MaskedTextBox txtData1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_agenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
    }
}