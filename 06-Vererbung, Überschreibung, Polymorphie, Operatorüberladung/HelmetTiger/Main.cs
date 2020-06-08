using System;

namespace Tigers
{
    class Program
    {
        static void Main(string[] args)
        {
        	var helmet = new Helmet(51.0, 42);

        	//Polymorphie: Zugriff auf "HelmTiger" über "Tiger"-Referenz!
        	//Trotzdem werden in "Helmtiger" überschriebene Methoden aufgerufen.
        	Tiger helmetTiger = new HelmetTiger(42, 50.0, 666, helmet);
        	Console.WriteLine(helmetTiger.Firmness);
        }
    }
}
