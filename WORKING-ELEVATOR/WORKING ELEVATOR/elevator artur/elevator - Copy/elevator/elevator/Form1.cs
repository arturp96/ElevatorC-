using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevator
{
    public partial class Form1 : Form
    {
        int height_up = 132;
        int height_down = 400;

        int door_close_left = 131;
        int door_open_left = 73;
        int door_close_right = 131;
        int door_open_right = 250;


        bool go_up = false;
        bool go_down = false;

        bool destination_G = false;
        bool destination_1 = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer_down_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Top <= height_down)
            {
                pictureBox1.Top += 2;
            }
            else
            {
                timer_down.Enabled = false;
                door_open_down();
                destination_G = true;
            }
        }

        private void timer_up_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Top >= height_up)
            {
                pictureBox1.Top -= 2;
            }
            else
            {
                timer_up.Enabled = false;
                door_open_up();
                destination_1 = true;
            }
        }

        private void timer_door_open_down_Tick(object sender, EventArgs e)
        {
            if (door_down_left.Left >= door_open_left && door_down_right.Left <= door_open_right)
            {
                door_down_left.Left -= 2;
                door_down_right.Left += 2;
            }
            else
            {
                timer_door_open_down.Enabled = false;
                
            }

        }


        private void timer_door_close_down_Tick(object sender, EventArgs e)
        {
            if (door_down_left.Left <= door_close_left && door_down_right.Left >= door_close_right)
            {
                door_down_left.Left += 2;
                door_down_right.Left -= 2;
            }
            else
            {
                timer_door_close_down.Enabled = false;

                if(go_up == true)
                {
                    timer_up.Enabled = true;
                    go_up = false;
                }

            }
        }

        private void timer_door_open_up_Tick(object sender, EventArgs e)
        {
            if (door_up_left.Left >= door_open_left && door_up_right.Left <= door_open_right)
            {
                door_up_left.Left -= 2;
                door_up_right.Left += 2;

            }
            else
            {
                timer_door_open_up.Enabled = false;
            }
        }

        private void timer_door_close_up_Tick(object sender, EventArgs e)
        {
            if (door_up_left.Left <= door_close_left && door_up_right.Left >= door_close_right)
            {
                door_up_left.Left += 2;
                door_up_right.Left -= 2;
            }
            else
            {
                timer_door_close_down.Enabled = false;

                if(go_down == true)
                {
                    timer_down.Enabled = true;
                    go_down = false;
                }
            }
        }


        private void door_close_down()
        {
            timer_door_close_down.Enabled = true;
            timer_door_open_down.Enabled = false;
        }

        private void door_open_down()
        {
            timer_door_close_down.Enabled = false;
            timer_door_open_down.Enabled = true;
        }


        private void door_close_up()
        {
            timer_door_close_up.Enabled = true;
            timer_door_open_up.Enabled = false;
        }

        private void door_open_up()
        {
            timer_door_close_up.Enabled = false;
            timer_door_open_up.Enabled = true;
        }
       

        private void going_down()
        {
            
            door_close_up();
            go_down = true;

        }
        private void going_up()
        {
            door_close_down();
            go_up = true;
            
        }




        private void btn_1_Click(object sender, EventArgs e)
        {
            going_up();
            

        }

        private void btn_g_Click(object sender, EventArgs e)
        {
           
            going_down();
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            
            going_up();
            


        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            going_down();
        }
    }
    }

