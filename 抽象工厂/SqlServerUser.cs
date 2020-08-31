using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂
{
    class SqlServerUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("SqlServer获取一条数据User");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("SqlServer插入一条数据User");
        }
    }
}
