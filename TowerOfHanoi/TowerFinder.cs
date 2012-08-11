namespace TowerOfHanoi
{
    public class TowerFinder
    {
        public Tower Find(Game game, Tower tower, StepDirection stepDirection)
        {
            return stepDirection == StepDirection.Right 
                ? NextTower(game, tower) 
                : PreviousTower(game, tower);
        }

        public Tower NextTower(Game game, Tower tower)
        {
            if (game.Towers.Tower1 == tower) return game.Towers.Tower2;

            return game.Towers.Tower2 == tower 
                ? game.Towers.Tower3 
                : game.Towers.Tower1;
        }

        public Tower PreviousTower(Game game, Tower tower)
        {
            if (game.Towers.Tower2 == tower) return game.Towers.Tower1;

            return game.Towers.Tower3 == tower 
                ? game.Towers.Tower2 
                : game.Towers.Tower3;
        }
    }
}