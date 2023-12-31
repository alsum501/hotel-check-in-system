﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BayViewBookings
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        Timer t1 = new Timer();
        // these variables had been set but not used
        //SQLiteConnection dbCon = new SQLiteConnection();
        //SQLiteCommand dbcmd = new SQLiteCommand();
        const string details = @"Data Source = ..\..\Database\bookings.db";

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   // this stops the timer if the form is completely displayed
            else
                Opacity += 0.03;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lbl_managed_by.Text = null;
            this.Visible = false;
            Opacity = 0;     

            t1.Interval = 10;  
            t1.Tick += new EventHandler(fadeIn); 
            t1.Start();
            this.AcceptButton = btn_login; // this makes it so that when enter is pressed the login button will be executed

            pnl_login.Location = new Point(
            this.ClientSize.Width / 2 - pnl_login.Size.Width / 2,
            this.ClientSize.Height / 2 - pnl_login.Size.Height / 2);
            pnl_login.Anchor = AnchorStyles.None;

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dbCon = new SQLiteConnection(details))
                {
                    dbCon.Open();
                    
                    using (var dbcmd = new SQLiteCommand("SELECT Employee_ID, Username, Password FROM Employee WHERE Username=@Username AND Password=@Password", dbCon))
                    {
                        dbcmd.Parameters.AddWithValue("@Username", txt_username.Text);
                        dbcmd.Parameters.AddWithValue("@Password", txt_password.Text);
                        using (var reader = dbcmd.ExecuteReader())
                        {
                            if (reader.Read()) // if there are any results to read from the database
                            {
                                // if the label is set to "Manager" then they are a manager, otherwise a staff member has logged in.
                                if (lbl_managed_by.Text == "Manager") 
                                {
                                   
                                    frm_Manager_Homepage frm2 = new frm_Manager_Homepage();
                                    frm2.FirstName = lbl_firstname.Text;
                                    frm2.UserID = reader.GetInt64(0);
                                    frm2.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    // this was only required for testing purposes
                                    //MessageBox.Show("Staff"); 

                                    frm_Staff_Homepage frm3 = new frm_Staff_Homepage();
                                    frm3.FirstName = lbl_firstname.Text;
                                    frm3.UserID = reader.GetInt64(0);
                                    frm3.Show();
                                    this.Hide();
                                }
                            }
                            else // the details don't match and the password box is reset for the user to try again.
                            {
                                MessageBox.Show("Please recheck your details");
                                txt_password.Text = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
           
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            lbl_managed_by.Text = "";
            // get all the details of the employee that matches the username entered
            string Query = "Select * From Employee Where Username=@Username";
            SQLiteConnection myConn = new SQLiteConnection(details);
            SQLiteCommand cmdDataBase = new SQLiteCommand(Query, myConn);
            cmdDataBase.Parameters.AddWithValue("@Username", txt_username.Text);

            try
            {
                myConn.Open();
                SQLiteDataReader dbreader = cmdDataBase.ExecuteReader();

                while (dbreader.Read())
                {

                    string role = dbreader.GetString(6);
                    string firstName = dbreader.GetString(1);
                    lbl_managed_by.Text = role; // gets role to depend on username and whether staff/manager login
                    lbl_firstname.Text = firstName; // also stores their actual name

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myConn.Close();
            }
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really quit?", "Exit Program",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK) // pops up a message and if the user clicks OK the program closes
            {
                Environment.Exit(0);
            }
        }
    }
 }

