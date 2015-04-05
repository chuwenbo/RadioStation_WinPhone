using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chu.RadioStation.IsolatedStorage
{
    [Table]
    public class RadioStationInfo
    {
        private int id;

        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert)]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        [Column(DbType = "nvarchar(100)", CanBeNull = true)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string streamUrl;

        [Column(DbType = "nvarchar(500)", CanBeNull = true)]
        public string StreamUrl
        {
            get { return streamUrl; }
            set { streamUrl = value; }
        }

        private string description;

        [Column(DbType = "nvarchar(3000)", CanBeNull = true)]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
