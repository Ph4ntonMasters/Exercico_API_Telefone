using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_API
{
    public static class Ler_Json
    {
        public static List<Ddds_Por_UF> LerJsonDDDPorUF()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"Ddds_por_UF.json");
            var dddsPorUF = JsonConvert.DeserializeObject<List<Ddds_Por_UF>>(json);

            return dddsPorUF;
        }

        public static DDD_Brasil LerJsonDDDBrasil()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"ddds_Brasil.json");
            var dddsBrasil = JsonConvert.DeserializeObject<DDD_Brasil>(json);

            return dddsBrasil;
        }
    }
}
