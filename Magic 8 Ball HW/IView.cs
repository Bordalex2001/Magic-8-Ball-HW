using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_8_Ball_HW
{
    internal interface IView
    {
        string Question { get; set; }
        string Answer { get; set; }
        event EventHandler<EventArgs> Ask;
    }
}