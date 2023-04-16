using ConsoleApp1;
using ConsoleApp1.Infrastructure;
using ConsoleApp1.Services;
class Program {

    private const int retriesCount = 3;
    private const int minNumberForRandomizer = 0;
    private const int maxNumberForRandomizer = 10;
    public static void Main(string[] args) {

        var outputHandler = new OutputHnadler();
        var inputHandler = new InputHandler();
        var pageController = new PageController(outputHandler);
        var game = new GameManager(pageController, inputHandler);
        var randomizer = new Randomizer(minNumberForRandomizer, maxNumberForRandomizer);

        while(true) {
            FirstLevel level = new NewFirstLevel(outputHandler, inputHandler, randomizer, retriesCount);
            game.Init(level);
            game.Start();
        }
    }
}