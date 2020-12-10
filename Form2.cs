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
    public partial class newCategory : Form
    {
        Index parent;
        String tab;
        public newCategory(String _tab, Index _parent)
        {
            parent = _parent;
            tab = _tab;
            InitializeComponent();
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

        private void confirm_Click(object sender, EventArgs e)
        {
            var contex = new db_reminder_appEntities();
            if(tab == "reminder")
            {
                var category = new reminder_category();
                category.name = name.Text;
                category.color = colorExamplePanel.BackColor.ToArgb();
                contex.reminder_category.Add(category);
                
            }
            if(tab == "notes")
            {
                var category = new note_category();
                category.name = name.Text;
                category.color = colorExamplePanel.BackColor.ToArgb();
                contex.note_category.Add(category);
            }
            contex.SaveChanges();
            parent.DisplayData();
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
