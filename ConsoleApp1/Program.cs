using MyLibrary;
using System.Net;

Secretary Maria = new Secretary();
Maria.Name = "Maria";
Manager Pedro = new Manager();
Pedro.Name = "Pedro";
Developer Miguel = new Developer();

WriteEmployeeinfo(Maria);
WriteEmployeeinfo(Pedro);
WriteEmployeeinfo(Miguel);


void WriteEmployeeinfo(Employee employee)
{
    Console.WriteLine($"{employee.Name}: {employee.CalculateMonthlyPayment()}");
}
