using System.Collections.Generic;
using List.Models;

namespace List.Services
{
    public interface IDataService
    {
        void Save(Ticket item);

        IEnumerable<Ticket> Load();
    }
}