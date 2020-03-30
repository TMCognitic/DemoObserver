using DemoObserver.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoObserver.Models
{
    public class Acheteur : IObserver
    {
        public string Nom { get; private set; }

        public Acheteur(string nom)
        {
            Nom = nom;
        }

        public void Update(ISubject subject)
        {
            Produit p = subject as Produit;

            if(!(p is null))
                Console.WriteLine($"{Nom} est notifié(e) que le prix du produit '{p.Nom}' a changé : {p.Prix}");
        }
    }
}
