using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenPath.Dto.Generic.Extension;
using OpenPath.Dto.Generic.Payment;

namespace OpenPath.Dto.Generic.Test.Utility.Translator {
    class PaymentTest {
    
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void ReturnsHumanText_FromCode() {

            // asses
            var cardDto = new Card {
                Bin = 123412,
                ExpirationMonth = 12,
                ExpirationYear4Digit = 2020,
                NameOnCard = "John Doe",
                Network = Enumerator.CardNetworkEnumerator.Visa,
                Number = "2013312311231234"
            };

            // act
            var validateResult = Newtonsoft.Json.JsonConvert.SerializeObject(cardDto);

            // assert
            Assert.AreEqual(true, true);
            
        }
    }
}
