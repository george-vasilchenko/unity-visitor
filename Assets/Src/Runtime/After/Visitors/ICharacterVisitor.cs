using Assets.Src.Runtime.After.Characters;

namespace Assets.Src.Runtime.After.Visitors
{
    public interface ICharacterVisitor<T>
    {
        T Visit(Archer archer);

        T Visit(Paladin paladin);

        T Visit(Mage mage);
    }
}