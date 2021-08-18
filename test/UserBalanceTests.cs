using System.Linq;
using Xunit;
using FluentAssertions;

namespace CoinInsertionManagerPractice
{
    public class UserBalanceTests
    {
        private readonly UserBalance _userBalance = new UserBalance();
        private Coin quarter = ValidCoins.Coins.First(c => c.Name == "Quarter");

        [Fact]
        public void InsertQuarterUpdatesUserBalance()
        {
            _userBalance.AddFunds(Quarter());
            _userBalance.Balance.Should().Be(0.25);
        }
        
        [Fact]
        public void HeavyQuarterIsRejected()
        {

            var heavyQuarter = Quarter();
            heavyQuarter.WeightInGrams += 0.01;
            
            _userBalance.AddFunds(heavyQuarter);
            _userBalance.Balance.Should().Be(0.0);
        }
        
        [Fact]
        public void LargeQuarterIsRejected()
        {
            var largeQuarter = Quarter();
            largeQuarter.DiameterInMillimeters += 0.01;
            
            _userBalance.AddFunds(largeQuarter);
            _userBalance.Balance.Should().Be(0.0);
        }
        
        private InsertedCoin Quarter()
        {
            return new InsertedCoin(quarter.DiameterInMillimeters, quarter.WeightInGrams);
        }
        
    }
}