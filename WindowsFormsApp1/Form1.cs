using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Mode01.Checked && !Mode02.Checked && !Mode03.Checked && !Mode04.Checked && !SelectedSort01.Checked && !SelectedSort02.Checked && !SelectedSort03.Checked && !SelectedSort04.Checked && !SelectedSort05.Checked)
            {
                MessageBox.Show("Ви не вибрали режим!");
            }
            else if (Mode01.Checked)
            {
                Hide();
                AddForm addForm = new AddForm();
                addForm.Show();
            }
            else if (Mode02.Checked)
            {
                Hide();
                EditForm editForm = new EditForm();
                editForm.Show();
            }
            else if (Mode03.Checked)
            {
                Hide();
                RemoveForm removeForm = new RemoveForm();
                removeForm.Show();
            }
            else if (Mode04.Checked)
            {
                Hide();
                OutputForm outputForm = new OutputForm();
                outputForm.Show();
            }
            else if (SelectedSort01.Checked)
            {
                Hide();
                Sorting01Form sorting01Form = new Sorting01Form();
                sorting01Form.Show();
            }
            else if (SelectedSort02.Checked)
            {
                Hide();
                Sorting02Form sorting02Form = new Sorting02Form();
                sorting02Form.Show();
            }
            else if (SelectedSort03.Checked)
            {
                Hide();
                Sorting03Form sorting03Form = new Sorting03Form();
                sorting03Form.Show();
            }
            else if (SelectedSort04.Checked)
            {
                Hide();
                Sorting04Form sorting04Form = new Sorting04Form();
                sorting04Form.Show();
            }
            else if (SelectedSort05.Checked)
            {
                Hide();
                Sorting05Form sorting05Form = new Sorting05Form();
                sorting05Form.Show();
            }
        }

        private void Mode05_CheckedChanged(object sender, EventArgs e)
        {
            Sorting01.Visible = true;
            Sorting02.Visible = true;
            Sorting03.Visible = true;
            Sorting04.Visible = true;
            Sorting05.Visible = true;

            SelectedSort01.Visible = true;
            SelectedSort02.Visible = true;
            SelectedSort03.Visible = true;
            SelectedSort04.Visible = true;
            SelectedSort05.Visible = true;

            if (!Mode05.Checked && !SelectedSort01.Checked && !SelectedSort02.Checked && !SelectedSort03.Checked && !SelectedSort04.Checked && !SelectedSort05.Checked)
            {
                Sorting01.Visible = false;
                Sorting02.Visible = false;
                Sorting03.Visible = false;
                Sorting04.Visible = false;
                Sorting05.Visible = false;

                SelectedSort01.Visible = false;
                SelectedSort02.Visible = false;
                SelectedSort03.Visible = false;
                SelectedSort04.Visible = false;
                SelectedSort05.Visible = false;
            }
        }

        private void SelectedSort01_CheckedChanged(object sender, EventArgs e)
        {
            if (!Mode05.Checked && !SelectedSort01.Checked && !SelectedSort02.Checked && !SelectedSort03.Checked && !SelectedSort04.Checked && !SelectedSort05.Checked)
            {
                Sorting01.Visible = false;
                Sorting02.Visible = false;
                Sorting03.Visible = false;
                Sorting04.Visible = false;
                Sorting05.Visible = false;

                SelectedSort01.Visible = false;
                SelectedSort02.Visible = false;
                SelectedSort03.Visible = false;
                SelectedSort04.Visible = false;
                SelectedSort05.Visible = false;
            }
        }

        private void SelectedSort02_CheckedChanged(object sender, EventArgs e)
        {
            if (!Mode05.Checked && !SelectedSort01.Checked && !SelectedSort02.Checked && !SelectedSort03.Checked && !SelectedSort04.Checked && !SelectedSort05.Checked)
            {
                Sorting01.Visible = false;
                Sorting02.Visible = false;
                Sorting03.Visible = false;
                Sorting04.Visible = false;
                Sorting05.Visible = false;

                SelectedSort01.Visible = false;
                SelectedSort02.Visible = false;
                SelectedSort03.Visible = false;
                SelectedSort04.Visible = false;
                SelectedSort05.Visible = false;
            }
        }

        private void SelectedSort03_CheckedChanged(object sender, EventArgs e)
        {
            if (!Mode05.Checked && !SelectedSort01.Checked && !SelectedSort02.Checked && !SelectedSort03.Checked && !SelectedSort04.Checked && !SelectedSort05.Checked)
            {
                Sorting01.Visible = false;
                Sorting02.Visible = false;
                Sorting03.Visible = false;
                Sorting04.Visible = false;
                Sorting05.Visible = false;

                SelectedSort01.Visible = false;
                SelectedSort02.Visible = false;
                SelectedSort03.Visible = false;
                SelectedSort04.Visible = false;
                SelectedSort05.Visible = false;
            }
        }

        private void SelectedSort04_CheckedChanged(object sender, EventArgs e)
        {
            if (!Mode05.Checked && !SelectedSort01.Checked && !SelectedSort02.Checked && !SelectedSort03.Checked && !SelectedSort04.Checked && !SelectedSort05.Checked)
            {
                Sorting01.Visible = false;
                Sorting02.Visible = false;
                Sorting03.Visible = false;
                Sorting04.Visible = false;
                Sorting05.Visible = false;

                SelectedSort01.Visible = false;
                SelectedSort02.Visible = false;
                SelectedSort03.Visible = false;
                SelectedSort04.Visible = false;
                SelectedSort05.Visible = false;
            }
        }

        private void SelectedSort05_CheckedChanged(object sender, EventArgs e)
        {
            if (!Mode05.Checked && !SelectedSort01.Checked && !SelectedSort02.Checked && !SelectedSort03.Checked && !SelectedSort04.Checked && !SelectedSort05.Checked)
            {
                Sorting01.Visible = false;
                Sorting02.Visible = false;
                Sorting03.Visible = false;
                Sorting04.Visible = false;
                Sorting05.Visible = false;

                SelectedSort01.Visible = false;
                SelectedSort02.Visible = false;
                SelectedSort03.Visible = false;
                SelectedSort04.Visible = false;
                SelectedSort05.Visible = false;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
