
int amount = 1234;
int months = 12;

int yearlyWage = CalculateYearLyWage(amount, months);

Console.Write($"Yearly wage: {yearlyWage}");

Console.ReadLine();

static int CalculateYearLyWage(int monthyWage, int numberOfMonthsWorked)
{
  Console.WriteLine($"Yearly wage: {monthyWage * numberOfMonthsWorked}");

  return monthyWage * numberOfMonthsWorked;
}