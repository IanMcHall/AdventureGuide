using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster
{
    public class Character
    {
        public string PlayerName { get; set; }
        public string CharacterName { get; set; }
        public string CharacterLevel { get; set; }
        public string CharacterBackground{ get; set; }
        public string CharacterAlignment { get; set; }
        public string CharacterRace { get; set; }
        public string CharacterClass { get; set; }

        public Character(string playerName, string characterName, string characterBackground, string characterAlignment, string characterLevel, string characterRace, string characterClass)
        {
            PlayerName = playerName;
            CharacterName = characterName;
            CharacterBackground = characterBackground;
            CharacterAlignment = characterAlignment;
            CharacterLevel = characterLevel;
            CharacterClass = characterClass;
            CharacterRace = characterRace;
        }


        //public void GainEXP() //Make sure this can add incremental exp, and see if we can make the message reflect how much is gained.
        //{
        //    characterEXP++;

        //    Console.WriteLine($"{ characterName} gained experience!");
        //}

        //public void LevelUp()
        //{
        //    characterLevel++;

        //    Console.WriteLine($"{characterName} leveled up!");
        //}

        //public void DisplayCharacterDetails()
        //{
        //    Console.WriteLine($"\nCharacter Name: {characterName}\nPlayer Name: {playerName}\nRace: {characterRace}\nClass: {characterClass}\nLevel: {characterLevel}\nBackground: {characterBackground}\nAlignment: {characterAlignment}\nEXP: {characterEXP}");
        //}

    }
    
}
