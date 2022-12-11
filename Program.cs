using DRH_MINADER;


Console.WriteLine("Creating Employeee");
Console.WriteLine("------------------------");



Employee regis = new Employee("Atemengue", "Regis", "moafembe@gmail", new DateTime(1994, 4, 11));

regis.DisplayEmployeeDetails();

regis.PerformWork();
regis.PerformWork();
regis.PerformWork(5);
regis.PerformWork();

double receivedWageRegis = regis.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {receivedWageRegis}");


Console.WriteLine("Creating Employeee");
Console.WriteLine("------------------------");


Employee eric = new("Eric", "Okala", "ericokala@gmail.com", new DateTime(1990, 4, 12), 30);

eric.DisplayEmployeeDetails();
eric.PerformWork();
eric.PerformWork();
eric.PerformWork(3);
eric.PerformWork();
eric.PerformWork(8);

var receivedWageEric = eric.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {receivedWageEric}");

