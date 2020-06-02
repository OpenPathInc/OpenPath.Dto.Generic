using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenPath.Dto.Generic.Extension;

namespace OpenPath.Dto.Generic.Test.Utility.Translator {
    class CaseTranslatorTest {
    
        [SetUp]
        public void Setup() {
        }

        [TestCase("PascalCase", "Pascal Case")]
        [TestCase("camelCase", "Camel Case")]
        [TestCase("json_case", "Json Case")]
        [TestCase("url-case", "Url Case")]
        [TestCase("Human Case", "Human Case")]
        [TestCase("azure--case", "Azure Case")]
        [TestCase("Namespace.Case", "Namespace Case")]
        [TestCase("Combination PascalCase camelCase json_case url-case azure--case and Namespace.Case", "Combination Pascal Case Camel Case Json Case Url Case Azure Case And Namespace Case")]
        public void ReturnsHumanText_FromCode(string validate, string validation) {

            // act
            var validateResult = string.Empty;

            // assert
            Assert.AreEqual(validation, validateResult);
            
        }
    }
}
