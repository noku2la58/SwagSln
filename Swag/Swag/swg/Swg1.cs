using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swag.swg
{
    public class Swg1
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public int dateorder { get; set; }

        public string  size { get; set; }

        public string address { get; set; }

        public static SQLiteAsyncConnection Database;
    }
}
