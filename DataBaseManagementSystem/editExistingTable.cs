﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseManagementSystem
{
    public partial class editExistingTable : Form
    {
        sqlQueries sqlQue;
        private MainForm refForm;

        public editExistingTable()
        {
            InitializeComponent();
        }
        
        // constuctor to access req fielsd and methods
        public editExistingTable(string cP, MainForm _refForm)
        {
            sqlQue = new sqlQueries(cP);
            this.refForm = _refForm;

            InitializeComponent();
        }
    }
}
