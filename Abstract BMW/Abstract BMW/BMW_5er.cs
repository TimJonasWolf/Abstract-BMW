using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_BMW
{
	internal class BMW_5er : BMW
	{
		public BMW_5er()
		{
			Eingabe();
		}
		public override void Aussehen()
		{
			Console.WriteLine("Ich bin ein 5er BMW");

			Ausgabe();
		}
		public override void Preis_Anzeige()
		{
			Console.WriteLine($"Preis : 75.000 Fränkli");
		}
	}
}
