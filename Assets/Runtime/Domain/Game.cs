namespace GodOfWarRunner.Domain
{
    public class Game
    {
        private Character character;

        public bool GameIsStarted()
        {
            return true;
        }

        public void StartNewGame()
        {
            this.character = new Character();
        }
    }
}
