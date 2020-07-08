using System;
using System.Collections.Generic;

namespace shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Info.ArticlePrint(Info.Apple, Info.Ariel, Info.Cola);
            Console.WriteLine();
            Info.ClientPrint(Info.Client1, Info.Client2, Info.Client3);
            Console.WriteLine();
            Info.RequestItemPrint(Info.requestApple, Info.requestAriel, Info.requestCola);
            Console.WriteLine();
            Info.RequestPrint(Info.request1, Info.request2, Info.request3);
        }
    }
}
