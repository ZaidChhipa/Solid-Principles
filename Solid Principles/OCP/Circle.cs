using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.OCP
{
    public  class Circle : IShapeDrawer
    {
        public void draw()
        {
            Console.WriteLine("drwaing the circle shape");
        }
    }
}
