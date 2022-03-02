using System;
using System.Collections.Generic;
using System.Linq;

namespace DungeonMaster
{
    class Program1
    {

        // Is the app receiving the multiple entries to new characters?
        private static List<Character> characters = new List<Character>();

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("            Welcome To             ");
            Console.WriteLine("            Dungeon Master         ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;

            string userSelection;

            do
            {
                //Review Characters is not yet implemented
                Console.WriteLine("1. Create a character");
                Console.WriteLine("2. Review Characters");
                Console.WriteLine("9. Exit");

                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        CreateCharacter();
                        break;
                     // case 2 not returning the desired results   
                    case "2":
                        ReviewCharacter();
                       break;
                }
            }
            while (userSelection != "9");

            Console.WriteLine("Until fate sees your return...");
            Console.Read();
        }
        private static void CreateCharacter()
        {
            //add list for character class
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("         What is your name?           ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;

            string playerName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   What is your character name?   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;

            string characterName = Console.ReadLine();


            //How can I make this accept ONLY numbers? It should return an error otherwise. Currently the app crashes.
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   What is your character level?   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            int characterLevel = Convert.ToInt32(Console.ReadLine());

            //Get characterAligment function 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***********************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("      What is your alignment?      ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***********************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1: Lawful Good");
                Console.WriteLine("2: Neutral Good");
                Console.WriteLine("3: Chaotic Good");
                Console.WriteLine("4: Lawful Nuetral");
                Console.WriteLine("5: True Nuetral");
                Console.WriteLine("6: Chaotic Neutral");
                Console.WriteLine("7: Lawful Evil");
                Console.WriteLine("8: Neutral Evil");
                Console.WriteLine("9: Chaotic Evil");
                Console.WriteLine("10: Unaligned");

                //Doesn't loop when invalid selection is passed through. Accepts whatever is typed
                string characterAlignment = Console.ReadLine();
                switch (characterAlignment)
                {
                    case "1":
                        characterAlignment = "Lawful Good";
                        break;
                    case "2":
                        characterAlignment = "Neutral Good";
                        break;
                    case "3":
                        characterAlignment = "Chaotic Good";
                        break;
                    case "4":
                        characterAlignment = "Lawful Neutral";
                        break;
                    case "5":
                        characterAlignment = "True Neutral";
                        break;
                    case "6":
                        characterAlignment = "Chaotic Neutral";
                        break;
                    case "7":
                        characterAlignment = "Lawful Evil";
                        break;
                    case "8":
                        characterAlignment = "Neutral Evil";
                        break;
                    case "9":
                        characterAlignment = "Chaotic Evil";
                        break;
                    case "10":
                        characterAlignment = "Unaligned";
                        break;
                  
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");

                        break;
                }
            


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("     What is your background?      ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1: Acolyte");
                Console.WriteLine("2: Anthropologist");
                Console.WriteLine("3: Archaeologist");
                Console.WriteLine("4: Athlete");
                Console.WriteLine("5: Azorius Functionary");
                Console.WriteLine("6: Boros Legionnaire");
                Console.WriteLine("7: Celebrity Adventurer's Scoin");
                Console.WriteLine("8: Charlata");
                Console.WriteLine("9: City Watch");
                Console.WriteLine("10: Clan Crafter");
                Console.WriteLine("11: Cloistered Scholar");
                Console.WriteLine("12: Courtier");
                Console.WriteLine("13: Criminal");
                Console.WriteLine("14: Dimir Operative");
                Console.WriteLine("15: Entertainer");
                Console.WriteLine("16: Faceless");
                Console.WriteLine("17: Faction Agent");
                Console.WriteLine("18: Failed Merchant");
                Console.WriteLine("19: Far Traveler");
                Console.WriteLine("20: Feylost");
                Console.WriteLine("21: Fisher");
                Console.WriteLine("22: Folk Hero");
                Console.WriteLine("23: Gambler");
                Console.WriteLine("24: Gladiator");
                Console.WriteLine("25: Golgari Agent");
                Console.WriteLine("26: Grinner");
                Console.WriteLine("27: Gruul Anarch");
                Console.WriteLine("28: Guild Artisan");
                Console.WriteLine("29: Guild Merchant");
                Console.WriteLine("30: Haunted One");
                Console.WriteLine("31: Hermit");
                Console.WriteLine("32: House Agent");
                Console.WriteLine("33: Inheritor");
                Console.WriteLine("34: Investigator");
                Console.WriteLine("35: Izzet Engineer");
                Console.WriteLine("36: Knight");
                Console.WriteLine("37: Kinght of the Order");
                Console.WriteLine("38: Lorehold Student");
                Console.WriteLine("39: Marine");
                Console.WriteLine("40: Mercenary Veteran");
                Console.WriteLine("41: Noble");
                Console.WriteLine("42: Orzhov Representative");
                Console.WriteLine("43: Outlander");
                Console.WriteLine("44: Pirate");
                Console.WriteLine("45: Plaintiff");
                Console.WriteLine("46: Prismari Student");
                Console.WriteLine("47: Quandrix Student");
                Console.WriteLine("48: Rakdos Cultist");
                Console.WriteLine("49: Rival Intern");
                Console.WriteLine("50: Sage");
                Console.WriteLine("51: Sailor");
                Console.WriteLine("52: Selesnya Initiate");
                Console.WriteLine("53: Shipwright");
                Console.WriteLine("54: Silverquill Student");
                Console.WriteLine("55: Simic Scientist");
                Console.WriteLine("56: Smuggler");
                Console.WriteLine("57: Soldier");
                Console.WriteLine("58: Spy");
                Console.WriteLine("59: Urban Bounty Hunter");
                Console.WriteLine("60: Urchin");
                Console.WriteLine("61: Uthgardt Tribe Member");
                Console.WriteLine("62: Volstrucker Agent");
                Console.WriteLine("63: Waterdhavian Noble");
                Console.WriteLine("64: Witchlight Hand");
                Console.WriteLine("65: Witherbloom Student");

            //Doesn't loop when invalid selection is passed through.Accepts whatever is typed
            string characterBackground = Console.ReadLine();
            switch (characterBackground)
            {
                case "1": characterBackground = "Acolyte";
                    break;
                case "2": characterBackground = "Anthropologist";
                    break;
                case "3": characterBackground = "Archaeologist";
                    break;
                case "4": characterBackground = "Athlete";
                    break;
                case "5": characterBackground = "Azorius Functionary";
                    break;
                case "6": characterBackground = "Boros Legionnaire";
                    break;
                case "7": characterBackground = "Celebrity Adventurer's Scoin";
                    break;
                case "8": characterBackground = "Charlata";
                    break;
                case "9": characterBackground = "City Watch";
                    break;
                case "10": characterBackground = "Clan Crafter";
                    break;
                case "11": characterBackground = "Cloistered Scholar";
                    break;
                case "12": characterBackground = "Courtier";
                    break;
                case "13": characterBackground = "Criminal";
                    break;
                case "14": characterBackground = "Dimir Operative";
                    break;
                case "15": characterBackground = "Entertainer";
                    break;
                case "16": characterBackground = "Faceless";
                    break;
                case "17": characterBackground = "Faction Agent";
                    break;
                case "18": characterBackground = "Failed Merchant";
                    break;
                case "19": characterBackground = "Far Traveler";
                    break;
                case "20": characterBackground = "Feylost";
                    break;
                case "21": characterBackground = "Fisher";
                    break;
                case "22": characterBackground = "Folk Hero";
                    break;
                case "23": characterBackground = "Gambler";
                    break;
                case "24": characterBackground = "Gladiator";
                    break;
                case "25": characterBackground = "Golgari Agent";
                    break;
                case "26": characterBackground = "Grinner";
                    break;
                case "27": characterBackground = "Gruul Anarch";
                    break;
                case "28": characterBackground = "Guild Artisan";
                    break;
                case "29": characterBackground = "Guild Merchan";
                    break;
                case "30": characterBackground = "Haunted One";
                    break;
                case "31": characterBackground = "Hermit";
                    break;
                case "32": characterBackground = "House Agent";
                    break;
                case "33": characterBackground = "Inheritor";
                    break;
                case "34": characterBackground = "Investigator";
                    break;
                case "35": characterBackground = "Izzet Engineer";
                    break;
                case "36": characterBackground = "Knight";
                    break;
                case "37": characterBackground = "Kinght of the Order";
                    break;
                case "38": characterBackground = "Lorehold Student";
                    break;
                case "39": characterBackground = "Marine";
                    break;
                case "40": characterBackground = "Mercenary Veteran";
                    break;
                case "41": characterBackground = "Noble";
                    break;
                case "42": characterBackground = "Orzhov Representative";
                    break;
                case "43": characterBackground = "Outlander";
                    break;
                case "44": characterBackground = "Pirate";
                    break;
                case "45": characterBackground = "Plantiff";
                    break;
                case "46": characterBackground = "Prismari Student";
                    break;
                case "47": characterBackground = "Quandrix Student";
                    break;
                case "48": characterBackground = "Rakdos Cultist";
                    break;
                case "49": characterBackground = "Rival Intern";
                    break;
                case "50": characterBackground = "Sage";
                    break;
                case "51": characterBackground = "Sailor";
                    break;
                case "52": characterBackground = "Selesnya Initiate";
                    break;
                case "53": characterBackground = "Shipwright";
                    break;
                case "54": characterBackground = "Silverquill Student";
                    break;
                case "55": characterBackground = "Simic Scientist";
                    break;
                case "56": characterBackground = "Smuggler";
                    break;
                case "57": characterBackground = "Soldier";
                    break;
                case "58": characterBackground = "Spy";
                    break;
                case "59": characterBackground = "Urban Bounty Hunter";
                    break;
                case "60": characterBackground = "Urchin";
                    break;
                case "61": characterBackground = "Uthgardt Tribe Member";
                    break;
                case "62": characterBackground = "Volstrucker Agent";
                    break;
                case "63": characterBackground = "Waterdhavian Noble";
                    break;
                case "64": characterBackground = "Witchlight Hand";
                    break;
                case "65": characterBackground = "Witherbloom Student";
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }


            //Same issue as characterLevel.How can I make this accept ONLY numbers? It should return an error otherwise. Currently the app crashes.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    What is your current EXP?      ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            
            int characterEXP = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("        What is your race?         ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Aarakocra");
                Console.WriteLine("2. Aasimar");
                Console.WriteLine("3. Bugbear");
                Console.WriteLine("4. Centaur");
                Console.WriteLine("5. Changeling");
                Console.WriteLine("6. Dragonborn");
                Console.WriteLine("7. Dwarf");
                Console.WriteLine("8. Elf");
                Console.WriteLine("9. Fairy");
                Console.WriteLine("10. Feral Tiefling");
                Console.WriteLine("11. Firbolg");
                Console.WriteLine("12. Genasi");
                Console.WriteLine("13. Gith");
                Console.WriteLine("14. Gnome");
                Console.WriteLine("15. Goblin");
                Console.WriteLine("16. Goliath");
                Console.WriteLine("17. Grung");
                Console.WriteLine("18. Half Elf");
                Console.WriteLine("19. Half Orc");
                Console.WriteLine("20. Halfling");
                Console.WriteLine("21. Harengon");
                Console.WriteLine("22. Hobgoblin");
                Console.WriteLine("23. Human");
                Console.WriteLine("24. Kalashtar");
                Console.WriteLine("25. Kenku");
                Console.WriteLine("26. Kobold");
                Console.WriteLine("27. Leonin");
                Console.WriteLine("28. Lineages");
                Console.WriteLine("29. Lizardfolk");
                Console.WriteLine("30. Locathah");
                Console.WriteLine("31. Loxodon");
                Console.WriteLine("32. Minotaur");
                Console.WriteLine("33. Orc");
                Console.WriteLine("34. Orc of Eberron");
                Console.WriteLine("35. Orc of Exandria");
                Console.WriteLine("36. Owlin");
                Console.WriteLine("37. Satyr");
                Console.WriteLine("38. Shifter");
                Console.WriteLine("39. Simic Hybrid");
                Console.WriteLine("40. Tabaxi");
                Console.WriteLine("41. Tiefling");
                Console.WriteLine("42. Tortle");
                Console.WriteLine("43. Triton");
                Console.WriteLine("44. Vedalken");
                Console.WriteLine("45. Verdan");
                Console.WriteLine("46. Warforged");
                Console.WriteLine("47. Yuanti Pureblood");

            //Doesn't loop when invalid selection is passed through.Accepts whatever is typed
            string characterRace = Console.ReadLine();
            switch (characterRace)
            {
                case "1": characterRace = "Aarakocra";
                    break;
                case "2": characterRace = "Aasimar";
                    break;
                case "3": characterRace = "Bugbear";
                    break;
                case "4": characterRace = "Centaur";
                    break;
                case "5": characterRace = "Changeling";
                    break;
                case "6": characterRace = "Dragonborn";
                    break;
                case "7": characterRace = "Dwarf";
                    break;
                case "8": characterRace = "Elf";
                    break;
                case "9": characterRace = "Fairy";
                    break;
                case "10": characterRace = "Feral Tiefling";
                    break;
                case "11": characterRace = "Firbolg";
                    break;
                case "12": characterRace = "Genasi";
                    break;
                case "13": characterRace = "Gith";
                    break;
                case "14": characterRace = "Gnome";
                    break;
                case "15": characterRace = "Goblin";
                    break;
                case "16": characterRace = "Goliath";
                    break;
                case "17": characterRace = "Grung";
                    break;
                case "18": characterRace = "Half Elf";
                    break;
                case "19": characterRace = "Half Orc";
                    break;
                case "20": characterRace = "Halfling";
                    break;
                case "21": characterRace = "Harengon";
                    break;
                case "22": characterRace = "Hobgoblin";
                    break;
                case "23": characterRace = "Human";
                    break;
                case "24": characterRace = "Kalashtar";
                    break;
                case "25": characterRace = "Kenku";
                    break;
                case "26": characterRace = "Kobold";
                    break;
                case "27": characterRace = "Leonin";
                    break;
                case "28": characterRace = "Lineages";
                    break;
                case "29": characterRace = "Lizardfolk";
                    break;
                case "30": characterRace = "Locathah";
                    break;
                case "31": characterRace = "Loxodon";
                    break;
                case "32": characterRace = "Minotaur";
                    break;
                case "33": characterRace = "Orc";
                    break;
                case "34": characterRace = "Orc of Eberron";
                    break;
                case "35": characterRace = "Orc of Exandria";
                    break;
                case "36": characterRace = "Owlin";
                    break;
                case "37": characterRace = "Satyr";
                    break;
                case "38": characterRace = "Shifter";
                    break;
                case "39": characterRace = "Simic Hybrid";
                    break;
                case "40": characterRace = "Tabaxi";
                    break;
                case "41": characterRace = "Tiefling";
                    break;
                case "42": characterRace = "Tortle";
                    break;
                case "43": characterRace = "Triton";
                    break;
                case "44": characterRace = "Vedalken";
                    break;
                case "45": characterRace = "Verdan";
                    break;
                case "46": characterRace = "Warforged";
                    break;
                case "47": characterRace = "Yuanti Pureblood";
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("        What is your class?        ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Barbarian");
                Console.WriteLine("2. Bard");
                Console.WriteLine("3. Cleric");
                Console.WriteLine("4. Druid");
                Console.WriteLine("5. Fighter");
                Console.WriteLine("6. Monk");
                Console.WriteLine("7. Paladin");
                Console.WriteLine("8. Ranger");
                Console.WriteLine("9. Rogue");
                Console.WriteLine("10. Sorcerer");
                Console.WriteLine("11. Warlock");
                Console.WriteLine("12. Wizard");
                Console.WriteLine("13. Artificer");

            //Doesn't loop when invalid selection is passed through.Accepts whatever is typed
            string characterClass = Console.ReadLine();
            switch (characterClass)
            {
                case "1": characterClass = "Barbarian";
                    break;
                case "2": characterClass = "Bard";
                    break;
                case "3": characterClass = "Cleric";
                    break;
                case "4": characterClass = "Druid";
                    break;
                case "5": characterClass = "Fighter";
                    break;
                case "6": characterClass = "Monk";
                    break;
                case "7": characterClass = "Paladin";
                    break;
                case "8": characterClass = "Rogue";
                    break;
                case "9": characterClass = "Sorcerer";
                    break;
                case "10": characterClass = "Warlock";
                    break;
                case "11": characterClass = "Wizard";
                    break;
                case "12": characterClass = "Artificer";
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }

            Character character = new Character(playerName, characterName, characterBackground, characterAlignment, characterLevel, characterEXP, characterRace, characterClass);
            characters.Add(character);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" You have created a new character! ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;

        }

        
        private static void ReviewCharacter()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("           Characters              ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            characters.ForEach(character =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(character.CharacterName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Player: {character.PlayerName}");
                Console.WriteLine($"Level: {character.CharacterLevel}; EXP:{character.CharacterEXP}");
                Console.WriteLine($"Class: {character.CharacterClass}");
                Console.WriteLine($"Race: {character.CharacterRace}");
                Console.WriteLine($"Background: {character.CharacterBackground}");
                Console.WriteLine($"Alignment: {character.CharacterAlignment}");
                Console.WriteLine();
                Console.WriteLine();
               
            });
            
        }
    }
}
