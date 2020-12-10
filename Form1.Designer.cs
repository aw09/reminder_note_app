
namespace reminder_notes_app
{
    partial class Index
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.editCategoryReminder = new System.Windows.Forms.Button();
            this.newCategroyReminder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelUpdateReminder = new System.Windows.Forms.Button();
            this.updateReminder = new System.Windows.Forms.Button();
            this.pickCategoryReminderComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.addReminder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.reminderDetail = new System.Windows.Forms.TextBox();
            this.reminderList = new System.Windows.Forms.FlowLayoutPanel();
            this.categoryReminderComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editCategoryNote = new System.Windows.Forms.Button();
            this.newCategoryNote = new System.Windows.Forms.Button();
            this.newNote = new System.Windows.Forms.Button();
            this.noteList = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryNoteComboBox = new System.Windows.Forms.ComboBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.deleteReminder = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.editCategoryReminder);
            this.tabPage1.Controls.Add(this.newCategroyReminder);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.reminderList);
            this.tabPage1.Controls.Add(this.categoryReminderComboBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reminder";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // editCategoryReminder
            // 
            this.editCategoryReminder.Location = new System.Drawing.Point(310, 26);
            this.editCategoryReminder.Name = "editCategoryReminder";
            this.editCategoryReminder.Size = new System.Drawing.Size(75, 23);
            this.editCategoryReminder.TabIndex = 12;
            this.editCategoryReminder.Text = "Edit";
            this.editCategoryReminder.UseVisualStyleBackColor = true;
            this.editCategoryReminder.Click += new System.EventHandler(this.editCategoryReminder_Click);
            // 
            // newCategroyReminder
            // 
            this.newCategroyReminder.Location = new System.Drawing.Point(229, 26);
            this.newCategroyReminder.Name = "newCategroyReminder";
            this.newCategroyReminder.Size = new System.Drawing.Size(75, 23);
            this.newCategroyReminder.TabIndex = 11;
            this.newCategroyReminder.Text = "New";
            this.newCategroyReminder.UseVisualStyleBackColor = true;
            this.newCategroyReminder.Click += new System.EventHandler(this.NewCategroyReminder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "List Reminder";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.deleteReminder);
            this.panel1.Controls.Add(this.cancelUpdateReminder);
            this.panel1.Controls.Add(this.updateReminder);
            this.panel1.Controls.Add(this.pickCategoryReminderComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.addReminder);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.reminderDetail);
            this.panel1.Location = new System.Drawing.Point(438, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 374);
            this.panel1.TabIndex = 8;
            // 
            // cancelUpdateReminder
            // 
            this.cancelUpdateReminder.Location = new System.Drawing.Point(24, 336);
            this.cancelUpdateReminder.Name = "cancelUpdateReminder";
            this.cancelUpdateReminder.Size = new System.Drawing.Size(75, 23);
            this.cancelUpdateReminder.TabIndex = 12;
            this.cancelUpdateReminder.Text = "Cancel";
            this.cancelUpdateReminder.UseVisualStyleBackColor = true;
            this.cancelUpdateReminder.Click += new System.EventHandler(this.cancelUpdateReminder_Click);
            // 
            // updateReminder
            // 
            this.updateReminder.Location = new System.Drawing.Point(208, 336);
            this.updateReminder.Name = "updateReminder";
            this.updateReminder.Size = new System.Drawing.Size(75, 23);
            this.updateReminder.TabIndex = 11;
            this.updateReminder.Text = "Update";
            this.updateReminder.UseVisualStyleBackColor = true;
            this.updateReminder.Click += new System.EventHandler(this.updateReminder_Click);
            // 
            // pickCategoryReminderComboBox
            // 
            this.pickCategoryReminderComboBox.FormattingEnabled = true;
            this.pickCategoryReminderComboBox.Location = new System.Drawing.Point(112, 257);
            this.pickCategoryReminderComboBox.Name = "pickCategoryReminderComboBox";
            this.pickCategoryReminderComboBox.Size = new System.Drawing.Size(100, 21);
            this.pickCategoryReminderComboBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "New Reminder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Category";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(41, 51);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2020, 12, 7, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // addReminder
            // 
            this.addReminder.Location = new System.Drawing.Point(118, 336);
            this.addReminder.Name = "addReminder";
            this.addReminder.Size = new System.Drawing.Size(75, 23);
            this.addReminder.TabIndex = 7;
            this.addReminder.Text = "Add";
            this.addReminder.UseVisualStyleBackColor = true;
            this.addReminder.Click += new System.EventHandler(this.addReminder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Reminder";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(69, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // reminderDetail
            // 
            this.reminderDetail.Location = new System.Drawing.Point(112, 290);
            this.reminderDetail.Name = "reminderDetail";
            this.reminderDetail.Size = new System.Drawing.Size(100, 20);
            this.reminderDetail.TabIndex = 5;
            // 
            // reminderList
            // 
            this.reminderList.AutoScroll = true;
            this.reminderList.Location = new System.Drawing.Point(39, 84);
            this.reminderList.Name = "reminderList";
            this.reminderList.Size = new System.Drawing.Size(370, 283);
            this.reminderList.TabIndex = 3;
            // 
            // categoryReminderComboBox
            // 
            this.categoryReminderComboBox.FormattingEnabled = true;
            this.categoryReminderComboBox.Location = new System.Drawing.Point(102, 28);
            this.categoryReminderComboBox.Name = "categoryReminderComboBox";
            this.categoryReminderComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryReminderComboBox.TabIndex = 1;
            this.categoryReminderComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryReminderComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.editCategoryNote);
            this.tabPage2.Controls.Add(this.newCategoryNote);
            this.tabPage2.Controls.Add(this.newNote);
            this.tabPage2.Controls.Add(this.noteList);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.categoryNoteComboBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Note";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // editCategoryNote
            // 
            this.editCategoryNote.Location = new System.Drawing.Point(372, 22);
            this.editCategoryNote.Name = "editCategoryNote";
            this.editCategoryNote.Size = new System.Drawing.Size(103, 23);
            this.editCategoryNote.TabIndex = 5;
            this.editCategoryNote.Text = "Edit Category";
            this.editCategoryNote.UseVisualStyleBackColor = true;
            this.editCategoryNote.Click += new System.EventHandler(this.EditCategory_Click);
            // 
            // newCategoryNote
            // 
            this.newCategoryNote.Location = new System.Drawing.Point(263, 22);
            this.newCategoryNote.Name = "newCategoryNote";
            this.newCategoryNote.Size = new System.Drawing.Size(103, 23);
            this.newCategoryNote.TabIndex = 4;
            this.newCategoryNote.Text = "New Category";
            this.newCategoryNote.UseVisualStyleBackColor = true;
            this.newCategoryNote.Click += new System.EventHandler(this.NewCategoryNote_Click);
            // 
            // newNote
            // 
            this.newNote.Location = new System.Drawing.Point(624, 22);
            this.newNote.Name = "newNote";
            this.newNote.Size = new System.Drawing.Size(75, 23);
            this.newNote.TabIndex = 3;
            this.newNote.Text = "New Note";
            this.newNote.UseVisualStyleBackColor = true;
            this.newNote.Click += new System.EventHandler(this.NewNote_Click);
            // 
            // noteList
            // 
            this.noteList.AutoScroll = true;
            this.noteList.Location = new System.Drawing.Point(26, 51);
            this.noteList.Name = "noteList";
            this.noteList.Size = new System.Drawing.Size(716, 309);
            this.noteList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // categoryNoteComboBox
            // 
            this.categoryNoteComboBox.FormattingEnabled = true;
            this.categoryNoteComboBox.Location = new System.Drawing.Point(122, 24);
            this.categoryNoteComboBox.Name = "categoryNoteComboBox";
            this.categoryNoteComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryNoteComboBox.TabIndex = 0;
            this.categoryNoteComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // deleteReminder
            // 
            this.deleteReminder.Location = new System.Drawing.Point(118, 336);
            this.deleteReminder.Name = "deleteReminder";
            this.deleteReminder.Size = new System.Drawing.Size(75, 23);
            this.deleteReminder.TabIndex = 13;
            this.deleteReminder.Text = "Delete";
            this.deleteReminder.UseVisualStyleBackColor = true;
            this.deleteReminder.Click += new System.EventHandler(this.deleteReminder_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Index";
            this.Text = "Reminder & Note App";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.ComboBox categoryReminderComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categoryNoteComboBox;
        private System.Windows.Forms.Button newNote;
        private System.Windows.Forms.FlowLayoutPanel noteList;
        private System.Windows.Forms.Button newCategoryNote;
        private System.Windows.Forms.Button editCategoryNote;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.FlowLayoutPanel reminderList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addReminder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reminderDetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button editCategoryReminder;
        private System.Windows.Forms.Button newCategroyReminder;
        private System.Windows.Forms.ComboBox pickCategoryReminderComboBox;
        private System.Windows.Forms.Button cancelUpdateReminder;
        private System.Windows.Forms.Button updateReminder;
        private System.Windows.Forms.Button deleteReminder;
    }
}

