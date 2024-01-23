using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_BMW
{
	internal abstract class BMW
	{
		public string Model { get; set; }
		public int Jahrgang { get; set; }
		public int Qcm { get; set; }
		public double secPro100KM { get; set; }
		public abstract void Aussehen();
		public abstract void Preis_Anzeige();
		public void Eingabe()
		{
			try
			{
				Console.WriteLine("Model : ");
				Model = Console.ReadLine();
				Console.WriteLine("Jahrgang : ");
				Jahrgang = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Qcm : ");
				Qcm = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("SecPro100km : ");
				secPro100KM = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("______________________________________________________");
                Console.WriteLine();




            }
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
		public void Ausgabe()
		{
			Console.WriteLine(	$"Model : {Model}\n"+
								$"Jahrgang : {Jahrgang}\n"+
								$"Qcm : {Qcm}\n" +
								$"SecPro100KM : {secPro100KM}\n" );
		}
		public void SecKorrekur()
		{
			try
			{

				Console.WriteLine("Geben sie die neue SecPro100km : ");
				secPro100KM = Convert.ToDouble(Console.ReadLine());


			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}



	}
}
