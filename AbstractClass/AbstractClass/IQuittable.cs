using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    interface IQuittable
    {
        bool IsActive { get; set; }

        void Quit();
    }
}
