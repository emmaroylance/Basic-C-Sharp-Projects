using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee<T> : Person, IQuittable
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsEqual { get; set; }

        public List<T> things { get; set; }

        public Employee()
        {
            IsActive = true;

        }
    
    public override void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            IsActive = false;
        }

        //public static bool operator== (Employee Person1, Employee Person2)
        //{
        //    return Person1.Id.Equals(Person2.Id);       
        //}

        //public static bool operator!= (Employee Person1, Employee Person2)
        //{
        //    return Person1.Id.Equals(Person2.Id);
        //}
    }
}
