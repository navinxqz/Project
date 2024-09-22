﻿using GameServer_Management.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameServer_Management.Forms
{
    public partial class UserDB : Form
    {
        public UserDB()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            try
            {
                string query = @"select userid, CONCAT(firstname, ' ', lastname), gender, email, username, upass, dob from usertbl where username like '%"+ searchBox.Text+"%'";

                ListBox l = new ListBox();
                l.Items.Add(dgvId);
                l.Items.Add(dgvName);
                l.Items.Add(dgvGender);
                l.Items.Add(dgvEmail);
                l.Items.Add(dgvusername);
                l.Items.Add(dgvDOB);

                DBconnect.LoadData(query, dataGridView1, l);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data! {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserDB_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
