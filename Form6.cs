using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reminder_notes_app
{
    public partial class EditCategoryReminder : Form
    {
        Index parent;
        reminder_category category;
        public EditCategoryReminder(reminder_category _category, Index _parent)
        {
            InitializeComponent();
            parent = _parent;
            category = _category;
            display_data();
        }

        private void display_data()
        {
            name.Text = category.name;
            colorExamplePanel.BackColor = Color.FromArgb((int)category.color);
        }
        private void update_Click(object sender, EventArgs e)
        {
            var contex = new db_reminder_appEntities();
            var editCategory = (from a in contex.reminder_category
                                where a.id == category.id
                                select a).Single();
            editCategory.name = name.Text;
            editCategory.color = colorExamplePanel.BackColor.ToArgb();
            contex.SaveChanges();
            parent.DisplayData();
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this category and all content??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var contex = new db_reminder_appEntities();
                var deleteCategory = (from a in contex.reminder_category
                                      where a.id == category.id
                                      select a).Single();
                var listReminder = (from a in contex.reminders
                                 where a.id_category == category.id
                                 select a).ToList();
                if (listReminder.Count > 0)
                    MessageBox.Show("Cannot delete this category\nDelete all note in this category first!", "Failed", MessageBoxButtons.OK);
                else
                {
                    contex.reminder_category.Remove(deleteCategory);
                    contex.SaveChanges();
                    parent.DisplayData();
                    this.Close();
                }

            }
        }

        private void pickColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = colorExamplePanel.BackColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                colorExamplePanel.BackColor = MyDialog.Color;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
