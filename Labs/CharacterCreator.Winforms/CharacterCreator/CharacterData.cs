using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class CharacterData
    {
        public CharacterData() : this(true)
        { }

        public CharacterData(bool seed) : this(GetSeedCharacter(seed))
        { }

        public CharacterData(Character[] character)
        {
            _items.AddRange(character);
        }

        //default characters
        private static Character[] GetSeedCharacter(bool seed)
        {
            if (!seed)
                return new Character[0];

            return new Character[] {
                new Character()
                {
                    Name = "BaldHammer",
                    Profession = "Hunter",
                    Race = "Dwarf",
                    Strength = 90,
                    Agility = 30,
                    Charisma = 70,
                    Intelligence = 40,
                    Constitution = 80,
                    Description = "",
                },
                new Character()
                {
                    Name = "Solaris",
                    Profession = "Rogue",
                    Race = "Elf",
                    Strength = 30,
                    Agility = 80,
                    Charisma = 40,
                    Intelligence = 70,
                    Constitution = 90,
                    Description = "",
                },
                new Character()
                {
                    Name = "Gadget",
                    Profession = "Wizard",
                    Race = "Gnome",
                    Strength = 40,
                    Agility = 30,
                    Charisma = 90,
                    Intelligence = 80,
                    Constitution = 70,
                    Description = "",
                },
                new Character()
                {
                    Name = "Moonkin",
                    Profession = "Priest",
                    Race = "Half Elf",
                    Strength = 70,
                    Agility = 90,
                    Charisma = 40,
                    Intelligence = 80,
                    Constitution = 30,
                    Description = "",
                },
                new Character()
                {
                    Name = "Leroy",
                    Profession = "Fighter",
                    Race = "Human",
                    Strength = 80,
                    Agility = 70,
                    Charisma = 90,
                    Intelligence = 40,
                    Constitution = 30,
                    Description = "",
                },
            };
        }

        public Character[] GetAll()
        {
            var count = _items.Count;

            var temp = new Character[count];
            var index = 0;
            foreach (var character in _items)
            {
                temp[index++] = character;
            };

            return temp;
        }

        private Character FindCharacter(string name)
        {
            var pairs = new Dictionary<string, Character>();

            foreach (var character in _items)
            {
                if (String.Compare(name, character.Name, true) == 0)
                    return character;
            };

            return null;
        }

        //helpers
        public void AddCharacter(Character character)
        {
            _items.Add(character);
        }

        public void RemoveCharacter(string name)
        {
            var character = FindCharacter(name);
            if (character != null)
                _items.Remove(character);
        }

        public void EditCharacter(string name, Character character)
        {
            RemoveCharacter(name);

            AddCharacter(character);
        }

        //list of characters
        private List<Character> _items = new List<Character>();
    }
}
