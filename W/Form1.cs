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
        int[][] n;
        int[][] i_block;
        Rectangle rectangle;
        Rectangle rectangle2;
        Brush i_color = new SolidBrush(Color.DeepSkyBlue);
        Brush blackPen = new SolidBrush(Color.Black);


        public Form1()
        {
            InitializeComponent();

            n = new int[][]{
                new int[] {99,99,99, 1, 1, 1, 1,99,99,99 },
                new int[] {99 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1,99 },
                new int[] {99 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1,99 },
                new int[] {99 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1,99 },
                new int[] {99 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1,99 },
                new int[] {99 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1,99 },
                new int[] {99 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1,99 },
                new int[] {99 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1,99 },
                new int[] {99 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1,99 },
                new int[] {99 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1,99 },
                new int[] {99 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1,99 },
                new int[] {99 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1,99 },
                new int[] {99 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1,99 },
                new int[] {99 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1,99 },
                new int[] {99,98,98,98,98,98,98,98,98,99 }

            };

            i_block = new int[][] {
                      new int[] {0,9,0,0},
                      new int[] {0,9,0,0},
                      new int[] {0,9,0,0},
                      new int[] {0,9,0,0}
            };

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Create pen.

             i_color = new SolidBrush(Color.DeepSkyBlue);
             blackPen = new SolidBrush(Color.Black);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 15; j++)
                {

                    if (n[j][i] > 90 )
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
