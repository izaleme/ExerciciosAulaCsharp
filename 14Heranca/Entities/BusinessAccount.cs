namespace Couse14Heranca.Entities
{
    class BusinessAccount : Account
    {
        #region  Attributes/Properties

        public double LoanLimit { get; set; }

        #endregion

        #region  Builders

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance) // reaproveitamento o código do construtor da classe account
        {
            LoanLimit = loanLimit;
        }

        #endregion

        #region  Methods

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
                Balance += amount;
        }

        #endregion
    }
}