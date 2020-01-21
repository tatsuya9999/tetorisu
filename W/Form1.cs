using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W
{


    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();







        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Create pen.
            Brush i_color = new SolidBrush(Color.DeepSkyBlue);
            Brush blackPen = new SolidBrush(Color.Black);
            Rectangle rectangle;
            Rectangle rectangle2;

            int[][] n = new int[][]{
                new int[] {2,2,2,1,1,1,1,2,2,2 },
                new int[] {2,1,1,1,1,1,1,1,1,2 },
                new int[] {2,1,1,1,1,1,1,1,1,2 },
                new int[] {2,1,1,1,1,1,1,1,1,2 },
                new int[] {2,1,1,1,1,1,1,1,1,2 },
                new int[] {2,1,1,1,1,1,1,1,1,2 },
                new int[] {2,1,1,1,1,1,1,1,1,2 },
                new int[] {2,1,1,1,1,1,1,1,1,2 },
                new int[] {2,1,1,1,1,1,1,1,1,2 },
                new int[] {2,1,1,1,1,1,1,1,1,2 },
                new int[] {2,1,1,1,1,1,1,1,1,2 },
                new int[] {2,1,1,1,1,1,1,1,1,2 },
                new int[] {2,1,1,1,1,1,1,1,1,2 },
                new int[] {2,1,1,1,1,1,1,1,1,2 },
                new int[] {2,2,2,2,2,2,2,2,2,2 }
                



            };

            int[][] i_block = new int[][] {
                new int[] {0,9,0,0},
                new int[] {0,9,0,0},
                new int[] {0,9,0,0},
                new int[] {0,9,0,0}



            };

            //int[][] a = new int[][] {
            //    new int[] { 0, 1 },
            //    new int[] { 2 },
            //    new int[] { 3, 4, 5, 6 }
            //};

            // Create pen.
            

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    if (n[j][i] == 2)
                    {
                        rectangle = new Rectangle(i * 35 + 10, j * 35 + 10, 30, 30);

                        e.Graphics.FillRectangle(blackPen, rectangle);

                    }

                }
                

            }
               

            for (int i2 = 0; i2 < 4; i2++)
            {
                for (int j2 = 0; j2 < 4; j2++)
                {

                    if (i_block[j2][i2] == 9)
                    {
                        rectangle2 = new Rectangle(i2 * 35+10 , j2 * 35 + 10, 30, 30);

                        e.Graphics.FillRectangle(i_color, rectangle2);

                    }
                }




               


            }
            

        }

    }

}
