using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGuide
{
    public class Character
    {
        public string playerName { get; set; }
        public string characterName { get; set; }
        public int characterLevel { get; set; }
        public string characterBackground { get; set; }
        public string characterAlignment { get; set; }
        public int characterEXP { get; set; }

        public CharacterRace characterRace { get; set; }
        public CharacterClass characterClass { get; set; }

        public void GainEXP() //Make sure this can add incremental exp, and see if we can make the message reflect how much is gained.
        {
            characterEXP++;

            Console.WriteLine($"{ characterName} gained experience!");
        }

        public void LevelUp()
        {
            characterLevel++;

            Console.WriteLine($"{characterName} leveled up!");
        }

        public void DisplayCharacterDetails()
        {
            Console.WriteLine($"\nCharacter Name: {characterName}\nPlayer Name: {playerName}\nRace: {characterRace}\nClass: {characterClass}\nLevel: {characterLevel}\nBackground: {characterBackground}\nAlignment: {characterAlignment}\nEXP: {characterEXP}");
        }

    }
}
