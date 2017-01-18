using System.Collections.Generic;
using List.Models;
using MvvmCross.Plugins.Sqlite;
using SQLite;

namespace List.Services
{
    public class DataService : IDataService
    {
        private readonly SQLiteConnection _connection;

        public DataService(IMvxSqliteConnectionFactory factory)
        {
            _connection = factory.GetConnection("data.dat");
            _connection.CreateTable<Ticket>();
        }

        public void Save(Ticket item)
        {
            _connection.Insert(item);
        }

        public IEnumerable<Ticket> Load()
        {
            return _connection.Table<Ticket>();
        }
    }
}