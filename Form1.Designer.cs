namespace VinculoComUC5
{
    partial class Form1
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
            this.lboDados = new System.Windows.Forms.ListBox();
            this.btnObterDados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboDados
            // 
            this.lboDados.BackColor = System.Drawing.Color.MediumPurple;
            this.lboDados.FormattingEnabled = true;
            this.lboDados.Location = new System.Drawing.Point(65, 35);
            this.lboDados.Name = "lboDados";
            this.lboDados.Size = new System.Drawing.Size(215, 173);
            this.lboDados.TabIndex = 0;
            // 
            // btnObterDados
            // 
            this.btnObterDados.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObterDados.Location = new System.Drawing.Point(65, 229);
            this.btnObterDados.Name = "btnObterDados";
            this.btnObterDados.Size = new System.Drawing.Size(215, 33);
            this.btnObterDados.TabIndex = 1;
            this.btnObterDados.Text = "Extrair Dados";
            this.btnObterDados.UseVisualStyleBackColor = true;
            this.btnObterDados.Click += new System.EventHandler(this.btnObterDados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObterDados);
            this.Controls.Add(this.lboDados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboDados;
        private System.Windows.Forms.Button btnObterDados;
    }
}

