namespace PresentationLayer.ReciptionRelatedForms
{
    partial class ReciptionForm
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
            System.Windows.Forms.Label patientIDLabel;
            System.Windows.Forms.Label patientNameLabel;
            System.Windows.Forms.Label patientAddressLabel;
            System.Windows.Forms.Label enterDateLabel;
            System.Windows.Forms.Label reciptionIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReciptionForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clinicDataSet = new PresentationLayer.ClinicDataSet();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new PresentationLayer.ClinicDataSetTableAdapters.PatientTableAdapter();
            this.tableAdapterManager = new PresentationLayer.ClinicDataSetTableAdapters.TableAdapterManager();
            this.patientBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.patientBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.patientAddressTextBox = new System.Windows.Forms.TextBox();
            this.enterDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reciptionIDTextBox = new System.Windows.Forms.TextBox();
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patientIDLabel = new System.Windows.Forms.Label();
            patientNameLabel = new System.Windows.Forms.Label();
            patientAddressLabel = new System.Windows.Forms.Label();
            enterDateLabel = new System.Windows.Forms.Label();
            reciptionIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1BindingNavigator)).BeginInit();
            this.patientBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Location = new System.Drawing.Point(21, 233);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(59, 13);
            patientIDLabel.TabIndex = 9;
            patientIDLabel.Text = "Patient ID:";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Location = new System.Drawing.Point(21, 259);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(75, 13);
            patientNameLabel.TabIndex = 11;
            patientNameLabel.Text = "Patient Name:";
            // 
            // patientAddressLabel
            // 
            patientAddressLabel.AutoSize = true;
            patientAddressLabel.Location = new System.Drawing.Point(21, 285);
            patientAddressLabel.Name = "patientAddressLabel";
            patientAddressLabel.Size = new System.Drawing.Size(87, 13);
            patientAddressLabel.TabIndex = 13;
            patientAddressLabel.Text = "Patient Address:";
            // 
            // enterDateLabel
            // 
            enterDateLabel.AutoSize = true;
            enterDateLabel.Location = new System.Drawing.Point(21, 312);
            enterDateLabel.Name = "enterDateLabel";
            enterDateLabel.Size = new System.Drawing.Size(63, 13);
            enterDateLabel.TabIndex = 15;
            enterDateLabel.Text = "Enter Date:";
            // 
            // reciptionIDLabel
            // 
            reciptionIDLabel.AutoSize = true;
            reciptionIDLabel.Location = new System.Drawing.Point(21, 337);
            reciptionIDLabel.Name = "reciptionIDLabel";
            reciptionIDLabel.Size = new System.Drawing.Size(69, 13);
            reciptionIDLabel.TabIndex = 17;
            reciptionIDLabel.Text = "Reciption ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(359, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(298, 99);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(55, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "------------";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(298, 123);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "------------";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(134, 99);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "LoginIn";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.btnlogin);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(181, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 152);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recipation Login";
            // 
            // clinicDataSet
            // 
            this.clinicDataSet.DataSetName = "ClinicDataSet";
            this.clinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "Patient";
            this.patientBindingSource1.DataSource = this.clinicDataSet;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PatientTableAdapter = this.patientTableAdapter;
            this.tableAdapterManager.UpdateOrder = PresentationLayer.ClinicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patientBindingSource1BindingNavigator
            // 
            this.patientBindingSource1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientBindingSource1BindingNavigator.BindingSource = this.patientBindingSource1;
            this.patientBindingSource1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientBindingSource1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patientBindingSource1BindingNavigatorSaveItem});
            this.patientBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patientBindingSource1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientBindingSource1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientBindingSource1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientBindingSource1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientBindingSource1BindingNavigator.Name = "patientBindingSource1BindingNavigator";
            this.patientBindingSource1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientBindingSource1BindingNavigator.Size = new System.Drawing.Size(849, 25);
            this.patientBindingSource1BindingNavigator.TabIndex = 9;
            this.patientBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // patientBindingSource1BindingNavigatorSaveItem
            // 
            this.patientBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientBindingSource1BindingNavigatorSaveItem.Image")));
            this.patientBindingSource1BindingNavigatorSaveItem.Name = "patientBindingSource1BindingNavigatorSaveItem";
            this.patientBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patientBindingSource1BindingNavigatorSaveItem.Text = "Save Data";
            this.patientBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.patientBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource1, "PatientID", true));
            this.patientIDTextBox.Enabled = false;
            this.patientIDTextBox.Location = new System.Drawing.Point(114, 230);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientIDTextBox.TabIndex = 10;
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource1, "PatientName", true));
            this.patientNameTextBox.Location = new System.Drawing.Point(114, 256);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientNameTextBox.TabIndex = 12;
            // 
            // patientAddressTextBox
            // 
            this.patientAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource1, "PatientAddress", true));
            this.patientAddressTextBox.Location = new System.Drawing.Point(114, 282);
            this.patientAddressTextBox.Name = "patientAddressTextBox";
            this.patientAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientAddressTextBox.TabIndex = 14;
            // 
            // enterDateDateTimePicker
            // 
            this.enterDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource1, "EnterDate", true));
            this.enterDateDateTimePicker.Location = new System.Drawing.Point(114, 308);
            this.enterDateDateTimePicker.Name = "enterDateDateTimePicker";
            this.enterDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.enterDateDateTimePicker.TabIndex = 16;
            // 
            // reciptionIDTextBox
            // 
            this.reciptionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource1, "ReciptionID", true));
            this.reciptionIDTextBox.Enabled = false;
            this.reciptionIDTextBox.Location = new System.Drawing.Point(114, 334);
            this.reciptionIDTextBox.Name = "reciptionIDTextBox";
            this.reciptionIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.reciptionIDTextBox.TabIndex = 18;
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AllowUserToAddRows = false;
            this.patientDataGridView.AllowUserToDeleteRows = false;
            this.patientDataGridView.AutoGenerateColumns = false;
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.patientDataGridView.DataSource = this.patientBindingSource1;
            this.patientDataGridView.Location = new System.Drawing.Point(331, 207);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.ReadOnly = true;
            this.patientDataGridView.Size = new System.Drawing.Size(511, 220);
            this.patientDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PatientID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PatientID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PatientName";
            this.dataGridViewTextBoxColumn2.HeaderText = "PatientName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PatientAddress";
            this.dataGridViewTextBoxColumn3.HeaderText = "PatientAddress";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EnterDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "EnterDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ReciptionID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ReciptionID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // ReciptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 469);
            this.Controls.Add(this.patientDataGridView);
            this.Controls.Add(patientIDLabel);
            this.Controls.Add(this.patientIDTextBox);
            this.Controls.Add(patientNameLabel);
            this.Controls.Add(this.patientNameTextBox);
            this.Controls.Add(patientAddressLabel);
            this.Controls.Add(this.patientAddressTextBox);
            this.Controls.Add(enterDateLabel);
            this.Controls.Add(this.enterDateDateTimePicker);
            this.Controls.Add(reciptionIDLabel);
            this.Controls.Add(this.reciptionIDTextBox);
            this.Controls.Add(this.patientBindingSource1BindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReciptionForm";
            this.Text = "ReciptionForm";
            this.Load += new System.EventHandler(this.ReciptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1BindingNavigator)).EndInit();
            this.patientBindingSource1BindingNavigator.ResumeLayout(false);
            this.patientBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.GroupBox groupBox1;
        //private ClinicDataSet clinicDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        //private ClinicDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        //private ClinicDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ClinicDataSet clinicDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private ClinicDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private ClinicDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientBindingSource1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patientBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.TextBox patientAddressTextBox;
        private System.Windows.Forms.DateTimePicker enterDateDateTimePicker;
        private System.Windows.Forms.TextBox reciptionIDTextBox;
        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}