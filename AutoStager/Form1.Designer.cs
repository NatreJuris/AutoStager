
namespace AutoStager
{
    partial class Form1
    { 
        //</s/u/m/m/a/r/y/>
        // Required designer variable.
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            MovTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.StaEditFormBtn = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.stagingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calendarDataSet = new AutoStager.CalendarDataSet();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            StaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.calendarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CalendarTable = new System.Windows.Forms.DataGridView();
            this.StaSendEmail = new System.Windows.Forms.Button();
            this.MovSendEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stagingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalendarTable)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 97);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(133, 96);
            this.checkedListBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moving Crew";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new System.Drawing.Point(495, 16);
            monthCalendar1.MaxSelectionCount = 60;
            monthCalendar1.MinDate = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // MovTextBox
            // 
            MovTextBox.Location = new System.Drawing.Point(151, 97);
            MovTextBox.Multiline = true;
            MovTextBox.Name = "MovTextBox";
            MovTextBox.Size = new System.Drawing.Size(316, 96);
            MovTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Send Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SendMovbtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.CustomFormat = "  ddd dd MMM yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 26);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(663, 365);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 40);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "UHAUL";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 46);
            this.label3.TabIndex = 12;
            this.label3.Text = "HEMMA STAGING";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "  hh:mm  tt";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dateTimePicker3.Location = new System.Drawing.Point(352, 68);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(115, 26);
            this.dateTimePicker3.TabIndex = 13;
            this.dateTimePicker3.Value = new System.DateTime(2023, 6, 3, 0, 0, 0, 0);
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 30);
            this.button3.TabIndex = 16;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.MovEditFormBtn_Click);
            // 
            // StaEditFormBtn
            // 
            this.StaEditFormBtn.Location = new System.Drawing.Point(12, 373);
            this.StaEditFormBtn.Name = "StaEditFormBtn";
            this.StaEditFormBtn.Size = new System.Drawing.Size(60, 30);
            this.StaEditFormBtn.TabIndex = 23;
            this.StaEditFormBtn.Text = "Edit";
            this.StaEditFormBtn.UseVisualStyleBackColor = true;
            this.StaEditFormBtn.Click += new System.EventHandler(this.StaEditFormBtn_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "  hh:mm  tt";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dateTimePicker2.Location = new System.Drawing.Point(352, 242);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(115, 26);
            this.dateTimePicker2.TabIndex = 22;
            this.dateTimePicker2.Value = new System.DateTime(2023, 7, 28, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // stagingBindingSource
            // 
            this.stagingBindingSource.DataMember = "Staging";
            this.stagingBindingSource.DataSource = this.calendarDataSet;
            // 
            // calendarDataSet
            // 
            this.calendarDataSet.DataSetName = "CalendarDataSet";
            this.calendarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker4.CustomFormat = "  ddd dd MMM yyyy";
            this.dateTimePicker4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dateTimePicker4.Location = new System.Drawing.Point(151, 242);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(195, 26);
            this.dateTimePicker4.TabIndex = 21;
            this.dateTimePicker4.ValueChanged += new System.EventHandler(this.dateTimePicker4_ValueChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(151, 373);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 30);
            this.button4.TabIndex = 20;
            this.button4.Text = "Send Text";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SendStabtn_Click);
            // 
            // StaTextBox
            // 
            StaTextBox.Location = new System.Drawing.Point(151, 271);
            StaTextBox.Multiline = true;
            StaTextBox.Name = "StaTextBox";
            StaTextBox.Size = new System.Drawing.Size(316, 96);
            StaTextBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Staging Crew";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(12, 271);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(133, 96);
            this.checkedListBox2.TabIndex = 17;
            // 
            // CalendarTable
            // 
            this.CalendarTable.AccessibleName = "CalendarTable";
            this.CalendarTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.CalendarTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CalendarTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CalendarTable.ColumnHeadersVisible = false;
            this.CalendarTable.Location = new System.Drawing.Point(495, 271);
            this.CalendarTable.Name = "CalendarTable";
            this.CalendarTable.RowHeadersVisible = false;
            this.CalendarTable.RowHeadersWidth = 62;
            this.CalendarTable.RowTemplate.Height = 28;
            this.CalendarTable.Size = new System.Drawing.Size(342, 87);
            this.CalendarTable.TabIndex = 24;
            // 
            // StaSendEmail
            // 
            this.StaSendEmail.Location = new System.Drawing.Point(335, 374);
            this.StaSendEmail.Name = "StaSendEmail";
            this.StaSendEmail.Size = new System.Drawing.Size(132, 29);
            this.StaSendEmail.TabIndex = 25;
            this.StaSendEmail.Text = "Send Email";
            this.StaSendEmail.UseVisualStyleBackColor = true;
            this.StaSendEmail.Click += new System.EventHandler(this.StaSendEmail_Click);
            // 
            // MovSendEmail
            // 
            this.MovSendEmail.Location = new System.Drawing.Point(335, 199);
            this.MovSendEmail.Name = "MovSendEmail";
            this.MovSendEmail.Size = new System.Drawing.Size(132, 30);
            this.MovSendEmail.TabIndex = 26;
            this.MovSendEmail.Text = "Send Email";
            this.MovSendEmail.UseVisualStyleBackColor = true;
            this.MovSendEmail.Click += new System.EventHandler(this.MovSendEmail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(865, 414);
            this.Controls.Add(this.MovSendEmail);
            this.Controls.Add(this.StaSendEmail);
            this.Controls.Add(this.CalendarTable);
            this.Controls.Add(this.StaEditFormBtn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.button4);
            this.Controls.Add(StaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(MovTextBox);
            this.Controls.Add(monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "HEMMA STAGING";
            ((System.ComponentModel.ISupportInitialize)(this.stagingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalendarTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button StaEditFormBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource calendarDataSetBindingSource;
        private System.Windows.Forms.DataGridView CalendarTable;
        private System.Windows.Forms.BindingSource stagingBindingSource;
        private CalendarDataSet calendarDataSet;
        private System.Windows.Forms.Button StaSendEmail;
        private System.Windows.Forms.Button MovSendEmail;
        public static System.Windows.Forms.TextBox MovTextBox;
        public static System.Windows.Forms.TextBox StaTextBox;
        public static System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

