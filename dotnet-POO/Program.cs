using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_POO.src.Entities
{ class Program
    {

        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23,"knight");
            Wizard wizard = new Wizard("Jennica", 23,"White Wizard");
            Ninja giraya = new Ninja("Giraya", 20, "Ninja");
            Black mago = new Black("Nosferato", 25, "Black");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(giraya.Attack());
            Console.WriteLine(mago.Attack());
            
        }
    }
}