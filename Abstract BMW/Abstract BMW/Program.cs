namespace Abstract_BMW
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<BMW> list = new List<BMW>();

			while(true)

			{
				Console.WriteLine($"Mit j/J weiter mit n/N Ende \n");
				string str = Console.ReadLine();

				if(str == "n" || str == "N")
				{
					Console.WriteLine("Ciau Cacau");
					break;
				}
				else if (str == "j" || str == "J")
				{
					int auswahl = Menü();

					switch(auswahl)
					{
						case 1:
							BMW_3er bmw_3er = new BMW_3er();
							list.Add(bmw_3er);
							break;
						case 2:
							BMW_5er bmw_5er = new BMW_5er();
							list.Add(bmw_5er);
							break;
						case 3:
							BMW_M4 bmw_M4 = new BMW_M4();
							list.Add(bmw_M4);
							break;
						default:
							Console.WriteLine("Falsche Eingabe");
							break;

					}
				}
				else
				{
					Console.WriteLine("Falsche Eingabe");
				}
			}
			int k = 1;
			foreach (var x in list) 
			{
				Console.WriteLine($"{k++}es BMW");
				x.Aussehen();
				x.Ausgabe();
				x.Preis_Anzeige();
				Console.WriteLine("______________________________________________________________________");
			}

			Console.WriteLine("Welcher BMW möchten Sie korrigieren ?");
			int i = Convert.ToInt32(Console.ReadLine());

			if( i >= 1 && i <= list.Count - 1)
			{
				for( k = 0; k<list.Count; k++)
				{
					if(k==i-1)
						list[k].SecKorrekur();

				}
			}
			else
			{
				Console.WriteLine("Falsche Eingabe");
			}

			static int Menü()
			{
				int wahl;
				try
				{
					Console.WriteLine($"Wählen sie bitte ");
					Console.WriteLine($"3er			(1) ");
					Console.WriteLine($"5er			(2) ");
					Console.WriteLine($"M4			(3) ");

					wahl = Convert.ToInt32( Console.ReadLine());
					return wahl;

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					return -1;
				}


			}

			Console.ReadKey();
		}
	}
	
}
