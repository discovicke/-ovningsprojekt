// See https://aka.ms/new-console-template for more information
using System.Collections;
using System;
using System.Collections.Generic;

namespace RuethRaknasaRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Spel spel = new Spel();
            GUI.Title("VÄLKOMMEN TILL RUETHS RESA");
            spel.Run();
        }
    }
}