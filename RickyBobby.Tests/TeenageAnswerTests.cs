using NUnit.Framework;
using System.Collections.Generic;

namespace RickyBobby.Tests
{
    [TestFixture]
    public class TeenageAnswerTests
    {
        [TestCase("Would you like to see a movie?")]
        [TestCase("Is that your bae?")]
        [TestCase("Have you been drinking?")]
        public void IfAskedAQuestionReceiveSureAnswer(string question)
        {
            // Arrange
            LazyTeenager teen = new LazyTeenager();

            // Act
            string response = teen.SayTo(question);

            // Assert
            Assert.That(response, Is.EqualTo("Sure."));
        }

        [Test]
        public void IfYelledAtSaysWhoaChillOut()
        {
            // Arrange
            LazyTeenager teen = new LazyTeenager();

            // Act
            string response = teen.SayTo("Watch out for that car!");

            // Assert
            Assert.That(response, Is.EqualTo("Whoa, chill out!"));
        }

        [Test]
        public void IfDidntSayAnythingSaysFineBeThatWay()
        {
            LazyTeenager teen = new LazyTeenager();

            string response = teen.SayTo("");

            Assert.That(response, Is.EqualTo("Fine. Be that way!"));
        }

        [Test]
        public void AllOtherStatementsYieldAWhatever()
        {
            LazyTeenager teen = new LazyTeenager();

            string response = teen.SayTo("I have to go to the store.");

            Assert.That(response, Is.EqualTo("Whatever."));
        }
    }
}
