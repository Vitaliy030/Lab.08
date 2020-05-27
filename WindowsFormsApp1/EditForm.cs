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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        void EditForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
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

                int n, n0;
                try
                {
                    n = Convert.ToInt32(Line00.Text);
                    if (n > count - 1 || n < 1)
                    {
                        MessageBox.Show("Ви ввели некоректний порядковий номер, введiть ще раз!");
                        return;
                    }
                    n0 = Convert.ToInt32(Column00.Text);
                    if (n0 > 5 || n0 < 1)
                    {
                        MessageBox.Show("Ви ввели некоректний номер стовпчика, введiть новий!");
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

                if (n0 == 1)
                {
                    int num;
                    try
                    {
                        num = Convert.ToInt32(textBox1.Text);
                        if (num < 0)
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

                    tickets[n - 1].ticket_number = num;
                }
                else if (n0 == 2)
                {
                    string nm = textBox1.Text;
                    for (int i = 0; i < nm.Length; i++)
                    {
                        if (Char.IsWhiteSpace(nm[i]))
                        {
                            MessageBox.Show("Ви ввели некоректне значення, введiть ще раз!");
                            return;
                        }
                    }

                    tickets[n - 1].the_name_of_the_buyer = nm;
                }
                else if (n0 == 3)
                {
                    string tit = textBox1.Text;
                    for (int i = 0; i < tit.Length; i++)
                    {
                        if (Char.IsWhiteSpace(tit[i]))
                        {
                            MessageBox.Show("Ви ввели некоректне значення, введiть ще раз!");
                            return;
                        }
                    }

                    tickets[n - 1].the_title_of_the_film = tit;
                }
                else if (n0 == 4)
                {
                    double pr;
                    try
                    {
                        pr = Convert.ToDouble(textBox1.Text);
                        if (pr < 0)
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

                    tickets[n - 1].ticket_price = pr;
                }
                else if (n0 == 5)
                {
                    string st = textBox1.Text;
                    if (st != "Paid" && st != "Unpaid")
                    {
                        MessageBox.Show("Ви ввели некоректне значення, введiть нове!");
                        return;
                    }
                    tickets[n - 1].payment_status = st;
                }

                using (StreamWriter f = new StreamWriter(TO.AddressFILE))
                {
                    f.WriteLine(TO.prt01);
                    foreach (var t in tickets)
                        f.WriteLine("{0}\t\t\t{1}\t\t\t\t\t{2}\t\t\t{3}\t\t\t\t{4}", t.ticket_number, t.the_name_of_the_buyer, t.the_title_of_the_film, t.ticket_price, t.payment_status);
                }
                MessageBox.Show("Змiни збережено!");

                label3.Text = "";
                textBox1.Text = "";
                textBox1.Visible = false;

                Line00.ReadOnly = false;
                Column00.ReadOnly = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Line00.Text == "" || Column00.Text == "")
                MessageBox.Show("Ви не ввели всіх параметрів!");
            else
            {
                Ticket_office TO = new Ticket_office();

                int count = File.ReadAllLines(TO.AddressFILE).Length;

                int n, n0;
                try
                {
                    n = Convert.ToInt32(Line00.Text);
                    if (n > count - 1 || n < 1)
                    {
                        MessageBox.Show("Ви ввели некоректний порядковий номер, введiть ще раз!");
                        return;
                    }
                    n0 = Convert.ToInt32(Column00.Text);
                    if (n0 > 5 || n0 < 1)
                    {
                        MessageBox.Show("Ви ввели некоректний номер стовпчика, введiть новий!");
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

                if (n0 == 1)
                {
                    label3.Text = "Номер квидка (8 цифр):";
                    textBox1.Visible = true;
                }
                else if (n0 == 2)
                {
                    label3.Text = "Прiзвище покупця:";
                    textBox1.Visible = true;
                }
                else if (n0 == 3)
                {
                    label3.Text = "Назва фiльму (без пробiлiв, використовуйте _ ):";
                    textBox1.Visible = true;
                }
                else if (n0 == 4)
                {
                    label3.Text = "Цiна квидка:";
                    textBox1.Visible = true;
                }
                else if (n0 == 5)
                {
                    label3.Text = "Cтатус оплати (Paid або Unpaid):";
                    textBox1.Visible = true;
                }

                Line00.ReadOnly = true;
                Column00.ReadOnly = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
