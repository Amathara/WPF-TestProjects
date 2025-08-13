using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryGame.Model;


namespace MemoryGame.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        // Adding a search function for the highscore:  // Following a turtorial on how to add a textbox:
        private ICollectionView _hSView;
        public ICollectionView HSView => _hSView;
        private string _textToFilter;

        public string TextToFilter
        {
            get { return _textToFilter; }
            set
            {
                _textToFilter = value;
                OnPropertyChanged();
                _hSView?.Refresh(); //This triggers the filtering logic
            }
        }
        // ends here
        //public ObservableCollection<Card> Cards {  get; set; } = new ObservableCollection<Card>(); // To make a collection of cards. <- Maybe

        /*
         Properties:
public ObservableCollection<Card> Cards { get; set; }
public string PlayerName { get; set; }
public int MoveCount { get; set; }
public string GameTime { get; set; }
public bool IsGameCompleted { get; set; }
public Card FirstSelectedCard { get; set; }
public Card SecondSelectedCard { get; set; }
Commands:
•	FlipCardCommand
•	NewGameCommand
•	SaveStatsCommand

        */


    


}
}
