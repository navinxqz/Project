﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameServer_Management.Controller
{
    public partial class signupcomplete : UserControl
    {
        public signupcomplete()
        {
            InitializeComponent();
        }
        public string txt
        {
            get { return txtlabel.Text; }
            set { txtlabel.Text = value; }
        }
    }
}
