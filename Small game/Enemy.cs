using System;
using System.Collections.Generic;
using System.Text;

namespace Small_game
{
    public class Enemy : Characters
    {
     
        public Enemy(string name, int health, int attack, int defense, string phrase) : base(name, health, attack, defense, phrase)
        {

        }

    }   
}
