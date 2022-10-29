using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Precisamos armazenar em uma lista string e ints
            // Para isso vamos ter que ter uma lista diferente, e sim uma lista do objeto do Tipo Aula

            var aulaIntro = new Aula("Introdução às Coleções", 20);
            var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            var aulaSets = new Aula("Trabalhando com Conjuntos", 16);
            // Quanod criar uma lista desse tipo, você só pode adicionar uma lista desse tipo.  
            List<Aula> aulaList = new List<Aula>()
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };

            //   aulaList.Add("Conlusão") Não é possivél adicionar tipo string dentro de uma lista do tipo Aula
            Imprimir(aulaList);


            //Vamos fazer a ordenção: Para dar certo da classe Aula deve implementar a interface IComparable
            aulaList.Sort(); // Método Sort chama o método CompareTo(); - Para dize qual será o algoritmo para ordenar
            Imprimir(aulaList);

            /*Como modificar a meneira de ordenção, como eu quiser, por tempo de duração*/
            //Irá recber dois elementos para comparação
            aulaList.Sort((este,outro) =>
            {
                return este.Tempo.CompareTo(outro.Tempo);
            });

            Imprimir(aulaList);
            


        }

        private static void Imprimir(List<Aula> aulaList)
        {
            Console.Clear(); // Limpara a console caso haja infos já dentro dela
            foreach (var aula in aulaList)
            {
                Console.WriteLine(aula); // Só que isso irá imprimir o objeto, não o nome da aula, nós estamos imprimindo o objeto
                /*Console.WriteLine - está indo lá no objeto aula, e está buscando um método chamado ToString
                 só que nossa classe não têm esse método, mas lembre-se, toda classe deriva de object, e no o
                 object esse método existe, então está acionaodo o método ToString da classe object, está imprimindo o que esse método
                da classe object está mandando imprimir que o namespace mais o nome da classe; Para resolver isso precisamos sobreescrever
                esse método da classe object*/
            }
            Console.ReadLine();
        }
    }




    class Aula : IComparable
    {

        //Campos privador
        private string _titulo;
        private int _tempo;

        public Aula(string titulo, int tempo)
        {
            _titulo = titulo;
            _tempo = tempo;
        }
        //Propriedade dos campos privador
        public string Titulo { get => _titulo; set => _titulo = value; }
        public int Tempo { get => _tempo; set => _tempo = value; }
        /*Esse método irá comparar um aula com a outra*/
        //Queremos compara a ordem alfábetica
        //Compara o seu objeto que chamou a função com outro que recebei viar arguemnto
        public int CompareTo(object obj)
        {
            Aula aula = obj as Aula;

            return this._titulo.CompareTo(aula._titulo);


            
        }

        public override string ToString()
        {
            return $"Título: {_titulo}, Tempo: {_tempo}"; 
        }
    }
}
