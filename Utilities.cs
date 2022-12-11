
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

    public static int CalculateYearLyWage(int monthyWage, int numberOfMonthsWorked, int bonus)
    {
      Console.WriteLine($"Yearly wage: {monthyWage * numberOfMonthsWorked + bonus}");
      return monthyWage * numberOfMonthsWorked + bonus;
    }

    public static int AddNumbers(int a, int b, int c = 100)
    {
      return a + b + c;
    }

    public static int CalculateYearLyWageExpressionBodied(int monthyWage, int numberOfMonthsWorked, int bonus)
     => monthyWage * numberOfMonthsWorked + bonus;


  }
}