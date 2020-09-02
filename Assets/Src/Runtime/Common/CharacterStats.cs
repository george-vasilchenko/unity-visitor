namespace Assets.Src.Runtime.Common
{
    public struct CharacterStats
    {
        public int Agility;
        public int Intelligence;
        public int Strength;

        public static CharacterStats CreateFromOtherWithDeltas(
            CharacterStats other,
            CharacterStats deltas) => new CharacterStats(other, deltas);

        public static CharacterStats CreateFromOther(CharacterStats other) => new CharacterStats(other);

        private CharacterStats(
            CharacterStats source,
            CharacterStats deltas) : this(source)
        {
            this.Agility += deltas.Agility;
            this.Intelligence += deltas.Intelligence;
            this.Strength += deltas.Strength;
        }

        private CharacterStats(CharacterStats source)
        {
            this.Agility = source.Agility;
            this.Intelligence = source.Intelligence;
            this.Strength = source.Strength;
        }
    }
}