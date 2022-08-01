﻿using System;

namespace Episode_07
{
    class Wizard
    {
        public string name;
        public string favouriteSpell;
        public int spellSlots;
        public float experience;

        public Wizard(string  _name, string _favouriteSpell)
        {
            name =  _name;
            favouriteSpell = _favouriteSpell;
            spellSlots = 2;
            experience = 0f;
        }

        public void CastSpell()
        {
            if (spellSlots > 0)
            {
                Console.WriteLine(name + " casts " + favouriteSpell);
                spellSlots--;
                experience += 0.3f;
            } else {
                Console.WriteLine(name + " is out of spell slots.");
            }    
        }

        public void Meditate()
        {
            Console.WriteLine(name + "meditates to regain spell slots.");
            spellSlots = 2;
        }
    }
    
    class Program
    {
        static void Main (string[] args)
        {
            Wizard wizard01 = new Wizard("Zyzz", "Bruh");
            
            wizard01.CastSpell();
            wizard01.CastSpell();
            wizard01.CastSpell();

            wizard01.Meditate();

            wizard01.CastSpell();
            wizard01.CastSpell();
            
            Console.WriteLine("Experience: " + wizard01.experience);

            Console.ReadKey();
        }
    }
}