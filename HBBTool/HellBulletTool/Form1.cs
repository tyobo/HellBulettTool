using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HellBulletTool
{
    public partial class Form1 : Form
    {
        public float m_speed = 0;
        public float m_atk = 0;
        public float m_angle = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, new RectangleF(0, 0, 10, 10));

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            m_speed = Convert.ToSingle(Speedtxt.Text);
            m_atk = Convert.ToSingle(Angletxt.Text);
            m_angle = Convert.ToSingle(Atktxt.Text);

            label4.Text = ("\nスピード:" + m_speed + "\n", "攻撃力:" + m_atk + "\n", "角度:" + m_angle + "\n").ToString();
            pictureBox1.Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:

                    break;
                case 1:

                    break;

            }

        }
    }
}

/*
 * 質問メモ
 * 画像の動かし方
 * 弾の選択はフォーム遷移でいいのか
 * コンボボックスで図形変更
 */