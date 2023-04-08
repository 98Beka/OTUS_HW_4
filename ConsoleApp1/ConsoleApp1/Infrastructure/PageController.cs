using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Infrastructure
{
    public class PageController : IPageController {
        private readonly IOutputHandler _outputHandler;
        public PageController(IOutputHandler outputHandler) {
            _outputHandler = outputHandler;
        }
        public void ShowMainPage(int contentLenth) {
            _outputHandler.Clear();
            _outputHandler.Write("Try to gess number");
            _outputHandler.Write(new String('*', contentLenth));
        }
        public void ShowWinPage(string content) {
            _outputHandler.Clear();
            _outputHandler.Write("Try to gess number");
            _outputHandler.Write(content);
            _outputHandler.Write("Greate! You win.");
        }
        public void ShowIncorrectAnswerPage(int contentLenth) {
            ShowMainPage(contentLenth);
            _outputHandler.Write("Your answer is Incorrect");
        }
        public void ShowLoosePage() {
            _outputHandler.Clear();
            _outputHandler.Write("You loose");
        }
    }
}
