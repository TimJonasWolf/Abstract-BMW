using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_BMW
{
	internal class BMW_3er : BMW
	{
		public BMW_3er()
		{
			Eingabe();
		}
		public override void Aussehen()
		{
			Console.WriteLine("Ich bin ein 3er BMW");

			Ausgabe();
		}
		public override void Preis_Anzeige()
		{
			Console.WriteLine($"Preis : 55.000 Fränkli");
		}

	}
}
