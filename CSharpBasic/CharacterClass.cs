using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic
{
    class CharacterClass
    {
        public string CharacterName;
        public int level;
        public string race;
        public double hitPoints;
        public string Class;
        public bool inGuild;

        public void CharacterSelect()
        {
            if (level >= 100)
            {
                Console.WriteLine($"Welcome {CharacterName}. You are mighty {Class}, of the {race} people. You must be a hard one to defeat with {hitPoints} hit points.");
            }
            else if(level >= 50){
                Console.WriteLine($"Welcome {CharacterName}. You are a growing young {race}.");

            }
            else
            {
                if (inGuild == true)
                {
                    Console.WriteLine("cool you're in a guild...");
                }
                else
                {
                    Console.WriteLine("You're about to be jumped, you ain't in a guild.");
                }
            }
        }
    }
}
