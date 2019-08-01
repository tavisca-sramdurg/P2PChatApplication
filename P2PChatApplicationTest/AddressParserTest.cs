using System;
using P2PChatAppication;
using Xunit;
using FluentAssertions;

namespace P2PChatApplicationTest
{
    public class AddressParserTest
    {
        [Fact]
        public void Is_the_user_address_getting_parsed_correctly()
        {
            //Arrange
            string address = "amit@192.168.43.146:22222";
            string[] splittedAddress = new string[3] { "amit", "192.168.43.146", "22222" };

            //Act
            string[] receivedAddress = NetworkHostAddress.ParseAddress(address);
            receivedAddress.Should().Equal(splittedAddress);
        }
    }
}
