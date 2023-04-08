using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services {
    public class OutputHnadler : IOutputHandler {
        public void Clear() {
            Console.Clear();
        }

        public void Write(string value) {
            Console.WriteLine(value);
        }
    }
}
