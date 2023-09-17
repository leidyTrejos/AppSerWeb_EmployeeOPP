// Referenciar y usar
using EmployeeOPP.Clases;

try
{
    Console.WriteLine("OPP Aplication");
    Console.WriteLine("--------------");

    int day, month, year;
    string firstName, lastName;
    decimal salary;

    Console.Write("Ingresar el díá: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());


    //Inicializacion de la clase date

    //crear un objeto a partir de la clase
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

    //CLASE SALARY EMPLOYEE
    //Creacion de objetos por medio de hardCoding
    Console.Write("Ingresar nombre: ");
    firstName = Console.ReadLine();

    Console.Write("Ingresar apellidos: ");
    lastName = Console.ReadLine();

    Console.Write("Ingresar salario devengado: ");
    salary = decimal.Parse(Console.ReadLine());

    //HardCoding = Quemar codigo
    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {
        //Defino propiedades que se encuentran en la clase padre y en la misma clase
        Id = 123456,
        FirstName = Console.ReadLine(),
        LastName = Console.ReadLine(),
        Birthdate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = Decimal.Parse(Console.ReadLine()),
    };

    //Mostramos el objeto - el ToString() viene por default
    Console.WriteLine(salaryEmployee);

    //CLASE HOURLY EMPLOYEE
    HourlyEmployee hourlyEmployee = new HourlyEmployee()
    {
        //Defino propiedades que se encuentran en la clase padre y en la misma clase
        Id = 123456,
        FirstName = Console.ReadLine(),
        LastName = Console.ReadLine(),
        Birthdate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Hours = 3,
        HourValue = 15000
    };

    //Mostramos el objeto
    Console.WriteLine(hourlyEmployee);


    //CLASE HOURLY EMPLOYEE
    BaseCommissionEmployee BaseCommissionEmployee = new BaseCommissionEmployee()
    {
        //Defino propiedades que se encuentran en la clase padre y en la misma clase
        Id = 123456,
        FirstName = Console.ReadLine(),
        LastName = Console.ReadLine(),
        Birthdate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        CommissionPercentaje= 19,
        Sales= 2,
        Base= 1000000
    };

    //Mostramos el objeto
    Console.WriteLine(BaseCommissionEmployee);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

