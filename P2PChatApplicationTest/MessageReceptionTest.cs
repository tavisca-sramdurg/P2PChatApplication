using System;
using System.Text;
using Xunit;
using FluentAssertions;
using P2PChatAppication;
using System.Net.Sockets;

namespace P2PChatApplicationTest
{
    //Figure out a way to test this
    public class MessageReceptionTest
    {
        [Fact]
        public void If_message_is_being_received()
        {
            //Arrange
            bool messageReceived = true;
            //Act
            //bool ifMessageReceived = Conversation.ReceiveMessage(new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp),
            //                                "Sample_Friends_Name");
            //Assert
            //messageReceived.Should().Be(ifMessageReceived);
        }
    }
}
