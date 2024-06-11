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
    public partial class Vacancies : Form
    {
        public Vacancies()
        {
            InitializeComponent();
        }

        private void vacanciesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vacanciesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.labor_ExchangeDataSet);

        }

        private void vacanciesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.vacanciesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.labor_ExchangeDataSet);

        }

        private void Vacancies_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "labor_ExchangeDataSet.Vacancies". При необходимости она может быть перемещена или удалена.
            this.vacanciesTableAdapter.Fill(this.labor_ExchangeDataSet.Vacancies);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vacanciesBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vacanciesBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vacanciesBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vacanciesBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            vacanciesBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vacanciesBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей this.Validate(); //закрывает подключение с сервером
            this.vacanciesBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.labor_ExchangeDataSet);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
