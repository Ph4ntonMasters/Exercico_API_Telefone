namespace Exercicio_API 
{
    public class Program
    {
        static void Main(string[] args)
        {
            var telefoneConstroi = new Telefone_Construtor();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Escolha o tipo de telefone.");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1. Telefone Aleatório");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("2. Telefone Fixo");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("3. Telefone Celular");
            Console.WriteLine("-----------------------------");

            int escolhaTipo = int.Parse(Console.ReadLine());

            switch (escolhaTipo)
            {
                case 1:
                    telefoneConstroi.NumeroAleatorio();
                    break;
                case 2:
                    telefoneConstroi.NumeroFixo();
                    break;
                case 3:
                    telefoneConstroi.NumeroCelular();
                    break;

                default:
                    Console.WriteLine("Escolha inválida.");
                    break;
            }

            Console.WriteLine("Deseja formatação? (S/N):");
            Console.WriteLine("-----------------------------");
            bool escolhaFormatacao = Console.ReadLine().ToUpper() == "S";

            if (escolhaFormatacao)
                telefoneConstroi.ComFormatacao();
            else
                telefoneConstroi.SemFormatacao();

            Console.WriteLine("Deseja adicionar DDD (S/N): ");
            Console.WriteLine("-----------------------------");
            bool escolhaDdd = Console.ReadLine().ToUpper() == "S";

            
            if (escolhaDdd)
            {                
                Console.WriteLine("Deseja DDD Aleatório ou definir um Estado? (A/E):");
                Console.WriteLine("-----------------------------");
                char escolhaDddTipo = Console.ReadLine().ToUpper()[0];

                if (escolhaDddTipo == 'A')
                {
                    telefoneConstroi.ComDddAleatorio();
                    mostraNumero();
                }

                else if (escolhaDddTipo == 'E')
                {
                    Console.WriteLine("Digite a sigla do estado (ex: SP):");
                    Console.WriteLine("-----------------------------");
                    string uf = Console.ReadLine();
                    telefoneConstroi.DddPorUF(uf);
                    mostraNumero();
                }
                else
                {
                    Console.WriteLine("Escolha Inválida!");
                }
            }


            void mostraNumero() 
            {
                var numeroTelefone = telefoneConstroi.Constroi();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"Numero de telefone gerado: {numeroTelefone}");
                Console.WriteLine("---------------------------------------------");
            }
        }
    }
}