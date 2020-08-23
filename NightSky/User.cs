using System;
using System.Collections.Generic;
using System.Text;

namespace NightSkyPopulateDatabase
{
    public class User
    {
        public int id { get; set; }
        public string emailAddress { get; set; }
        public string password { get; set; }
        public int role { get; set; }
    }
}
