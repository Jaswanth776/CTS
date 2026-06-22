namespace NUnitDemo.LeapYearTests
{
    public class LeapYearChecker
    {
        public bool IsLeapYear(int year)
        {
            return (year % 400 == 0) ||
                   (year % 4 == 0 && year % 100 != 0);
        }
    }
}
