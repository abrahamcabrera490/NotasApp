using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotasApp
{
    
    public partial class Form1 : Form
    
    {
    
        List<Note> _notes = new List<Note>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            addData(txttitle.Text, txtdescription.Text);

        }


        public void addData(string a, string b)
        {
            if(!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b))
            {
                _notes.Add(new Note() { Title = a.ToString(), Description = b.ToString() });

                Binding();
                Clear();
            }
         else
            {
                MessageBox.Show("sin valor en titulo \n o en Nota");
            }   


        }

        public void Binding()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = _notes;
            dgvTask.DataSource = bs;
        }
        public void Clear()
        {
            txtdescription.Text = string.Empty;
            txttitle.Text = string.Empty;
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            if(dgvTask.SelectedRows != null)
            {
                var title = dgvTask.SelectedCells[0].Value.ToString();
                ReadTask(title);
            }
        }


        private void ReadTask(string a)
        {
            foreach(var note in _notes)
            {
                if(note.Title == a)
                {
                    txttitle.Text = note.Title.ToString();
                    txtdescription.Text = note.Description.ToString();
                }


            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (dgvTask.SelectedRows != null)
            {
                var title = dgvTask.SelectedCells[0].Value.ToString();
                Delete(title);
             
            }
        }

        private void Delete(string a) {

            Note noteDelete = null; 
        foreach (var note in _notes)
            {
                if (note.Title == a)
                {
                    noteDelete = note;
                }
            
            }
        if(noteDelete != null)
                _notes.Remove(noteDelete);
            Binding();

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
