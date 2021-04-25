using System;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;

namespace DynamoDBObjectPersistence
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			// Add an item
			var client = new AmazonDynamoDBClient();
			var context = new DynamoDBContext(client);
			var item = new OldMovie
			{
				MovieName = "Breakfast at Tiffany's",
				Stars = "Audrey Hepburn, George Peppard",
				YearMade = 1961
			};

			context.SaveAsync(item).Wait();

			// Read item
			OldMovie retrievedItem = context.LoadAsync<OldMovie>("Breakfast at Tiffany's").Result;
			Console.WriteLine("Movie is {0}, made in {1}, starring {2}",
				retrievedItem.MovieName,
				retrievedItem.YearMade, 
				retrievedItem.Stars);

			Console.ReadLine();
		}
	}
}
