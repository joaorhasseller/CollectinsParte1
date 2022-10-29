using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSomenteLeitura
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Vamos  criar uma lista de  cursos onde as aulas estarão incluídos


            Curso cSharColocaoes = new Curso("C# Collectins", "Marcelo");

            /*Problema chamado Code Smell - Mal cheiro no código
            perceba que para adcicionar uma Aula, dentro da lista<Aula> estmaos usando um métoda da classe List, o que corretor seria
           fazer um método Adicionar para a claasse Curso, que iria fazer o trabalho de adicioonar a aula dentro de sua List.
            */
            cSharColocaoes.Adiciona(new Aula("Trabalhando com lista", 21));

          

            Imprimir(cSharColocaoes.Aulas);


           



        }

        private static void Imprimir(IList<Aula> aulaList)
        {
            Console.Clear(); // Limpara a console caso haja infos já dentro dela
            foreach (var aula in aulaList)
            {
                Console.WriteLine(aula); 
            }
            Console.ReadLine();
        }
    }
}
