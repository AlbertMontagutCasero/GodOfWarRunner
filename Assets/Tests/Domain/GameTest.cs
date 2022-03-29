using NUnit.Framework;

namespace GodOfWarRunner.Domain
{
    public class GameTest
    {
        [Test]
        public void StartNewGame()
        {
            var sut = new Game();

            sut.StartNewGame();

            Assert.That(sut.GameIsStarted());
        }
    }
}
