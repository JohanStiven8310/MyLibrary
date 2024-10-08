using MyLibrary;
using System.Net;

Employee Maria = new Secretary();
Maria.Name = "Maria";
Employee Pedro = new Manager();
Pedro.Name = "Pedro";
Developer Miguel = new Developer();
Console.WriteLine($"Dias;{Miguel.GetPaymentDays()}");

WriteEmployeeinfo(Maria);
WriteEmployeeinfo(Pedro);
WriteEmployeeinfo(Miguel);


void WriteEmployeeinfo(Employee employee)
{
    Console.WriteLine($"{employee.Name}: {employee.CalculateMonthlyPayment()}");
    Console.WriteLine($"Days;{employee.GetPaymentDays()}");
}

