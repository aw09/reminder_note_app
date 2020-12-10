using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;

namespace reminder_notes_app
{
    public partial class Index : Form
    {
        System.Threading.Timer timer;
        reminders tempReminder;
        public Index()
        {
            InitializeComponent();
            timer = new System.Threading.Timer(StartThread, "", TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
            DisplayData();
        }
        private void StartThread(object state)
        {
            if (GetReminders().Count > 0)
            {
                reminders reminder = GetReminders().First();

                DateTime alarm = ((DateTime)reminder.date).Add((TimeSpan)reminder.time);
                if (alarm <= DateTime.Now)
                {
                    tempReminder = reminder;
                    ReminderAction();
                }
            }   
            
        }
        private void ReminderAction()
        {
            timer.Change(TimeSpan.FromSeconds(100), TimeSpan.FromSeconds(100));
            SoundPlayer simpleSound = new SoundPlayer("E:/FFOutput/Alarm.wav");
            simpleSound.Play();
            if (MessageBox.Show(tempReminder.detail, "Reminder Alert", MessageBoxButtons.OK) == DialogResult.OK)
            {
                if (InvokeRequired)
                    Invoke(new MethodInvoker(DeleteReminder));
                else
                    DeleteReminder();
                timer.Change(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
                simpleSound.Stop();
            }
                
        }
        private void NewNote_Click(object sender, EventArgs e)
        {
            Form newNote = new newNote(this);
            newNote.Show();
        }

        private void NewCategoryNote_Click(object sender, EventArgs e)
        {
            Form newCategory = new newCategory("notes", this);
            newCategory.Show();
        }

        public void DisplayData()
        {
            CheckEditCategory();
            BindingCategories();
            DisplayNotes("All");
            SettingsReminderTab();
            DisplayReminder("All");
        }
        private void BindingCategories()
        {
            ComboBoxBinding(GetNoteCategories(), categoryNoteComboBox);
            ComboBoxBinding(GetReminderCategories(), categoryReminderComboBox);
            ComboBoxBinding(GetReminderCategories(false), pickCategoryReminderComboBox);
        }
        private void ComboBoxBinding<T>(List<T> list, ComboBox comboBox)
        {
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = list;
            comboBox.DataSource = bindingSource1.DataSource;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "name";
        }
        private List<reminder_category> GetReminderCategories(bool addAll = true)
        {
            var contex = new db_reminder_appEntities();
            var all = new reminder_category(-1, "All");
            List<reminder_category> list = (from a in contex.reminder_category select a).ToList();
            if(addAll)
                list.Insert(0, all);
            return list;
        }
        private List<note_category> GetNoteCategories()
        {
            var contex = new db_reminder_appEntities();
            var all = new note_category(-1, "All");
            List<note_category> list = (from a in contex.note_category select a).ToList();
            list.Insert(0, all);
            return list;
        }
        private void DisplayNotes(String _name)
        {
            noteList.Controls.Clear();
            List<notes> listNotes = GetNotes();
            foreach(notes note in listNotes)
            {
                var margin = 5;
                Panel panel = new Panel();
                panel.Width = noteList.Width/3-margin*3;
                Label label = new Label();
                label.Text = note.detail;
                label.Location = new Point(margin, margin);
                label.Height = panel.Height - 2*margin;
                label.Width = panel.Width - 2 * margin;
                label.DoubleClick += (sender, e) => NoteClick(note);
                panel.Controls.Add(label);
                panel.DoubleClick += (sender, e) => NoteClick(note);

                panel.BackColor = Color.FromArgb((int)note.note_category.color);
                if (note.note_category.name == _name || _name == "All")
                    noteList.Controls.Add(panel);
            }
        }
        private void NoteClick(notes note)
        {
            EditNote editNote = new EditNote(note, this);
            editNote.Show();
        }

        private List<notes> GetNotes()
        {
            var contex = new db_reminder_appEntities();
            List<notes> list = (from a in contex.notes orderby a.last_edited descending select a).ToList();
            return list;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            noteList.Controls.Clear();
            DisplayNotes(((note_category)categoryNoteComboBox.SelectedItem).name);
            CheckEditCategory();
        }
        private void CheckEditCategory()
        {
            if (categoryNoteComboBox.SelectedIndex == 0)
                editCategoryNote.Hide();
            else
                editCategoryNote.Show();
        }

        private void EditCategory_Click(object sender, EventArgs e)
        {
            Form editCategory = new EditCategoryNote((note_category)categoryNoteComboBox.SelectedItem, this);
            editCategory.Show();
        }

        private void NewCategroyReminder_Click(object sender, EventArgs e)
        {
            Form newCategory = new newCategory("reminder", this);
            newCategory.Show();
        }

        private void addReminder_Click(object sender, EventArgs e)
        {
            var contex = new db_reminder_appEntities();
            var reminders = new reminders();
            var selectedCategory = (reminder_category)pickCategoryReminderComboBox.SelectedItem;
            reminders.id_category = selectedCategory.id;
            reminders.detail = reminderDetail.Text;
            reminders.date = monthCalendar1.SelectionStart;
            reminders.time = TimeSpan.Parse(dateTimePicker1.Value.ToString("H:mm:ss"));
            contex.reminders.Add(reminders);
            contex.SaveChanges();
            DisplayData();
            ClearData();
        }
        private void DisplayReminder(string _name)
        {
            reminderList.Controls.Clear();
            List<reminders> listReminders = GetReminders();
            foreach (reminders reminder in listReminders)
            {
                var margin = 5;
                Panel panel = new Panel();
                panel.Width = reminderList.Width-5*margin;
                //Label untuk detail
                Label detail = new Label();
                detail.Text = reminder.detail;
                detail.Location = new Point(margin, margin);
                detail.Height = panel.Height - 2 * margin;
                detail.Width = panel.Width*2/3;
                detail.DoubleClick += (sender, e) => ReminderClick(reminder);

                //Label untuk tanggal
                Label date = new Label();
                date.Text = reminder.date.ToString();
                date.Location = new Point(panel.Width - 20*margin,2*margin);
                date.DoubleClick += (sender, e) => ReminderClick(reminder);

                //Label untuk waktu
                Label time = new Label();
                time.Text = reminder.time.ToString();
                time.Location = new Point(panel.Width - 20 * margin, 8*margin);
                time.DoubleClick += (sender, e) => ReminderClick(reminder);


                panel.Controls.Add(detail);
                panel.Controls.Add(date);
                panel.Controls.Add(time);
                panel.DoubleClick += (sender, e) => ReminderClick(reminder);
                panel.BackColor = Color.FromArgb((int)reminder.reminder_category.color);
                if (reminder.reminder_category.name == _name || _name == "All")
                    reminderList.Controls.Add(panel);
            }
        }
        private void ReminderClick(reminders reminder) 
        {
            monthCalendar1.SelectionStart = (DateTime)reminder.date;
            dateTimePicker1.Value = Convert.ToDateTime(reminder.time.ToString());
            List<reminder_category> categories = GetReminderCategories(false);
            var index = 0;
            foreach(reminder_category category in categories)
            {
                Console.WriteLine(category.id.ToString()+" "+reminder.id_category);
                if (category.id == reminder.id_category)
                    break;
                else
                    index++;
                Console.WriteLine(index);
            }
            tempReminder = reminder;
            pickCategoryReminderComboBox.SelectedIndex = index;
            reminderDetail.Text = reminder.detail;
            addReminder.Hide();
            updateReminder.Show();
            deleteReminder.Show();
            cancelUpdateReminder.Show();
        }
        private void SettingsReminderTab()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Value = DateTime.Today;
            monthCalendar1.MinDate = DateTime.Today;
            monthCalendar1.SelectionStart = DateTime.Today;
            monthCalendar1.SelectionEnd = DateTime.Today;
            editCategoryReminder.Hide();
            addReminder.Show();
            updateReminder.Hide();
            deleteReminder.Hide();
            cancelUpdateReminder.Hide();
        }
        private void ClearData()
        {
            monthCalendar1.ResetText();
            dateTimePicker1.Value = DateTime.Today;
            reminderDetail.ResetText();
        }
        private List<reminders> GetReminders()
        {
            var contex = new db_reminder_appEntities();
            List<reminders> list = (from a in contex.reminders orderby a.date , a.time select a).ToList();
            return list;
        }

        private void cancelUpdateReminder_Click(object sender, EventArgs e)
        {
            CancelClick();
        }
        private void CancelClick()
        {
            tempReminder = null;
            monthCalendar1.ResetText();
            pickCategoryReminderComboBox.ResetText();
            reminderDetail.ResetText();
            dateTimePicker1.Value = DateTime.Today;
            DisplayData();
        }
        private void categoryReminderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryReminderComboBox.SelectedIndex != 0)
                editCategoryReminder.Show();
            else
                editCategoryReminder.Hide();
            DisplayReminder(((reminder_category)categoryReminderComboBox.SelectedItem).name);
        }

        private void editCategoryReminder_Click(object sender, EventArgs e)
        {
            EditCategoryReminder edit = new EditCategoryReminder((reminder_category)categoryReminderComboBox.SelectedItem, this);
            edit.Show();
        }

        private void deleteReminder_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this reminder ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                DeleteReminder();
            }
        }
        private void DeleteReminder()
        {
            Console.WriteLine(tempReminder.id);
            var contex = new db_reminder_appEntities();
            var deleteReminder = (from a in contex.reminders
                                where a.id == tempReminder.id
                                select a).Single();
            contex.reminders.Remove(deleteReminder);
            contex.SaveChanges();
            DisplayData();
            CancelClick();
        }

        private void updateReminder_Click(object sender, EventArgs e)
        {
            var contex = new db_reminder_appEntities();
            var editReminder = (from a in contex.reminders
                              where a.id == tempReminder.id
                              select a).Single();
            editReminder.detail = reminderDetail.Text;
            editReminder.id_category = ((reminder_category)pickCategoryReminderComboBox.SelectedItem).id;
            editReminder.date = monthCalendar1.SelectionStart;
            editReminder.time = TimeSpan.Parse(dateTimePicker1.Value.ToString("H:mm:ss"));
            contex.SaveChanges();
            DisplayData();
        }
    }
}
