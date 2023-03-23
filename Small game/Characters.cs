using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Small_game
{
    public class Characters
    {
        private string Name { get; }

        private int Health { get; set; }

        private int Attack { get; }

        private int Defense { get; }

        private string Phrase { get; }

        public Characters(string name, int health, int attack, int defense, string phrase)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
            Phrase = phrase;
          
        }
        public int Attacking()
        {
            Random rnd = new Random();
            int attackNum = rnd.Next(20);
            return attackNum;
         
        }
        public int HealthStatus()
        {
            return Health;
        }
        public int DamageHealth(int damageDone)
        {
            Health -= damageDone;
            return Health;
        }

        public int AttackPoints()
        {
            return Attack;
        }

        public int DefensePoints()
        {
            return Defense;
        }

        public string Shout()
        {
            return Phrase;
        }
        
        //public string AfterBattle()
        //{
           
        //}



    }
}
