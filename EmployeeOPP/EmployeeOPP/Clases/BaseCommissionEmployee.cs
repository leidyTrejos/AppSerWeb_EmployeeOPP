using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOPP.Clases
{
    public class BaseCommissionEmployee: ComissionEmployee
    {
        #region Properties
        public decimal Base { get; set; }
        #endregion

        #region Methods
        public BaseCommissionEmployee() { }
        public override decimal GetValueToPay()
        {
            return ((CommissionPercentaje / 100) * Sales) + Base;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salario base + Comisiones: {((CommissionPercentaje / 100) * Sales):C2}\n\t";
        }
        #endregion
    }
}
