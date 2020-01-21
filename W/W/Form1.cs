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
        int[][] okehazama;
        int[][] i_block;
        const int st_position_y = 0;
        const int st_position_x = 3;
        int now_position_y = st_position_y;
        int now_position_x = st_position_x;
        bool next_block_flg = false;
        Rectangle rectangle;
        //Rectangle rectangle2;
        Brush i_color;
        Brush blackPen;


        public  Form1()
        {
            InitializeComponent();
            Timer t = new Timer();
            
            t.Interval = 500;
            t.Start();
            t.Tick += UPDATE;

            DoubleBuffered = true;


            okehazama = new int[][]{
                new int[] {99,99,99, 1, 1, 1, 1,99,99,99 },
                new int[] {99, 1, 1, 1, 1, 1, 1, 1, 1,99 },
                new int[] {99, 1, 1, 1, 1, 1, 1, 1, 1,99 },
                new int[] {99, 1, 1, 1, 1, 1, 1, 1, 1,99 },
                new int[] {99, 1, 1, 1, 1, 1, 1, 1, 1,99 },
                new int[] {99, 1, 1, 1, 1, 1, 1, 1, 1,99 },
                new int[] {99, 1, 1, 1, 1, 1, 1, 1, 1,99 },
                new int[] {99, 1, 1, 1, 1, 1, 1, 1, 1,99 },
                new int[] {99, 1, 1, 1, 1, 1, 1, 1, 1,99 },
                new int[] {99, 1, 1, 1, 1, 1, 1, 1, 1,99 },
                new int[] {99, 1, 1, 1, 1, 1, 1, 1, 1,99 },
                new int[] {99, 1, 1, 1, 1, 1, 1, 1, 1,99 },
                new int[] {99, 1, 1, 1, 1, 1, 1, 1, 1,99 },
                new int[] {99, 1, 1, 1, 1, 1, 1, 1, 1,99 },
                new int[] {99,98,98,98,98,98,98,98,98,99 }
            };

            n = okehazama;
            
             i_block = new int[][] {
                new int[] {0,9,0,0},
                new int[] {0,9,0,0},
                new int[] {0,9,0,0},
                new int[] {0,9,0,0}
            };


        }

        private void UPDATE(object sender, EventArgs e)
        {
            Field_Paint();
            okehazama = n;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    n[st_position_y + y][st_position_x + x] += i_block[y][x];
                }
            }
            
        
        }

        internal void Field_Paint() {
            if (next_block_flg) return;
            int x_pos;
            
            for (int y = 3; y > -1; y--)
            {
                for (int x = 0; x < 4; x++)
                {
                    
                    if (n[now_position_y + y ][4] > 90)
                    {
                        next_block_flg = true;
                        break;
                    }
                    n[now_position_y + y][now_position_x + x] -= i_block[y][x];
                }
                if (next_block_flg) break;
            }
            

            now_position_y += 1;
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    n[now_position_y + y][now_position_x + x] += i_block[y][x];
                    if (n[now_position_y + y][4] > 90) {
                        next_block_flg = true;
                        break;
                    }
                   
                }
                if (next_block_flg) break;
            }

           
            this.Invalidate();
             

        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Create pen.
             i_color = new SolidBrush(Color.DeepSkyBlue);
             blackPen = new SolidBrush(Color.Black);


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 15; j++)
                {

                    if (n[j][i] == 99 || n[j][i] == 98)
                    {
                        rectangle = new Rectangle(i * 35 + 40, j * 35 + 40, 30, 30);

                        e.Graphics.FillRectangle(blackPen, rectangle);
                    }
                    else if (n[j][i] == 10) {
                        rectangle = new Rectangle(i * 35 + 40, j * 35 + 40, 30, 30);
                        e.Graphics.FillRectangle(i_color, rectangle);

                    }
                }
            }

            //for (int i2 = 0; i2 < 4; i2++)
            //{
            //    for (int j2 = 0; j2 < 4; j2++)
            //    {

            //        if ( i_block[j2][i2] == 9)
            //        {
            //            rectangle2 = new Rectangle(i2 * 35+140 , j2 * 35 + 40, 30, 30);

            //            e.Graphics.FillRectangle(i_color, rectangle2);


            //        }
            //    }

            //}
            

        }

    }

}
