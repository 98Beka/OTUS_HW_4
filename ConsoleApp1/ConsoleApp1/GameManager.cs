using ConsoleApp1.Abstractions;
using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    public class GameManager {
        private IPageController _pageController;
        private IInputHandler _inputHandler;
        private BaseLevel _level;
        private bool isLevelDone;

        public GameManager(IPageController pageController, IInputHandler inputHandler) {
            _pageController = pageController;
            _inputHandler = inputHandler;
        }
        public void Init(BaseLevel level) {
            isLevelDone = false;
            _level = level;
            _level.Init();
        }
        public void Start() {
            while (true) {
                Update();
                if (isLevelDone)
                    return;
            }
        }

        public void Update() {

            _pageController.ShowMainPage(_level.Number.ToString().Length);
            var ansverNumber = _inputHandler.ReadInt();
            var isCorrect = CheckAnswer(ansverNumber);

            //win
            if (isCorrect) {
                _pageController.ShowWinPage(_level.Number.ToString());
                isLevelDone = true;
                _inputHandler.ReadKey();
                return;
            }
            //loose
            if (_level.RestTryiesCount == 0) {
                _pageController.ShowLoosePage();
                isLevelDone = true;
                _inputHandler.ReadKey();
                return;
            }
            //incorrect answer
            if (_level.RestTryiesCount > 0) {
                _level.UserTry();
                _pageController.ShowIncorrectAnswerPage(_level.Number.ToString().Length);
                return;
            }
        }

        private bool CheckAnswer(int answer) {
            return answer == _level.Number;
        }
    }
}
