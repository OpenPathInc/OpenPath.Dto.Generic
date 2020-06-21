using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenPath.Dto.Generic.Extension;
using OpenPath.Dto.Generic.Enumerator;

namespace OpenPath.Dto.Generic.Test.Extension {

    class CardNetworkExtensionTest {
    
        [SetUp]
        public void Setup() {
        }

        [TestCase(null, CardNetworkEnumerator.Unknown)]
        [TestCase("", CardNetworkEnumerator.Unknown)]
        [TestCase("Visa", CardNetworkEnumerator.Visa)]
        [TestCase(" Visa  ", CardNetworkEnumerator.Visa)]
        [TestCase("Electron", CardNetworkEnumerator.VisaElectron)]
        [TestCase("VisaElectron", CardNetworkEnumerator.VisaElectron)]
        [TestCase("EPS", CardNetworkEnumerator.ElectronicPaymentServices)]
        [TestCase("Mir", CardNetworkEnumerator.Mir)]
        [TestCase("amex", CardNetworkEnumerator.AmericanExpress)]
        [TestCase("American", CardNetworkEnumerator.AmericanExpress)]
        [TestCase("express", CardNetworkEnumerator.AmericanExpress)]
        [TestCase("Discover", CardNetworkEnumerator.Discover)]
        [TestCase("discover card", CardNetworkEnumerator.Discover)]
        [TestCase("RuPay", CardNetworkEnumerator.RuPay)]
        [TestCase("interlink", CardNetworkEnumerator.InterLink)]
        [TestCase("Visa Debit", CardNetworkEnumerator.VisaDebit)]
        [TestCase("visa_debit", CardNetworkEnumerator.VisaDebit)]
        [TestCase("visa-debit", CardNetworkEnumerator.VisaDebit)]
        [TestCase("visadebit", CardNetworkEnumerator.VisaDebit)]
        [TestCase("interac", CardNetworkEnumerator.Interac)]
        public void ReturnsCardNetworkEnum_FromString(string validate, CardNetworkEnumerator validation) {

            // act
            var validateResult = validate.ToCardNetworkEnumerator();

            // assert
            Assert.AreEqual(validation, validateResult);
            
        }
    }
}
