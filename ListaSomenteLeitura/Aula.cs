using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSomenteLeitura
{


    public class Aula : IComparable
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

