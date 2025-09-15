namespace CrudCreateConexus
{
    partial class frmCadastrodeClientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrodeClientes));
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbCadastro = new System.Windows.Forms.TabPage();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtNomeSocial = new System.Windows.Forms.TextBox();
            this.lblNomeSocial = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.tbConsulta = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gradientPanel2 = new GradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConexus = new System.Windows.Forms.Label();
            this.gradientPanel1 = new GradientPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tbControl.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this.tbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbCadastro);
            this.tbControl.Controls.Add(this.tbConsulta);
            this.tbControl.Location = new System.Drawing.Point(164, 147);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(810, 236);
            this.tbControl.TabIndex = 2;
            this.tbControl.SelectedIndexChanged += new System.EventHandler(this.tbControl_SelectedIndexChanged);
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.txtCPF);
            this.tbCadastro.Controls.Add(this.lblCPF);
            this.tbCadastro.Controls.Add(this.txtEmail);
            this.tbCadastro.Controls.Add(this.lblemail);
            this.tbCadastro.Controls.Add(this.txtNomeSocial);
            this.tbCadastro.Controls.Add(this.lblNomeSocial);
            this.tbCadastro.Controls.Add(this.txtNomeCompleto);
            this.tbCadastro.Controls.Add(this.lblNomeCompleto);
            this.tbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastro.Size = new System.Drawing.Size(802, 210);
            this.tbCadastro.TabIndex = 0;
            this.tbCadastro.Text = "Dados de Clientes";
            this.tbCadastro.UseVisualStyleBackColor = true;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(143, 139);
            this.txtCPF.Mask = "###,###,###-##";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(124, 26);
            this.txtCPF.TabIndex = 7;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblCPF.Location = new System.Drawing.Point(86, 142);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(43, 20);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(143, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(367, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblemail.Location = new System.Drawing.Point(73, 102);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(59, 20);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "E-mail";
            // 
            // txtNomeSocial
            // 
            this.txtNomeSocial.Location = new System.Drawing.Point(143, 61);
            this.txtNomeSocial.Name = "txtNomeSocial";
            this.txtNomeSocial.Size = new System.Drawing.Size(367, 26);
            this.txtNomeSocial.TabIndex = 3;
            // 
            // lblNomeSocial
            // 
            this.lblNomeSocial.AutoSize = true;
            this.lblNomeSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeSocial.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblNomeSocial.Location = new System.Drawing.Point(28, 61);
            this.lblNomeSocial.Name = "lblNomeSocial";
            this.lblNomeSocial.Size = new System.Drawing.Size(109, 20);
            this.lblNomeSocial.TabIndex = 2;
            this.lblNomeSocial.Text = "Nome Social";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(143, 22);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(367, 26);
            this.txtNomeCompleto.TabIndex = 1;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblNomeCompleto.Location = new System.Drawing.Point(3, 22);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(136, 20);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // tbConsulta
            // 
            this.tbConsulta.Controls.Add(this.btnPesquisar);
            this.tbConsulta.Controls.Add(this.txtBuscar);
            this.tbConsulta.Controls.Add(this.dgvClientes);
            this.tbConsulta.Location = new System.Drawing.Point(4, 22);
            this.tbConsulta.Name = "tbConsulta";
            this.tbConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tbConsulta.Size = new System.Drawing.Size(802, 210);
            this.tbConsulta.TabIndex = 1;
            this.tbConsulta.Text = "Consulta";
            this.tbConsulta.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(6, 56);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(790, 148);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.VirtualMode = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(475, 389);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(149, 42);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 90F;
            this.gradientPanel2.ColorBottom = System.Drawing.Color.MediumSlateBlue;
            this.gradientPanel2.ColorTop = System.Drawing.Color.SlateBlue;
            this.gradientPanel2.Controls.Add(this.label5);
            this.gradientPanel2.Controls.Add(this.label6);
            this.gradientPanel2.Controls.Add(this.panel1);
            this.gradientPanel2.Controls.Add(this.label4);
            this.gradientPanel2.Controls.Add(this.label3);
            this.gradientPanel2.Controls.Add(this.label2);
            this.gradientPanel2.Controls.Add(this.label1);
            this.gradientPanel2.Controls.Add(this.txtConexus);
            this.gradientPanel2.Location = new System.Drawing.Point(-4, -9);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(995, 73);
            this.gradientPanel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aquamarine;
            this.label5.Location = new System.Drawing.Point(73, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 39);
            this.label5.TabIndex = 7;
            this.label5.Text = "o";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(101, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 39);
            this.label6.TabIndex = 8;
            this.label6.Text = "nexus";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(823, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 40);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(613, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sobre Nós";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(541, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Agenda ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(435, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Abordagem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(373, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Home";
            // 
            // txtConexus
            // 
            this.txtConexus.AutoSize = true;
            this.txtConexus.BackColor = System.Drawing.Color.Transparent;
            this.txtConexus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtConexus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConexus.ForeColor = System.Drawing.Color.White;
            this.txtConexus.Location = new System.Drawing.Point(42, 27);
            this.txtConexus.Name = "txtConexus";
            this.txtConexus.Size = new System.Drawing.Size(43, 39);
            this.txtConexus.TabIndex = 1;
            this.txtConexus.Text = "C";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 90F;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.Aquamarine;
            this.gradientPanel1.ColorTop = System.Drawing.Color.MediumSlateBlue;
            this.gradientPanel1.Location = new System.Drawing.Point(-4, 63);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(147, 396);
            this.gradientPanel1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(389, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 39);
            this.label7.TabIndex = 9;
            this.label7.Text = "Fluxo de Usuários";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(6, 18);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(155, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(183, 14);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(89, 24);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmCadastrodeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastrodeClientes";
            this.Text = "Form1";
            this.tbControl.ResumeLayout(false);
            this.tbCadastro.ResumeLayout(false);
            this.tbCadastro.PerformLayout();
            this.tbConsulta.ResumeLayout(false);
            this.tbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbCadastro;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtNomeSocial;
        private System.Windows.Forms.Label lblNomeSocial;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TabPage tbConsulta;
        private System.Windows.Forms.Button btnSalvar;
        private GradientPanel gradientPanel1;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label txtConexus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnPesquisar;
    }
}

