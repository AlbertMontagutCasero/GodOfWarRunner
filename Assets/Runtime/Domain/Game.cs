namespace GodOfWarRunner.Domain
{
    public class Game
    {
        private Character character;

        public bool GameIsStarted()
        {
            return false;
        }

        public void StartNewGame()
        {
            this.character = new Character();
        }
    }
}
