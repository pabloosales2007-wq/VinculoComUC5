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
        /// <summary>
        /// Criação do objeto como um elemnto do codigo
        /// </summary>
        private Pessoa __pessoa;

        /// <summary>
        /// Construindo o formulario, precisa ter no inicioo a pessoa a ser editada
        /// </summary>
        /// <param name="pessoa">passa a pessoa antiga para a atualização</param>
        public Cadastro(Pessoa pessoa)
        {
            //inicia todos os controle (textbox,listbox,combobox) do formulario
            InitializeComponent();

            //Vou passar a pessoa antiga para atualização
            __pessoa = pessoa;
            // Vou preencher todos os controle (textBox, ComboBox) etc...
            txtNome.Text = pessoa.nome;

            txtEscolaridade.Text = pessoa.escolaridade;

            rdoFeminino.Checked = pessoa.sexo is 'F';
            rdoMasculino.Checked = pessoa.sexo is 'M';

            cboClasse.SelectedItem = pessoa.classe.Substring(0,8) ;

           
        }

        /// <summary>
        /// Vou habilitar a leitura da pessoa
        /// </summary>
        public Pessoa pessoa
        {
            get { return __pessoa; }
        }
        /// <summary>
        /// Função do clique que permite a pessoa ter seus dados atualizados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //modifica os dados, com base no controle (textBox, comboBox,...)
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
        /// <summary>
        /// Informe que a pessoa sera nula (vazio) e para no outro codigo 
        /// excluir da alista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            __pessoa = null;
            Close();
        }
    }
}
