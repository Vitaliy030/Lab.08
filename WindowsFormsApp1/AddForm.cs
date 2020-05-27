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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        void AddForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ticket_office TO = new Ticket_office();
            List<Ticket_office> tickets = new List<Ticket_office>();
            string[] s0 = File.ReadAllLines(TO.AddressFILE);

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

            if (Ticket_number.Text == "" || The_name_of_the_buyer.Text == "" || The_title_of_the_film.Text == "" || Ticket_price.Text == "" || Payment_status.Text == "")
                MessageBox.Show("Ви не ввели всіх параметрів!");
            else
            {
                int ticket_number;
                try
                {
                    ticket_number = Convert.ToInt32(Ticket_number.Text);
                    if (ticket_number < 0)
                    {
                        MessageBox.Show("Ви ввели некоректне значення, введiть нове!");
                        return;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ви ввели некоректне значення, введiть нове!");
                    return;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Ви ввели некоректне значення, введiть нове!");
                    return;
                }

                string the_name_of_the_buyer = The_name_of_the_buyer.Text;
                for (int i = 0; i < the_name_of_the_buyer.Length; i++)
                {
                    if (Char.IsWhiteSpace(the_name_of_the_buyer[i]))
                    {
                        MessageBox.Show("Ви ввели некоректне значення, введiть ще раз!");
                        return;
                    }
                }

                string the_title_of_the_film = The_title_of_the_film.Text;
                for (int i = 0; i < the_title_of_the_film.Length; i++)
                {
                    if (Char.IsWhiteSpace(the_title_of_the_film[i]))
                    {
                        MessageBox.Show("Ви ввели некоректне значення, введiть ще раз!");
                        return;
                    }
                }

                double ticket_price;
                try
                {
                    ticket_price = Convert.ToDouble(Ticket_price.Text);
                    if (ticket_price < 0)
                    {
                        MessageBox.Show("Ви ввели некоректне значення, введiть нове!");
                        return;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ви ввели некоректне значення, введiть нове!");
                    return;
                }

                string payment_status = Payment_status.Text;
                if (payment_status != "Paid" && payment_status != "Unpaid")
                {
                    MessageBox.Show("Ви ввели некоректне значення, введiть нове!");
                    return;
                }

                tickets.Add(new Ticket_office(ticket_number, the_name_of_the_buyer, the_title_of_the_film, ticket_price, payment_status));

                using (StreamWriter f = new StreamWriter(TO.AddressFILE, true))
                    f.WriteLine("{0}\t\t\t{1}\t\t\t\t\t{2}\t\t\t{3}\t\t\t\t{4}", ticket_number, the_name_of_the_buyer, the_title_of_the_film, ticket_price, payment_status);
                MessageBox.Show("Змiни збережено!");

                Ticket_number.Text = "";
                The_name_of_the_buyer.Text = "";
                The_title_of_the_film.Text = "";
                Ticket_price.Text = "";
                Payment_status.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
