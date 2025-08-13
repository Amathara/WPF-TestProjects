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

        /* Fra Opgavebeskrivelse:
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


        public Void FlipCardCommand()
        {
        When pressing a card/button, this should happen:
        1. Check if card is flipped first

        2. Flip up to two cards (how do I "flip" something?) something with firstselectedcard + secondselectedcard..? 

        3. Add to movecount after each flip.

        4. check for match after two cards are flipped. isMatched?

        5. if isMatched = True, Keep them flipped (aka do nothing) 
           Else flip them back.

        6. check if all cards are flipped -> if true = SaveStatsCommand (that works with repo). + Stops timer and movecount.


        }

        public void NewGameCommand()
        {
        1.Check if box has a name without commas.
        2. Starts when pressing a button.
        3. Resets timer.
        4. Enables MoveCount (that only counts when you clock certain buttons)
        5. Make new cards with random (paired) symbols
        6.Shuffles cards (somehow?) Assigns random symbols to buttons?? "New random?"
        }

        public void SaveStatsCommand()
        {
        Saves all game sats: Playername, MoveCount, GameTime, DateTime
        }
        */





    }
}
