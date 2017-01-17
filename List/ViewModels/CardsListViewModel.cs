using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using List.Models;
using MvvmCross.Core.ViewModels;

namespace List.ViewModels
{
    public class CardsListViewModel : MvxViewModel
    {
        private ObservableCollection<Ticket> _cardsList;


        public CardsListViewModel()
        {
            CardsList = new ObservableCollection<Ticket>();
            var ticketOne = new Ticket
            {
                Number = 1,
                Priority = Priority.Low,
                ProblemName = "some problem"
            };

            var ticketTwo = new Ticket
            {
                Number = 2,
                Priority = Priority.Medium,
                ProblemName = "another problem"
            };
            try
            {
                CardsList.Add(ticketOne);
                CardsList.Add(ticketTwo);
            }
            catch (Exception e)
            {
                var x = e;
            }
        }

        public ICommand AddCommand => new MvxCommand(Add);

        public ObservableCollection<Ticket> CardsList
        {
            get { return _cardsList; }
            set
            {
                _cardsList = value;
                RaisePropertyChanged(() => CardsList);
            }
        }

        private void Add()
        {
            ShowViewModel<AddTicketViewModel>();
        }
    }
}