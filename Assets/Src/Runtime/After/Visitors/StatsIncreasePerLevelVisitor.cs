using System;
using Assets.Src.Runtime.After.Characters;
using Assets.Src.Runtime.Common;

namespace Assets.Src.Runtime.After.Visitors
{
    public class StatsIncreasePerLevelVisitor : ICharacterVisitor<CharacterStats>
    {
        public CharacterStats Visit(Archer archer)
        {
            switch (archer.Level)
            {
                case 2:
                    return new CharacterStats
                    {
                        Agility = 6,
                        Intelligence = 2,
                        Strength = 2
                    };

                case 3:
                    return new CharacterStats
                    {
                        Agility = 6,
                        Intelligence = 4,
                        Strength = 5
                    };

                default: throw new ArgumentOutOfRangeException("");
            }
        }

        public CharacterStats Visit(Paladin paladin)
        {
            switch (paladin.Level)
            {
                case 2:
                    return new CharacterStats
                    {
                        Agility = 2,
                        Intelligence = 2,
                        Strength = 6
                    };

                case 3:
                    return new CharacterStats
                    {
                        Agility = 3,
                        Intelligence = 2,
                        Strength = 10
                    };

                default: throw new ArgumentOutOfRangeException("");
            }
        }

        public CharacterStats Visit(Mage mage)
        {
            switch (mage.Level)
            {
                case 2:
                    return new CharacterStats
                    {
                        Agility = 3,
                        Intelligence = 5,
                        Strength = 2
                    };

                case 3:
                    return new CharacterStats
                    {
                        Agility = 3,
                        Intelligence = 9,
                        Strength = 3
                    };

                default: throw new ArgumentOutOfRangeException("");
            }
        }
    }
}