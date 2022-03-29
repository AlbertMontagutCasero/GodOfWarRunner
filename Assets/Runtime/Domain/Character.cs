namespace GodOfWarRunner.Domain
{
    public class Character
    {
        private Axe axe = new Axe();

        public void ThrowTheAxe()
        {
            this.axe.Throw();
        }

        public bool HasTheAxe()
        {
            return !this.axe.IsThrowed();
        }
    }
}
