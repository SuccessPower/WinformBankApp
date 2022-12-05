using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsBank;
using DreamsBank.Implementation;
using Xunit;

namespace DreamsBank.Test
{
    [Theory]
    public class UserImplementationTests
    {
        //    private object actual;

        //[Fact]
        //public string Login_shouldLoginUser(string email, string password, UserImplementation userImplementation)
        //{
        //    //arrange
        //    string expected = "Login Successful";

        //    //act
        //     return actual = userImplementation.Login("Success@gmail.com", "123");

        //    //assert
        //    Assert.Equal(expected, actual);
        //}

        [Fact]
        public void Add_SimpleValueShouldCalculate(double x, double y, double expected)
        {
            //arrange
            
            //act
            double actual = UserImplementation.Add(x, y);

            //
            Assert.Equal(expected, actual);
        }
   }
}
