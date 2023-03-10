using System;
using System.Collections.Generic;

class TaxEstimator
{
    static void Main(string[] args)
    {
        // Constants for tax brackets
        var taxBrackets = new Dictionary<string, Tuple<double, double>>
        {
            {"10%", Tuple.Create(0.0, 9700.0)},
            {"12%", Tuple.Create(9701.0, 39475.0)},
            {"22%", Tuple.Create(39476.0, 84200.0)},
            {"24%", Tuple.Create(84201.0, 160725.0)},
            {"32%", Tuple.Create(160726.0, 204100.0)},
            {"35%", Tuple.Create(204101.0, 510300.0)},
            {"37%", Tuple.Create(510301.0, double.PositiveInfinity)},
        };

        // Standard deduction for single filers
        var standardDeduction = 12_950.0;

        // Ask the user for the number of W2s they have
        Console.Write("How many W2s do you have? ");
        var numW2s = int.Parse(Console.ReadLine());

        // Loop through and total the user's gross income from each W2
        var grossIncome = 0.0;
        for (var i = 0; i < numW2s; i++)
        {
            Console.Write($"Enter the gross income from W2 #{i + 1}: ");
            var w2Income = double.Parse(Console.ReadLine());
            grossIncome += w2Income;
        }

        // Ask the user for deductions until they're done entering values
        var deductions = 0.0;
        while (true)
        {
            Console.Write("Enter a deduction (or type 'done' to stop): ");
            var input = Console.ReadLine();
            if (input == "done") break;
            deductions += double.Parse(input);
        }

        // Use the standard deduction if the user's total deductions are less than it
        if (deductions < standardDeduction) deductions = standardDeduction;

        // Calculate the user's adjusted gross income
        var adjustedGrossIncome = grossIncome - deductions;

        // Calculate taxes owed at each bracket
        var taxesOwed = 0.0;
        foreach (var bracket in taxBrackets)
        {
            var lowerBound = bracket.Value.Item1;
            var upperBound = bracket.Value.Item2;
            if (adjustedGrossIncome > upperBound)
                taxesOwed += (upperBound - lowerBound) * double.Parse(bracket.Key.TrimEnd('%')) / 100;
            else
            {
                taxesOwed += (adjustedGrossIncome - lowerBound) * double.Parse(bracket.Key.TrimEnd('%')) / 100;
                break;
            }
        }

        // Display taxes owed at each bracket, even if it's $0
        foreach (var bracket in taxBrackets)
        { }
    }
}
