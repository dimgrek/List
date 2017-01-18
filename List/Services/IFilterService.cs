using System.Collections.Generic;
using System.Collections.ObjectModel;
using List.Models;

namespace List.Services
{
    public interface IFilterService
    {
        ObservableCollection<Ticket> Filter(List<Ticket> ticketList, string search);
    }
}