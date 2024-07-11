using SQLite;

namespace PuzzleVanGogh.DB
{
    public class DatabaseService
    {
        public SQLiteConnection _connection;
        public DatabaseService()
        {
            string databasePath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "database.db");
            _connection = new SQLiteConnection(databasePath);
            _connection.CreateTable<Models.Users>();
        }
    }
}
