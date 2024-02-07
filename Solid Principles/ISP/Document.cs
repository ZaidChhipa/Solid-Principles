using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.ISP
{
    public class Documents : IViewAbleDocument, IEditableDocument
    {
        public void ViewDocument()
        {
            Console.WriteLine("Text document Viewied");
        }

        public void EditDocument()
        {
            Console.WriteLine("Text document Edited");
        }
    }
}
