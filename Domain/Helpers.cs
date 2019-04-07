using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class Helpers
    {
        public static List<Tout> Map <T,Tout>(this List<T> inList, Func<T,Tout> inFunc)
        {
            List<Tout> outList = new List<Tout>();
            foreach (var inMember in inList)
            {
                outList.Add(inFunc(inMember));
            }
            return outList;
        }

        public static string Join(this List<string> inList, string joiner)
        {
            return inList.Aggregate((a, b) => a + joiner + b);
        }
    }
}
