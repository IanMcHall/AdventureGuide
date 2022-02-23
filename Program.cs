using System;

namespace AdventureGuide
{
    class Program
    {
        static void Main(string[] args)
        {
            //add list for character class

            Console.WriteLine("What is your name?");
                string playerName = Console.ReadLine();
            Console.WriteLine("What is your character name?");
                string characterName = Console.ReadLine();
            Console.WriteLine("What is your character level?");
                int characterLevel = Convert.ToInt32(Console.ReadLine());



            //creates new instance of classs pulling from user input
            Character character = new Character();
            character.playerName = playerName;
            character.characterName = characterName;




                
            
            
            
          
            
            
        }
    }
}
