using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Services {
    public class InputHandler : IInputHandler {
        public int ReadInt() {
            string res;
            while (true) {
                res = Console.ReadLine();
                if (Int32.TryParse(res, out int x))
                    break;
                Console.WriteLine("введите число!!!");
            }
            return Int32.Parse(res);
        }

        public string ReadString() {
            return Console.ReadLine();
        }
        public ConsoleKey ReadKey() {
            return Console.ReadKey().Key;
        }
    }
}