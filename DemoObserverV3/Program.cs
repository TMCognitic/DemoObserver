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

            coca33CL.Attach(lukas.Print);
            coca33CL.Attach(charlotte.Print);

            coca33CL.Prix = .80;

        }
    }
}
