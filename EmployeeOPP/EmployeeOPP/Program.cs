// Referenciar y usar
using EmployeeOPP.Clases;

try
{
    Console.WriteLine("OPP Aplication");
    Console.WriteLine("--------------");

    int day, month, year;

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
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

