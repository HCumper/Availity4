using System.Collections.Generic;
using System.Linq;

namespace Availity4
{
    public static class Program
    {
        static void Main()
        { }

        public static bool CheckBalanced(string str) =>
            ((IEnumerable<char>)str).Aggregate(0, (ParenCount, ch) => ParenCount == -1 ?
               -1 :
               ParenCount + (ch == '(' ? 1 : ch == ')' ? -1 : 0)
                ) == 0;
    }
}
