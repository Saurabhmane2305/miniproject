﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyFarmTool
{
    public partial class CowsHealth : Form
    {
        public CowsHealth()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {
            Cows Ob = new Cows();
            Ob.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MilkProduction Ob = new MilkProduction();
            Ob.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Breeding Ob = new Breeding();
            Ob.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Milk_Sales Ob = new Milk_Sales();
            Ob.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {

            Finance Ob = new Finance();
            Ob.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {

            Dashboard Ob = new Dashboard();
            Ob.Show();
            this.Hide();
        }

        private void CowsHealth_Load(object sender, EventArgs e)
        {

        }
    }
}
