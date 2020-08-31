using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂
{
    interface IFactory
    {
        IUser CreateUser();
        IDepartment CreateDepartment();
    }
}
