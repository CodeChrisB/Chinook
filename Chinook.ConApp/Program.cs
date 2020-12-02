using System;

namespace Chinook.ConApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
			Console.WriteLine("Chinook - Marketing");
			Console.WriteLine("Christopher -- 4BHIF");
			Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

			#region TrackTime
			var (avg, longest, shortest) = Report.MarketingReports.GetTrackTimes();

			Console.WriteLine("Track-Zeit-Auswertung");
			Console.WriteLine("{0,-50} {1,20}", longest.Name, longest.Seconds);
			Console.WriteLine("{0,-50} {1,20}", shortest.Name, shortest.Seconds);
			Console.WriteLine("{0,-50} {1,20:f2}\n", "AVG-Time", avg / 1000);
			#endregion
			Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

			#region AlbumTime
			var (avg1, longest1, shortest1) = Report.MarketingReports.GetAlbumTime();

			Console.WriteLine("Album-Zeit-Auswertung");
			Console.WriteLine("{0,-50} {1,20}", longest1.Name, longest1.Seconds);
			Console.WriteLine("{0,-50} {1,20}", shortest1.Name, shortest1.Seconds);
			Console.WriteLine("{0,-50} {1,20:f2}\n", "AVG -Time", avg1);
			#endregion
			Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

			#region TrackSales
			Console.WriteLine("Track-Verkauf-Auswertung");

			var sales = Report.MarketingReports.GetTrackSales();

			Console.WriteLine("{0,-50} {1,20}", sales.HighestSales.Name, sales.HighestSales.Secondary);
			Console.WriteLine("{0,-50} {1,20}", sales.LowestSales.Name, sales.LowestSales.Secondary);
			Console.WriteLine("{0,-50} {1,20}", sales.HighestRevenue.Name, sales.HighestRevenue.Secondary);
			Console.WriteLine("{0,-50} {1,20}", sales.LowestRevenue.Name, sales.LowestRevenue.Secondary);
			Console.WriteLine("{0,-50} {1,20:f2}\n", "AVG-Price", sales.Average);
			#endregion
			Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

			#region Customers
			var customers = Report.MarketingReports.GetCustomersInfo();

			Console.WriteLine("{0,-50} {1,20}", "Kunde/Name", "Umsatz");
			Console.WriteLine("{0,-50} {1,20}", customers.TopCustomer.Name, customers.TopCustomer.Secondary);
			Console.WriteLine("{0,-50} {1,20}", customers.BottomCustomer.Name, customers.BottomCustomer.Secondary);
			Console.WriteLine("{0,-50} {1,20:f2}\n", "AVG-Time", customers.Average);
			#endregion
			Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

			#region GenreSales
			Console.WriteLine("Genre-Verkauf-Auswertung");

			var (genre1, genre2) = Report.MarketingReports.GetGenresInfo();

			Console.WriteLine("{0,-50} {1,20}", genre1.Name, genre1.Secondary);
			Console.WriteLine("{0,-50} {1,20}\n", genre2.Name, genre2.Secondary);
			#endregion

			Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
			Console.WriteLine("Press any key to continue ...");
			Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

			Console.ReadKey();
		}
	}
}
