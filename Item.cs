using System;
using System.Collections.Generic;
using System.Text;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;

namespace DynamoDBObjectPersistence
{
	[DynamoDBTable("OldMovies")]
	class Item
	{
		[DynamoDBHashKey]
		public string MovieName { get; set; }
		public string Stars { get; set; }
		public int YearMade { get; set; }
	}
}
