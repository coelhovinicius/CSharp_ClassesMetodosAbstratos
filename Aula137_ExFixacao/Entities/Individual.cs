/* >>> CLASS INDIVIDUAL <<< */
namespace Aula137_ExFixacao.Entities
{
    class Individual : TaxPayer
    {
        public double HealthCosts { get; private set; }

        public Individual(string name, double annualIncome, double healthCosts) : base(name, annualIncome)
        {
            HealthCosts = healthCosts;
        }

        public override double Taxes()
        {
            if (AnnualIncome < 20000.00)
            {
                return AnnualIncome * 0.15 - HealthCosts * 0.5;                
            }
            else
            {
                return AnnualIncome * 0.25 * 0.5;
            }
        }
    }
}
