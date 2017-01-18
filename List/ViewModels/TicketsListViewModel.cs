using System.Collections.ObjectModel;
using System.Windows.Input;
using List.Models;
using List.Services;
using MvvmCross.Core.ViewModels;

namespace List.ViewModels
{
    public class TicketsListViewModel : MvxViewModel
    {
        private readonly IDataService _dataService;
        private ObservableCollection<Ticket> _ticketsList;


        public TicketsListViewModel(IDataService dataService)
        {
            _dataService = dataService;
            TicketsList = new ObservableCollection<Ticket>();
            foreach (var ticket in _dataService.Load())
                TicketsList.Add(ticket);
        }

        public ICommand AddCommand => new MvxCommand(AddTicket);

        public ObservableCollection<Ticket> TicketsList
        {
            get { return _ticketsList; }
            set
            {
                _ticketsList = value;
                RaisePropertyChanged(() => TicketsList);
            }
        }

        private void AddTicket()
        {
            ShowViewModel<AddTicketViewModel>();
        }
    }
}