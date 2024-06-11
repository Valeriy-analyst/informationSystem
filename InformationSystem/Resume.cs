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
    public partial class Resume : Form
    {
        public Resume()
        {
            InitializeComponent();
        }

        private void resumeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.resumeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.labor_ExchangeDataSet);

        }

        private void Resume_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "labor_ExchangeDataSet.Profession". При необходимости она может быть перемещена или удалена.
            this.professionTableAdapter.Fill(this.labor_ExchangeDataSet.Profession);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "labor_ExchangeDataSet.Resume". При необходимости она может быть перемещена или удалена.
            this.resumeTableAdapter.Fill(this.labor_ExchangeDataSet.Resume);

        }
    }
}
