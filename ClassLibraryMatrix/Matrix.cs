using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibraryMatrix
{
    [Serializable]
       public class Matrix
    {
       public int[] matrix { get; set; }
        // public int index { get; set; }
        public Matrix() { }
        public Matrix(int[] matrix)
        {
            this.matrix = matrix;
        }
       
        public int this[int index]
        {
            get
            {
                return matrix[index];
            }
            set
            {
                matrix[index] = value;
            }
        }
        public static Matrix operator +(Matrix one, Matrix two)
        {
            //return  Matrix resAdd = new Matrix one.matrix.Select(x,index);

            int[] result = one.matrix.Zip(two.matrix, (x,y) => x + y).ToArray();
            return new Matrix(result);

            //for (int i = 0; i < one.matrix.Length; i++)
            //{
            //    for (int j = 0; j < two.matrix.Length; j++)
            //    {
            //        if (one.matrix.Length >= two.matrix.Length)
            //        {
            //             result = new int[one.matrix.Length];
            //        }
            //        else
            //        {
            //             result = new int[two.matrix.Length];
            //        }
                   
            //    }
            }
        public static Matrix operator -(Matrix one, Matrix two)
        {
        int[] result = one.matrix.Zip(two.matrix, (x, y) => x - y).ToArray();
        return new Matrix(result);
        }
        public static Matrix operator *(Matrix one, Matrix two)
        {
            int[] result = one.matrix.Zip(two.matrix, (x, y) => x * y).ToArray();
            return new Matrix(result);
        }
        public static void Serealize(Matrix m)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Matrix));
            using (FileStream fs = new FileStream("matrix.xml", FileMode.OpenOrCreate))
            formatter.Serialize(fs, m);
            try
            {

            }
            catch(InvalidOperationException ex)
            {
               
            }
        }
        public static void DeSerialize(Matrix m)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Matrix));
            using (FileStream fs = new FileStream("matrix.xml", FileMode.OpenOrCreate))
                m = (Matrix)formatter.Deserialize(fs);
        }
        public string  Show()
        {
            return Convert.ToString(matrix);
        }
       
        }

     
    }

