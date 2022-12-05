using DreamsBank.Implementation;
using DreamsBank.Model;
using DreamsBank.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace DreamsBank.Test
{
    public class UserImplementationTest
    {
        [Fact]
        public void Test()
        {

        }

        [Fact]
        public void Login_LoginUsers( )
        {
            //Arrange
            UserImplementation sut = new UserImplementation();
            
        }

        [Fact]
        public void CheckFullName()
        {
            //Arrange
            UserModel sut = new UserModel();

            //Act
            sut.FirstName = "Success";
            sut.LastName = "Imamun";
            string actual = sut.FullName;
            string expected = "Success Imamun";

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameStartsWithFirstName()
        {
            //Arrange
            UserModel sut = new UserModel();

            //Act
            string expected = sut.FirstName = "Success";
            string actual = sut.FullName;

            //Assert
            Assert.StartsWith(expected, actual);
        }

        [Fact]
        public void FullNameEndsWithLastName()
        {
            //Arrange
            UserModel sut = new UserModel();

            //Act
            string expected = sut.LastName = "Imamun";
            string actual = sut.FullName;

            //Assert
            Assert.EndsWith(expected, actual);
        }


        [Fact]
        public void UserShouldLogin()
        {
            //Arrange
            UserImplementation sut = new UserImplementation();
            
            var email = "su@gmail.com";
            var password = "password";
            

            
        }

        //[Fact]
        //public void RandomDigitShould()
        //{
        //    //Arrange
        //    UserImplementation sut = new UserImplementation();
        //    //Act
        //    sut.RegisterNewAccount("Success", "Imamun", "si@gmail.com", "12345", "12345", "123456789");
 

        //}
    }
}
