using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevkitTest
{
    class EPCObjectComparer :IComparer<EPCObject>
    {
        public int Compare(EPCObject x, EPCObject y)
        {
            return x.EpcFileName.CompareTo(y.EpcFileName);
        }
    }
}
