using DemoObserver.Models;
using System;

namespace DemoObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Acheteur lukas = new Acheteur("Lukas");
            Acheteur charlotte = new Acheteur("Charlotte");
            Produit coca33CL = new Produit("Coca 33cl");
            Produit iPhone = new Produit("IPhone 11");

            coca33CL.NotifyHandler += lukas.Print;
            coca33CL.NotifyHandler += charlotte.Print;

            coca33CL.NotifyHandler.Invoke(iPhone);
            coca33CL.NotifyHandler = null;

            coca33CL.Prix = .80;

        }
    }
}
