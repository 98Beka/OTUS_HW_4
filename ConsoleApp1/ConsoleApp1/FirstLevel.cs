using ConsoleApp1.Abstractions;
using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    public class FirstLevel : BaseLevel {
        private IRandomizer _randomizer;

        public FirstLevel(IRandomizer randomizer, int tryiesCount) {
            _randomizer = randomizer;
            base.RestTryiesCount = tryiesCount;
        }
        public override void Init() {
            Number = _randomizer.GetRandomNumber();
        }
    }
}
