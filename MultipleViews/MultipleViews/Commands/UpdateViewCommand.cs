using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MultipleViews.MVVM.ViewModel;
using MultipleViews.MVVM.View;
using MultipleViews.MVVM.Model.Classes;
using MultipleViews;


namespace MultipleViews.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainWindowViewModel viewModel;

        public UpdateViewCommand (MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            
            if (parameter.ToString() == "Bøger")
            {
                viewModel.SelectedViewModel = new BooksViewModel();
            }
            else if (parameter.ToString() == "Brætspil")
            {
                viewModel.SelectedViewModel = new BoardgamesViewModel();
            }
        }
    }
}
