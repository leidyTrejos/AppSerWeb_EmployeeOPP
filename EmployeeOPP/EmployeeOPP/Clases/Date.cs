using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOPP.Clases
{
    public class Date
    {
        #region Fiels

        //Formato Dia/mes/año
        private int _year;
        private int _month;
        private int _day;

        #endregion

        #region Methods
        public Date(int day, int month,int year)
        {
            _year = year;
            _month = month;
            _day = day;
        }

        public override string ToString() {
            //dia/mes/año

            //Concatenacion basica
            //string dateConcatenated = _day + "/" + _month + "/" + _year;

            //Concatenacion en interpolacion
            //string dateConcatenated = $"{_day}/{_month}/{_year}";

            //Concatenacion con la clase String.Format
            string dateConcatenated = String.Format("{0}/{1}/{2}", _day,_month,_year);
            
            //retorno
            return dateConcatenated;
        }

        #endregion
    }
}
