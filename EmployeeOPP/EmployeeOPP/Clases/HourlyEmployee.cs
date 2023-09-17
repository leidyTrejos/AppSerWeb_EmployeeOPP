using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOPP.Clases
{
    public class HourlyEmployee : Employee
    {
        #region Properties
        public int Hours { get; set; }
        public decimal HourValue { get; set; }
        #endregion

        #region Methods
        public HourlyEmployee(){}
        public override decimal GetValueToPay()
        {
            return Hours * HourValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Horas: {Hours}\n\t"+
                $"Valor de la hora: {HourValue}\n\t" +
                $"Salario Devengado: {HourValue * Hours:C2}\n\t";
        }
        #endregion
    }
}
