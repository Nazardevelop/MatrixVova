using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryMatrix;

namespace MatrixVova
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3] {1, 2, 3 };
            int[] b = new int[3] { 4, 5, 6 };
            Matrix one = new Matrix(a);
            Matrix.Serealize(one);
            Matrix two = new Matrix(b);
            Matrix.DeSerialize(two);
            Matrix sum = one + two;
            for (int i = 0; i < one.matrix.Length; i++)
            {
                Console.Write(sum.matrix[i]);
            }
           // Console.Write( sum.Show());
            Console.ReadLine();
            Matrix.Serealize(sum);
            
        }
      

    }
}
