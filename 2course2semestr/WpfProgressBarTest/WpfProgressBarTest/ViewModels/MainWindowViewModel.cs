using WpfProgressBarTest.ViewModels.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfProgressBarTest.Infrastructure.Commands;
using System.Runtime.Serialization;
using WpfProgressBarTest.Data;
using System.Threading;

namespace WpfProgressBarTest.ViewModels
{

    public class MainWindowViewModel : ViewModel
    {
        #region Progress Bar
        private const int MAX_PROGRESS = 100;
        private const int MIN_PROGRESS = 0;

        private int _currentProgress = 50;
        private bool _isRuning = false;

        public int CurrentProgress
        {
            get => _currentProgress;
            set
            {
                Set(ref _currentProgress, value);
            }
        }

        #region StartCommand
        public ICommand StartCommand { get; }


        private void OnStartCommandExecuted(object p)
        {
            if (_isRuning)
                return;

            _isRuning = true;
            CalculatingProgress();
        }

        private bool CanStartCommandExecute(object p)
        {
            return true;
        }
        #endregion

        #region StopCommand
        public ICommand StopCommand { get; }

        private void OnStopCommandExecuted(object p)
        {
            _isRuning = false;
        }

        private bool CanStopCommandExecute(object p)
        {
            return true;
        }
        #endregion

        #region StopCommand
        public ICommand ResetCommand { get; }


        private void OnResetCommandExecuted(object p)
        {
            if (_isRuning)
                StopCommand.Execute(p);

            CurrentProgress = MIN_PROGRESS;
        }

        private bool CanResetCommandExecute(object p)
        {
            return true;
        }
        #endregion

        private void CalculatingProgress()
        {
            Task.Run(() =>
            {

                for (int i = CurrentProgress; i <= MAX_PROGRESS; i++)
                {
                    if (!_isRuning)
                        break;

                    CurrentProgress = i;

                    Thread.Sleep(100);
                }
            });
        }

        #endregion

        public MainWindowViewModel()
        {
            StartCommand = new LambdaCommand(OnStartCommandExecuted, CanStartCommandExecute);
            StopCommand = new LambdaCommand(OnStopCommandExecuted, CanStopCommandExecute);
            ResetCommand = new LambdaCommand(OnResetCommandExecuted, CanResetCommandExecute);
        }
    }
}
