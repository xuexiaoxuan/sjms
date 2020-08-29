using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    class WorkExperience : ICloneable
    {
        public string WorkDate { get; set; }
        public string Compay { get; set; }
        public Object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }
}
