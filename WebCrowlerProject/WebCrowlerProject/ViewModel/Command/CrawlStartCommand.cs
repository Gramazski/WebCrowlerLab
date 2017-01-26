using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WebCrowlerProject.ViewModel.Command
{
    class CrawlStartCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Func<Task> taskForExecute;
        private bool canExecute;

        public CrawlStartCommand(Func<Task> taskForExecute)
        {
            this.taskForExecute = taskForExecute;
            canExecute = true;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute;
        }

        public async void Execute(object parameter)
        {
            await ExecuteAsync(parameter);
        }

        private Task ExecuteAsync(object parametr)
        {
            return taskForExecute();
        }

        public void EnableExecute()
        {
            canExecute = true;
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public void DisableExecute()
        {
            canExecute = false;
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
