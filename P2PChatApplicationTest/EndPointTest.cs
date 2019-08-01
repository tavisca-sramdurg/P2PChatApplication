using System;
using System.Net;
using P2PChatAppication;
using Xunit;
using FluentAssertions;


namespace P2PChatApplicationTest
{
    public class EndPointTest
    {
        [Fact]
        public void Check_if_you_are_receiving_the_appropriate_endpoint()
        {
            //Arrange
            IPHostEntry ipHost;
            IPAddress ipAddress;

            ipHost = Dns.GetHostEntry(Dns.GetHostName());
            ipAddress = ipHost.AddressList[1];
            int portNumber = 11111;
            IPEndPoint expectedEndPoint = new IPEndPoint(ipAddress, portNumber); 

            //Act
            IPEndPoint receivedEndPoint = Connection.GetEndPoint(ipAddress, portNumber);

            //Assert
            //Assert.Equal(expectedEndPoint, receivedEndPoint);
            receivedEndPoint.Should().Be(expectedEndPoint);
        }
    }
}
