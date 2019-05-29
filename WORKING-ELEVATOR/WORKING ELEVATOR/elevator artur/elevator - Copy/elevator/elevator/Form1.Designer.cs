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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_up = new System.Windows.Forms.Timer(this.components);
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_g = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.door_up_left = new System.Windows.Forms.PictureBox();
            this.door_up_right = new System.Windows.Forms.PictureBox();
            this.door_down_left = new System.Windows.Forms.PictureBox();
            this.door_down_right = new System.Windows.Forms.PictureBox();
            this.timer_door_open_down = new System.Windows.Forms.Timer(this.components);
            this.timer_door_close_down = new System.Windows.Forms.Timer(this.components);
            this.timer_door_open_up = new System.Windows.Forms.Timer(this.components);
            this.timer_door_close_up = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_up_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_up_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_down_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_down_right)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_down
            // 
            this.timer_down.Interval = 1;
            this.timer_down.Tick += new System.EventHandler(this.timer_down_Tick);
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
            // timer_up
            // 
            this.timer_up.Interval = 1;
            this.timer_up.Tick += new System.EventHandler(this.timer_up_Tick);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(540, 168);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 23);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "btn_1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_g
            // 
            this.btn_g.Location = new System.Drawing.Point(540, 461);
            this.btn_g.Name = "btn_g";
            this.btn_g.Size = new System.Drawing.Size(75, 23);
            this.btn_g.TabIndex = 2;
            this.btn_g.Text = "btn_g";
            this.btn_g.UseVisualStyleBackColor = true;
            this.btn_g.Click += new System.EventHandler(this.btn_g_Click);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(867, 168);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 23);
            this.btn_down.TabIndex = 3;
            this.btn_down.Text = "btn_down";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(867, 120);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 4;
            this.btn_up.Text = "btn_up";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // door_up_left
            // 
            this.door_up_left.Image = ((System.Drawing.Image)(resources.GetObject("door_up_left.Image")));
            this.door_up_left.Location = new System.Drawing.Point(131, 132);
            this.door_up_left.Name = "door_up_left";
            this.door_up_left.Size = new System.Drawing.Size(63, 172);
            this.door_up_left.TabIndex = 5;
            this.door_up_left.TabStop = false;
            // 
            // door_up_right
            // 
            this.door_up_right.Image = ((System.Drawing.Image)(resources.GetObject("door_up_right.Image")));
            this.door_up_right.Location = new System.Drawing.Point(192, 132);
            this.door_up_right.Name = "door_up_right";
            this.door_up_right.Size = new System.Drawing.Size(64, 172);
            this.door_up_right.TabIndex = 6;
            this.door_up_right.TabStop = false;
            // 
            // door_down_left
            // 
            this.door_down_left.Image = ((System.Drawing.Image)(resources.GetObject("door_down_left.Image")));
            this.door_down_left.Location = new System.Drawing.Point(73, 400);
            this.door_down_left.Name = "door_down_left";
            this.door_down_left.Size = new System.Drawing.Size(64, 172);
            this.door_down_left.TabIndex = 7;
            this.door_down_left.TabStop = false;
            // 
            // door_down_right
            // 
            this.door_down_right.Image = ((System.Drawing.Image)(resources.GetObject("door_down_right.Image")));
            this.door_down_right.Location = new System.Drawing.Point(250, 400);
            this.door_down_right.Name = "door_down_right";
            this.door_down_right.Size = new System.Drawing.Size(64, 172);
            this.door_down_right.TabIndex = 8;
            this.door_down_right.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 703);
            this.Controls.Add(this.door_down_right);
            this.Controls.Add(this.door_down_left);
            this.Controls.Add(this.door_up_right);
            this.Controls.Add(this.door_up_left);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_g);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_up_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_up_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_down_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_down_right)).EndInit();
            this.ResumeLayout(false);

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
    }
}

