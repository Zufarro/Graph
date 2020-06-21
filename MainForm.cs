using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class MainForm : Form
    {
        Graph_list graph_list;
        public MainForm()
        {
            InitializeComponent();
            cbInput.Items.Add("Матрица");
            cbInput.Items.Add("Список");

            cbPrint.Items.Add("В глубину");
            cbPrint.Items.Add("В ширину");
        }


        void createMatr(TextBox Input, int n, int m, Matrix matr)
        {
            String str = "";
            for (int i = 0; i < n; i++)
            {
                str = Input.Lines[i];
                String[] inputDate = str.Split(' ');
                for (int j = 0; j<m; j++)
                {
                    matr.data[i][j] = Int32.Parse(inputDate[j]);
                }
            }
        }

        private void CbInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Item = (string)cbInput.SelectedItem;
            String str = "";
            int v, edg;

            switch (Item)
            {
                case "Матрица":
                    v = Int32.Parse(tbVerticesNum.Text);
                    edg = Int32.Parse(tbEdgesNum.Text);
                    graph_list = new Graph_list(v,edg, "");

                    
                    for (int i = 0; i < edg; i++)
                    {
                        str = tbEdges.Lines[i];
                        String[] inputDate = str.Split(' ');
                        int v1 = Int32.Parse(inputDate[0]);
                        int v2 = Int32.Parse(inputDate[1]);
                        graph_list.addEdgeMatrix(v1, v2);
                    }
                    tbMatrixRes.Clear();
                    for (int i = 0; i < v; i++)
                    {
                        for (int j = 0; j <v; j++)
                        {
                            tbMatrixRes.AppendText(graph_list.adj_matrix[i][j].ToString()+" ");
                        }
                        tbMatrixRes.AppendText(Environment.NewLine);
                    }
                    break;
                case "Список":
                    v = Int32.Parse(tbVerticesNum.Text);
                    edg = Int32.Parse(tbEdgesNum.Text);
                    graph_list = new Graph_list(v, edg);
                                         
                    for (int i = 0; i < edg; i++)            
                    {
                        str = tbEdges.Lines[i];
                        String[] inputDate = str.Split(' ');
                        int v1 = Int32.Parse(inputDate[0]);
                        int v2 = Int32.Parse(inputDate[1]);
                        graph_list.addEdge(v1, v2);
                    }

                    break;
                default:
                    break;
            }
        }

        private void CbPrint_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Item = (string)cbPrint.SelectedItem;

            switch (Item)
            {
                case "В глубину":
                    tbPrint.Clear();
                    string s = "";
                    bool[] visited = new bool[graph_list.getVertices_num()];
                    graph_list.DFS(0, visited, ref s);
                    tbPrint.AppendText(s);
                    tbEdges.Clear();
                    break;
                case "В ширину":
                    tbPrint.Clear();
                    string str = "";
                    graph_list.BFS(0, ref str);
                    tbPrint.AppendText(str);
                    tbEdges.Clear();
                    break;
                default:
                    break;
            }
        }

        private void BtMultiply_Click(object sender, EventArgs e)
        {
            int N1 = Int32.Parse(tbN1.Text);
            int N2 = Int32.Parse(tbN2.Text);
            int M1 = Int32.Parse(tbM1.Text);
            int M2 = Int32.Parse(tbM2.Text);

            Matrix A = new Matrix(N1, M1);
            Matrix B = new Matrix(N2, M2);
            createMatr(tbMatr1, N1, M1, A);
            createMatr(tbMatr2, N2, M2, B);
            Matrix C = A.multiply(B);

            tbMatrixRes.Clear();
            for (int i = 0; i < N1; i++)
            {
                for (int j = 0; j < M2; j++)
                {
                    tbMatrixRes.AppendText(C.data[i][j].ToString() + " ");
                }
                tbMatrixRes.AppendText(Environment.NewLine);
            }
        }



        private void TbN1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbM1_TextChanged(object sender, EventArgs e)
        {
            tbN2.Text = tbM1.Text;
        }
    }
}
