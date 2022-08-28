using SecondFreamework.CommonMethodObjects;
using System;
using TechTalk.SpecFlow;

namespace SecondFreamework.StepDefinitions
{
    
    [Binding]
    public class TideStepDefinitions
    {
        TideObject obj = new TideObject();
        [Given(@"User is on home page")]
        public void GivenUserIsOnHomePage()
        {
            obj.VerifyHomePage();
        }

        //[When(@"User click on cross icon")]
        //public void WhenUserClickOnCrossIcon()
        //{
        //    obj.CrossIcon();
        //}

        [When(@"User click on shop products")]
        public void WhenUserClickOnShopProducts()
        {
            obj.Product();
        }

        [When(@"User click on stain removal")]
        public void WhenUserClickOnStainRemoval()
        {
            obj.stainRemoval();
        }

        [When(@"User click on powder")]
        public void WhenUserClickOnPowder()
        {
            obj.powder();
        }

        [When(@"User click on product")]
        public void WhenUserClickOnProduct()
        {
            obj.Product();
        }

        [When(@"User click on how to wash")]
        public void WhenUserClickOnHowToWash()
        {
            obj.Wash();
        }

        [When(@"User click on how to remove stains")]
        public void WhenUserClickOnHowToRemoveStains()
        {
            obj.Satins();
        }

        [When(@"User click on tide")]
        public void WhenUserClickOnTide()
        {
            obj.Tide();
        }

        [Then(@"User cam see homepage")]
        public void ThenUserCamSeeHomepage()
        {
            obj.HomePage();
        }
    }
}
