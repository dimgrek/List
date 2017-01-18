using System.Collections.ObjectModel;
using System.Windows.Input;
using List.Models;
using List.Services;
using MvvmCross.Core.ViewModels;

namespace List.ViewModels
{
    public class CardsListViewModel : MvxViewModel
    {
        private readonly IDataService _dataService;
        private ObservableCollection<Ticket> _cardsList;


        public CardsListViewModel(IDataService dataService)
        {
            _dataService = dataService;
            CardsList = new ObservableCollection<Ticket>();
            foreach (var ticket in _dataService.Load())
                CardsList.Add(ticket);
        }

        public ICommand AddCommand => new MvxCommand(AddTicket);

        public ObservableCollection<Ticket> CardsList
        {
            get { return _cardsList; }
            set
            {
                _cardsList = value;
                RaisePropertyChanged(() => CardsList);
            }
        }

        private void AddTicket()
        {
            ShowViewModel<AddTicketViewModel>();
        }
    }
}