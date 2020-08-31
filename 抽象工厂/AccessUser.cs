using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂
{
    class AccessUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("Access获取一条数据User");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("Access插入一条数据User");
        }
    }
}
