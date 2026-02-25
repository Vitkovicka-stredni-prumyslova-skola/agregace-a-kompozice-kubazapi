﻿namespace AgregaceAKompozice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // TEST
            var trida = new Trida("2.A");
            Console.WriteLine($"Třída: {trida.Nazev}");
            trida.PridejStudenta(new Student("", "", -2));
        
        }
            
    }
}