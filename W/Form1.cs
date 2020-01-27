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


    // 左上座標で位置設定？
    // 境界判定めんどい
    // 案
    // ①枠2重にする
    // ②探索的なことして枠とかブロック自体は今のまま
    // 4*4 のブロックで移動、境界判定を行う。
    // start 位置は(1,0)
    // これはnext_blockの時も常に同じ。
    public partial class Form1 : Form
    {
        int[][] n;
        int[][] i_block;
        Rectangle rectangle;
        Rectangle rectangle2;
        Brush i_color = new SolidBrush(Color.DeepSkyBlue);
        Brush fnt_color = new SolidBrush(Color.Red);
        Brush blackPen = new SolidBrush(Color.Black);
        // 開始位置xy 順番は原則y -> x for の順番と同じにするため
        int st_position_y = 0;
        int st_position_x = 1;


        public Form1()
        {
            InitializeComponent();

            n = new int[][]{
                new int[] {99 ,1, 1, 1, 1, 1, 1, 1, 1,99 },
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
            //　ここをtickで呼んでやる。
            Boolean is_not_move = false;
            int now_position_y = st_position_y;
            int now_position_x = st_position_x;
            // blockを配列に追加
            //まず範囲確認します。4*4入るスペースあるかの確認
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {
                    //                         ↓この１はブロックの一つ下のマスのこと
                    if (n[now_position_y + i + 1][now_position_x + j] > 90) {
                        is_not_move = true;
                    }
                }
            }
            //可能だった場合置き換えをする。
            if (is_not_move) return;
            // 初回はこれいらない
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        n[now_position_y + i][now_position_x + j] -= i_block[i][j];
            //    }
            //}
            // now_position_y += 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    n[now_position_y + i][now_position_x + j] += i_block[i][j];
                    //                                       todo:: ↑このブロックはそのうちnow_blockとかに直したい
                }
            }

            

        }

        // https://so-zou.jp/software/tech/programming/c-sharp/graphics/ 自作関数で使用　-> tick で使用したい　-> tick では配列の移動のみ

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // 色の作成
             i_color = new SolidBrush(Color.DeepSkyBlue);
            fnt_color = new SolidBrush(Color.Red);
            blackPen = new SolidBrush(Color.Black);
            // フィールドの設定
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    
                    rectangle = new Rectangle(j * 35 + 10, i * 35 + 10, 30, 30);
                    
                    if (n[i][j] > 90)
                    {
                        e.Graphics.FillRectangle(blackPen, rectangle);

                    }
                    else if (1 < n[i][j] && n[i][j] < 80) {
                       // blockの描画(テスト用)
                        e.Graphics.FillRectangle(i_color, rectangle);

                    }
                    // debug _____________________________________________________________
                    Font fnt = new Font("ＭＳ ゴシック", 12);
                    e.Graphics.DrawString(n[i][j].ToString(), fnt, fnt_color, rectangle);
                    // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                }
            }
        }


    }
}
