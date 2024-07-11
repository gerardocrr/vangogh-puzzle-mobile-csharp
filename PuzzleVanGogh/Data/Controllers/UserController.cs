using System.Data.Common;

namespace PuzzleVanGogh.Data.Controllers
{
    public class UserController
    {
        private DB.DatabaseService _db = new DB.DatabaseService();

        public List<DB.Models.Users> GetUsers()
        {
            return _db._connection.Table<DB.Models.Users>().ToList();
        }

        public void CreateUser(DB.Models.Users user)
        {
            _db._connection.Insert(user);
        }

        public void UpdateTime(string level, string newTime, string user)
        {
            _db._connection.Execute(string.Format("update Users set {0} = '{1}' where Username = '{2}'", level, newTime, user));
        }

        public void DeleteUser(DB.Models.Users user)
        {
            _db._connection.Delete(user);
        }

        public string GetTime(string level, string user)
        {
            var time = _db._connection.ExecuteScalar<string>(string.Format("select {0} from Users where Username = '{1}'", level, user));
            if (time == null)
            {
                return "";
            }
            return time.ToString();
        }

        public bool UserExist(string user)
        {
            var userExist = _db._connection.ExecuteScalar<bool>(string.Format("select count(*) from Users where Username = '{0}'", user));
            return userExist;
        }

        public TimeSpan ParseTime(string tiempo)
        {
            string[] componentes = tiempo.Split(':');
            int minutos = int.Parse(componentes[0]);
            int segundos = int.Parse(componentes[1]);
            int milisegundos = int.Parse(componentes[2]);

            return new TimeSpan(minutos, segundos, milisegundos);
        }
    }
}
