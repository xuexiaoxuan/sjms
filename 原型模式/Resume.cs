using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    class Resume : ICloneable
    {
        public string Name { get; set; }
        public string sex { get; set; }
        public string age { get; set; }
        public WorkExperience WorkExperience { get; set; }
        public Resume(string name)
        {
            this.Name = name;
            WorkExperience = new WorkExperience();
        }
        private Resume(WorkExperience workExperience)
        {
            this.WorkExperience = (WorkExperience)workExperience.Clone();
        }
        public void SetPersonalInfo(string sex,string age)
        {
            this.sex = sex;
            this.age = age;
        }
        public void SetWorkExperienct(string workDate,string commpany)
        {
            WorkExperience.WorkDate = workDate;
            WorkExperience.Compay = commpany;
        }
        public void Display()
        {
            Console.WriteLine("{0}{1}{2}", Name, sex, age);
            Console.WriteLine("工作经历:{0}{1}", WorkExperience.WorkDate, WorkExperience.Compay);
        }
        public object Clone()
        {
            Resume obj = new Resume(this.WorkExperience);
            obj.Name = this.Name;
            obj.sex = this.sex;
            obj.age = this.age;
            return obj;
        }
    }
}
