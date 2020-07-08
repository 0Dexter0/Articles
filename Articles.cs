using System;
using System.Collections.Generic;

namespace shop
{

	public struct Article
	{
		public Article(int Code, string Name, ArticleType Type, int Price)
		{
			this.Code = Code;
			this.Name = Name;
			this.Type = Type;
			this.Price = Price;
		}

		public int Code;
		public string Name;
		public ArticleType Type;
		public int Price;
	}

	public struct Client
	{
		public Client(int Code, string SNP, string Address, int PhoneNumber, int Orders, int AllOrders, ClientType ClientType)
		{
			this.Code = Code;
			this.SNP = SNP;
			this.Address = Address;
			this.PhoneNumber = PhoneNumber;
			this.Orders = Orders;
			this.AllOrders = AllOrders;
			this.ClientType = ClientType;
		}

		public int Code;
		public string SNP;
		public string Address;
		public int PhoneNumber;
		public int Orders;
		public int AllOrders;
		public ClientType ClientType;
	}

	public struct RequestItem
	{
		public RequestItem(string Product, int ProductQuntity)
		{
			this.Product = Product;
			this.ProductQuntity = ProductQuntity;
		}

		public string Product;
		public int ProductQuntity;
	}

	public struct Request
	{
		public Request(int Code, string Client, DateTime Date, string Name, PayType PayType, int SummRequest)
		{
			this.Code = Code;
			this.Client = Client;
			this.Date = Date;
			this.Name = Name;
			this.PayType = PayType;
			this.SummRequest = SummRequest;
		}

		public int Code;
		public string Client;
		public DateTime Date;
		public string Name;
		public PayType PayType;
		public int SummRequest;
	}
}

