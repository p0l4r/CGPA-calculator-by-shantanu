using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGPA_calculator_by_shantanu
{
    public partial class Form1 : Form
    {
        double t_credit = 0;
        double t_cgpa = 0.0;
        double c_credit;
        double c_cgpa ;
        double c1 = 0.0, c2 = 0.0, c3 = 0.0, c4 = 0.0, c5 = 0.0;
        double g1 = 0.00, g2 = 0.00, g3 = 0.00, g4 = 0.00, g5 = 0.00;
    


        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1 = double.Parse(comboBox1.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            c2 = double.Parse(comboBox2.Text);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            c3 = double.Parse(comboBox3.Text);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            c4 = double.Parse(comboBox4.Text);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            c5 = double.Parse(comboBox5.Text);
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox6.Text)
            {
                case "A+":
                    g1 = 4.00;
                    break;
                case "A":
                    g1 = 4.00;
                    break;
                case "A-":
                    g1 = 3.70;
                    break;
                case "B+":
                    g1 = 3.30;
                    break;
                case "B":
                    g1 = 3.00;
                    break;
                case "B-":
                    g1 = 2.70;
                    break;
                case "C+":
                    g1 = 2.30;
                    break;
                case "C":
                    g1 = 2.00;
                    break;
                case "C-":
                    g1 = 1.70;
                    break;
                case "D+":
                    g1 = 1.30;
                    break;
                case "D":
                    g1 = 1.00;
                    break;
                case "F":
                    g1 = 0.00;
                    break;
                default:
                    g1 = 0.00;
                    break;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox7.Text)
            {
                case "A+":
                    g2 = 4.00;
                    break;
                case "A":
                    g2 = 4.00;
                    break;
                case "A-":
                    g2 = 3.70;
                    break;
                case "B+":
                    g2 = 3.30;
                    break;
                case "B":
                    g2 = 3.00;
                    break;
                case "B-":
                    g2 = 2.70;
                    break;
                case "C+":
                    g2 = 2.30;
                    break;
                case "C":
                    g2 = 2.00;
                    break;
                case "C-":
                    g2 = 1.70;
                    break;
                case "D+":
                    g2 = 1.30;
                    break;
                case "D":
                    g2 = 1.00;
                    break;
                case "F":
                    g2 = 0.00;
                    break;
                default:
                    g2 = 0.00;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 popup = new Form2();
            DialogResult dialogresult = popup.ShowDialog();
       
            popup.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "0.00";
          
            t_credit = 0;
            t_cgpa = 0.0;
            c1 = 0.0;
            c2 = 0.0;
            c3 = 0.0;
            c4 = 0.0;
            c5 = 0.0;
            g1 = 0.00;
            g2 = 0.00;
            g3 = 0.00;
            g4 = 0.00;
            g5 = 0.00;
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox8.Text)
            {
                case "A+":
                    g3 = 4.00;
                    break;
                case "A":
                    g3 = 4.00;
                    break;
                case "A-":
                    g3 = 3.70;
                    break;
                case "B+":
                    g3 = 3.30;
                    break;
                case "B":
                    g3 = 3.00;
                    break;
                case "B-":
                    g3 = 2.70;
                    break;
                case "C+":
                    g3 = 2.30;
                    break;
                case "C":
                    g3 = 2.00;
                    break;
                case "C-":
                    g3 = 1.70;
                    break;
                case "D+":
                    g3 = 1.30;
                    break;
                case "D":
                    g3 = 1.00;
                    break;
                case "F":
                    g3 = 0.00;
                    break;
                default:
                    g3 = 0.00;
                    break;
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox9.Text)
            {
                case "A+":
                    g4 = 4.00;
                    break;
                case "A":
                    g4 = 4.00;
                    break;
                case "A-":
                    g4 = 3.70;
                    break;
                case "B+":
                    g4 = 3.30;
                    break;
                case "B":
                    g4 = 3.00;
                    break;
                case "B-":
                    g4 = 2.70;
                    break;
                case "C+":
                    g4 = 2.30;
                    break;
                case "C":
                    g4 = 2.00;
                    break;
                case "C-":
                    g4 = 1.70;
                    break;
                case "D+":
                    g4 = 1.30;
                    break;
                case "D":
                    g4 = 1.00;
                    break;
                case "F":
                    g4 = 0.00;
                    break;
                default:
                    g4 = 0.00;
                    break;
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox10.Text)
            {
                case "A+":
                    g5 = 4.00;
                    break;
                case "A":
                    g5 = 4.00;
                    break;
                case "A-":
                    g5 = 3.70;
                    break;
                case "B+":
                    g5 = 3.30;
                    break;
                case "B":
                    g5 = 3.00;
                    break;
                case "B-":
                    g5 = 2.70;
                    break;
                case "C+":
                    g5 = 2.30;
                    break;
                case "C":
                    g5 = 2.00;
                    break;
                case "C-":
                    g5 = 1.70;
                    break;
                case "D+":
                    g5 = 1.30;
                    break;
                case "D":
                    g5 = 1.00;
                    break;
                case "F":
                    g5 = 0.00;
                    break;
                default:
                    g5 = 0.00;
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            c_cgpa = double.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            c_credit = double.Parse(textBox2.Text);
        }

    

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            t_credit = c1 + c2 + c3 + c4 + c5;
            t_cgpa = (c1 * g1) + (c2 * g2) + (c3 * g3) + (c4 * g4) + (c5 * g5);
            double result;
            result = Math.Round((((c_cgpa * c_credit) + t_cgpa) / (c_credit + t_credit)),2);
            textBox3.Text = textBox3.Text + (result).ToString();
        }
    }
}
