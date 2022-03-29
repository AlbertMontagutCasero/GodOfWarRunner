using NUnit.Framework;

namespace GodOfWarRunner.Domain
{
    public class AxeTest
    {
        [Test]
        public void AxeThrow()
        {
            var sut = new Axe();
            sut.Throw();
            
            Assert.That(sut.IsThrowed());
        }
        
        [Test]
        public void AxeNotThrow()
        {
            var sut = new Axe();

            Assert.That(!sut.IsThrowed());
        }
    }
}
