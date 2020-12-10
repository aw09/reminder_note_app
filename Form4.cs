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
    public partial class EditNote : Form
    {
        notes note;
        Index parent;
        public EditNote(notes _note, Index _parent)
        {
            InitializeComponent();
            note = _note;
            parent = _parent;
            display_data();
        }

        private void update_Click(object sender, EventArgs e)
        {
            var contex = new db_reminder_appEntities();
            var editedNote = (from a in contex.notes
                              where a.id == note.id
                              select a).Single();
            editedNote.detail = detailTextBox.Text;
            editedNote.id_category = ((note_category)categoryComboBox.SelectedItem).id;
            editedNote.last_edited = DateTime.Now;
            contex.SaveChanges();
            parent.DisplayData();
            this.Close();
        }
        public void display_data()
        {
            bindCategories();
            detailTextBox.Text = note.detail;
        }
        private void bindCategories()
        {
            var bindingSource1 = new BindingSource();
            List<note_category> categories = getNote_Categories();
            bindingSource1.DataSource = categories;

            categoryComboBox.DataSource = bindingSource1.DataSource;

            categoryComboBox.DisplayMember = "name";
            categoryComboBox.ValueMember = "name";

            var i = 0;
            foreach(note_category category in categories)
            {
                if (category.id == note.note_category.id)
                    categoryComboBox.SelectedIndex = i;
                i++;
            }
        }

        private List<note_category> getNote_Categories()
        {
            var contex = new db_reminder_appEntities();
            List<note_category> list = (from a in contex.note_category select a).ToList();
            return list;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this note ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var contex = new db_reminder_appEntities();
                var deleteNote = (from a in contex.notes
                                  where a.id == note.id
                                  select a).Single();
                contex.notes.Remove(deleteNote);
                contex.SaveChanges();
                parent.DisplayData();
                this.Close();
            }
        }
    }
}
