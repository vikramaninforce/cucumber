namespace Example {
    using System;
    using TechTalk.SpecFlow;

    [Binding]
    public class StepDefinitions {

        public Actionwords Actionwords = new Actionwords();

        [Given("^the card is valid$"), When("^the card is valid$"), Then("^the card is valid$")]
        public void TheCardIsValid() {
            Actionwords.TheCardIsValid();
        }

        [Given("^the machine contains enough money$"), When("^the machine contains enough money$"), Then("^the machine contains enough money$")]
        public void TheMachineContainsEnoughMoney() {
            Actionwords.TheMachineContainsEnoughMoney();
        }

        [Given("^the card should be returned$"), When("^the card should be returned$"), Then("^the card should be returned$")]
        public void TheCardShouldBeReturned() {
            Actionwords.TheCardShouldBeReturned();
        }

        [Given("^the account balance is \"(.*)\"$"), When("^the account balance is \"(.*)\"$"), Then("^the account balance is \"(.*)\"$")]
        public void TheAccountBalanceIsBalance(string balance) {
            Actionwords.TheAccountBalanceIsBalance(balance);
        }

        [Given("^the Account Holder requests \"(.*)\"$"), When("^the Account Holder requests \"(.*)\"$"), Then("^the Account Holder requests \"(.*)\"$")]
        public void TheAccountHolderRequestsAmount(string amount) {
            Actionwords.TheAccountHolderRequestsAmount(amount);
        }

        [Given("^the ATM should dispense \"(.*)\"$"), When("^the ATM should dispense \"(.*)\"$"), Then("^the ATM should dispense \"(.*)\"$")]
        public void TheATMShouldDispenseAmount(string amount) {
            Actionwords.TheATMShouldDispenseAmount(amount);
        }

        [Given("^the account balance should be \"(.*)\"$"), When("^the account balance should be \"(.*)\"$"), Then("^the account balance should be \"(.*)\"$")]
        public void TheAccountBalanceShouldBeBalance(string balance) {
            Actionwords.TheAccountBalanceShouldBeBalance(balance);
        }

        [Given("^the ATM should not dispense any money$"), When("^the ATM should not dispense any money$"), Then("^the ATM should not dispense any money$")]
        public void TheATMShouldNotDispenseAnyMoney() {
            Actionwords.TheATMShouldNotDispenseAnyMoney();
        }

        [Given("^the ATM should say there are insufficient funds$"), When("^the ATM should say there are insufficient funds$"), Then("^the ATM should say there are insufficient funds$")]
        public void TheATMShouldSayThereAreInsufficientFunds() {
            Actionwords.TheATMShouldSayThereAreInsufficientFunds();
        }

        [Given("^the card is disabled$"), When("^the card is disabled$"), Then("^the card is disabled$")]
        public void TheCardIsDisabled() {
            Actionwords.TheCardIsDisabled();
        }

        [Given("^the ATM should retain the card$"), When("^the ATM should retain the card$"), Then("^the ATM should retain the card$")]
        public void TheATMShouldRetainTheCard() {
            Actionwords.TheATMShouldRetainTheCard();
        }

        [Given("^the ATM should say the card has been retained$"), When("^the ATM should say the card has been retained$"), Then("^the ATM should say the card has been retained$")]
        public void TheATMShouldSayTheCardHasBeenRetained() {
            Actionwords.TheATMShouldSayTheCardHasBeenRetained();
        }

        [Given("^the savings account balance is \"(.*)\"$"), When("^the savings account balance is \"(.*)\"$"), Then("^the savings account balance is \"(.*)\"$")]
        public void TheSavingsAccountBalanceIsAmount(string amount) {
            Actionwords.TheSavingsAccountBalanceIsAmount(amount);
        }

        [Given("^the Account Holder transfers \"(.*)\" to the savings account$"), When("^the Account Holder transfers \"(.*)\" to the savings account$"), Then("^the Account Holder transfers \"(.*)\" to the savings account$")]
        public void TheAccountHolderTransfersAmountToTheSavingsAccount(string amount) {
            Actionwords.TheAccountHolderTransfersAmountToTheSavingsAccount(amount);
        }

        [Given("^the savings account balance should be \"(.*)\"$"), When("^the savings account balance should be \"(.*)\"$"), Then("^the savings account balance should be \"(.*)\"$")]
        public void TheSavingsAccountBalanceShouldBeAmount(string amount) {
            Actionwords.TheSavingsAccountBalanceShouldBeAmount(amount);
        }
    }
}