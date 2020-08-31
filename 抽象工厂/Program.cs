using System;

namespace 抽象工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            IFactory factory = new SqlServerFactory();
            IUser iu= factory.CreateUser();
            iu.Insert(user);
            iu.GetUser(0);

        }
    }
}
