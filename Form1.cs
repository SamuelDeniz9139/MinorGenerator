using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MinorGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.minorComBox.SelectedIndex = 0;
            showButton.Click += new EventHandler(showMinors);
        }
        private void showMinors(object s, EventArgs e)
        {//makes the minor recommendations visible
            int arrItem = minorComBox.SelectedIndex;
            String[] artMinors = { "Drawing I", "Drawing for Non-Majors", "Drawing II", "Introduction to Painting", "Painting", "Watercolors", "Painting the Figure", "Fine Art Drawing", "Printmaking", "Figure Drawing" };
            String[] envMinors = { "Concepts of Environmental Science", "Soil Science", "Science in the Garden", "General Ecology", "Urban Ecology", "Climate Change- Science Technology & Policy", "General Ecology", "Marine Biology", "Freshwater Ecology", "Conservation Biology", "Wetlands" };
            String[] imaMinors = { "Imaging Sciences", "Color Management Technology", "Retouch and Restore", "The Fine Print Workflow", "Color Measurement", "Digital Imaging Processing", "Digital Color Management", "High Speed Photography", "e-Sensitometry", "Advanced Retouching and Compositing", "Media Production and Technology", "Preservation Care of Photographs" };
            String[] astMinors = { "Imaging Detectors", "Observational Astronomy", "Extragalactic Astrophysics and Cosmology", "Galactic Astrophysics", "Stellar Astrophysics", "University Astronomy", "Modern Physics I", "Project-based Calculus I", "Project-based Calculus II", "University Astronomy", "University Physics I", "University Physics II" };
            String[] entMinors = { "Entrepreneurship", "Real World Business Solutions", "Financial Accounting", "Organizational Behavior", "Finaning New Ventures", "Management Accounting", "Principles of Marketing", "Digital Marketing" };
            String[] eleMinors = { "Circuits I", "Circuits II", "Project Based Calculus II", "University Physics II", "Linear Systems", "EM Fields and Transmission Lines", "Communication Systems", "Mechatronics", "Embedded System Design", "Analog Electronics", "Classical Control", "Digital Electronics" };
            String[][] minors = { artMinors, envMinors, imaMinors, astMinors, entMinors, eleMinors };
            Label[] labels = new Label[10];
            Label[] usedLabels = new Label[7];
            labels[0] = this.label1;
            labels[1] = this.label2;
            labels[2] = this.label3;
            labels[3] = this.label4;
            labels[4] = this.label5;
            labels[5] = this.label6;
            labels[6] = this.label7;
            labels[7] = this.label8;
            labels[8] = this.label9;
            labels[9] = this.label10;
            usedLabels[0] = this.label11;
            usedLabels[1] = this.label12;
            usedLabels[2] = this.label13;
            usedLabels[3] = this.label14;
            usedLabels[4] = this.label15;
            usedLabels[5] = this.label16;
            usedLabels[6] = this.label17;
            for(int f=0;f<labels.Length;f++)
            {//these are for all the labels in the recommendations groupBox
                if(f<minors[arrItem].Length)
                {
                    for(int h=0;h<minors[arrItem].Length;h++)
                    {
                        if(minors[arrItem][f]=classInfo.className)
                        {
                            usedLabels[f].Text = minors[arrItem][f];
                        }
                        else
                        {
                            labels[f].Text = minors[arrItem][f];
                        }
                    }
                }
                else
                {//if it goes over the array's second length, this is a failsafe
                    labels[f].Text = "";
                }
            }
            for (int f = 0; f < usedLabels.Length; f++)
            {//these are for all the labels in the already taken groupBox
                if (f < minors[arrItem].Length)
                {
                    usedLabels[f].Text = minors[arrItem][f];
                }
                else
                {//if it goes over the array's second length, this is a failsafe
                    usedLabels[f].Text = "";
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}