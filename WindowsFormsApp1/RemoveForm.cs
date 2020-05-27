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
    public partial class RemoveForm : Form
    {
        public RemoveForm()
        {
            InitializeComponent();
        }

        private void RemoveForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DeleteLine.Text == "")
                MessageBox.Show("Ви не ввели всіх параметрів!");
            else
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

                int count = File.ReadAllLines(TO.AddressFILE).Length;

                int n;
                try
                {
                    n = Convert.ToInt32(DeleteLine.Text);
                    if (n > count - 1 || n < 1)
                    {
                        MessageBox.Show("Ви ввели некоректний порядковий номер, введiть ще раз!");
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

                tickets.RemoveAt(n - 1);
                using (StreamWriter f = new StreamWriter(TO.AddressFILE))
                {
                    f.WriteLine(TO.prt01);
                    foreach (var t in tickets)
                        f.WriteLine("{0}\t\t\t{1}\t\t\t\t\t{2}\t\t\t{3}\t\t\t\t{4}", t.ticket_number, t.the_name_of_the_buyer, t.the_title_of_the_film, t.ticket_price, t.payment_status);
                }
                MessageBox.Show("Змiни збережено!");

                DeleteLine.Text = "";
            }
        }
    }
}
