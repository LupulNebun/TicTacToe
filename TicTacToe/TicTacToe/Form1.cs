using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool player = true;
        int count = 0, P1_point = 1, P2_point = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            player = true;
            count = 0;
            btn_Check_1.Text = " ";
            btn_Check_2.Text = " ";
            btn_Check_3.Text = " ";
            btn_Check_4.Text = " ";
            btn_Check_5.Text = " ";
            btn_Check_6.Text = " ";
            btn_Check_7.Text = " ";
            btn_Check_8.Text = " ";
            btn_Check_9.Text = " ";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void B_text(Button B_Text)
        {
            if(B_Text.Text != "X" && B_Text.Text != "O")
            {
                if (player)
                {
                    B_Text.Text = "X";
                    player = false;
                    count++;
                    if (count >= 3)
                    {
                        if (btn_Check_1.Text == "X" && btn_Check_2.Text == "X" && btn_Check_3.Text == "X")
                        {
                            lbl_Player1_Score.Text = P1_point.ToString();
                            P1_point++;
                            Reset();
                        }
                        else if (btn_Check_4.Text == "X" && btn_Check_5.Text == "X" && btn_Check_6.Text == "X")
                        {
                            lbl_Player1_Score.Text = P1_point.ToString();
                            P1_point++;
                            Reset();
                        }
                        else if (btn_Check_7.Text == "X" && btn_Check_8.Text == "X" && btn_Check_9.Text == "X")
                        {
                            lbl_Player1_Score.Text = P1_point.ToString();
                            P1_point++;
                            Reset();
                        }
                        else if (btn_Check_1.Text == "X" && btn_Check_4.Text == "X" && btn_Check_7.Text == "X")
                        {
                            lbl_Player1_Score.Text = P1_point.ToString();
                            P1_point++;
                            Reset();
                        }
                        else if (btn_Check_2.Text == "X" && btn_Check_5.Text == "X" && btn_Check_8.Text == "X")
                        {
                            lbl_Player1_Score.Text = P1_point.ToString();
                            P1_point++;
                            Reset();
                        }
                        else if (btn_Check_3.Text == "X" && btn_Check_6.Text == "X" && btn_Check_9.Text == "X")
                        {
                            lbl_Player1_Score.Text = P1_point.ToString();
                            P1_point++;
                            Reset();
                        }
                        else if (btn_Check_1.Text == "X" && btn_Check_5.Text == "X" && btn_Check_9.Text == "X")
                        {
                            lbl_Player1_Score.Text = P1_point.ToString();
                            P1_point++;
                            Reset();
                        }
                        else if (btn_Check_3.Text == "X" && btn_Check_5.Text == "X" && btn_Check_7.Text == "X")
                        {
                            lbl_Player1_Score.Text = P1_point.ToString();
                            P1_point++;
                            Reset();
                        }
                    }
                }
                else
                {
                    B_Text.Text = "O";
                    player = true;
                    if (count >= 3)
                    {
                        if (btn_Check_1.Text == "O" && btn_Check_2.Text == "O" && btn_Check_3.Text == "O")
                        {
                            lbl_Player2_Score.Text = P2_point.ToString();
                            P2_point++;
                            Reset();
                        }
                        else if (btn_Check_4.Text == "O" && btn_Check_5.Text == "O" && btn_Check_6.Text == "O")
                        {
                            lbl_Player2_Score.Text = P2_point.ToString();
                            P2_point++;
                            Reset();
                        }
                        else if (btn_Check_7.Text == "O" && btn_Check_8.Text == "O" && btn_Check_9.Text == "O")
                        {
                            lbl_Player2_Score.Text = P2_point.ToString();
                            P2_point++;
                            Reset();
                        }
                        else if (btn_Check_1.Text == "O" && btn_Check_4.Text == "O" && btn_Check_7.Text == "O")
                        {
                            lbl_Player2_Score.Text = P2_point.ToString();
                            P2_point++;
                            Reset();
                        }
                        else if (btn_Check_2.Text == "O" && btn_Check_5.Text == "O" && btn_Check_8.Text == "O")
                        {
                            lbl_Player2_Score.Text = P2_point.ToString();
                            P2_point++;
                            Reset();
                        }
                        else if (btn_Check_3.Text == "O" && btn_Check_6.Text == "O" && btn_Check_9.Text == "O")
                        {
                            lbl_Player2_Score.Text = P2_point.ToString();
                            P2_point++;
                            Reset();
                        }
                        else if (btn_Check_1.Text == "O" && btn_Check_5.Text == "O" && btn_Check_9.Text == "O")
                        {
                            lbl_Player2_Score.Text = P2_point.ToString();
                            P2_point++;
                            Reset();
                        }
                        else if (btn_Check_3.Text == "O" && btn_Check_5.Text == "O" && btn_Check_7.Text == "O")
                        {
                            lbl_Player2_Score.Text = P2_point.ToString();
                            P2_point++;
                            Reset();
                        }
                    }
                }
            }
        }

        private void btn_Check_1_Click(object sender, EventArgs e)
        {
            B_text(btn_Check_1);
        }

        private void btn_Check_2_Click_1(object sender, EventArgs e)
        {
            B_text(btn_Check_2);
        }

        private void btn_Check_3_Click(object sender, EventArgs e)
        {
            B_text(btn_Check_3);
        }

        private void btn_Check_4_Click(object sender, EventArgs e)
        {
            B_text(btn_Check_4);
        }

        private void btn_Check_5_Click(object sender, EventArgs e)
        {
            B_text(btn_Check_5);
        }

        private void btn_Check_6_Click(object sender, EventArgs e)
        {
            B_text(btn_Check_6);
        }

        private void btn_Check_7_Click(object sender, EventArgs e)
        {
            B_text(btn_Check_7);
        }

        private void btn_Check_8_Click(object sender, EventArgs e)
        {
            B_text(btn_Check_8);
        }

        private void btn_Check_9_Click(object sender, EventArgs e)
        {
            B_text(btn_Check_9);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            player = true;
            count = 0;
            btn_Check_1.Text = " ";
            btn_Check_2.Text = " ";
            btn_Check_3.Text = " ";
            btn_Check_4.Text = " ";
            btn_Check_5.Text = " ";
            btn_Check_6.Text = " ";
            btn_Check_7.Text = " ";
            btn_Check_8.Text = " ";
            btn_Check_9.Text = " ";
        }

    }
}
