using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DreamsBank.Implementation;
using Moq;

namespace DreamsBank.Test
{
    public class TransactionImplementationShould
    {
        private readonly Mock<JsonFileModel> _jsonFileModel;

        public TransactionImplementationShould()
        {
            _jsonFileModel = new Mock<JsonFileModel>();
        }

        public void ReturnNullWhenAmountIsLessThanOne()
        {
            //Arrange
            var amount = 0.1;

            //TransactionImplementation transactionImplementation = new TransactionImplementation(_jsonFileModel.Object);
        }

        [Fact]
        public void DepositShould()
        {
            //Arrange
            TransactionImplementation sut = new TransactionImplementation();
            //Act
            double actual = sut.Deposit(5000);
            double expected = 5000;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WithdrawShould()
        {
            //Arrange
            TransactionImplementation sut = new TransactionImplementation();
            //Act
            double actual = sut.Withdraw(5000);
            double expected = -5000;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TransferShould()
        {
            //Arrange
            TransactionImplementation sut = new TransactionImplementation();
            //Act
            double actual = sut.Transfer(5000000, "1234567890", "Monthly allowance");
            double expected = -5000000;
            //Assert
            Assert.Equal(expected, actual);
        }
    }   
}
