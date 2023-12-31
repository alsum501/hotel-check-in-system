﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Data.SQLite;

namespace BayViewBookings
{
    public partial class frm_ViewReports : Form
    {
        public frm_ViewReports()
        {
            InitializeComponent();
        }

        SQLiteDataAdapter daRoomsCheck;
        DataTable dtdaRoomsCheck = new DataTable();
        const string details = @"Data Source = ..\..\Database\bookings.db";
        Decimal numberofrows;

        private void frm_ViewReports_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft YaHei UI, 9.75pt", 10.5F, GraphicsUnit.Pixel);

            try //gathers the total amount of rooms
            {
                SQLiteConnection conn = new SQLiteConnection(details);
                SQLiteCommand cmd = new SQLiteCommand("select * from Room");
                SQLiteDataAdapter ap = new SQLiteDataAdapter(cmd.CommandText, conn);
                DataSet ds = new DataSet();

                conn.Open();
                ap.Fill(ds);

                numberofrows = ds.Tables[0].Rows.Count;
                lbl_totalrooms.Text = numberofrows.ToString();
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();

                using (var dbCon = new SQLiteConnection(details))
                {

                    string sqlCheck =
                        @"SELECT r.* FROM room r"
                        + " JOIN RoomBooking b ON b.Room_ID = r.Room_ID"
                        + " JOIN Booking c ON b.Booking_ID = c.Booking_ID"
                       + " WHERE c.Check_In BETWEEN '" + Convert.ToDateTime(txt_checkIn.Text).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(txt_checkOut.Text).ToString("yyyy-MM-dd") + "'"
                       + " OR c.Check_Out BETWEEN '" + Convert.ToDateTime(txt_checkIn.Text).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(txt_checkOut.Text).ToString("yyyy-MM-dd") + "'"
                       + " OR (c.Check_In < '" + Convert.ToDateTime(txt_checkIn.Text).ToString("yyyy-MM-dd") + "' AND c.Check_Out > '" + Convert.ToDateTime(txt_checkOut.Text).ToString("yyyy-MM-dd") + "')";

                    daRoomsCheck = new SQLiteDataAdapter(sqlCheck, dbCon);
                    dtdaRoomsCheck.Clear();
                    daRoomsCheck.Fill(dtdaRoomsCheck);

                    dataGridView1.DataSource = dtdaRoomsCheck;
                    int numRows = dataGridView1.Rows.Count - 1;

                    lbl_available_rooms.Text = numRows.ToString();
                    // dataGridView1.DisplayMember = "Dates";
                    // dataGridView1.ValueMember = "Booking_ID";


                    Decimal occupancyrates = numRows / numberofrows * 100;
                    Decimal DEBITAMT = Convert.ToDecimal(string.Format("{0:0.00}", occupancyrates));
                    lbl_occupancyrates.Text = DEBITAMT.ToString() + "%";
                    if (occupancyrates >= 70)
                    {
                        lbl_occupancyrates.ForeColor = Color.Green;
                    }
                    else
                    {
                        lbl_occupancyrates.ForeColor = Color.Red;
                    }
                    pnl_kpioccupancy.Visible = true;
                    pnl_kpirooms.Visible = true;
                    pnl_kpiunavaialble.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Quit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_exitViewReport_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveFileDialogTest.Title = "Save Report";
            saveFileDialogTest.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialogTest.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialogTest.FilterIndex = 1;
            saveFileDialogTest.FileName = "";
            if (saveFileDialogTest.ShowDialog() != DialogResult.Cancel)  // if they do not click the cancel button
            {
                try
                {
                    StreamWriter write = new StreamWriter(File.Create(saveFileDialogTest.FileName));

                    string str = "";
                    int row = dataGridView1.Rows.Count;
                    int cell = dataGridView1.Rows[1].Cells.Count;
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < cell; j++)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value == null)
                            {
                                //or set a value for the empty data
                                dataGridView1.Rows[i].Cells[j].Value = "";
                            }
                            str += dataGridView1.Rows[i].Cells[j].Value.ToString() + ",";
                        }
                    }
                    write.WriteLine(str);

                    write.Close();
                    write.Dispose();

                    MessageBox.Show("File Saved");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message);
                }
                
            }

        }
    }
}    