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
    public partial class newNote : Form
    {
        Index parent;
        public newNote(Index _parent)
        {
            parent = _parent;
            InitializeComponent();
            display_data();
        }

        private void save_Click(object sender, EventArgs e)
        {
            var contex = new db_reminder_appEntities();
            var notes = new notes();
            var selectedCategory = (note_category)categoryComboBox.SelectedItem;
            notes.id_category = selectedCategory.id;
            notes.detail = detailTextBox.Text;
            notes.last_edited = DateTime.Now;
            contex.notes.Add(notes);
            contex.SaveChanges();
            parent.DisplayData();
            this.Close();
        }
        public void display_data()
        {

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = getNote_Categories();

            categoryComboBox.DataSource = bindingSource1.DataSource;

            categoryComboBox.DisplayMember = "name";
            categoryComboBox.ValueMember = "name";
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
    }
}
