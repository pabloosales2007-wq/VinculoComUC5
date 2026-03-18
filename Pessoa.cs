using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinculoComUC5
{
    /// <summary>
    /// Representa as pessoas da base de dados dadosdogoverno.txt
    /// </summary>
    internal class Pessoa
    {
        // private → Este campo fica visivel apenas no Pessoa.cs
        private string _nome;
        private char _sexo;
        private string _escolaridade;
        private string _classe;


        /// <summary>
        /// Construindo a identidade da pessoa em outro codigo
        /// </summary>
        /// <param name="nome">nome da pessoa da base de dados</param> //undeline _ e de um arquivo externo
        /// <param name="sexo">sexo da pessoa da base de dados</param> // interno
        /// <param name="escolaridade">Escolaridade da pessoa da base de dados</param>
        /// <param name="classe">Classe da pessoa da base de dados</param>
        /// 

        // public → Este construtor fica visivel para todos
        public Pessoa(string nome, char sexo, string escolaridade, string classe)
        {
            this._nome = nome;  // Tanto faz com This, quanto sem o this
            _sexo = sexo;
            _escolaridade = escolaridade;
            _classe = classe;

        }
        //public override string ToString() => _nome;
        public override string ToString()
        {
            return _nome;
        }
    }
}
