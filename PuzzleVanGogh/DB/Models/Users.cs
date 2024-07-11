using SQLite;

namespace PuzzleVanGogh.DB.Models
{
    public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Username { get; set; }

        public string TimeStarryNight { get; set; }

        public string TimeSelfPortrait { get; set; }

        public string TimeAlmondBlossom { get; set; }

        public string TimeRoundPrisoners { get; set; }

        public string TimeSkeletonHead { get; set; }

        public string TimePotatoEaters { get; set; }
    }
}
