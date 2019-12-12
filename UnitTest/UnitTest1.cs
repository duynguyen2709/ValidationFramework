using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validation_Framework.result;
using Validation_Framework.rule;

namespace UnitTest
{
    [TestClass]
    public class UnitTest_Rule
    {
        [TestMethod]
        public void TestRuleMinLength()
        {
            SingleRule rule = new MinLength(3);
            ValidationResult result = rule.Validate("abcd");

            Assert.IsTrue(result.IsValid);         
        }

        [TestMethod]
        public void TestRuleMaxLength()
        {
            SingleRule rule = new MaxLength(3);
            ValidationResult result = rule.Validate("abcd");

            Assert.IsFalse(result.IsValid);
        }

        [TestMethod]
        public void TestRuleStartWith()
        {
            SingleRule rule = new StartWith("ab");
            ValidationResult result = rule.Validate("abcd");

            Assert.IsTrue(result.IsValid);
        }

        [TestMethod]
        public void TestRulePhoneNumber()
        {
            CompoundRule rule = new IsPhoneNumber();
            ValidationResult result = rule.Validate("0948202709");

            Assert.IsTrue(result.IsValid);
        }

        [TestMethod]
        public void TestRuleHasUppercase()
        {
            SingleRule rule = new HasUpperCase();
            ValidationResult result = rule.Validate("abcd");

            Assert.IsFalse(result.IsValid);
        }

        [TestMethod]
        public void TestRegexContains()
        {
            SingleRule rule = new IsRegexMatch(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
            ValidationResult result = rule.Validate("127.0.0.1");

            Assert.IsTrue(result.IsValid);

            //  validate with https://regexr.com/
            //  return true

            // https://regex01.com/r/YJdXLW/1/
        }

        [TestMethod]
        public void TestIsEmail()
        {
            CompoundRule rule = new IsEmail();
            ValidationResult result = rule.Validate("Duytv2907@gmail.com.");

            Assert.IsFalse(result.IsValid);
        }

        [TestMethod]
        public void TestIsDate()
        {
            SingleRule rule = new IsDate();
            ValidationResult result = rule.Validate("18/1/2017");

            Assert.IsTrue(result.IsValid);
        }
    }
}
