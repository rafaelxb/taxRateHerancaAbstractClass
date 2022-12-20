
namespace taxRate.Entities
{
    internal class Individual : Payer
    {
        public double ExpendHealth { get; set; }

        public Individual(string name, double annualIncome, double expendHealth) : base(name, annualIncome)
        {
            ExpendHealth = expendHealth;
        }

        public override double taxesPaid()
        {
            double taxToPay;

            if (AnnualIncome >= 20000)
            {
                taxToPay = (AnnualIncome * 0.25) - (ExpendHealth * 0.50);
            }
            else
            {
                taxToPay = AnnualIncome * 0.15;
            }

            return taxToPay;
        }
    }
}
