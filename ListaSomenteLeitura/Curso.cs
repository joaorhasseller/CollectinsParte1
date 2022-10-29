using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSomenteLeitura
{
    public class Curso
    {


		private List<Aula> aulas;




		//Toda vez que queremoa acessar a propriedade Aulas, a função get será executada, o retorno é um objeto que implmenta a IList.
		public IList<Aula> Aulas
		{
			get { return new ReadOnlyCollection<Aula>(aulas); } // get é a função de retorno. Toda vez que chamar Aulas, você ESTARÁ CHAMANDO O MÉTODO get
				
		}


		private string nome;
		private string instrutor;

		public Curso(string nome, string instrutor)
		{
			this.nome = nome;
			this.instrutor = instrutor;
			this.aulas = new List<Aula>(); // Instanciar já um objeto que irá armazenar as aulas.
		}

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}



		public string Instrutor
		{
			get { return instrutor; }
			set { instrutor = value; }
		}

		public void Adiciona(Aula aula)
		{
			this.aulas.Add(aula);	//Estamos acessando nossa lista de verdade, não estamos acessando a propriedade Aula
		}
	}
}
