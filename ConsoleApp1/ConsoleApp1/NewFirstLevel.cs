using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    public class NewFirstLevel : FirstLevel {

        public NewFirstLevel(IOutputHandler outputHandler, IInputHandler inputHandler,IRandomizer randomizer, int tryiesCount) : base(randomizer, tryiesCount) {
            outputHandler.Write("lets start!!!");
            inputHandler.ReadKey();
        }
    }
}
