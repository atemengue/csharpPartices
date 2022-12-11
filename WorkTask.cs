namespace DRH_MINADER
{
  internal struct WorkTask
  {
    public string description;
    public int hours;
    public int minutes;

    public void PerformWorkTask()
    {
      Console.WriteLine($"Task {description} of {hours} hours(s) has been performed.");
    }
  }
}