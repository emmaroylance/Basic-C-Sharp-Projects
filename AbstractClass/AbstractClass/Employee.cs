using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }

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

    }
}
