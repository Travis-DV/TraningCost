using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traningcost
{
    public partial class Form1 : Form
    {
        //money time
        private int[] costs = { 0, 0 };
        private int locationcost = 0;
        private bool[] locationcorsechosen = { false, false };

        public Form1()
        {
            InitializeComponent();
        }
        private void centerlb()
        {
            //width height
            int[] buffer = { 0, 30 };
            int width = (this.Size.Width / 2) - (outputLB.Width / 2) + buffer[0];
            int height = (this.Size.Height / 2) - (outputLB.Height / 2) + buffer[1];
            outputLB.Location = new Point(width, height);
        }

        private void calculatecost()
        {
            if (locationcorsechosen[0] && locationcorsechosen[1])
            {
                costs[0] += costs[1] * locationcost;
                outputLB.Text = $"Total cost: ${costs[0]}";
                centerlb();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            locationcorsechosen[0] = false;
            costs[0] = 0;
            costs[1] = 0;
            int[,] timecost = { { 3, 1000 }, { 3, 800 }, { 3, 1500 }, { 5, 1300 }, { 1, 500 } };
            for (int i = 0; i < timecost.Length/2; i++)
            {
                if (classCHBX.GetItemChecked(i))
                {
                    costs[0] += timecost[i,1];
                    costs[1] += timecost[i, 0];
                    locationcorsechosen[0] = true;
                }
            }
            calculatecost();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            centerlb();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            locationcorsechosen[1] = true;
            int temp = listBox1.SelectedIndex;
            int[] locationcosts = { 150, 225, 175, 175, 150 };
            locationcost = locationcosts[temp];
            calculatecost();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            centerlb();
        }
    }
}
