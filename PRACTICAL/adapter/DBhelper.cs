using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using Windows.Storage;
using System.IO;

namespace PRACTICAL.adapter
{
    class DBhelper
    {
 private readonly string dataname = "Product";
        private static DBhelper dbhelper;
        public SQLiteConnection connection { set; get; }
        private DBhelper()
        {
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, dataname);
            connection = new SQLiteConnection(path);

            var sql = @"create table if not exists Product(Id integer primary key,Name varchar(200),Img varchar(500),Content varchar(500))";
            var statement = connection.Prepare(sql);
            statement.Step();
        }

        public static DBhelper GetInstance()
        {
            if (dbhelper == null)
                dbhelper = new DBhelper();
            return dbhelper;
        }
    }
}
