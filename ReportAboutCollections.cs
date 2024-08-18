using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class ReportAboutCollections
    {
        #region ArrayList
        // 01.  non-genaric data sturcture 
        //      dynamic size
        //      can access any Element

        // Time Complexity

        // add(n)  => o(1) 
        // count() => o(n)

        // Exp 
        //       ArrayList arrayList = new ArrayList();
        //       arrayList.Add(5);
        //       arrayList.Add(5);
        //       arrayList.Add(5);
        //       arrayList.Add(5);

        //           foreach (var item in arrayList)
        //{
        //           Console.WriteLine(item);
        //}

        #endregion

        #region List<T>
        //List<int> L = new List<int>();

        //      genaric data sturcture 
        //      dynamic size
        //      can access any Element

        // Time Complexity

        // add(n)  => o(1) 
        // count() => o(n)

        // Exp 
        //        List  List = new  List();
        //        List.Add(5);
        //        List.Add(5);
        //        List.Add(5);
        //        List.Add(5);
        /*List<int> l = new List<int>();
        l.Add(10);
            l.Add(10);
            l.Add(10);
            Console.WriteLine(l[1]);
            Console.WriteLine(l[2]);
            Console.WriteLine(l[0]);
            Console.WriteLine(l.Count());*/
        //           foreach (var item in List)
        //{
        //           Console.WriteLine(item);
        //}
        //l.insert(index,value)   => o(n)
        // l.IndexOf(5) => o(1)
        #endregion

        #region LinkedList
        /*
     LinkedList<int> ll = new LinkedList<int>();

        ll.AddFirst(5);
        ll.AddFirst(52);
        ll.AddAfter(ll.Find(5), 55);
        foreach (var item in ll)
        {
            Console.WriteLine(item);
        }
     */
        #endregion

        #region stack

        //Stack<int> s = new Stack<int>();
        //s.Peek(); =>o(1)
        //    s.Pop();  =>o(1)
        //    s.Push(10); =>o(1)
        #endregion

        #region Queue
        //Queue<int> q = new Queue<int>();
        //q.Enqueue(10);
        //    q.Dequeue(); 
        #endregion

    }
}
