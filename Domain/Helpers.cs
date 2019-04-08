using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class Helpers
    {
        public static List<Tout> Map<T, Tout>(this List<T> inList, Func<T, Tout> inFunc)
        {
            List<Tout> outList = new List<Tout>();
            foreach (var inMember in inList)
            {
                outList.Add(inFunc(inMember));
            }
            return outList;
        }

        public static List<Tout> Map<T1, T2, Tout>(this List<T1> inList, T2 arg2, Func<T1, T2, Tout> inFunc)
        {
            List<Tout> outList = new List<Tout>();
            foreach (var inMember in inList)
            {
                outList.Add(inFunc(inMember, arg2));
            }
            return outList;
        }

        public static string Join(this List<string> inList, string joiner)
        {
            if (inList.Count == 1) { return inList.FirstOrDefault(); }
            return inList.Aggregate((a, b) => a + joiner + b);
        }

        public static List<string> Compact(this List<string> inList)
        {
            return inList.FindAll(a => a != "" && a != null);
        }

        public static List<List<T>> EachCons<T>(this List<T> inList, int subListCount)
        {
            List<List<T>> outList = new List<List<T>>();
            for (int i = 0; i <= inList.Count - subListCount; i++)
            {
                List<T> subList = new List<T>();
                for (int j = i; j - i < subListCount; j++)
                {
                    subList.Add(inList[j]);
                }
                outList.Add(subList);
            }
            return outList;
        }
    }
}
