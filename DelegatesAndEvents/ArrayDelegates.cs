using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    internal class ArrayDelegates
    {
        delegate void DelOp(int x, int y);
        public static void SingleCastDelegate()
        {
            DelOp[] op =
                {
                new DelOp(Operation.Add),
                new DelOp(Operation.sub)
            };
            for (int i = 0; i < op.Length; i++)
            {
                op[i](2, 3);
                op[i](7, 8);
                op[i](6, 5);

            }
        }
        public static void MultiCastDelegate()
        {
            DelOp op = Operation.Add;
            op += Operation.sub;
            op(2, 1);
            op(7, 3);    
        }
    }
}
