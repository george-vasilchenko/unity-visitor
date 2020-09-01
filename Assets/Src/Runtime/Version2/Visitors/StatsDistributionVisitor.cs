using Assets.Src.Runtime.Version2.Characters;

namespace Assets.Src.Runtime.Version2.Visitors
{
    public class StatsDistributionVisitor : ICharacterVisitor<StatsDistribution>
    {
        public StatsDistribution Visit(Archer archer)
        {
            return new StatsDistribution
            {
                AgilityPercentage = 0.5f,
                IntelligencePercentage = 0.25f,
                StrengthPercentage = 0.25f
            };
        }

        public StatsDistribution Visit(Paladin paladin)
        {
            return new StatsDistribution
            {
                AgilityPercentage = 0.2f,
                IntelligencePercentage = 0.2f,
                StrengthPercentage = 0.6f
            };
        }

        public StatsDistribution Visit(Mage mage)
        {
            return new StatsDistribution
            {
                AgilityPercentage = 0.3f,
                IntelligencePercentage = 0.6f,
                StrengthPercentage = 0.1f
            };
        }
    }
}