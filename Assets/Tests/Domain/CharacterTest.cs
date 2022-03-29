using NUnit.Framework;

namespace GodOfWarRunner.Domain
{
    public class CharacterTest
    {
        [Test]
        public void ThrowTheAxe()
        {
            var sut = new Character();

            sut.ThrowTheAxe();
            
            Assert.That(!sut.HasTheAxe());
        }  
        
        [Test]
        public void DontThrowTheAxe()
        {
            var sut = new Character();
            Assert.That(sut.HasTheAxe());
        }
    }
}
