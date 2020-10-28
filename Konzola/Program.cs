using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzola
{
	class Program
	{
		static void Main(string[] args)
		{
			//Kvadrat k = new Kvadrat();
			//k.a = 5;
			//Kvadrat k = new Kvadrat { a = 5 };

			Kvadrat kk = new Pravougaonik();
			kk.StaSam();

			List<Figura> kvadrati = new List<Figura>();
			kvadrati.Add(new Kvadrat { a = 5 });
			kvadrati.Add(new Kvadrat { a = 15 });
			kvadrati.Add(new Krug { poluprecnik = 5 });
			kvadrati.Add(new Kvadrat { a = 7 });
			kvadrati.Add(new Pravougaonik { a = 3, b = 2 });

			foreach (Figura k in kvadrati)
			{
				Console.WriteLine($"Povrsina: {k.Povrsina()}");
				Console.WriteLine($"Obim: {k.Obim()}");
			}

			Console.ReadKey();
		}
	}

	public abstract class Figura
	{
		public abstract double Povrsina();
		public abstract double Obim();
	}

	public class Kvadrat : Figura
	{
		public int a;

		public override double Povrsina()
		{
			Console.WriteLine("Racun za kvadrat");
			return a * a;
		}


		public override double Obim()
		{
			Console.WriteLine("Racun za kvadrat");
			return 4 * a;
		}

		public virtual void StaSam()
		{
			Console.WriteLine("kvadrat");
		}
	}

	public class Pravougaonik : Kvadrat
	{
		public int b;
		public override void StaSam()
		{
			Console.WriteLine("pravougaonik");
		}
		public override double Povrsina()
		{
			Console.WriteLine("Racun za pravougaonik");
			return a* b;
		}


		public override double Obim()
		{
			Console.WriteLine("Racun za pravougaonik");
			return 2 * a + 2 * b;
		}
	}

	public class Krug : Figura
	{
		public int poluprecnik;
		public override double Povrsina()
		{
			Console.WriteLine("Racun za krug");
			return Math.PI * poluprecnik * poluprecnik;
		}


		public override double Obim()
		{
			Console.WriteLine("Racun za krug");
			return 2 * Math.PI * poluprecnik;
		}
	}

	
}
