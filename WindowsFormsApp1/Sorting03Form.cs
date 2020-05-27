using System;
using System.IO;
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
    public partial class Sorting03Form : Form
    {
        public Sorting03Form()
        {
            InitializeComponent();

            Ticket_office TO = new Ticket_office();
            List<Ticket_office> tickets = new List<Ticket_office>();
            string[] s0 = File.ReadAllLines(TO.AddressFILE);
            int count = File.ReadAllLines(TO.AddressFILE).Length;

            for (int j = 1; j < File.ReadAllLines(TO.AddressFILE).Length; j++)
            {
                string s = s0[j];
                int u = s.Length;

                int k = 0;
                int l = 1;

                foreach (char c in s)
                {
                    if (Char.IsWhiteSpace(c))
                        break;
                    k++;
                }
                int ticket_number = Convert.ToInt32(s.Substring(0, k));

                for (int i = k + 1; i < u; i++)
                {
                    if (Char.IsWhiteSpace(s[i]))
                        k++;
                    else
                        break;
                }

                k++;
                for (int i = k + 1; i < u; i++)
                {
                    if (Char.IsWhiteSpace(s[i]))
                        break;
                    l++;
                }
                string the_name_of_the_buyer = s.Substring(k, l);

                k += l;
                l = 1;
                for (int i = k; i < u; i++)
                {
                    if (Char.IsWhiteSpace(s[i]))
                        k++;
                    else
                        break;
                }

                for (int i = k; i < u; i++)
                {
                    if (Char.IsWhiteSpace(s[i]))
                        break;
                    l++;
                }
                string the_title_of_the_film = s.Substring(k, l - 1);

                k = k + l - 1;
                l = 1;
                for (int i = k; i < u; i++)
                {
                    if (Char.IsWhiteSpace(s[i]))
                        k++;
                    else
                        break;
                }

                for (int i = k; i < u; i++)
                {
                    if (Char.IsWhiteSpace(s[i]))
                        break;
                    l++;
                }
                double ticket_price = Convert.ToDouble(s.Substring(k, l));

                k = k + l - 1;
                l = 1;
                for (int i = k; i < u; i++)
                {
                    if (Char.IsWhiteSpace(s[i]))
                        k++;
                    else
                        break;
                }

                for (int i = k; i < u; i++)
                {
                    if (Char.IsWhiteSpace(s[i]))
                        break;
                    l++;
                }
                string payment_status = s.Substring(k, l - 1);

                tickets.Add(new Ticket_office(ticket_number, the_name_of_the_buyer, the_title_of_the_film, ticket_price, payment_status));
            }

            tickets.Sort(new SortByThe_title_of_the_film());

            dataGridView1.RowCount = count - 1;
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                dataGridView1[0, j].Value = tickets[j].ticket_number;
                dataGridView1[1, j].Value = tickets[j].the_name_of_the_buyer;
                dataGridView1[2, j].Value = tickets[j].the_title_of_the_film;
                dataGridView1[3, j].Value = tickets[j].ticket_price;
                dataGridView1[4, j].Value = tickets[j].payment_status;
            }
        }

        private void Sorting03Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        void EditForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button2_Click(button2, null);
            }
        }
    }
}
