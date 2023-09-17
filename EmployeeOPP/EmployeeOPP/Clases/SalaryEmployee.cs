namespace EmployeeOPP.Clases
{
    internal class SalaryEmployee : Employee
    {
        #region Properties
        //El tipo de dato decimal es propio de decimal, es para valores monetarios
        public decimal Salary { get; set; }
        #endregion

        #region Methods
        public SalaryEmployee() {}
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            //base - se refiere a la clase padre
            return $"{base.ToString()}" + 
                $"Salario Devengado: {Salary:C2}\n\t";
        }
        #endregion

    }
}
