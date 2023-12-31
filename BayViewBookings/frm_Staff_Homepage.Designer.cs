﻿
namespace BayViewBookings
{
    partial class frm_Staff_Homepage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_viewBookings = new System.Windows.Forms.Button();
            this.btn_RoomAvail = new System.Windows.Forms.Button();
            this.btn_Transactions = new System.Windows.Forms.Button();
            this.btn_exitStaff = new System.Windows.Forms.Button();
            this.pnl_staff = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_X = new System.Windows.Forms.Button();
            this.btn_Staff_Rooms = new System.Windows.Forms.Button();
            this.btn_Staff_Bookings = new System.Windows.Forms.Button();
            this.btn_Staff_Guests = new System.Windows.Forms.Button();
            this.lbl_Welcome_Msg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_staff.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_viewBookings);
            this.panel1.Controls.Add(this.btn_RoomAvail);
            this.panel1.Controls.Add(this.btn_Transactions);
            this.panel1.Controls.Add(this.btn_exitStaff);
            this.panel1.Location = new System.Drawing.Point(0, 578);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 102);
            this.panel1.TabIndex = 1;
            // 
            // btn_viewBookings
            // 
            this.btn_viewBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewBookings.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewBookings.ForeColor = System.Drawing.Color.White;
            this.btn_viewBookings.Location = new System.Drawing.Point(264, 10);
            this.btn_viewBookings.Name = "btn_viewBookings";
            this.btn_viewBookings.Size = new System.Drawing.Size(120, 82);
            this.btn_viewBookings.TabIndex = 4;
            this.btn_viewBookings.Text = "View Bookings";
            this.btn_viewBookings.UseVisualStyleBackColor = true;
            this.btn_viewBookings.Click += new System.EventHandler(this.btn_viewBookings_Click);
            // 
            // btn_RoomAvail
            // 
            this.btn_RoomAvail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RoomAvail.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RoomAvail.ForeColor = System.Drawing.Color.White;
            this.btn_RoomAvail.Location = new System.Drawing.Point(138, 10);
            this.btn_RoomAvail.Name = "btn_RoomAvail";
            this.btn_RoomAvail.Size = new System.Drawing.Size(120, 82);
            this.btn_RoomAvail.TabIndex = 3;
            this.btn_RoomAvail.Text = "Room Availability";
            this.btn_RoomAvail.UseVisualStyleBackColor = true;
            this.btn_RoomAvail.Click += new System.EventHandler(this.btn_RoomAvail_Click);
            // 
            // btn_Transactions
            // 
            this.btn_Transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Transactions.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Transactions.ForeColor = System.Drawing.Color.White;
            this.btn_Transactions.Location = new System.Drawing.Point(12, 10);
            this.btn_Transactions.Name = "btn_Transactions";
            this.btn_Transactions.Size = new System.Drawing.Size(120, 82);
            this.btn_Transactions.TabIndex = 2;
            this.btn_Transactions.Text = "Transactions";
            this.btn_Transactions.UseVisualStyleBackColor = true;
            this.btn_Transactions.Click += new System.EventHandler(this.btn_Transactions_Click);
            // 
            // btn_exitStaff
            // 
            this.btn_exitStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exitStaff.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitStaff.ForeColor = System.Drawing.Color.White;
            this.btn_exitStaff.Location = new System.Drawing.Point(1104, 10);
            this.btn_exitStaff.Name = "btn_exitStaff";
            this.btn_exitStaff.Size = new System.Drawing.Size(120, 82);
            this.btn_exitStaff.TabIndex = 0;
            this.btn_exitStaff.Text = "Exit";
            this.btn_exitStaff.UseVisualStyleBackColor = true;
            this.btn_exitStaff.Click += new System.EventHandler(this.btn_exitStaff_Click);
            // 
            // pnl_staff
            // 
            this.pnl_staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_staff.Controls.Add(this.btn_Logout);
            this.pnl_staff.Controls.Add(this.btn_X);
            this.pnl_staff.Controls.Add(this.btn_Staff_Rooms);
            this.pnl_staff.Controls.Add(this.btn_Staff_Bookings);
            this.pnl_staff.Controls.Add(this.btn_Staff_Guests);
            this.pnl_staff.Controls.Add(this.lbl_Welcome_Msg);
            this.pnl_staff.ForeColor = System.Drawing.Color.White;
            this.pnl_staff.Location = new System.Drawing.Point(0, 0);
            this.pnl_staff.Name = "pnl_staff";
            this.pnl_staff.Size = new System.Drawing.Size(1240, 48);
            this.pnl_staff.TabIndex = 4;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(1119, 3);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 28);
            this.btn_Logout.TabIndex = 7;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_X
            // 
            this.btn_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_X.ForeColor = System.Drawing.Color.White;
            this.btn_X.Location = new System.Drawing.Point(1200, 3);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(33, 28);
            this.btn_X.TabIndex = 6;
            this.btn_X.Text = "X";
            this.btn_X.UseVisualStyleBackColor = false;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
            // 
            // btn_Staff_Rooms
            // 
            this.btn_Staff_Rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Staff_Rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Staff_Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff_Rooms.ForeColor = System.Drawing.Color.White;
            this.btn_Staff_Rooms.Location = new System.Drawing.Point(443, -3);
            this.btn_Staff_Rooms.Name = "btn_Staff_Rooms";
            this.btn_Staff_Rooms.Size = new System.Drawing.Size(150, 54);
            this.btn_Staff_Rooms.TabIndex = 3;
            this.btn_Staff_Rooms.Text = "View Rooms";
            this.btn_Staff_Rooms.UseVisualStyleBackColor = false;
            this.btn_Staff_Rooms.Click += new System.EventHandler(this.btn_Staff_Rooms_Click);
            // 
            // btn_Staff_Bookings
            // 
            this.btn_Staff_Bookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Staff_Bookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Staff_Bookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff_Bookings.ForeColor = System.Drawing.Color.White;
            this.btn_Staff_Bookings.Location = new System.Drawing.Point(296, -3);
            this.btn_Staff_Bookings.Name = "btn_Staff_Bookings";
            this.btn_Staff_Bookings.Size = new System.Drawing.Size(150, 54);
            this.btn_Staff_Bookings.TabIndex = 2;
            this.btn_Staff_Bookings.Text = "New Booking";
            this.btn_Staff_Bookings.UseVisualStyleBackColor = false;
            this.btn_Staff_Bookings.Click += new System.EventHandler(this.btn_Staff_Bookings_Click);
            // 
            // btn_Staff_Guests
            // 
            this.btn_Staff_Guests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Staff_Guests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Staff_Guests.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff_Guests.ForeColor = System.Drawing.Color.White;
            this.btn_Staff_Guests.Location = new System.Drawing.Point(149, -3);
            this.btn_Staff_Guests.Name = "btn_Staff_Guests";
            this.btn_Staff_Guests.Size = new System.Drawing.Size(150, 54);
            this.btn_Staff_Guests.TabIndex = 1;
            this.btn_Staff_Guests.Text = "View Guests";
            this.btn_Staff_Guests.UseVisualStyleBackColor = false;
            this.btn_Staff_Guests.Click += new System.EventHandler(this.btn_Staff_Guests_Click);
            // 
            // lbl_Welcome_Msg
            // 
            this.lbl_Welcome_Msg.AutoSize = true;
            this.lbl_Welcome_Msg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Welcome_Msg.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome_Msg.ForeColor = System.Drawing.Color.White;
            this.lbl_Welcome_Msg.Location = new System.Drawing.Point(699, 9);
            this.lbl_Welcome_Msg.Name = "lbl_Welcome_Msg";
            this.lbl_Welcome_Msg.Size = new System.Drawing.Size(294, 30);
            this.lbl_Welcome_Msg.TabIndex = 0;
            this.lbl_Welcome_Msg.Text = "#GREETING TIME#, #NAME#";
            // 
            // frm_Staff_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BayViewBookings.Properties.Resources.HEADER_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1236, 677);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_staff);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_Staff_Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage | Staff";
            this.Load += new System.EventHandler(this.frm_Staff_Homepage_Load);
            this.panel1.ResumeLayout(false);
            this.pnl_staff.ResumeLayout(false);
            this.pnl_staff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exitStaff;
        private System.Windows.Forms.Button btn_viewBookings;
        private System.Windows.Forms.Button btn_RoomAvail;
        private System.Windows.Forms.Button btn_Transactions;
        private System.Windows.Forms.Panel pnl_staff;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Button btn_Staff_Rooms;
        private System.Windows.Forms.Button btn_Staff_Bookings;
        private System.Windows.Forms.Button btn_Staff_Guests;
        private System.Windows.Forms.Label lbl_Welcome_Msg;
    }
}