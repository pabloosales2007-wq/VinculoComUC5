using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinculoComUC5
{

   
    public partial class Form1 : Form
    {
        private OpenFileDialog leitura = new OpenFileDialog();
        private SaveFileDialog salvamento = new SaveFileDialog();
        private string caminho;
        protected Pessoa pessoa = null;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ao clicar o codigo ira visualizar os dados
        /// </summary>
        /// <param name="sender">Botao de btnObterDados</param>
        /// <param name="e">O evento de click</param>

        private void btnObterDados_Click(object sender, EventArgs e)
        {
            //Vamos voltar nessa linha - 1
            leitura.Filter = "|*.txt";
            leitura.Title = "Selecione o arquivo que contem os dados";
            //Verificar se deu tudo certo ao clicar em OK, apos selecionar o dado
            //Se ao obter o caminho o caminho deu certo, continua, caso contrario encerra
            if (leitura.ShowDialog() != DialogResult.OK) return;

            //Obtendo o caminho do arquivo
            caminho = leitura.FileName;

            //Tenta executar o trecho de codigo
            try
            {
                //Ao digitar o comando, lembre-se de clicar na lampada com X
                //Depois em using System.IO
                //A criação de variavel com var, precisa da atribuição na sequencia 
                //O File, ira fazer a leitura dos dados dentro do arquivo que passei o caminho
                var textoLido = File.ReadAllText(caminho);
                //Extrair texto e coloca dentro do vetor linhas
                string[] linhas = textoLido.ToString().Split('\n'); 
                //for (int i = 0, i < linhas.lenght;i++) lboDados.Itens.Add(linha[i])
                //foreach (string linha in linhas) lboDados.Items.Add(linha);
                for (int i = 0; i < linhas.Length; i = i + 4)
                {
                    string nome = linhas[i]; //Vem do arquivo dadosdogoverno.txt
                    char sexo = linhas[i + 1].ToString()[0]; //serve para pegar o primeiro caractere de qualquer dado.
                    string escolaridade = linhas [i + 2];
                    string classe = linhas[i + 3];
                    Pessoa novaPessoa = new Pessoa(nome, sexo, escolaridade, classe);
                    lboDados.Items.Add(novaPessoa);

                }


            }
            //caso ocorrer qualquer erro no try
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }
        /// <summary>
        /// Ao selecionar uma pessoa da lista, posso modificar ou excluir sua informação
        /// </summary>

        private void lboDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vou obter os dados da pessoa antes de atualizar
            Pessoa antigaPessoa = (sender as ListBox).SelectedItem as Pessoa;

            // Vou valida se o  dado selecionado existe
            if (antigaPessoa == null) return;

            // Cria uma nova entidade de pessoa para obter a atualização dos dados
            Pessoa novaPessoa;
            // Enquanto o formulatio estiver ativo, espero ele finalizar para obter sua resposta
            // sobre a atualização dos dados
            using (Cadastro cadastro = new Cadastro(antigaPessoa))
            {
                cadastro.ShowDialog();
                novaPessoa = cadastro.pessoa;
            }
            // Retiro a seleção no ListBox da pessoa que vai ser atualizada
            lboDados.ClearSelected();
            if (novaPessoa == null)
                lboDados.Items.Remove(antigaPessoa);
            else
            {
                // Procuro a pessoa que sera atualizada
                for (int i = 0; i < lboDados.Items.Count; i++)
                {
                    // Se encontrar, mude a pessoa que foi atualizada
                    if (lboDados.Items[i] == antigaPessoa)
                    {

                        lboDados.Items[i] = novaPessoa;
                        //Pare de procurar uma pessoa -> comando break
                        break;
                    }
                }
            }
            //Atualiza nosso listBox com as novas informações
            lboDados.Update();

        }
    }
}
