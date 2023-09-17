namespace EmployeeOPP.Clases
{
    public abstract class Employee
    {
        #region Properties
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Date? Birthdate { get; set; }
        public Date? HiringDate { get; set; }
        public bool? IsActive { get; set; }

        #endregion

        #region Methods
        public abstract decimal GetValueToPay();
        public override string ToString()
        {
            return $"Información empleado \n\t" +
                $"ID: {Id}\n\t" +
                $"Nombres: {FirstName}\n\t" +
                $"Apellidos: {LastName}\n\t" +
                $"Fecha de cumpleaños: {Birthdate}\n\t" +
                $"Fecha de Contratación: {HiringDate}\n\t" +
                $"¿Empleado activo?: {IsActive}\n\t";
        }
        #endregion

    }
}
