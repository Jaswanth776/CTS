using System.Collections;

namespace NUnitDemo.TestCaseSourceTests
{
    public class Season
    {
        public static IEnumerable SeasonData()
        {
            yield return new TestCaseData(3).Returns("Spring");
            yield return new TestCaseData(6).Returns("Summer");
            yield return new TestCaseData(9).Returns("Autumn");
            yield return new TestCaseData(12).Returns("Winter");
        }

        public string GetSeason(int month)
        {
            if (month >= 3 && month <= 5)
                return "Spring";

            if (month >= 6 && month <= 8)
                return "Summer";

            if (month >= 9 && month <= 11)
                return "Autumn";

            return "Winter";
        }
    }
}
