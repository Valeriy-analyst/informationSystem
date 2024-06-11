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
    public partial class Occupation : Form
    {
        public Occupation()
        {
            InitializeComponent();
        }

        private void occupation_vacancyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.occupation_vacancyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.labor_ExchangeDataSet);

        }

        private void Occupation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "labor_ExchangeDataSet.Vacancies". При необходимости она может быть перемещена или удалена.
            this.vacanciesTableAdapter.Fill(this.labor_ExchangeDataSet.Vacancies);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "labor_ExchangeDataSet.Occupation_vacancy". При необходимости она может быть перемещена или удалена.
            this.occupation_vacancyTableAdapter.Fill(this.labor_ExchangeDataSet.Occupation_vacancy);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
        private System.Windows.Forms.DataGridViewColumn COL;
        private void button1_Click(object sender, EventArgs e)
        {
            //создает переменную COL для хранения имени выбранного столбца таблицы
            COL = new System.Windows.Forms.DataGridViewColumn();
            //блок switch, присваивающий в //переменную Col имя выбранного столбца таблицы в зависимости отномера
            //выбранного пункта списка (ListBox1.SelectedIndex). Если выбранпервый пункт //списка, то в переменную Col записывается столбец
            //DataGridViewTextBoxColumn2, если второй, то – DataGridViewTextBoxColumn3 //и так далее. Хотелось бы отметить тот факт, что нумерация пунктовсписка
            //начинается с нуля, а нумерация столбцов с единицы. Первый столбец «Наименование» //носит имя DataGridViewTextBoxColumn2, так как имя //DataGridViewTextBoxColumn1 имеет столбец заголовков строк;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn4;
                    break;
            }
            //Блок If выполняет следующую операцию: если включён //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать //таблицу по полю заданному в переменной Col по возрастанию //(pRODUCTSDataGridView.Sort (Col, System.ComponentModel.ListSortDirection. //Ascending)), иначе по убыванию (pRODUCTSDataGridView.Sort (Col, System.
//ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked) occupation_vacancyDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending); 
            else occupation_vacancyDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            occupation_vacancyBindingSource.Filter = "vacancy_code='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //перебирает все ячейки таблицы и //устанавливает в них белый цвет фона и чёрный цвет текста, то есть, //отменяет результаты предыдущего поиска
            for (int i = 0; i < occupation_vacancyDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < occupation_vacancyDataGridView.RowCount - 1; j++)
                {
                    occupation_vacancyDataGridView[i, j].Style.BackColor = Color.White; occupation_vacancyDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < occupation_vacancyDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < occupation_vacancyDataGridView.RowCount - 1; j++)
                {
                    if (occupation_vacancyDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        occupation_vacancyDataGridView[i, j].Style.BackColor = Color.AliceBlue; occupation_vacancyDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            occupation_vacancyBindingSource.Filter = "";
        }
    }
}
