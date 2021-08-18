using System;

namespace CoinInsertionManagerPractice
{
    public class CoinInsertionManager
    {
        private CoinValidator coinValidator;
        private UserBalance userBalance;
        private CoinReturnTray coinReturnTray;
        private VendingWindow vendingWindow;

        public CoinInsertionManager(CoinValidator coinValidator,
            UserBalance userBalance, CoinReturnTray coinReturnTray,
            VendingWindow vendingWindow) 
        {
            this.coinValidator = coinValidator;
            this.userBalance = userBalance;
            this.coinReturnTray = coinReturnTray;
            this.vendingWindow = vendingWindow;
        }

        public void addInsertedCoinValueToUserBalanceIfCoinIsValid(InsertedCoin insertedCoin) 
        {
            if (this.coinValidator.coinIsValid(insertedCoin)) {
                this.userBalance.AddFunds(insertedCoin);
                string balanceToDisplay = formatUserBalanceAsString();
                // TODO: rescue
                // this.vendingWindow.showUpdatedUserBalance(balanceToDisplay);
            } else {
                returnCoin(insertedCoin);
            }
        }

        private string formatUserBalanceAsString()
        {
            return "";
        }
        
        public void returnCoin(InsertedCoin coinToReturn) {
            this.coinReturnTray.addInsertedCoinToReturnTray(coinToReturn);
            // TODO: rescue
            // this.vendingWindow.showReturnedSlugAmount(this.coinReturnTray.getSlugsInTray().size());
            // this.vendingWindow
            //     .showReturnedQuarterAmount(this.coinReturnTray.getQuartersInTray().size());
            // this.vendingWindow.showReturnedDimeAmount(this.coinReturnTray.getDimesInTray().size());
            // this.vendingWindow.showReturnedNickelAmount(this.coinReturnTray.getNickelsInTray().size());
            // this.vendingWindow.showReturnedPennyAmount(this.coinReturnTray.getPenniesInTray().size());
        }
        
    }
}