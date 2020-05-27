using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Ticket_office
    {
        public string AddressFILE = "D:\\ІТ\\Програмування\\Програми\\Lab.8\\WindowsFormsApp1\\Ticket office.txt";
        public string prt01 = "Ticket number:\t\t\tThe name of the buyer:\t\t\tThe title of the film:\t\t\tTicket price:\t\t\tPayment status:";

        private int Ticket_number;
        private string The_name_of_the_buyer;
        private string The_title_of_the_film;
        private double Ticket_price;
        private string Payment_status;

        public int ticket_number
        {
            get
            {
                return Ticket_number;
            }
            set
            {
                Ticket_number = value;
            }
        }
        public string the_name_of_the_buyer
        {
            get
            {
                return The_name_of_the_buyer;
            }
            set
            {
                The_name_of_the_buyer = value;
            }
        }
        public string the_title_of_the_film
        {
            get
            {
                return The_title_of_the_film;
            }
            set
            {
                The_title_of_the_film = value;
            }
        }
        public double ticket_price
        {
            get
            {
                return Ticket_price;
            }
            set
            {
                Ticket_price = value;
            }
        }
        public string payment_status
        {
            get
            {
                return Payment_status;
            }
            set
            {
                Payment_status = value;
            }
        }

        public Ticket_office() { }
        public Ticket_office(int ticket_number, string the_name_of_the_buyer, string the_title_of_the_film, double ticket_price, string payment_status)
        {
            this.ticket_number = ticket_number;
            this.the_name_of_the_buyer = the_name_of_the_buyer;
            this.the_title_of_the_film = the_title_of_the_film;
            this.ticket_price = ticket_price;
            this.payment_status = payment_status;
        }
    }

    public class SortByTicket_number : IComparer<Ticket_office>
    {
        int IComparer<Ticket_office>.Compare(Ticket_office b1, Ticket_office b2)
        {
            if (b1.ticket_number < b2.ticket_number)
                return -1;
            else if (b1.ticket_number > b2.ticket_number)
                return 1;
            else
                return 0;
        }
    }
    public class SortByThe_name_of_the_buyer : IComparer<Ticket_office>
    {
        int IComparer<Ticket_office>.Compare(Ticket_office b1, Ticket_office b2)
        {
            string str = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

            int k1 = str.Length + 5;
            int k2 = str.Length + 5;
            if (b1.the_name_of_the_buyer.Length > b2.the_name_of_the_buyer.Length)
            {
                for (int j1 = 0; j1 < b2.the_name_of_the_buyer.Length - 1; j1++)
                {
                    for (int z = 0; z < str.Length - 1; z++)
                    {
                        if ((b1.the_name_of_the_buyer[j1] == str[z]) && (b2.the_name_of_the_buyer[j1] == str[z]))
                        {
                            k1 = z;
                            k2 = z;
                            break;
                        }
                        else if (b1.the_name_of_the_buyer[j1] == str[z])
                        {
                            k1 = z;
                            break;
                        }
                        else if (b2.the_name_of_the_buyer[j1] == str[z])
                        {
                            k2 = z;
                            break;
                        }
                    }
                    if (k1 < k2)
                        return -1;
                    else if (k1 > k2)
                        return 1;
                    else if (k1 == str.Length + 5 && k2 == str.Length + 5)
                        continue;
                    else if (k1 == k2)
                        continue;
                }
                return 0;
            }
            else
            {
                for (int j1 = 0; j1 < b1.the_name_of_the_buyer.Length - 1; j1++)
                {
                    for (int z = 0; z < str.Length - 1; z++)
                    {
                        if ((b1.the_name_of_the_buyer[j1] == str[z]) && (b2.the_name_of_the_buyer[j1] == str[z]))
                        {
                            k1 = z;
                            k2 = z;
                            break;
                        }
                        else if (b1.the_name_of_the_buyer[j1] == str[z])
                        {
                            k1 = z;
                            break;
                        }
                        else if (b2.the_name_of_the_buyer[j1] == str[z])
                        {
                            k2 = z;
                            break;
                        }
                    }
                    if (k1 < k2)
                        return -1;
                    else if (k1 > k2)
                        return 1;
                    else if (k1 == str.Length + 5 && k2 == str.Length + 5)
                        continue;
                    else if (k1 == k2)
                        continue;

                }
                return 0;
            }
        }
    }
    public class SortByThe_title_of_the_film : IComparer<Ticket_office>
    {
        int IComparer<Ticket_office>.Compare(Ticket_office b1, Ticket_office b2)
        {
            string str = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz_";

            int k1 = str.Length + 5;
            int k2 = str.Length + 5;
            if (b1.the_title_of_the_film.Length > b2.the_title_of_the_film.Length)
            {
                for (int j1 = 0; j1 < b2.the_title_of_the_film.Length - 1; j1++)
                {
                    for (int z = 0; z < str.Length - 1; z++)
                    {
                        if ((b1.the_title_of_the_film[j1] == str[z]) && (b2.the_title_of_the_film[j1] == str[z]))
                        {
                            k1 = z;
                            k2 = z;
                            break;
                        }
                        else if (b1.the_title_of_the_film[j1] == str[z])
                        {
                            k1 = z;
                            break;
                        }
                        else if (b2.the_title_of_the_film[j1] == str[z])
                        {
                            k2 = z;
                            break;
                        }
                    }
                    if (k1 < k2)
                        return -1;
                    else if (k1 > k2)
                        return 1;
                    else if (k1 == str.Length + 5 && k2 == str.Length + 5)
                        continue;
                    else if (k1 == k2)
                        continue;
                }
                return 0;
            }
            else
            {
                for (int j1 = 0; j1 < b1.the_title_of_the_film.Length - 1; j1++)
                {
                    for (int z = 0; z < str.Length - 1; z++)
                    {
                        if ((b1.the_title_of_the_film[j1] == str[z]) && (b2.the_title_of_the_film[j1] == str[z]))
                        {
                            k1 = z;
                            k2 = z;
                            break;
                        }
                        else if (b1.the_title_of_the_film[j1] == str[z])
                        {
                            k1 = z;
                            break;
                        }
                        else if (b2.the_title_of_the_film[j1] == str[z])
                        {
                            k2 = z;
                            break;
                        }
                    }
                    if (k1 < k2)
                        return -1;
                    else if (k1 > k2)
                        return 1;
                    else if (k1 == str.Length + 5 && k2 == str.Length + 5)
                        continue;
                    else if (k1 == k2)
                        continue;

                }
                return 0;
            }
        }
    }
    public class SortByTicket_price : IComparer<Ticket_office>
    {
        int IComparer<Ticket_office>.Compare(Ticket_office b1, Ticket_office b2)
        {
            if (b1.ticket_price < b2.ticket_price)
                return -1;
            else if (b1.ticket_price > b2.ticket_price)
                return 1;
            else
                return 0;
        }
    }
    public class SortByPayment_status : IComparer<Ticket_office>
    {
        int IComparer<Ticket_office>.Compare(Ticket_office b1, Ticket_office b2)
        {
            if ((b1.payment_status == "Unpaid" && b2.payment_status == "Paid") || (b1.payment_status == "Unpaid" && b2.payment_status == "Unpaid"))
                return 1;
            else if (b1.payment_status == "Paid" && b2.payment_status == "Unpaid")
                return -1;
            else
                return 0;
        }
    }
}
