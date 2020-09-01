using Assets.Src.Runtime.Version2.Characters;

namespace Assets.Src.Runtime.Version2.Visitors
{
    public interface ICharacterVisitor<T>
    {
        T Visit(Archer archer);

        T Visit(Paladin paladin);

        T Visit(Mage mage);
    }
}