/* >>> CLASS COMPANY <<< */
namespace Aula137_ExFixacao.Entities
{
    class Company : TaxPayer
    {
        public int Empoloyees { get; private set; }

        public Company(int employees, string name, double annualIncome) : base(name, annualIncome)
        {
            Empoloyees = employees;
        }

        public override double Taxes()
        {
            if (Empoloyees <= 10)
            {
                return AnnualIncome * 0.16;
            }
            else
            {
                return AnnualIncome * 0.14;
            }
        }
    }
}
