namespace Couse14Heranca.Entities
{
    class SavingsAccount : Account   // herdando da classe account
    {
        #region  Attributes/Properties

        public double InterestRate { get; set; }

        #endregion

        #region  Builders

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        #endregion

        #region  Methods

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        #endregion
    }
}
