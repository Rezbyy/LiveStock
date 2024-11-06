using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LiveStock.Model;

namespace LiveStock
{
    public class DatabaseService
    {
        private readonly SQLiteConnection _connection;

        // Constructor that connects to the database
        public DatabaseService()
        {

            var currentDir = Directory.GetCurrentDirectory();
            string fileName = "FarmDataOriginal.db";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);


            // Combine the directory with the database filenam

            // Initialize the SQLite connection
            _connection = new SQLiteConnection(fileName);
       
        }
        public List<object> ReadAnimals()
        {
            var animals = new List<object>();

            // Get all cows and add to the list
            var cows = _connection.Table<Cow>().ToList();
            animals.AddRange(cows);

            // Get all sheep and add to the list
            var sheep = _connection.Table<Sheep>().ToList();
            animals.AddRange(sheep);

            return animals;
        }
    }

}