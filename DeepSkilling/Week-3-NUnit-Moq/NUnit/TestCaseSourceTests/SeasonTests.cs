using NUnit.Framework;

namespace NUnitDemo.TestCaseSourceTests
{
    [TestFixture]
    public class SeasonTests
    {
        private Season season;

        [SetUp]
        public void Setup()
        {
            season = new Season();
        }

        [TestCaseSource(typeof(Season), nameof(Season.SeasonData))]
        public string GetSeason_Test(int month)
        {
            return season.GetSeason(month);
        }
    }
}
