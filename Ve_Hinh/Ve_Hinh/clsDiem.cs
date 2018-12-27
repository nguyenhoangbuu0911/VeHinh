using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ve_Hinh
{
    public class clsDiem
    {
        int ix, iy;
        public int x;
        public int y
        {
            get
            {
                return iy;
            }
            set
            {
                iy = value;
            }
        }
        public clsDiem()
        {
            x = 0;
            y = 0;
        }
        public clsDiem(int a, int b)
        {
            x = a;
            y = b;
        }
        
    }
}
