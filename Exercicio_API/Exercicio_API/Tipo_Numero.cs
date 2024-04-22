using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_API
{
    public class Tipo_Numero
    {
        public string GeraTelefone(string tipo, bool temFormatacao, bool temDdd, string uf)
        {
            tipo = tipo.ToUpper();
            if (String.IsNullOrEmpty(tipo)) tipo = RandomTypeTelefone();
            if ("FIXO".Equals(tipo))
            {
                var tel = new Telefone_Fixo(temDdd, temFormatacao, uf);
                return tel.Numero;
            }
            else if ("CELULAR".Equals(tipo))
            {
                var cel = new Telefone_Celular(temDdd, temFormatacao, uf);
                return cel.Numero;
            }
            return null;
        }

        private string RandomTypeTelefone()
        {
            Random random = new Random();
            string[] types = { "FIXO", "CELULAR" };
            int index = random.Next(0, 2);
            return types[index];
        }
    }
}
