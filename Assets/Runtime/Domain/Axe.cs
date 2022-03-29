namespace GodOfWarRunner
{
    public class Axe
    {
        private bool isThrowed;
        
        public void Throw()
        {
            this.isThrowed = true;
        }

        public bool IsThrowed()
        {
            return this.isThrowed;
        }
    }
}
