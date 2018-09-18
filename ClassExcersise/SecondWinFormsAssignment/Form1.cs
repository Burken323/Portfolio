using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondWinFormsAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kurs crs = null;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crs = new Kurs();
            crs.Namn = textBox1.Text;
            crs.Poäng = float.Parse(textBox2.Text);
            crs.StartDatum = dateTimePicker2.Text;
            crs.SlutDatum = dateTimePicker1.Text;
            MessageBox.Show("Kurs: " + crs.Namn + "\r\n" + "Poäng: " + crs.Poäng + "\r\n" + "Startdatum: " + crs.StartDatum + "\r\n" + "Slutdatum: " + crs.SlutDatum);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            float poäng = crs.PoängPerKursDag();
            MessageBox.Show("Antal poäng per kursdag: " + poäng);
            Form1.ActiveForm.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            double dagar = crs.AntalKursDagar();
            MessageBox.Show("Antal kursdagar: " + dagar);
        }
    }
}
