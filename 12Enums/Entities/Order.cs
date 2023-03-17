using System;
using Course12Enums.Entities.Enums;

namespace Course12Enums.Entities
{
    class Order
    {
        #region  Properties

        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        #endregion

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }

    }
}
