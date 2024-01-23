using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_BMW
{
	internal class BMW_M4 : BMW
	{
		public BMW_M4()
		{
			Eingabe();
		}
		public override void Aussehen()
		{
			Console.WriteLine("Ich bin ein M4 BMW");
			Ausgabe();
		}
		public override void Preis_Anzeige()
		{
			Console.WriteLine($"Preis : 155.000 Fränkli");
		}
	}
}
