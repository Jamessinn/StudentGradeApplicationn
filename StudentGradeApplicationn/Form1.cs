using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace StudentGradeApplicationn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ScienceSubject = Convert.ToDouble(textBox2.Text);
            double MathSubject = Convert.ToDouble(textBox3.Text);
            double PESubject = Convert.ToDouble(textBox4.Text);
            double ValuesSubject = Convert.ToDouble(textBox5.Text);
            double HistorySubject = Convert.ToDouble(textBox6.Text);

            double totalGrade = ScienceSubject  + MathSubject + PESubject + ValuesSubject + HistorySubject;
            double gradeAverage = totalGrade / 5;

            label7.Text = gradeAverage >= 75.00 ? "            The Student passed\n        " + " The general average of " + textBox1.Text + " is " + gradeAverage : "               The Student Failed\n                " + "The general average of " + textBox1.Text + " is " + gradeAverage;

        }
    }
}
