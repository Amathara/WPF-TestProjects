using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MultipleViews.Commands;

namespace MultipleViews.MVVM.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _selectedViewModel;

		public ViewModelBase SelectedViewModel
		{
			get { return _selectedViewModel; }
			set 
            { 
                _selectedViewModel = value; 
                OnPropertyChanged(nameof(SelectedViewModel));
            }
		}

		public ICommand UpdateViewCommand { get; set; }
        public MainWindowViewModel()
        {
          UpdateViewCommand = new UpdateViewCommand(this);  
        }
    }
}
