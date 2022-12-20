
using System.Globalization;
using taxRate.Entities;

List<Payer> payers = new List<Payer>();

Console.Write("Enter the number of tax payers: ");
int payerNumber = int.Parse(Console.ReadLine());

for(int i = 1; i <= payerNumber; i++)
{
    Console.WriteLine($"Tax payer #{i} data:");
    Console.Write("Individual or company (i/c)?");
    char payerType = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Annual income: ");
    double annualIncome = double.Parse(Console.ReadLine());

    if (payerType == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpends = double.Parse(Console.ReadLine());
        payers.Add(new Individual(name,annualIncome,healthExpends));
    }
    else
    {
        Console.Write("Number of employees: ");
        int employeeQtt = int.Parse(Console.ReadLine());
        payers.Add(new Company(name, annualIncome, employeeQtt));
    }
}

Console.WriteLine("TAXES PAID:");

double totalTaxes = 0;

foreach(Payer payer in payers)
{
    Console.WriteLine($"{payer.Name}: $ {payer.taxesPaid().ToString("F2",CultureInfo.InvariantCulture)}");

    totalTaxes += payer.taxesPaid();
}

Console.WriteLine($"TOTAL TAXES: $ {totalTaxes.ToString("F2",CultureInfo.InvariantCulture)}");
