using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A310PoderDosSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SETS = CONJUNTOS
            //Dedicado ao um tipo de coleção chamado conjunto
            //Características:
            //1.não permite duplicidade : um elmento não irá ter mais de uma vez no mesmo conjunto
            //2. os elementos não têm uma ordem específica: quando você INCLUÍ ELEMENTOS VOCÊ NÃO SABE QUE POSIÇÃO ELE IRÁ PARAR DENTRO DO CONJUNTO

            // Declarando alunos como um conjunto = sets
            ISet<string> alunos = new HashSet<string>();
            // ADICIONANDO: RAFAEL, VANESSA, ANA
            alunos.Add("Ana Losnak");
            alunos.Add("Vaneessa Tonini");
            alunos.Add("Rafael Jordani");
            //imprimir
            Console.WriteLine(string.Join(",",alunos));


            //Diferença entre conjunto e lista: Conjunto não garante qual posição o elemento irá ocupar quanod adicionado

            alunos.Add("Priscila Faria");
            alunos.Add("Lucas Jordani");
            alunos.Add("João Rhasseller");
            Console.WriteLine(string.Join(",", alunos));


            //Removendo um aluno e colocando outro: Marcelo Borges
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Borges");
            Console.WriteLine(string.Join(",", alunos)); // Agora o Marcelo ocupa a mesma posição que Ana ocupava

            alunos.Add("Marcelo Borges");
            //Não vai dar erro, não vai dar nada, o conjunto irá continuar da mesma maneria
            Console.WriteLine(string.Join(",", alunos));


            //Vantagem sobre a lista: O sets são fais rápido para buscar os elementos , ele rápido o tempo de busca mas ocupa mais espaço de mémoria devido a tabela de espalhamento
            //HashSet utiliza uma tabela de espalhamento

            //Ordenação sort: Não contém essa função devido a ser sets de readonly
            //Como resolver: Fazemos uma cópia de nossa sets para uma list

            List<string> alunosEmLista = new List<string>(alunos);
            alunosEmLista.Sort();
            Console.WriteLine(string.Join(",", alunosEmLista));









            Console.ReadLine();



        }
    }
}
