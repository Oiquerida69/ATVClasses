using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATVClasses
{
    internal class Modelo
    {
        //Variaveis Globais
        public string nome;
        public int idade;
        public string endereço;
        public string cidade;

        //Método construtor
        public Modelo(string nome, int idade, string endereço, string cidade)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereço = endereço;
            this.cidade = cidade;

        }
    }
}

        
