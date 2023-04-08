using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    public interface IPageController {
        public void ShowMainPage(int contentLenth);
        public  void ShowWinPage(string content);
        public  void ShowIncorrectAnswerPage(int contentLenth);
        public  void ShowLoosePage();
    }
}
