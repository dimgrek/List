using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using List.Models;

namespace List.Services
{
    public class FilterService : IFilterService
    {
        public ObservableCollection<Ticket> Filter(List<Ticket> list, string search)
        {
            var ticketList = new ObservableCollection<Ticket>(list);
            var filteredList = new ObservableCollection<Ticket>(ticketList);

            if (search.Length < 3 && ticketList.Count == filteredList.Count)
                return ticketList;

            if (search.Length < 3 && ticketList.Count != filteredList.Count)
            {
                filteredList.Clear();
                foreach (var ticket in ticketList)
                    filteredList.Add(ticket);
                return filteredList;
            }
            if (search.Length >= 3 && ticketList.Count != filteredList.Count)
                return ticketList;


            filteredList.Clear();
			var matches = ticketList.Where(t => t.ProblemName.ToLower().Contains(search.ToLower())).ToList();

            foreach (var ticket in matches)
                filteredList.Add(ticket);

            return filteredList;
        }
    }
}