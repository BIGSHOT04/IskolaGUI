﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO

namespace iskolaGUI2
{
    public partial class Form1 : Form
    {
        List<tanulo> tanulok = new List<tanulo>();
        BindingSource bs;



        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void btnBetölt_Click(object sender, EventArgs e)
        {
            foreach (var sor in File.ReadAllLines("nevek.txt"))
            {
                tanulok.add(new tanulo(sor));

            }

            bs = new BindingSource();
            bs.datasource = tanulok;
            List.datasource = bs;
            ListBox.displaymember = "név";
        }

        private void btnTörlés_Click(object sender, EventArgs e)
        {
            tanulók.removeat(listBox1.SelectedIndex);
            bs.resetbindings(false);

        }
    }
}
