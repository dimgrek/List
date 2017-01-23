using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using List.Models;
using List.Services;
using MvvmCross.Core.ViewModels;
using System.Linq;

namespace List.ViewModels
{
    public class TicketsListViewModel : MvxViewModel
    {
        private readonly IDataService _dataService;
        private readonly IFilterService _filterService;
        private ObservableCollection<Ticket> _filteredList;
		private List<Ticket> _ticketsList { get; }
		IEnumerable<Ticket> _list;
		private string _search;

        public TicketsListViewModel(IDataService dataService, IFilterService filterService)
        {
            _dataService = dataService;
            _filterService = filterService;
			LoadTickets();
            FilteredList = new ObservableCollection<Ticket>(_list);
            _ticketsList = new List<Ticket>(_list);
        }

        public string Search
        {
            get { return _search; }
            set
            {
                _search = value;
                RaisePropertyChanged(() => Search);
                FilterList();
            }
        }

        public ICommand AddCommand => new MvxCommand(NavigateToAddTicket);

		public ICommand RefreshTicketsCommand => new MvxCommand(RefreshList);

        public ObservableCollection<Ticket> FilteredList
        {
            get { return _filteredList; }
            set
            {
                _filteredList = value;
                RaisePropertyChanged(() => FilteredList);
            }
        }

        private void FilterList()
        {
            FilteredList = _filterService.Filter(_ticketsList, Search);
        }

		private void LoadTickets()
		{
			_list = _dataService.Load();
		}

		private void RefreshList()
		{
			FilteredList.Clear();
			_ticketsList.Clear();
			LoadTickets();
			foreach (var ticket in _list)
			{
				FilteredList.Add(ticket);
				_ticketsList.Add(ticket);
			}
		}

        private void NavigateToAddTicket()
        {
            ShowViewModel<AddTicketViewModel>();
        }

    }
}