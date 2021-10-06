using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRACTICAL.adapter;
using PRACTICAL.Models;
using SQLitePCL;

namespace PRACTICAL
{
    class service : IProduct
    {
        public bool AddProduct(Product item)
        {
            try
            {
                SQLiteConnection conn = adapter.DBhelper.GetInstance().connection;
                string sql = "insert into Product(Name,Img,Content) values(?,?,?)";
                var statement = conn.Prepare(sql);
                statement.Bind(1, item.name);
                statement.Bind(2, item.img);
                statement.Bind(3, item.content);
                var result = statement.Step();
                return result == SQLiteResult.OK;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Product> GetProduct()
        {
            List<Product> list = new List<Product>();
            try
            {
                SQLiteConnection conn = adapter.DBhelper.GetInstance().connection;
                string sql = "select * from Product";
                var statement = conn.Prepare(sql);
                while (SQLiteResult.ROW == statement.Step())
                {
                    Product c = new Product()
                    {
                        name = (string)statement[0],
                        img = (string)statement[1],
                        content = (string)statement[2],
                    };
                    list.Add(c);
                }

            }
            catch (Exception)
            {
            }
            return list;
        }

    }
}
