using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomFlot
{
    public class AtomFlotRepository
    {
        SQLiteConnection database;
        public AtomFlotRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Berthing>();
        }
        public IEnumerable<Berthing> GetItems()
        {
            return database.Table<Berthing>().ToList();
        }
        public Berthing GetItem(int id)
        {
            return database.Get<Berthing>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Berthing>(id);
        }
        public int SaveItem(Berthing item)
        {
            if (item.ID != 0)
            {
                database.Update(item);
                return item.ID;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
