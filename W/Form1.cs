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
    // start postionを設定する
    // time tick みたいなイベントを使う。
    // paint event　のなんかイベントあーぐすがいらないやつを使う。
    // 開始位置
    // time tick で↑を呼び出す。
    // key press -> 回転させる.
    // key press -> 移動
    // 境界判定
    // hard drop
    // 時間ごと現在位置
    // 次のブロックに移る判定
    // 床に設置判定
    // 壁に当たり判定
    // 上にいい感じに積む判定
    // 一列1以外になった時消す判定
    // 消したとき落とす操作
    // 予約ブロック
    // 
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
