using System.ComponentModel;
using System.Xml;

namespace class_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            employee info =new employee();
            do
            {
                Console.WriteLine("1: isci elave et");
                Console.WriteLine("2: butun iscilere bax");
                Console.WriteLine("3: maas araligina gore iscileri axtaris et");
                Console.WriteLine("0: programdan cixis et");
                Console.WriteLine(choice = Console.ReadLine());
                switch (choice)
                {
                    case "1":
                        info.addEmployee();
                        break;
                        case "2":
                        info.showAllEmployee();
                        break;
                        case "3":
                        info.salaryrange();
                        break;
                        case "0":
                        Console.WriteLine("programdan cixis etdiniz");
                        break;
                        default: Console.WriteLine("yaxsisan? bele bir secimin yoxudr!");
                        break;

                }
            }while (choice != "0");
        }
    }
}
class employee
{
    public string employeeName;
    public string employeeSurname;
    public byte employeeAge;
    public double employeeSalary;
    public string departmentName;

    public void addEmployee()
    {
        Console.WriteLine("name: ");
        employeeName = Console.ReadLine();

        Console.WriteLine("surname: ");
        employeeSurname = Console.ReadLine();

        Console.WriteLine("age: ");
        employeeAge = Convert.ToByte(Console.ReadLine());

        Console.WriteLine("salary: ");
        employeeSalary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("department name: ");
        departmentName = Console.ReadLine();

        employee employee = new employee();
        employee.addEmployee();
        Console.WriteLine("Congratulations, added succesfully");

    }public void showAllEmployee()
    {
        Console.WriteLine("\nButun isciler:");
        Console.WriteLine($"name: {employeeName}");
        Console.WriteLine($"surname: {employeeSurname}");
        Console.WriteLine($"age: {employeeAge}");
        Console.WriteLine($"salary: {employeeSalary}");
        Console.WriteLine($"Departament name: {departmentName}");
    }public void salaryrange()
    {
        Console.WriteLine("minimum maas");
        double minSalary=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("maximum maas");
        double maxSalary=Convert.ToDouble(Console.ReadLine());
        if(employeeSalary>=minSalary && employeeSalary <= maxSalary)
        {
            Console.WriteLine("maas araligindaki isciler tapildi");
            showAllEmployee();
        }
        else
        {
            Console.WriteLine("bu maas araliginda isci yoxdur");
        }
    }

}
