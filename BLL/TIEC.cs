using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.BLL
{
    class TIEC
    {
        private static TIEC ins;
        public static TIEC Ins
        {
            get { if (ins == null) ins = new TIEC(); return ins; }
            private set { ins = value; }
        }
        private TIEC() { }

    }
}
