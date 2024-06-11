using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSystem
{
    public partial class Form1 : Form
    {
        private Resume resume;
        private Vacancies vacancies;
        private Occupation occupation;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resume = new Resume();
            resume.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vacancies = new Vacancies();
            vacancies.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            occupation = new Occupation();
            occupation.Visible = true;

        }
    }
}
