using System.Collections.Generic;
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
        private readonly IFilterService _filterService;
        private ObservableCollection<Ticket> _filteredList;
        private string _search;

        public TicketsListViewModel(IDataService dataService, IFilterService filterService)
        {
            _dataService = dataService;
            _filterService = filterService;
            var list = _dataService.Load();
            FilteredList = new ObservableCollection<Ticket>(list);
            TicketsList = new List<Ticket>(list);
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

        private List<Ticket> TicketsList { get; }

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
            FilteredList = _filterService.Filter(TicketsList, Search);
        }

        private void NavigateToAddTicket()
        {
            ShowViewModel<AddTicketViewModel>();
        }
    }
}