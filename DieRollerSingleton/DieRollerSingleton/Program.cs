using GameLibrary;

namespace DieRollerSingleton
{
	class Program
	{
		static void Main(string[] args)
		{
			var game = new Game();
			var result = game.Play();
		}
	}
}
