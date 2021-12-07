/* >>> CLASS TAXPAYER <<< */
namespace Aula137_ExFixacao.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; private set; }
        public double AnnualIncome { get; private set; }

        protected TaxPayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Taxes();
    }
}
