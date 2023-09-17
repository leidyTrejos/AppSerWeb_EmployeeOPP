using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOPP.Clases
{
    public class ComissionEmployee: Employee
    {
        #region Properties
        public decimal CommissionPercentaje { get; set; }
        public int Sales { get; set; }
        #endregion

        #region Methods
        public ComissionEmployee() { }
        public override decimal GetValueToPay()
        {
            return ((CommissionPercentaje / 100) * Sales);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Porcentaje de comisión: {CommissionPercentaje}\n\t" +
                $"Ventas: {Sales}\n\t" +
                $"Comisiones Devengadas: {(CommissionPercentaje / 100) * Sales:C2}\n\t";
        }
        #endregion
    }
}
