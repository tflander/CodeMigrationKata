namespace CoinInsertionManagerPractice
{
    public class UserBalance
    {
        public double Balance { get; private set; }

        public UserBalance()
        {
            Balance = 0.0;
        }
        
        // @Override
        // public void subtractFunds(String fundsToSubtractAsNumericStringRepresentingValueAsDouble) {
        //     BigDecimal fundsToSubtractAsDecimal = new BigDecimal(
        //         fundsToSubtractAsNumericStringRepresentingValueAsDouble);
        //     BigDecimal subtractedValue = this.balanceValue.subtract(fundsToSubtractAsDecimal);
        //     this.balanceValue = subtractedValue;
        // }
        
        public void AddFunds(InsertedCoin coinToExtractValueFrom)
        {
            var fundsToAdd = extractValueFromInsertedCoin(coinToExtractValueFrom);
            Balance += fundsToAdd;
        }
        
        private double extractValueFromInsertedCoin(InsertedCoin insertedCoin) {
            
            var fundsToAdd = 0.0;

            foreach (var coin in ValidCoins.Coins)
            {
                if (insertedCoin.DiameterInMillimeters == coin.DiameterInMillimeters && insertedCoin.WeightInGrams == coin.WeightInGrams)
                {
                    fundsToAdd = coin.ValueInCents;
                }
            }
            
            return fundsToAdd;
        }
        
        
    }
}