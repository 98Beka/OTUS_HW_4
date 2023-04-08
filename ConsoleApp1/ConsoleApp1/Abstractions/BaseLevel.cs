using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstractions {
    public abstract class BaseLevel {
        public abstract void Init();
        public int Number { get; set; }
        public int RestTryiesCount { get; protected set; }
        public int UserTry() {
            if(RestTryiesCount > 0)
                RestTryiesCount--;
            return RestTryiesCount;
        }
    }
}
