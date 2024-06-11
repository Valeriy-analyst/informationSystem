namespace InformationSystem
{
    partial class Vacancies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label organizationLabel;
            System.Windows.Forms.Label date_the_vacancy_was_postedLabel;
            System.Windows.Forms.Label working_conditionsLabel;
            System.Windows.Forms.Label requirements_for_a_specialistLabel;
            System.Windows.Forms.Label paymentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vacancies));
            this.label1 = new System.Windows.Forms.Label();
            this.labor_ExchangeDataSet = new InformationSystem.Labor_ExchangeDataSet();
            this.vacanciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacanciesTableAdapter = new InformationSystem.Labor_ExchangeDataSetTableAdapters.VacanciesTableAdapter();
            this.tableAdapterManager = new InformationSystem.Labor_ExchangeDataSetTableAdapters.TableAdapterManager();
            this.vacanciesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vacanciesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.date_the_vacancy_was_postedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.working_conditionsTextBox = new System.Windows.Forms.TextBox();
            this.requirements_for_a_specialistTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            organizationLabel = new System.Windows.Forms.Label();
            date_the_vacancy_was_postedLabel = new System.Windows.Forms.Label();
            working_conditionsLabel = new System.Windows.Forms.Label();
            requirements_for_a_specialistLabel = new System.Windows.Forms.Label();
            paymentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.labor_ExchangeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesBindingNavigator)).BeginInit();
            this.vacanciesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // organizationLabel
            // 
            organizationLabel.AutoSize = true;
            organizationLabel.Location = new System.Drawing.Point(192, 168);
            organizationLabel.Name = "organizationLabel";
            organizationLabel.Size = new System.Drawing.Size(67, 13);
            organizationLabel.TabIndex = 2;
            organizationLabel.Text = "organization:";
            // 
            // date_the_vacancy_was_postedLabel
            // 
            date_the_vacancy_was_postedLabel.AutoSize = true;
            date_the_vacancy_was_postedLabel.Location = new System.Drawing.Point(109, 103);
            date_the_vacancy_was_postedLabel.Name = "date_the_vacancy_was_postedLabel";
            date_the_vacancy_was_postedLabel.Size = new System.Drawing.Size(150, 13);
            date_the_vacancy_was_postedLabel.TabIndex = 4;
            date_the_vacancy_was_postedLabel.Text = "date the vacancy was posted:";
            // 
            // working_conditionsLabel
            // 
            working_conditionsLabel.AutoSize = true;
            working_conditionsLabel.Location = new System.Drawing.Point(158, 225);
            working_conditionsLabel.Name = "working_conditionsLabel";
            working_conditionsLabel.Size = new System.Drawing.Size(101, 13);
            working_conditionsLabel.TabIndex = 6;
            working_conditionsLabel.Text = "Working conditions:";
            // 
            // requirements_for_a_specialistLabel
            // 
            requirements_for_a_specialistLabel.AutoSize = true;
            requirements_for_a_specialistLabel.Location = new System.Drawing.Point(119, 278);
            requirements_for_a_specialistLabel.Name = "requirements_for_a_specialistLabel";
            requirements_for_a_specialistLabel.Size = new System.Drawing.Size(140, 13);
            requirements_for_a_specialistLabel.TabIndex = 8;
            requirements_for_a_specialistLabel.Text = "requirements for a specialist:";
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Location = new System.Drawing.Point(209, 330);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new System.Drawing.Size(50, 13);
            paymentLabel.TabIndex = 10;
            paymentLabel.Text = "payment:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(313, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вакансии";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labor_ExchangeDataSet
            // 
            this.labor_ExchangeDataSet.DataSetName = "Labor_ExchangeDataSet";
            this.labor_ExchangeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacanciesBindingSource
            // 
            this.vacanciesBindingSource.DataMember = "Vacancies";
            this.vacanciesBindingSource.DataSource = this.labor_ExchangeDataSet;
            // 
            // vacanciesTableAdapter
            // 
            this.vacanciesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EducationTableAdapter = null;
            this.tableAdapterManager.Job_titleTableAdapter = null;
            this.tableAdapterManager.Occupation_vacancyTableAdapter = null;
            this.tableAdapterManager.ProfessionTableAdapter = null;
            this.tableAdapterManager.ResumeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = InformationSystem.Labor_ExchangeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacanciesTableAdapter = this.vacanciesTableAdapter;
            // 
            // vacanciesBindingNavigator
            // 
            this.vacanciesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vacanciesBindingNavigator.BindingSource = this.vacanciesBindingSource;
            this.vacanciesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vacanciesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vacanciesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vacanciesBindingNavigatorSaveItem});
            this.vacanciesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vacanciesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vacanciesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vacanciesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vacanciesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vacanciesBindingNavigator.Name = "vacanciesBindingNavigator";
            this.vacanciesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vacanciesBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.vacanciesBindingNavigator.TabIndex = 1;
            this.vacanciesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // vacanciesBindingNavigatorSaveItem
            // 
            this.vacanciesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vacanciesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vacanciesBindingNavigatorSaveItem.Image")));
            this.vacanciesBindingNavigatorSaveItem.Name = "vacanciesBindingNavigatorSaveItem";
            this.vacanciesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vacanciesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.vacanciesBindingNavigatorSaveItem.Click += new System.EventHandler(this.vacanciesBindingNavigatorSaveItem_Click_1);
            // 
            // date_the_vacancy_was_postedDateTimePicker
            // 
            this.date_the_vacancy_was_postedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vacanciesBindingSource, "date_the_vacancy_was_posted", true));
            this.date_the_vacancy_was_postedDateTimePicker.Location = new System.Drawing.Point(265, 99);
            this.date_the_vacancy_was_postedDateTimePicker.Name = "date_the_vacancy_was_postedDateTimePicker";
            this.date_the_vacancy_was_postedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_the_vacancy_was_postedDateTimePicker.TabIndex = 5;
            // 
            // working_conditionsTextBox
            // 
            this.working_conditionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacanciesBindingSource, "Working_conditions", true));
            this.working_conditionsTextBox.Location = new System.Drawing.Point(265, 222);
            this.working_conditionsTextBox.Name = "working_conditionsTextBox";
            this.working_conditionsTextBox.Size = new System.Drawing.Size(100, 20);
            this.working_conditionsTextBox.TabIndex = 7;
            // 
            // requirements_for_a_specialistTextBox
            // 
            this.requirements_for_a_specialistTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacanciesBindingSource, "requirements_for_a_specialist", true));
            this.requirements_for_a_specialistTextBox.Location = new System.Drawing.Point(265, 275);
            this.requirements_for_a_specialistTextBox.Name = "requirements_for_a_specialistTextBox";
            this.requirements_for_a_specialistTextBox.Size = new System.Drawing.Size(100, 20);
            this.requirements_for_a_specialistTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(378, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Следующая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(508, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(220, 396);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(378, 396);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(300, 425);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 23);
            this.button7.TabIndex = 18;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacanciesBindingSource, "payment", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(265, 327);
            this.maskedTextBox1.Mask = "99990.00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 19;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.vacanciesBindingSource;
            this.comboBox1.DisplayMember = "organization";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(265, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "vacancy_code";
            // 
            // Vacancies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(paymentLabel);
            this.Controls.Add(requirements_for_a_specialistLabel);
            this.Controls.Add(this.requirements_for_a_specialistTextBox);
            this.Controls.Add(working_conditionsLabel);
            this.Controls.Add(this.working_conditionsTextBox);
            this.Controls.Add(date_the_vacancy_was_postedLabel);
            this.Controls.Add(this.date_the_vacancy_was_postedDateTimePicker);
            this.Controls.Add(organizationLabel);
            this.Controls.Add(this.vacanciesBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vacancies";
            this.Text = "Вакансии";
            this.Load += new System.EventHandler(this.Vacancies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labor_ExchangeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesBindingNavigator)).EndInit();
            this.vacanciesBindingNavigator.ResumeLayout(false);
            this.vacanciesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Labor_ExchangeDataSet labor_ExchangeDataSet;
        private System.Windows.Forms.BindingSource vacanciesBindingSource;
        private Labor_ExchangeDataSetTableAdapters.VacanciesTableAdapter vacanciesTableAdapter;
        private Labor_ExchangeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vacanciesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vacanciesBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker date_the_vacancy_was_postedDateTimePicker;
        private System.Windows.Forms.TextBox working_conditionsTextBox;
        private System.Windows.Forms.TextBox requirements_for_a_specialistTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}