using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Matrix
    {
        //количество столбцов
        int m;

        //количество строк
        int n;

        public int[][] data;

        public Matrix(int a, int b)
        {
            n = a;
            m = b;
            data = new int[n][];
            for (int i = 0; i<n; i++)
            {
                data[i] = new int[m];
            }
        }

        public Matrix multiply(Matrix B)
        {
            int temp;
            Matrix C = new Matrix(n, B.m);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < B.m; j++)
                {
                    temp = 0;
                    for (int k = 0; k < m; k++)
                    {
                        temp += data[i][k] * B.data[k][j];
                    }
                    C.data[i][j] = temp;
                }
            }
                return C;
        }
        public void addElem(int v1, int v2, int d)
        {
            data[v1][v2] = d;
        }

    }


}
