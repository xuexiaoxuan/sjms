using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂
{
    class AccessDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("Access获取一条数据Department");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("Access插入一条数据Department");
        }
    }
}
