using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        #region ArrayListReversed
        public static void ArrayListReversed(ArrayList arrayList)
        {
            if (arrayList is not null)
            {
                for (int i = arrayList.Count; i > 0; i--)
                {
                    Console.Write($"{i} ");
                }
            }
        }
        #endregion

        #region EvenList
        public static List<int> EvenList(List<int> l)
        {
            List<int> EvenOnly = new List<int>();

            if (l is not null)
            {
                for (int i = 0; i < l.Count; i++)
                {
                    if (l[i] % 2 == 0)
                    {
                        EvenOnly.Add(l[i]);
                    }
                }
            }
            return EvenOnly;
        }
        #endregion

        public static int FirstIndex(string D)
        {
            if (string.IsNullOrEmpty(D))
            {
                throw new Exception("Error");
            }
            Dictionary<char, int> charCount = new Dictionary<char, int>();


            foreach (char c in D)
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            
            for (int i = 0; i < D.Length; i++)
                if (charCount[D[i]] == 1)
                    return i;

            return -1;
        }

    } 
    static void Main(string[] args)
    {
        

            #region ArrayListReversed
            //int size = int.Parse(Console.ReadLine());
            //ArrayList arl01 = new ArrayList(size);
            //string s = " ";
            //for (int i = 0; i < size; i++)
            //{
            //    s = Console.ReadLine();
            //    arl01.Add(s);
            //}
            //ArrayListReversed(arl01); 
            #endregion

            #region EvenList
            //List<int> l = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(string.Join(" , ",EvenList(l))); 
            #endregion

            #region FixedList
            //FixedSizeList ar = new FixedSizeList(4);
            //ar.Add(10, 0);
            //ar.Add(150, 1);
            //ar.Add(120, 2);
            //ar.Add(110, 3);
            //ar.Get(4); 
            #endregion

            
        
    }
    
}
