using System;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using System.Text;

namespace Small_game
{
    public class Map
    {
        Hero hero = new Hero();
        Battle battle = new Battle();
        private Vector2 myVector = new Vector2(1.0f,1.0f);
        public bool Encounter1 { get; set; } = false;
        public string Space { get; set; } = "~";
        public int XLength { get; } = 110;
        public int YLength { get; } = 27;
        public void MapMovement()
        {
            ConsoleKeyInfo input;
            do
            {
                
                input = Console.ReadKey();

                if (input.Key.Equals(ConsoleKey.RightArrow))
                {
                    myVector.X += 1.0f;
                } 
                if(myVector.X == XLength + 1)
                {
                    myVector.X -= 1.0f;
                }
                if(input.Key.Equals(ConsoleKey.LeftArrow))
                {
                    myVector.X -= 1.0f;
                }
                if(myVector.X == XLength - XLength -1)
                {
                    myVector.X += 1.0f;
                }
                if (input.Key.Equals(ConsoleKey.UpArrow))
                {
                    myVector.Y -= 1.0f;
                }
                if (myVector.Y == YLength - YLength -1)
                {
                    myVector.Y += 1.0f;
                }
                if (input.Key.Equals(ConsoleKey.DownArrow))
                {
                    myVector.Y += 1.0f;
                }
                if (myVector.Y == YLength + 1)
                {
                    myVector.Y -= 1.0f;
                }
                GenerateMap();
                Encounters();




            } while (!input.Key.Equals(ConsoleKey.Escape));
        }

        public void GenerateMap()
        {

            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            Console.Clear();
            
            for (float y = 0; y <= YLength; y++)
            {
                for (float x = 0; x <= XLength; x++)
                {
                    if (myVector.X == x && myVector.Y == y)
                    {
                        Console.Write("P");
                    } else
                    {
                        Console.Write(Space);
                    }
                    
                    
                }
                Console.WriteLine();
                
                
            }
            Console.WriteLine($"{myVector} Jeff, Health: {hero.HealthStatus()}, Attack: {hero.AttackPoints()} Defense: {hero.DefensePoints()}");
            Console.SetCursorPosition(0, 0);


        }
        
        public void EncounterFirst()
        {
            if (myVector.X == 2 && myVector.Y == 1)
            {

                Console.Clear();
                battle.Battle1(new Hero(), new Goblin());
                
            }
           
        }
        

        public void Encounters()
        {
            

            if(myVector.X == 2 && myVector.Y == 1)
            {
                if (Encounter1 == false)
                {
                    EncounterFirst();
                    Encounter1 = true;
                }
            }
            
            
        }

    }
}

