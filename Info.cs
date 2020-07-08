using System;
using System.Collections.Generic;

namespace shop
{
    public class Info
    {
        public static int Summ(Article Name, RequestItem items)
        {
            int summ = 0;

                if (Name.Name == items.Product)
                {
                    summ += Name.Price * items.ProductQuntity;
                }

            return summ;
        }
        public static void ArticlePrint(Article apple, Article ariel, Article cola)
        {
            Article[] articles = { apple, ariel, cola };
            for(int i = 0; i < articles.Length; i++)
            {
                Console.WriteLine(articles[i].Code);
                Console.WriteLine(articles[i].Name);
                Console.WriteLine(articles[i].Type);
                Console.WriteLine(articles[i].Price);
                Console.WriteLine();
            }
        }
        public static void ClientPrint(Client client1, Client client2, Client client3)
        {
            Client[] clients = { client1, client2, client3 };
            for(int i = 0; i < clients.Length; i++)
            {
                Console.WriteLine(clients[i].Code);
                Console.WriteLine(clients[i].SNP);
                Console.WriteLine(clients[i].Address);
                Console.WriteLine(clients[i].PhoneNumber);
                Console.WriteLine(clients[i].Orders);
                Console.WriteLine(clients[i].AllOrders);
                Console.WriteLine(clients[i].ClientType);
                Console.WriteLine();
            }
        }
        public static void RequestItemPrint(RequestItem rApple, RequestItem rAriel, RequestItem rCola)
        {
            RequestItem[] requestItems = { rApple, rAriel, rCola };
            for(int i = 0; i < requestItems.Length; i++)
            {
                Console.WriteLine(requestItems[i].Product);
                Console.WriteLine(requestItems[i].ProductQuntity);
                Console.WriteLine();
            }
        }
        public static void RequestPrint(Request r1, Request r2, Request r3)
        {
            Request[] requests = { r1, r2, r3 };
            for(int i = 0; i < requests.Length; i++)
            {
                Console.WriteLine(requests[i].Code);
                Console.WriteLine(requests[i].Client);
                Console.WriteLine(requests[i].Date);
                Console.WriteLine(requests[i].Name);
                Console.WriteLine(requests[i].PayType);
                Console.WriteLine(requests[i].SummRequest);
                Console.WriteLine();
            }
        }

        public static Article Cola = new Article(1, "Cola", ArticleType.Напиток, 10);

        public static Article Ariel = new Article(2, "Ariel", ArticleType.ХимВещество, 40);

        public static Article Apple = new Article(3, "Apple", ArticleType.Еда, 1);


        public static Client Client1 = new Client(1, "Client1", "Address1", 123456789, 10, 15, ClientType.Low);

        public static Client Client2 = new Client(2, "Client2", "Address2", 987654321, 30, 50, ClientType.Medium);

        public static Client Client3 = new Client(3, "Client3", "Address3", 159753462, 60, 120, ClientType.Hight);


        public static RequestItem requestApple = new RequestItem(Apple.Name, 100);

        public static RequestItem requestAriel = new RequestItem(Ariel.Name, 20);

        public static RequestItem requestCola = new RequestItem(Cola.Name, 50);


        public static Request request1 = new Request(1, Client1.SNP, DateTime.Now, Apple.Name, PayType.Cash, Summ(Apple, requestApple));

        public static Request request2 = new Request(2, Client2.SNP, DateTime.Now, Cola.Name, PayType.GooglePay, Summ(Cola, requestCola));

        public static Request request3 = new Request(3, Client3.SNP, DateTime.Now, Ariel.Name, PayType.Visa, Summ(Ariel, requestAriel));
    }
}
