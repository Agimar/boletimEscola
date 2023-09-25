using System;

namespace escola 
{
	public class Nota
	{
		public double np1;
		public double np2;
		public double pim;
		public double media;
		public double exame;
		public bool reprovado;


		public void setNp1(double np1)
		{
			this.np1 = np1;
		}

		public double getNp1()
		{
			return np1;
		}

		public void setNp2(double np2)
		{
			this.np2 = np2;
		}

		public double getNp2()
		{
			return np2;
		}

		public void setPim(double pim)
		{
			this.pim = pim;
		}

		public double getPim()
		{
			return pim;
		}

		public void setMedia(double np1, double np2, double pim)
		{
			this.media = Math.Round(((np1 + np2) * 0.8) / 2 +(pim * 0.2),2);
			reprovado = (media < 7);
		}

		public double getMedia()
		{
			return media;
		}

		public void setExame()
		{
			if(reprovado)
			{
				Console.Write("Digite exame: ");
				exame = Convert.ToDouble(Console.ReadLine());
				media = (exame + media) / 2;
				reprovado = (exame < 5) || (media < 5);  
			}
		}

		public double getExame()
		{
			return exame;
		}
	}
}