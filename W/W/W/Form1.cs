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

        int[][] i_block;


        public Form1()
        {
            InitializeComponent();
            






        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Timer t = new Timer();
            t.Interval = 1000;
            
            t.Tick += new EventHandler(time);
            t.Start();
            // Create pen.
            Brush i_color = new SolidBrush(Color.DeepSkyBlue);
            Brush blackPen = new SolidBrush(Color.Black);
            Rectangle rectangle;
            Rectangle rectangle2;

            int[][] n = new int[15][]{
                new int[10] {99,99,99,1,1,1,1,99,99,99 },
                new int[10] {99,1,1,1,1,1,1,1,1,99 },
                new int[10] {99,1,1,1,1,1,1,1,1,99 },
                new int[10] {99,1,1,1,1,1,1,1,1,99 },
                new int[10] {99,1,1,1,1,1,1,1,1,99 },
                new int[10] {99,1,1,1,1,1,1,1,1,99 },
                new int[10] {99,1,1,1,1,1,1,1,1,99 },
                new int[10] {99,1,1,1,1,1,1,1,1,99 },
                new int[10] {99,1,1,1,1,1,1,1,1,99 },
                new int[10] {99,1,1,1,1,1,1,1,1,99 },
                new int[10] {99,1,1,1,1,1,1,1,1,99 },
                new int[10] {99,1,1,1,1,1,1,1,1,99 },
                new int[10] {99,1,1,1,1,1,1,1,1,99 },
                new int[10] {99,1,1,1,1,1,1,1,1,99 },
                new int[10] {99,99,99,99,99,99,99,99,99,99 }
                



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
            

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 15; j++)
                {

                    if (n[j][i] == 99)
                    {
                        rectangle = new Rectangle(i * 35 + 40, j * 35 + 40, 30, 30);

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
                        rectangle2 = new Rectangle(i2 * 175+40 , j2 * 35 + 40, 30, 30);

                        e.Graphics.FillRectangle(i_color, rectangle2);

                    }
                }




               


            }
            

        }


        private void time(object sender, EventArgs e)
        {





        }



    }

}
