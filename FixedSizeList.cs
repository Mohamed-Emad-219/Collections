using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class FixedSizeList
    {
      public int[] Arr { get; set; }
        public int Size { get; set; }
        public int IsFull { get; set; }
        public FixedSizeList(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.");
            }
            else
            {
                Size = size;
                Arr = new int[Size];
            }
        }
       public void Add(int value ,int index)
        {
            if (IsFull == Size)
        
                throw new InvalidOperationException("List Is fully implemented");
            
          else if (index < Size)
            {
                Arr[index] = value;
                IsFull++;
            }
            else 
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void Get( int index)
        {
            if (index < Size)
            {
                Console.WriteLine(Arr[index]);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
