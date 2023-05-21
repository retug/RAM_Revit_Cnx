using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAM_Revit_Cnx2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getRAMResults_Click(object sender, EventArgs e)
        {
            int x = RAMModel.RunStuff();
            MessageBox.Show("You clicked me" + x.ToString());
            string RSSFileName = "I:\\Common\\06 Employee Personal Folders\\Austin Guter\\TestRAMModel\\testModel.rss";
            floorListBox.DataSource = RAMModel.GET_STORY_NAMES(RSSFileName);
            

        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void getGridInfo_Click(object sender, EventArgs e)
        {
            if (floorListBox.SelectedIndex > -1) //somthing was selected
            {
                string RSSFileName = "I:\\Common\\06 Employee Personal Folders\\Austin Guter\\TestRAMModel\\testModel.rss";
                int storyValue = floorListBox.SelectedIndex;
                List<string> gridNames = new List<string>();
                gridNames = RAMModel.GET_GRID_NAMES(RSSFileName, storyValue);
                gridListBox.DataSource = gridNames;
            }
                
            else //ensure that a user selects a level
            {
                MessageBox.Show("Please select a level, if no levels are shown above, click 'Gather RAM Info'");
            }
            

        }
    }
}
