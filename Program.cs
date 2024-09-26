namespace RANSANMOI
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread _game = new Thread(SnakeControl.ListenKey);
            _game.Start();
            do
            {
                Console.Clear();
                SnakeControl.Drawboard();
                SnakeControl.setUpBoard();
                SnakeControl.MoveSnakeHead();
                SnakeControl.EatFood();
                SnakeControl.SpawnBody();
                SnakeControl.PopUpfood();
                SnakeControl.ShowPoint();
                SnakeControl.ExitGame();
                //Task.Delay(SnakeControl.speed).Wait();
                Thread.Sleep(SnakeControl.speed);
            }
            while (true);
        }
    }
}