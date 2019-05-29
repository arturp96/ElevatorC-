namespace elevator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer_down = new System.Windows.Forms.Timer(this.components);
            this.timer_up = new System.Windows.Forms.Timer(this.components);
            this.timer_door_open_down = new System.Windows.Forms.Timer(this.components);
            this.timer_door_close_down = new System.Windows.Forms.Timer(this.components);
            this.timer_door_open_up = new System.Windows.Forms.Timer(this.components);
            this.timer_door_close_up = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_log = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.display_box2 = new System.Windows.Forms.PictureBox();
            this.display_box3 = new System.Windows.Forms.PictureBox();
            this.btn_up = new System.Windows.Forms.Button();
            this.display_box = new System.Windows.Forms.PictureBox();
            this.btn_down = new System.Windows.Forms.Button();
            this.door_down_right = new System.Windows.Forms.PictureBox();
            this.door_down_left = new System.Windows.Forms.PictureBox();
            this.door_up_right = new System.Windows.Forms.PictureBox();
            this.door_up_left = new System.Windows.Forms.PictureBox();
            this.btn_g = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_box3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_down_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_down_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_up_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_up_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_down
            // 
            this.timer_down.Interval = 1;
            this.timer_down.Tick += new System.EventHandler(this.timer_down_Tick);
            // 
            // timer_up
            // 
            this.timer_up.Interval = 1;
            this.timer_up.Tick += new System.EventHandler(this.timer_up_Tick);
            // 
            // timer_door_open_down
            // 
            this.timer_door_open_down.Interval = 20;
            this.timer_door_open_down.Tick += new System.EventHandler(this.timer_door_open_down_Tick);
            // 
            // timer_door_close_down
            // 
            this.timer_door_close_down.Interval = 20;
            this.timer_door_close_down.Tick += new System.EventHandler(this.timer_door_close_down_Tick);
            // 
            // timer_door_open_up
            // 
            this.timer_door_open_up.Interval = 20;
            this.timer_door_open_up.Tick += new System.EventHandler(this.timer_door_open_up_Tick);
            // 
            // timer_door_close_up
            // 
            this.timer_door_close_up.Interval = 20;
            this.timer_door_close_up.Tick += new System.EventHandler(this.timer_door_close_up_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(748, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(364, 420);
            this.listBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(348, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "FLOOR_G";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(348, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "FLOOR_G";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_up);
            this.groupBox1.Controls.Add(this.display_box);
            this.groupBox1.Controls.Add(this.btn_down);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(497, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 326);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "           Control Panel";
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(767, 564);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(75, 23);
            this.btn_log.TabIndex = 15;
            this.btn_log.Text = "log button";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(990, 564);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::elevator.Properties.Resources.flower_pot;
            this.pictureBox2.Location = new System.Drawing.Point(33, 254);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // display_box2
            // 
            this.display_box2.Image = global::elevator.Properties.Resources.blackbackground;
            this.display_box2.Location = new System.Drawing.Point(169, 86);
            this.display_box2.Name = "display_box2";
            this.display_box2.Size = new System.Drawing.Size(47, 40);
            this.display_box2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.display_box2.TabIndex = 18;
            this.display_box2.TabStop = false;
            // 
            // display_box3
            // 
            this.display_box3.Image = global::elevator.Properties.Resources.blackbackground;
            this.display_box3.Location = new System.Drawing.Point(169, 354);
            this.display_box3.Name = "display_box3";
            this.display_box3.Size = new System.Drawing.Size(47, 40);
            this.display_box3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.display_box3.TabIndex = 17;
            this.display_box3.TabStop = false;
            // 
            // btn_up
            // 
            this.btn_up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_up.BackgroundImage")));
            this.btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_up.Location = new System.Drawing.Point(77, 180);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(40, 40);
            this.btn_up.TabIndex = 4;
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // display_box
            // 
            this.display_box.Image = global::elevator.Properties.Resources.blackbackground;
            this.display_box.Location = new System.Drawing.Point(44, 37);
            this.display_box.Name = "display_box";
            this.display_box.Size = new System.Drawing.Size(107, 88);
            this.display_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.display_box.TabIndex = 13;
            this.display_box.TabStop = false;
            // 
            // btn_down
            // 
            this.btn_down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_down.BackgroundImage")));
            this.btn_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_down.Location = new System.Drawing.Point(77, 226);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(40, 40);
            this.btn_down.TabIndex = 3;
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // door_down_right
            // 
            this.door_down_right.Image = ((System.Drawing.Image)(resources.GetObject("door_down_right.Image")));
            this.door_down_right.Location = new System.Drawing.Point(194, 400);
            this.door_down_right.Name = "door_down_right";
            this.door_down_right.Size = new System.Drawing.Size(64, 172);
            this.door_down_right.TabIndex = 8;
            this.door_down_right.TabStop = false;
            // 
            // door_down_left
            // 
            this.door_down_left.Image = global::elevator.Properties.Resources.DOOR_RIGHT;
            this.door_down_left.Location = new System.Drawing.Point(131, 400);
            this.door_down_left.Name = "door_down_left";
            this.door_down_left.Size = new System.Drawing.Size(64, 172);
            this.door_down_left.TabIndex = 7;
            this.door_down_left.TabStop = false;
            // 
            // door_up_right
            // 
            this.door_up_right.Image = ((System.Drawing.Image)(resources.GetObject("door_up_right.Image")));
            this.door_up_right.Location = new System.Drawing.Point(194, 132);
            this.door_up_right.Name = "door_up_right";
            this.door_up_right.Size = new System.Drawing.Size(64, 172);
            this.door_up_right.TabIndex = 6;
            this.door_up_right.TabStop = false;
            // 
            // door_up_left
            // 
            this.door_up_left.Image = global::elevator.Properties.Resources.DOOR_RIGHT;
            this.door_up_left.Location = new System.Drawing.Point(131, 132);
            this.door_up_left.Name = "door_up_left";
            this.door_up_left.Size = new System.Drawing.Size(63, 172);
            this.door_up_left.TabIndex = 5;
            this.door_up_left.TabStop = false;
            // 
            // btn_g
            // 
            this.btn_g.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_g.BackgroundImage")));
            this.btn_g.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_g.Location = new System.Drawing.Point(364, 500);
            this.btn_g.Name = "btn_g";
            this.btn_g.Size = new System.Drawing.Size(40, 40);
            this.btn_g.TabIndex = 2;
            this.btn_g.UseVisualStyleBackColor = true;
            this.btn_g.Click += new System.EventHandler(this.btn_g_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_1.BackgroundImage")));
            this.btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_1.Location = new System.Drawing.Point(364, 232);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(40, 40);
            this.btn_1.TabIndex = 1;
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 172);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::elevator.Properties.Resources.flower_pot;
            this.pictureBox3.Location = new System.Drawing.Point(33, 522);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(255, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 172);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(255, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(66, 172);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(69, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(66, 172);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(69, 400);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(66, 172);
            this.panel4.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(878, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "clear log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1170, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.display_box2);
            this.Controls.Add(this.display_box3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.door_down_right);
            this.Controls.Add(this.door_down_left);
            this.Controls.Add(this.door_up_right);
            this.Controls.Add(this.door_up_left);
            this.Controls.Add(this.btn_g);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_box3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_down_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_down_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_up_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_up_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_down;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer_up;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_g;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.PictureBox door_up_left;
        private System.Windows.Forms.PictureBox door_up_right;
        private System.Windows.Forms.PictureBox door_down_left;
        private System.Windows.Forms.PictureBox door_down_right;
        private System.Windows.Forms.Timer timer_door_open_down;
        private System.Windows.Forms.Timer timer_door_close_down;
        private System.Windows.Forms.Timer timer_door_open_up;
        private System.Windows.Forms.Timer timer_door_close_up;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox display_box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox display_box3;
        private System.Windows.Forms.PictureBox display_box2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
    }
}

