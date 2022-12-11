
namespace Demo
{
  internal class Utilities
  {

    public static int CalculateYearLyWage(int monthyWage, int numberOfMonthsWorked)
    {
      Console.WriteLine($"Yearly wage: {monthyWage * numberOfMonthsWorked}");

      if (numberOfMonthsWorked == 23)
        return monthyWage * (numberOfMonthsWorked + 1);

      return monthyWage * numberOfMonthsWorked;
    }

  }
}