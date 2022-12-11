
namespace DRH_MINADER
{
  internal class Employee
  {
    public string firstName;
    public string lastName;
    public string email;

    public int numberOfHoursWorked;
    public double wage;
    public double hourlyRate;

    public DateTime birdthDay;

    public void PerformWork()
    {
      numberOfHoursWorked++;
      Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hoours(s)!");
    }

    public void PerformWork(int numberOfHours)
    {
      numberOfHoursWorked += numberOfHours;
      Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hoours(s)!");
    }

    public double ReceiveWage(bool resetHours = true)
    {
      wage = numberOfHoursWorked * hourlyRate;
      Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hours(s) of work");

      if (resetHours)
        numberOfHoursWorked = 0;

      return wage;
    }
    public void DisplayEmployeeDetails()
    {
      Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}\nBirthday: \t{birthDay.ToShortDateString()}\n");
    }

  }



}