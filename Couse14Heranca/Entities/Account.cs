namespace Couse14Heranca.Entities
{
    class Account
    {
        #region  Attributes/Properties

        public int Number { get; private set; }
        public string Holder { get; private set; }  // private só permite alteração na classe atual
        public double Balance { get; protected set; }   // protected só permite alteração desta classe ou de subclasses desta

        #endregion

        #region  Builders

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        #endregion

        #region  Methods



        #endregion
    }
}
