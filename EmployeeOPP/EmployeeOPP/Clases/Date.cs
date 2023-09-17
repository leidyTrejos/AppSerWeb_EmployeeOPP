using System.Runtime.Serialization;

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
        public Date(int day, int month, int year)
        {
            _year = validateYear(year);
            _month = validateMonth(month);
            _day = validateDay(day, month, year);
        }

        private int validateDay(int day, int month, int year)
        {
            //valido si ek dia ingresado pertenece a un año bisiesto
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }

            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                bool isLeapYear = false;
                IsLeapYearException(isLeapYear, year);
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }
            else
            {
                //Exeception creation
                throw new DayException(String.Format("El dia {0} no es valido para el mes {1}", day, month));
            }
        }

        private void IsLeapYearException(bool isLeapYear, int year)
        {
            if (!isLeapYear)
            {
                //Exeception creation
                throw new YearException(String.Format("El año {0} es biciesto", year));
            }

        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        //validate year
        private int validateYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            else
            {
                //Exeception creation
                throw new YearException(String.Format("El año {0} no es válido", year));
            }
        }

        //Validar mes
        private int validateMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }
            else
            {
                //Exeception creation, las exepciones siempre se lanzan
                throw new MonthException(String.Format("El mes {0} no es válido", month));
            }
        }

        public override string ToString()
        {
            //dia/mes/año

            //Concatenacion basica
            //string dateConcatenated = _day + "/" + _month + "/" + _year;

            //Concatenacion en interpolacion
            //string dateConcatenated = $"{_day:00}/{_month:00}/{_year:0000}";

            //Concatenacion con la clase String.Format
            string dateConcatenated = String.Format("{0:00}/{1:00}/{2:00}", _day, _month, _year);

            //retorno
            return dateConcatenated;
        }

        #endregion
    }

    [Serializable]
    internal class DayException : Exception
    {
        public DayException()
        {
        }

        public DayException(string? message) : base(message)
        {
        }

        public DayException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DayException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
