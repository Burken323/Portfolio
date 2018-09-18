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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Student stu = null;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stu = new Student();
            stu.Förnamn = Förnamn.Text;
            stu.Efternamn = Efternamn.Text;
            stu.PersonNummer = Personnummer.Text;
            stu.Telefon = Telefon.Text;
            stu.Email = Email.Text;
            string missing = null;
            if (stu.KontrolleraVärden(missing))
            {
                MessageBox.Show("Förnamn: " + stu.Förnamn + "\r\n" +
                            "Efternamn: " + stu.Efternamn + "\r\n" +
                            "Personnummer: " + stu.PersonNummer + "\r\n" +
                            "Telefon: " + stu.Telefon + "\r\n" +
                            "Email: " + stu.Email);
            }
            else
            {
                MessageBox.Show("Missing field: " + missing);

            }
            
            
        }
    }
}
