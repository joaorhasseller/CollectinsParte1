using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            // Fazendo um lista e já inicializado, isso é uma classe generica
            //Isso é um coleção

            //List<string> aulas = new List<string>()
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets

            //};

            //Criando a lista sem definir os elementos iniciais
            // Importante uma lista CONTÉM INTERNAMENTO UM ARRAY, LISTA É CHAMADO DE ARRAY DINAMICO
            //Diferente do array normal, essa lista se expande soziho ou diminui conforme eu coloco itens dentro dela

            List<string> aulas2 = new List<string>();

            //Adicionar elementos na lista dinâmica
            aulas2.Add(aulaIntro);
            aulas2.Add(aulaModelando);
            aulas2.Add(aulaSets);




            // Vamos imprimir a lista
            Imprimir(aulas2);




            Console.WriteLine("A PRIMEIRA AULA É:" + aulas2[0]);
            Console.WriteLine("A PRIMEIRA AULA É:" + aulas2.First());
          




            Console.WriteLine("A ÚLITIMA AULA É:" + aulas2[aulas2.Count-1]);
            Console.WriteLine("A ÚLITIMA AULA É:" + aulas2.Last());



            aulas2[0] = "Trabalhando com lista";

            Imprimir(aulas2);

            //Procurar um palavra dentro da lista de aulas:

            Console.WriteLine("A PRIMERIA AULA  'TRABALHANDO' É : "
                + aulas2.First(x => x.Contains("Trabalhando"))
                );

            Console.WriteLine("A ÚLTIMA AULA  'TRABALHANDO' É : "
              + aulas2.Last(x => x.Contains("Trabalhando"))
              );
            // Se não encontrar o resultado irá lançar um exceção, aí têm que tratar.
            Console.WriteLine("A ÚLTIMA AULA  'Conclusão' É : "
           + aulas2.Last(x => x.Contains("Conclusão"))
           );

            //Retorna um valor ou um valor padrão se a sequênica não tem o elemento, irá retornar null

            Console.WriteLine("A ÚLTIMA AULA  'Conclusão' É : "
          + aulas2.FirstOrDefault(x => x.Contains("Conclusão"))
          );

            // Fazendo inversão de ordem

            aulas2.Reverse();
            Imprimir(aulas2);
            // Invertendo de novo para ter o resultado inicial

            aulas2.Reverse();
            Imprimir(aulas2);


            //Remoção do último elemento do array
            aulas2.RemoveAt(aulas2.Count - 1);
            Imprimir(aulas2);

            /*FUNDAMENTAL ENTEDER, CONFORME VOCÊ ADICIONA O ARRAY DENTRO DA LISTA CRESCE, CONFORME VOCÊ RETIRA ELEEMTNOS
             A ARRAY DENTRO DA LISTA DIMINUÍ*/

            aulas2.Add("Conclusão");
            Imprimir(aulas2);

            //Ordenação de lista em ordem alfábetica:

            aulas2.Sort();
            Imprimir(aulas2);


            //Copiar para uma nova lista copiar os últimos 2 elementos da lista de aulas2
            /*Precisamos OBTER UM FAIXA DE VALORES PARA PODER PASSAR PARA O NOVO ARRAY: PRECISA INICIAR NO PÉNULTIMO ELEMENTO E IR ATÉ O ÚLTIMO
              ELMENTO ---- PORQUE EU QUEREMO OS DOIS ÚLITMOS

            */


            List<string> copia = aulas2.GetRange(aulas2.Count - 2, 2);
            Imprimir(copia);



            /*Fazendo a clonagem para um nova lista, apartir de todos elemento que estão dentor de aulas2*/

            List<string> clone = new List<string>(aulas2); // Fazendo uma cópia exata
            Imprimir(clone);



            //Remover os últimos dois elemtnos do nosso clone/ remover uma faixa de valores
            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);

            /*LISTA É MELHRO DO QUE USAR*/















        }
            
           


        //Método de impressão
        private static void Imprimir(List<string> aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //for (int i = 0; i < aulas.Count; i++) //Propriedade Cout, diz a quantidade total de elemetnos da lista - começando no 1 
            //{
            //    Console.WriteLine(aulas[i]); // Dá para acessar a partir do índice
            //}


            //Terceira forma de fazer varrer um array.

            aulas.ForEach(aula =>
            {

                Console.WriteLine(aula);
            });
        }
    }
}
