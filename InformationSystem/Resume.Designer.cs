namespace InformationSystem
{
    partial class Resume
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
            System.Windows.Forms.Label mesto_i_doljnost_posl_rabotLabel;
            System.Windows.Forms.Label prichina_uvolneniaLabel;
            System.Windows.Forms.Label family_statusLabel;
            System.Windows.Forms.Label contact_coordinateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resume));
            System.Windows.Forms.Label profession_numbLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.labor_ExchangeDataSet = new InformationSystem.Labor_ExchangeDataSet();
            this.resumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resumeTableAdapter = new InformationSystem.Labor_ExchangeDataSetTableAdapters.ResumeTableAdapter();
            this.tableAdapterManager = new InformationSystem.Labor_ExchangeDataSetTableAdapters.TableAdapterManager();
            this.resumeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.resumeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mesto_i_doljnost_posl_rabotTextBox = new System.Windows.Forms.TextBox();
            this.prichina_uvolneniaTextBox = new System.Windows.Forms.TextBox();
            this.family_statusTextBox = new System.Windows.Forms.TextBox();
            this.contact_coordinateTextBox = new System.Windows.Forms.TextBox();
            this.professionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professionTableAdapter = new InformationSystem.Labor_ExchangeDataSetTableAdapters.ProfessionTableAdapter();
            this.profession_numbTextBox = new System.Windows.Forms.TextBox();
            mesto_i_doljnost_posl_rabotLabel = new System.Windows.Forms.Label();
            prichina_uvolneniaLabel = new System.Windows.Forms.Label();
            family_statusLabel = new System.Windows.Forms.Label();
            contact_coordinateLabel = new System.Windows.Forms.Label();
            profession_numbLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.labor_ExchangeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumeBindingNavigator)).BeginInit();
            this.resumeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mesto_i_doljnost_posl_rabotLabel
            // 
            mesto_i_doljnost_posl_rabotLabel.AutoSize = true;
            mesto_i_doljnost_posl_rabotLabel.Location = new System.Drawing.Point(125, 160);
            mesto_i_doljnost_posl_rabotLabel.Name = "mesto_i_doljnost_posl_rabotLabel";
            mesto_i_doljnost_posl_rabotLabel.Size = new System.Drawing.Size(131, 13);
            mesto_i_doljnost_posl_rabotLabel.TabIndex = 6;
            mesto_i_doljnost_posl_rabotLabel.Text = "mesto i doljnost posl rabot:";
            // 
            // prichina_uvolneniaLabel
            // 
            prichina_uvolneniaLabel.AutoSize = true;
            prichina_uvolneniaLabel.Location = new System.Drawing.Point(160, 217);
            prichina_uvolneniaLabel.Name = "prichina_uvolneniaLabel";
            prichina_uvolneniaLabel.Size = new System.Drawing.Size(96, 13);
            prichina_uvolneniaLabel.TabIndex = 8;
            prichina_uvolneniaLabel.Text = "prichina uvolnenia:";
            // 
            // family_statusLabel
            // 
            family_statusLabel.AutoSize = true;
            family_statusLabel.Location = new System.Drawing.Point(186, 266);
            family_statusLabel.Name = "family_statusLabel";
            family_statusLabel.Size = new System.Drawing.Size(70, 13);
            family_statusLabel.TabIndex = 10;
            family_statusLabel.Text = "Family status:";
            // 
            // contact_coordinateLabel
            // 
            contact_coordinateLabel.AutoSize = true;
            contact_coordinateLabel.Location = new System.Drawing.Point(157, 316);
            contact_coordinateLabel.Name = "contact_coordinateLabel";
            contact_coordinateLabel.Size = new System.Drawing.Size(99, 13);
            contact_coordinateLabel.TabIndex = 12;
            contact_coordinateLabel.Text = "contact coordinate:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(262, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Резюме";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labor_ExchangeDataSet
            // 
            this.labor_ExchangeDataSet.DataSetName = "Labor_ExchangeDataSet";
            this.labor_ExchangeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resumeBindingSource
            // 
            this.resumeBindingSource.DataMember = "Resume";
            this.resumeBindingSource.DataSource = this.labor_ExchangeDataSet;
            // 
            // resumeTableAdapter
            // 
            this.resumeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EducationTableAdapter = null;
            this.tableAdapterManager.Job_titleTableAdapter = null;
            this.tableAdapterManager.Occupation_vacancyTableAdapter = null;
            this.tableAdapterManager.ProfessionTableAdapter = null;
            this.tableAdapterManager.ResumeTableAdapter = this.resumeTableAdapter;
            this.tableAdapterManager.UpdateOrder = InformationSystem.Labor_ExchangeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacanciesTableAdapter = null;
            // 
            // resumeBindingNavigator
            // 
            this.resumeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.resumeBindingNavigator.BindingSource = this.resumeBindingSource;
            this.resumeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.resumeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.resumeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.resumeBindingNavigatorSaveItem});
            this.resumeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.resumeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.resumeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.resumeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.resumeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.resumeBindingNavigator.Name = "resumeBindingNavigator";
            this.resumeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.resumeBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.resumeBindingNavigator.TabIndex = 1;
            this.resumeBindingNavigator.Text = "bindingNavigator1";
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
            // resumeBindingNavigatorSaveItem
            // 
            this.resumeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resumeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("resumeBindingNavigatorSaveItem.Image")));
            this.resumeBindingNavigatorSaveItem.Name = "resumeBindingNavigatorSaveItem";
            this.resumeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.resumeBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.resumeBindingNavigatorSaveItem.Click += new System.EventHandler(this.resumeBindingNavigatorSaveItem_Click);
            // 
            // mesto_i_doljnost_posl_rabotTextBox
            // 
            this.mesto_i_doljnost_posl_rabotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resumeBindingSource, "mesto_i_doljnost_posl_rabot", true));
            this.mesto_i_doljnost_posl_rabotTextBox.Location = new System.Drawing.Point(262, 157);
            this.mesto_i_doljnost_posl_rabotTextBox.Name = "mesto_i_doljnost_posl_rabotTextBox";
            this.mesto_i_doljnost_posl_rabotTextBox.Size = new System.Drawing.Size(100, 20);
            this.mesto_i_doljnost_posl_rabotTextBox.TabIndex = 7;
            // 
            // prichina_uvolneniaTextBox
            // 
            this.prichina_uvolneniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resumeBindingSource, "prichina_uvolnenia", true));
            this.prichina_uvolneniaTextBox.Location = new System.Drawing.Point(262, 214);
            this.prichina_uvolneniaTextBox.Name = "prichina_uvolneniaTextBox";
            this.prichina_uvolneniaTextBox.Size = new System.Drawing.Size(100, 20);
            this.prichina_uvolneniaTextBox.TabIndex = 9;
            // 
            // family_statusTextBox
            // 
            this.family_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resumeBindingSource, "Family_status", true));
            this.family_statusTextBox.Location = new System.Drawing.Point(262, 263);
            this.family_statusTextBox.Name = "family_statusTextBox";
            this.family_statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.family_statusTextBox.TabIndex = 11;
            // 
            // contact_coordinateTextBox
            // 
            this.contact_coordinateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resumeBindingSource, "contact_coordinate", true));
            this.contact_coordinateTextBox.Location = new System.Drawing.Point(262, 313);
            this.contact_coordinateTextBox.Name = "contact_coordinateTextBox";
            this.contact_coordinateTextBox.Size = new System.Drawing.Size(100, 20);
            this.contact_coordinateTextBox.TabIndex = 13;
            // 
            // professionBindingSource
            // 
            this.professionBindingSource.DataMember = "Profession";
            this.professionBindingSource.DataSource = this.labor_ExchangeDataSet;
            // 
            // professionTableAdapter
            // 
            this.professionTableAdapter.ClearBeforeFill = true;
            // 
            // profession_numbLabel
            // 
            profession_numbLabel.AutoSize = true;
            profession_numbLabel.Location = new System.Drawing.Point(168, 118);
            profession_numbLabel.Name = "profession_numbLabel";
            profession_numbLabel.Size = new System.Drawing.Size(88, 13);
            profession_numbLabel.TabIndex = 13;
            profession_numbLabel.Text = "Profession numb:";
            // 
            // profession_numbTextBox
            // 
            this.profession_numbTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resumeBindingSource, "Profession_numb", true));
            this.profession_numbTextBox.Location = new System.Drawing.Point(262, 115);
            this.profession_numbTextBox.Name = "profession_numbTextBox";
            this.profession_numbTextBox.Size = new System.Drawing.Size(100, 20);
            this.profession_numbTextBox.TabIndex = 14;
            // 
            // Resume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(profession_numbLabel);
            this.Controls.Add(this.profession_numbTextBox);
            this.Controls.Add(contact_coordinateLabel);
            this.Controls.Add(this.contact_coordinateTextBox);
            this.Controls.Add(family_statusLabel);
            this.Controls.Add(this.family_statusTextBox);
            this.Controls.Add(prichina_uvolneniaLabel);
            this.Controls.Add(this.prichina_uvolneniaTextBox);
            this.Controls.Add(mesto_i_doljnost_posl_rabotLabel);
            this.Controls.Add(this.mesto_i_doljnost_posl_rabotTextBox);
            this.Controls.Add(this.resumeBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Resume";
            this.Text = "Резюме";
            this.Load += new System.EventHandler(this.Resume_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labor_ExchangeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumeBindingNavigator)).EndInit();
            this.resumeBindingNavigator.ResumeLayout(false);
            this.resumeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Labor_ExchangeDataSet labor_ExchangeDataSet;
        private System.Windows.Forms.BindingSource resumeBindingSource;
        private Labor_ExchangeDataSetTableAdapters.ResumeTableAdapter resumeTableAdapter;
        private Labor_ExchangeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator resumeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton resumeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox mesto_i_doljnost_posl_rabotTextBox;
        private System.Windows.Forms.TextBox prichina_uvolneniaTextBox;
        private System.Windows.Forms.TextBox family_statusTextBox;
        private System.Windows.Forms.TextBox contact_coordinateTextBox;
        private System.Windows.Forms.BindingSource professionBindingSource;
        private Labor_ExchangeDataSetTableAdapters.ProfessionTableAdapter professionTableAdapter;
        private System.Windows.Forms.TextBox profession_numbTextBox;
    }
}