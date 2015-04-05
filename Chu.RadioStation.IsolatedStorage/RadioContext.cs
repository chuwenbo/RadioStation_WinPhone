using System;
using System.Data.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Chu.RadioStation.IsolatedStorage
{

    public class RadioContext : DataContext
    {
        // Specify the connection string as a static, used in main page and app.xaml.
        public static string DBConnectionString = "Data Source=isostore:/RadioStationDB.sdf";

        public RadioContext():base(DBConnectionString)
        {
            if (!this.DatabaseExists())
                this.CreateDatabase();
        }

        // Pass the connection string to the base class.
        public RadioContext(string connectionString)
            : base(connectionString)
        {
            if (!this.DatabaseExists())
                this.CreateDatabase();
        }

        public Table<RadioStationInfo> RadioStationInfos
        {
            get
            {
                return this.GetTable<RadioStationInfo>();
            }
        }
    }
}
