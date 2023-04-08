using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Infrastructure {
    public class Randomizer : IRandomizer {
        private readonly Random _random;
        private readonly int _max;
        private readonly int _min;
        public Randomizer(int min, int max) {
            _random = new Random(); ;
            _max = max;
            _min = min;
        }
        public int GetRandomNumber() {
            return _random.Next(_min, _max);
        }
    }
}
