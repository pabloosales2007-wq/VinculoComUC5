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
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblClasseA = new System.Windows.Forms.Label();
            this.lblClasseB = new System.Windows.Forms.Label();
            this.lblClasseC = new System.Windows.Forms.Label();
            this.btnSalvarComo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboDados
            // 
            this.lboDados.BackColor = System.Drawing.Color.MediumPurple;
            this.lboDados.FormattingEnabled = true;
            this.lboDados.Location = new System.Drawing.Point(65, 35);
            this.lboDados.Name = "lboDados";
            this.lboDados.Size = new System.Drawing.Size(540, 303);
            this.lboDados.TabIndex = 0;
            this.lboDados.SelectedIndexChanged += new System.EventHandler(this.lboDados_SelectedIndexChanged);
            // 
            // btnObterDados
            // 
            this.btnObterDados.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObterDados.Location = new System.Drawing.Point(65, 366);
            this.btnObterDados.Name = "btnObterDados";
            this.btnObterDados.Size = new System.Drawing.Size(247, 33);
            this.btnObterDados.TabIndex = 1;
            this.btnObterDados.Text = "Extrair Dados";
            this.btnObterDados.UseVisualStyleBackColor = true;
            this.btnObterDados.Click += new System.EventHandler(this.btnObterDados_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.btnInserir.Location = new System.Drawing.Point(65, 405);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(247, 33);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblClasseA
            // 
            this.lblClasseA.AutoSize = true;
            this.lblClasseA.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.lblClasseA.Location = new System.Drawing.Point(611, 34);
            this.lblClasseA.Name = "lblClasseA";
            this.lblClasseA.Size = new System.Drawing.Size(90, 31);
            this.lblClasseA.TabIndex = 3;
            this.lblClasseA.Text = "lblClasseA";
            // 
            // lblClasseB
            // 
            this.lblClasseB.AutoSize = true;
            this.lblClasseB.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.lblClasseB.Location = new System.Drawing.Point(611, 65);
            this.lblClasseB.Name = "lblClasseB";
            this.lblClasseB.Size = new System.Drawing.Size(89, 31);
            this.lblClasseB.TabIndex = 4;
            this.lblClasseB.Text = "lblClasseB";
            // 
            // lblClasseC
            // 
            this.lblClasseC.AutoSize = true;
            this.lblClasseC.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.lblClasseC.Location = new System.Drawing.Point(611, 96);
            this.lblClasseC.Name = "lblClasseC";
            this.lblClasseC.Size = new System.Drawing.Size(90, 31);
            this.lblClasseC.TabIndex = 5;
            this.lblClasseC.Text = "lblClasseC";
            // 
            // btnSalvarComo
            // 
            this.btnSalvarComo.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.btnSalvarComo.Location = new System.Drawing.Point(373, 405);
            this.btnSalvarComo.Name = "btnSalvarComo";
            this.btnSalvarComo.Size = new System.Drawing.Size(232, 32);
            this.btnSalvarComo.TabIndex = 6;
            this.btnSalvarComo.Text = "Salvar Como";
            this.btnSalvarComo.UseVisualStyleBackColor = true;
            this.btnSalvarComo.Click += new System.EventHandler(this.btnSalvarComo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Location = new System.Drawing.Point(373, 366);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(232, 33);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSalvarComo);
            this.Controls.Add(this.lblClasseC);
            this.Controls.Add(this.lblClasseB);
            this.Controls.Add(this.lblClasseA);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnObterDados);
            this.Controls.Add(this.lboDados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboDados;
        private System.Windows.Forms.Button btnObterDados;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblClasseA;
        private System.Windows.Forms.Label lblClasseB;
        private System.Windows.Forms.Label lblClasseC;
        private System.Windows.Forms.Button btnSalvarComo;
        private System.Windows.Forms.Button btnSalvar;
    }
}

