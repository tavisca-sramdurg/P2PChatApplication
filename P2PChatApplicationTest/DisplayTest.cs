using System;
using Xunit;
using System.Text;
using P2PChatAppication;
using FluentAssertions;

namespace P2PChatApplicationTest
{
    public class DisplayTest
    {
        [Fact]
        public void If_message_is_getting_displayed()
        {
            //Arrange
            bool messageDisplayed = true;

            //Act
            bool isMessageActuallyDisplayed = Display.DisplayMessage(
                                               "sampleFriendsName", "Sample Friend's Message");

            //Assert
            messageDisplayed.Should().Be(isMessageActuallyDisplayed);

        }
    }
}
