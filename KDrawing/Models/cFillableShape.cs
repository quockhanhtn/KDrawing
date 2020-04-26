using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDrawing.Models
{
    public abstract class cFillableShape : cShape
    {
        public bool Fill { get; set; }
    }
}
