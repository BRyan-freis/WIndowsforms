namespace alertas
{
    partial class Alertas
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
            this.lblTítulo = new System.Windows.Forms.Label();
            this.btnAlertaSimples = new System.Windows.Forms.Button();
            this.btnAlertaRobusto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTítulo.Location = new System.Drawing.Point(511, 35);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(294, 31);
            this.lblTítulo.TabIndex = 0;
            this.lblTítulo.Text = "Teste os alertas abaixo";
            // 
            // btnAlertaSimples
            // 
            this.btnAlertaSimples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(103)))), ((int)(((byte)(86)))));
            this.btnAlertaSimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertaSimples.ForeColor = System.Drawing.Color.White;
            this.btnAlertaSimples.Location = new System.Drawing.Point(582, 86);
            this.btnAlertaSimples.Name = "btnAlertaSimples";
            this.btnAlertaSimples.Size = new System.Drawing.Size(158, 64);
            this.btnAlertaSimples.TabIndex = 1;
            this.btnAlertaSimples.Text = "Alerta Simples";
            this.btnAlertaSimples.UseVisualStyleBackColor = false;
            this.btnAlertaSimples.Click += new System.EventHandler(this.btnAlertaSimples_Click);
            // 
            // btnAlertaRobusto
            // 
            this.btnAlertaRobusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlertaRobusto.FlatAppearance.BorderSize = 0;
            this.btnAlertaRobusto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAlertaRobusto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAlertaRobusto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertaRobusto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAlertaRobusto.Location = new System.Drawing.Point(567, 168);
            this.btnAlertaRobusto.Name = "btnAlertaRobusto";
            this.btnAlertaRobusto.Size = new System.Drawing.Size(192, 45);
            this.btnAlertaRobusto.TabIndex = 2;
            this.btnAlertaRobusto.Text = "Alerta Robusto";
            this.btnAlertaRobusto.UseVisualStyleBackColor = false;
            this.btnAlertaRobusto.Click += new System.EventHandler(this.btnAlertaRobusto_Click);
            // 
            // Alertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 395);
            this.Controls.Add(this.btnAlertaRobusto);
            this.Controls.Add(this.btnAlertaSimples);
            this.Controls.Add(this.lblTítulo);
            this.Name = "Alertas";
            this.Text = "Alertas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.Button btnAlertaSimples;
        private System.Windows.Forms.Button btnAlertaRobusto;
    }
}

