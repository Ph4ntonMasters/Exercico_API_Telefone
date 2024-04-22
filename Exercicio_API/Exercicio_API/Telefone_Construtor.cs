using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_API
{
    internal class Telefone_Construtor
    {
        public string Tipo { get; private set; }
        public bool TemFormatacao { get; private set; }

        public bool TemDdd { get; private set; }

        public string Uf { get; private set; }

        public string Constroi()
        {
            Exercicio_API.Tipo_Numero
                template = new();
            return template.GeraTelefone(Tipo, TemFormatacao, TemDdd, Uf);
        }

        public Telefone_Construtor NumeroAleatorio()
        {
            this.Tipo = "";
            return this;
        }
        public Telefone_Construtor NumeroFixo()
        {
            this.Tipo = "FIXO";
            return this;
        }
        public Telefone_Construtor NumeroCelular()
        {
            this.Tipo = "CELULAR";
            return this;
        }
        public Telefone_Construtor ComFormatacao()
        {
            this.TemFormatacao = true;
            return this;
        }
        public Telefone_Construtor SemFormatacao()
        {
            this.TemFormatacao = false;
            return this;
        }

        public Telefone_Construtor ComDddAleatorio()
        {
            this.TemDdd = true;
            this.Uf = "";
            return this;
        }

        public Telefone_Construtor DddPorUF(string uf)
        {
            this.TemDdd = true;
            this.Uf = uf;
            return this;
        }
    }
}
