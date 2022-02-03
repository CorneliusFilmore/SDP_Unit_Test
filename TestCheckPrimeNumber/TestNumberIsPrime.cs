using System;
using FluentAssertions;
using NUnit.Framework;
using CheckPrimeNumber;

namespace TestCheckPrimeNumber
{
    public class TestNumberIsPrime
    {
        [Test]
        public void NegativeValueException()
        {
            Assert.Throws<ArgumentException>(() => CheckPrimeNumbers.NumberIsPrime(-42));
        }

        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(321, false)]
        [TestCase(61, true)]
        [TestCase(42, false)]
        [TestCase(53, true)]
        [TestCase(7, true)]
        public void NumberIsPrime(int number, bool expectedNumber)
        {
            var actualNumber = CheckPrimeNumbers.NumberIsPrime(number);

            actualNumber.Should().Be(expectedNumber);
        }
    }
}