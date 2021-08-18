using System.Collections.Generic;

namespace CoinInsertionManagerPractice
{
    public class Coin
    {
        public string Name { get; }
        public double DiameterInMillimeters { get; private set; }
        public double WeightInGrams { get; private set; }
        public double ValueInCents { get; private set; }

        public Coin(string name, double diameterInMillimeters, double weightInGrams, double valueInCents)
        {
            Name = name;
            DiameterInMillimeters = diameterInMillimeters;
            WeightInGrams = weightInGrams;
            ValueInCents = valueInCents;
        }
    }
    
    public static class ValidCoins
    {
        public static readonly List<Coin> Coins = new List<Coin>()
        {
            new Coin("Nickel", 21.21, 5, .05),
            new Coin("Dime", 17.9, 2.268, .10),
            new Coin("Quarter", 24.26, 5.67, .25)
        };
        
        
    } 
}