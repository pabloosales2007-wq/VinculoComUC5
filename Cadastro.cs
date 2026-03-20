using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinculoComUC5
{
    public partial class Cadastro : Form
    {
        private Pessoa __pessoa;
        
        public Cadastro(Pessoa pessoa)
        {
            InitializeComponent();
            __pessoa = pessoa;
            txtNome.Text = pessoa.nome;

            txtEscolaridade.Text = pessoa.escolaridade;

            rdoFeminino.Checked = pessoa.sexo is 'F';
            rdoMasculino.Checked = pessoa.sexo is 'M';

            cboClasse.SelectedItem = pessoa.classe.Substring(0,8) ;

           
        }
        public Pessoa pessoa
        {
            get { return __pessoa; }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            char sexo = rdoFeminino.Checked ? 'F' : 'M';
            //char sexo;
            //if (rdoFeminino.Checked) sexo = 'F'
            //if (rdoMasculino.Checked) sexo = 'M'

            string escolaridade = txtEscolaridade.Text;
            string classe = cboClasse.SelectedItem as string;

            __pessoa.atualizarCampos(nome, escolaridade, sexo , classe);
            Close();
        }
    }
}
