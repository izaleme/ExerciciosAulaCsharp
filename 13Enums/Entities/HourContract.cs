using System;

namespace Course13Enums.Entities
{
    class HourContract
    {
        #region Atributos/Properties

        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        #endregion

        #region Construtores

        public HourContract() { }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        #endregion

        #region Métodos

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }

        #endregion
    }
}
