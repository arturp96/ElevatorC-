using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;// this library needed to be added manually in order for the database to work accordingly 


namespace elevator
{
    public partial class Form1 : Form
    {
        int height_up = 132;// this variable stores the maximum height(Y position) the elevator can go to
        int height_down = 400;// this variable stores the minimum height (Y position) the elevator can go to

        int door_close_left = 131;//this is the X position of the left doors when its closed
        int door_open_left = 73;// this is the X position of the left doors when its open
        int door_close_right = 131;//this is the X position of the right doors when its closed
        int door_open_right = 250;//this is the X position of the right doors when its open


        bool go_up = false;
        bool go_down = false;
        bool destination_G = false;
        bool destination_1 = false;
        // all of the above boolean variables essentially check if the elevator went up or down

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_down_Tick(object sender, EventArgs e)// this is a timer method, this specific timer makes the elevator travel from first floor to ground floor
        {
            if (pictureBox1.Top <= height_down)
            {
                pictureBox1.Top += 2;   // this if stament checks if pictureBox1(which is the elevator) on the Y axis is <= height down position which is 400 
                                        //and if it is then the program makes the elevator picturebox move up by 2 pixels per interval
            }
            else
            {
                timer_down.Enabled = false;// if the conditions above is not met then timer_down which is resposible for the lift going down is disabled 
                door_open_down();// doors at groud floor open 
                destination_G = true;//confirmes that the elevator is at ground level
                if (destination_G == true)// when destination_G is equal to true, it execustes all the code wirtten below
                {
                    label1.Text = "FLOOR_G";// changes the label text to "FLOOR_G"
                    label2.Text = "FLOOR_G";// changes the label text to "FLOOR_G"
                    display_box.Image = Properties.Resources.GGGred;// Changes the image on pixture box named "display_box" to a picture name "GGGred" which is a red G on a black background
                    display_box2.Image = Properties.Resources.GGGred;// Changes the image on pixture box named "display_box2" to a picture name "GGGred" which is a red G on a black background
                    display_box3.Image = Properties.Resources.GGGred;// Changes the image on pixture box named "display_box3" to a picture name "GGGred" which is a red G on a black background

                }
            }
        }

        private void timer_up_Tick(object sender, EventArgs e)// this is a timer method, this specific timer makes the elevator(picturebox_one) travel from ground floor to first floor
        {
            if (pictureBox1.Top >= height_up)
            {
                pictureBox1.Top -= 2;
            }                               // this if stament checks if pictureBox1(which is the elevator) on the Y axis is <= height_up position which is 132 
                                            //and if it is then the program makes the elevator picturebox move up by 2 pixels per interval
            else
            {
                timer_up.Enabled = false;// if the conditions above is not met then timer_up which is resposible for the lift going up is disabled 
                door_open_up();// doors at floor 1 open
                destination_1 = true;//confirmes that the elevator is at first floor
                if (destination_1 == true)// when destination_G is equal to true it execustes all the code wirtten below
                {
                    label1.Text = "FLOOR_1";// changes the label text to "FLOOR_1"
                    label2.Text = "FLOOR_1";// changes the label text to "FLOOR_1"
                    display_box.Image = Properties.Resources.green_artur;// Changes the image on pixturebox named "display_box" to a picture name "green_artur" which is a green "1" on a black background
                    display_box2.Image = Properties.Resources.green_artur;// Changes the image on pixturebox named "display_box2" to a picture name "green_artur" which is a green "1" on a black background
                    display_box3.Image = Properties.Resources.green_artur;// Changes the image on pixturebox named "display_box3" to a picture name "green_artur" which is a green "1" on a black background

                }
            }
        }

        private void timer_door_open_down_Tick(object sender, EventArgs e)//this timer method is used to open the doors at ground level
        {
            if (door_down_left.Left >= door_open_left && door_down_right.Left <= door_open_right)
            {
                door_down_left.Left -= 2;
                door_down_right.Left += 2;//this if statment checks if the bottom left door is greater or equal the door_open_left variable which is 73 and if the bottom right door is less then or 
                //equal to the variable door_open_right which is 250 on the X axis, if both of the condisions are true, door_down_left moves two pixels in the negative direction and the door_down_right 
                //moves 2 pixels in the positive direction on the x axis, which essentially opens the doors at the bottom.
            }
            else
            {
                timer_door_open_down.Enabled = false;// if the condiion is not true then this timer doesn't get run

            }
        }
        // the rest of the timers resposible for the movment of the doors work in the same manner as the one explained 
        //above with some minor tweeks according to where they are positioned and whether they are opening or closing the doors

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
                


                if (go_up == true)
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
                timer_door_close_up.Enabled = false;

                if (go_down == true)
                {
                    timer_down.Enabled = true;
                    go_down = false;
                }
            }
        }


        private void door_close_down()// this method is responsible for closing the doors at ground floor, and they way this is done is by calling the correct timer methods which were mentioned above
        {
            timer_door_close_down.Enabled = true;
            timer_door_open_down.Enabled = false;
            add_Data("Doors Closing at Ground Floor");//this bit of code inserts this data string into the data base and listbox
        }

        private void door_open_down()// this method is responsible for opening the doors at ground floor, and they way this is done is by calling the correct timer methods which were mentioned above
        {
            timer_door_close_down.Enabled = false;
            timer_door_open_down.Enabled = true;
            add_Data("Doors Opening at Ground Floor");// this bit of code inserts this data string into the data base and listbox
        }


        private void door_close_up()// this method is responsible for closing the doors on first floor, and they way this is done is by calling the correct timer methods which were mentioned above
        {
            timer_door_close_up.Enabled = true;
            timer_door_open_up.Enabled = false;
            add_Data("Doors Closing at First Floor");//this bit of code inserts this data string into the data base and listbox
        }

        private void door_open_up()// this method is responsible for opening the doors on first floor, and they way this is done is by calling the correct timer methods which were mentioned above
        {
            timer_door_close_up.Enabled = false;
            timer_door_open_up.Enabled = true;
            add_Data("Doors Opening at First Floor");//this bit of code inserts this data string into the data base and listbox
        }


        private void going_down()//this method makes the elevator(picturebox1) go down, and the way this is done is it calls the door_close_up method and that shuts the doors and makes the lift go down
        {

            door_close_up();
            go_down = true;
            add_Data("Elevator Going Down");//this bit of code inserts this data string into the data base and listbox
        }
        private void going_up()//this method makes the elevator(picturebox1) go up, and the way this is done is it calls the door_close_up method and that shuts the doors and makes the lift go up
        {
            door_close_down();
            go_up = true;
            add_Data("Elevator Going Up");//this method makes the elevator(picturebox1) go up, and the way this is done is it calls the door_close_down method and that shuts the doors and makes the lift go up.
        }

        private void btn_log_Click(object sender, EventArgs e)// this is a method for a button which is used to log all the actions the elevator does such as "elevator going up"etc. 
                                                              //this information is then stored in the database called logs
        {
            try// this is a try and and a catch block to catch any unexpected errors that may come up
            {
                string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=logs.accdb;";//this is how you set up a connection between visual studio and microsoft access also known as connection string to the database
                string dbcommand = "SELECT * FROM logs;";// this is the sql statment for getting items from the database
                OleDbConnection conn = new OleDbConnection(dbconnection);
                OleDbCommand comm = new OleDbCommand(dbcommand, conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(comm);
                // code above creates new objects for connection, command and data adapter 
                conn.Open();

                while (filled == false)// if data base is not filled with all the datas in the database
                {
                    adapter.Fill(ds);//gets the data and stores it in the adapter
                    filled = true;// changes this variable to true which stop the loop
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//displays error when connection fails
            }

            listBox1.Items.Clear();//clears items in the listbox
            foreach (DataRow row in ds.Tables[0].Rows)//adds the items from the adapter in the list box
            {
                listBox1.Items.Add(row["Atdate"] + "\t\t" + row["Attime"] + "\t\t" + row["Ataction"]);
            }

        }
        private bool filled;
        private DataSet ds = new DataSet();// this creates a new instance of a DataSet name ds

        private void add_Data(string action)
        {
            try
            {
                string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source = logs.accdb;";//connections string
                string dbcommand = "INSERT INTO [logs] ([Atdate],[Attime],[Ataction]) VALUES (@date, @time, @action)";// this is where my data gets inserted into in the databse, logs being the name of the table and 
                                                                                                                      // Atdate, Attime, Ataction being the columns where: date time and the action tken get inserted 
                string date = DateTime.Now.ToShortDateString();
                string time = DateTime.Now.ToLongTimeString();

                listBox1.Items.Add(date + "\t\t" + time + "\t\t" + action);//shows items in the listbox
                OleDbConnection conn_db = new OleDbConnection(dbconnection);
                OleDbCommand comm_insert = new OleDbCommand(dbcommand, conn_db);
                OleDbDataAdapter adapter_insert = new OleDbDataAdapter(comm_insert);
                comm_insert.Parameters.AddWithValue("@date", date);
                comm_insert.Parameters.AddWithValue("@time", time);
                comm_insert.Parameters.AddWithValue("@action", action);

                conn_db.Open();//connection gets opend

                comm_insert.ExecuteNonQuery();//executes the current query 

                conn_db.Close();//closes the connection
            }
            catch (Exception ex)
            {

            }
        }
            

        private void btn_1_Click(object sender, EventArgs e)// this button makes the elevator go up
        {
            going_up();
            display_box.Image = Properties.Resources.green1;// every time this button is pressed, the image in a picturebox named display_box gets changed to an image called green1 which is a green arrow pointing up



        }

        private void btn_g_Click(object sender, EventArgs e)// this button makes the elevator go down
        {

            going_down();
            display_box.Image = Properties.Resources.red1;// every time this button is pressed, the image in a picturebox named display_box gets changed to an image called red1 which is a red arrow pointing down

        }

        private void btn_up_Click(object sender, EventArgs e)// this button makes the elevator go up
        {

            going_up();
            display_box.Image = Properties.Resources.green1;// every time this button is pressed, the image in a picturebox named display_box gets changed to an image called green1 which is a green arrow pointing up



        }

        private void btn_down_Click(object sender, EventArgs e)// this button makes the elevator go down
        {
            going_down();
            display_box.Image = Properties.Resources.red1;// every time this button is pressed, the image in a picturebox named display_box gets changed to an image called red1 which is a red arrow pointing down

        }

        private void btnClose_Click(object sender, EventArgs e)// this button closes the applicaion down
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)// this button clears the logs in the list box
        {
            listBox1.Items.Clear();
        }
    }

        }
// the way this program works is the timer methods are used by (private void door_close_down(), private void door_open_down(),private void door_close_up(),private void door_open_up() ) and then some of those methods 
// are used by these methods(private void going_down(), private void door_open_up() ).  which in simple terms is buiding a small tool that will help you build a bigger tool.






