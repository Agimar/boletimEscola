using System;

namespace escola
{
	public class Aluno : Nota
	{
		public string nome;
		public int idade;
		public string ra;
		
		public void setNome(string nome)
		{
			this.nome = nome;
		}
		
		public string getNome()
		{
			return nome;
		}

		public void setIdade(int idade)
		{
			this.idade = idade;
		}

		public int getIdade()
		{
			return idade;
		}

		public void setRa(string ra)
		{
			this.ra = ra;
		}

		public string getRa()
		{
			return ra;
		}
		
		public void imprimir()
		{
			Console.WriteLine("Nome: " +getNome());
			Console.WriteLine("Idade: " +getIdade());
			Console.WriteLine("RA: " +getRa());
			
			Console.WriteLine("Np1: " +getNp1());
			Console.WriteLine("Np2: " +getNp2());
			Console.WriteLine("Pim: " +getPim());
			Console.WriteLine("Média: " +getMedia());
			Console.WriteLine("Exame: " +getExame());
			Console.WriteLine("Reprovado: " +reprovado);
		}
	}
}
