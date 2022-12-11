
namespace Demo
{
  internal class Utilities
  {

    public static void UsingEscapeCharacters()
    {

      string firstName = "Regis";
      string lastName = "Atemengue";

      string displayName = $"Welcome!\n{firstName}\t{lastName}";
      Console.WriteLine(displayName);

      string filePath = "C:\\data\\employeeLIist.xlsx";

      string filePath2 = @"C:\data\employeelist.xlsx";



    }


    public static void ManipulationStrings()
    {
      string firstName = "Bethamy";
      string lastName = "Smith";

      string fullName = firstName + " " + lastName;
      string employeeIdentification = String.Concat(firstName, lastName);

      string empId = firstName.ToLower() + "-" + lastName.Trim().ToLower();

      int length = empId.Length;

      if (fullName.Contains("beth") || fullName.Contains("Beht"))
      {
        // Console.WriteLine
      }

      string subString = fullName.Substring(1, 3);
      Console.WriteLine("Characteres 2 to 4 of fullName are " + subString);

      string userNameWithInterpolation = $"{firstName} = {lastName}";

    }

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