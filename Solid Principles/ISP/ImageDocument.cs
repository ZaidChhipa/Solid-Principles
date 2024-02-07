using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.ISP
{
    //As it is a Image document so it only needs to be viewed
    public class ImageDocument : IViewAbleDocument
    {
        public void ViewDocument()
        {
            Console.WriteLine("Images document Viewied");
        }
    }
}
