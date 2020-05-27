using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Ticket_office
    {
        public string AddressFILE = "D:\\ІТ\\Програмування\\Програми\\Lab.8\\ConsoleApp1\\Ticket office.txt";
        public string prt01 = "Ticket number:\t\t\tThe name of the buyer:\t\t\tThe title of the film:\t\t\tTicket price:\t\t\tPayment status:";

        public int Is_int32(string input)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(input);
                    if (number >= 0)
                        return number;
                    else
                    {
                        Console.WriteLine("Ви ввели некоректне значення, введiть нове: ");
                        input = Console.ReadLine();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ви ввели некоректне значення, введiть нове: ");
                    input = Console.ReadLine();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ви ввели некоректне значення, введiть нове: ");
                    input = Console.ReadLine();
                }
            }
        }
        public string Is_name_title(string input)
        {
            bool a = true;
            while (a)
            {
                a = false;
                for (int i = 0; i < input.Length; i++)
                {
                    if (Char.IsWhiteSpace(input[i]))
                    {
                        Console.WriteLine("Ви ввели некоректне значення, введiть ще раз!");
                        input = Console.ReadLine();
                        a = true;
                        break;
                    }
                }
            }
            return input;
        }
        public double Is_double(string input)
        {
            while (true)
            {
                try
                {
                    double number = Convert.ToDouble(input);
                    if (number > 0)
                        return number;
                    else
                    {
                        Console.WriteLine("Ви ввели некоректне значення, введiть нове: ");
                        input = Console.ReadLine();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ви ввели некоректне значення, введiть нове: ");
                    input = Console.ReadLine();
                }
            }
        }
        public string Is_status(string input)
        {
            while (true)
            {
                if (input == "Paid" || input == "Unpaid")
                    return input;
                else
                {
                    Console.WriteLine("Ви ввели некоректне значення, введiть нове: ");
                    input = Console.ReadLine();
                }
            }
        }

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

    class Program
    {
        static void Main(string[] args)
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

            while (true)
            {
                Console.WriteLine("Натиснiть на одну з вказаних клавiш, щоб вибрати режим роботи: ");
                Console.WriteLine("Додавання записiв - Enter");
                Console.WriteLine("Редагування записiв - E");
                Console.WriteLine("Знищення записiв - R");
                Console.WriteLine("Виведення iнформацiї з файла на екран - O");
                Console.WriteLine("Сортування - Tab");
                Console.WriteLine("Вихiд з програми - будь-яка iнша клавiша");

                ConsoleKeyInfo cki;
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("\nВведiть номер квидка (8 цифр):");
                    int ticket_number = TO.Is_int32(Console.ReadLine());

                    Console.WriteLine("Введiть прiзвище покупця:");
                    string the_name_of_the_buyer = TO.Is_name_title(Console.ReadLine());

                    Console.WriteLine("Введiть назву фiльму (без пробiлiв, використовуйте _ ):");
                    string the_title_of_the_film = TO.Is_name_title(Console.ReadLine());

                    Console.WriteLine("Введiть цiну квидка:");
                    double ticket_price = TO.Is_double(Console.ReadLine());

                    Console.WriteLine("Введiть статус оплати (Paid або Unpaid):");
                    string payment_status = TO.Is_status(Console.ReadLine());

                    Console.WriteLine("\nЯкщо ви бажаєте зберегти змiни то натиснiть Enter, якщо нi, то будь-яку iншу клавiшу.");
                    while (true)
                    {
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                        {
                            tickets.Add(new Ticket_office(ticket_number, the_name_of_the_buyer, the_title_of_the_film, ticket_price, payment_status));

                            using (StreamWriter f = new StreamWriter(TO.AddressFILE, true))
                                f.WriteLine("{0}\t\t\t{1}\t\t\t\t\t{2}\t\t\t{3}\t\t\t\t{4}", ticket_number, the_name_of_the_buyer, the_title_of_the_film, ticket_price, payment_status);
                            Console.WriteLine("Змiни збережено!\n\n");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nЗмiни не збережено!\n\n");
                            break;
                        }
                    }
                }
                else if (cki.Key == ConsoleKey.E)
                {
                    int count = File.ReadAllLines(TO.AddressFILE).Length;
                    Console.WriteLine("\nВведiть порядковий новер запису, де ви хочете здiйснити редагування: ");
                    int n = TO.Is_int32(Console.ReadLine());
                    while (n > count - 1 || n < 1)
                    {
                        Console.WriteLine("Ви ввели некоректний порядковий номер, введiть ще раз: ");
                        n = TO.Is_int32(Console.ReadLine());
                    }

                    Console.WriteLine("Введiть порядковий номер стовпчика, елемент якого хочете виправити: ");
                    int n0 = TO.Is_int32(Console.ReadLine());
                    while (n0 > 5 || n0 < 1)
                    {
                        Console.WriteLine("Ви ввели некоректний порядковий номер, введiть ще раз: ");
                        n0 = TO.Is_int32(Console.ReadLine());
                    }

                    if (n0 == 1)
                    {
                        Console.WriteLine("Номер квидка (8 цифр):");
                        tickets[n - 1].ticket_number = TO.Is_int32(Console.ReadLine());
                    }
                    else if (n0 == 2)
                    {
                        Console.WriteLine("Прiзвище покупця:");
                        tickets[n - 1].the_name_of_the_buyer = TO.Is_name_title(Console.ReadLine());
                    }
                    else if (n0 == 3)
                    {
                        Console.WriteLine("Назва фiльму (без пробiлiв, використовуйте _ ):");
                        tickets[n - 1].the_title_of_the_film = TO.Is_name_title(Console.ReadLine());
                    }
                    else if (n0 == 4)
                    {
                        Console.WriteLine("Цiна квидка:");
                        tickets[n - 1].ticket_price = TO.Is_double(Console.ReadLine());
                    }
                    else if (n0 == 5)
                    {
                        Console.WriteLine("Cтатус оплати (Paid або Unpaid):");
                        tickets[n - 1].payment_status = TO.Is_status(Console.ReadLine());
                    }

                    while (true)
                    {
                        Console.WriteLine("Якщо ви бажаєте продовжити редагування, то натиснiть на будь-яку клавiшу, якщо нi, то натиснiть Spacebar.");
                        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                            break;
                        else
                        {
                            Console.WriteLine("\nВведiть порядковий новер запису, де ви хочете здiйснити редагування: ");
                            n = TO.Is_int32(Console.ReadLine());
                            while (n > count - 1 || n < 1)
                            {
                                Console.WriteLine("Ви ввели некоректний порядковий номер, введiть ще раз: ");
                                n = TO.Is_int32(Console.ReadLine());
                            }

                            Console.WriteLine("Введiть порядковий номер стовпчика, елемент якого хочете виправити: ");
                            n0 = TO.Is_int32(Console.ReadLine());
                            while (n0 > 5 || n0 < 1)
                            {
                                Console.WriteLine("Ви ввели некоректний порядковий номер, введiть ще раз: ");
                                n0 = TO.Is_int32(Console.ReadLine());
                            }

                            if (n0 == 1)
                            {
                                Console.WriteLine("Номер квидка (8 цифр):");
                                tickets[n - 1].ticket_number = TO.Is_int32(Console.ReadLine());
                            }
                            else if (n0 == 2)
                            {
                                Console.WriteLine("Прiзвище покупця:");
                                tickets[n - 1].the_name_of_the_buyer = TO.Is_name_title(Console.ReadLine());
                            }
                            else if (n0 == 3)
                            {
                                Console.WriteLine("Назва фiльму (без пробiлiв, використовуйте _ ):");
                                tickets[n - 1].the_title_of_the_film = TO.Is_name_title(Console.ReadLine());
                            }
                            else if (n0 == 4)
                            {
                                Console.WriteLine("Цiна квидка:");
                                tickets[n - 1].ticket_price = TO.Is_double(Console.ReadLine());
                            }
                            else if (n0 == 5)
                            {
                                Console.WriteLine("Cтатус оплати (Paid або Unpaid):");
                                tickets[n - 1].payment_status = TO.Is_status(Console.ReadLine());
                            }
                        }
                    }

                    Console.WriteLine("\nЯкщо ви бажаєте зберегти змiни, то натиснiть Enter, якщо нi, то будь-яку iншу клавiшу.");
                    while (true)
                    {
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                        {
                            using (StreamWriter f = new StreamWriter(TO.AddressFILE))
                            {
                                f.WriteLine(TO.prt01);
                                foreach (var t in tickets)
                                    f.WriteLine("{0}\t\t\t{1}\t\t\t\t\t{2}\t\t\t{3}\t\t\t\t{4}", t.ticket_number, t.the_name_of_the_buyer, t.the_title_of_the_film, t.ticket_price, t.payment_status);
                            }
                            Console.WriteLine("Змiни збережено!\n\n");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nЗмiни не збережено!\n\n");
                            break;
                        }
                    }
                }
                else if (cki.Key == ConsoleKey.R)
                {
                    int count = File.ReadAllLines(TO.AddressFILE).Length;
                    Console.WriteLine("\nВведiть порядковий новер рядка, який ви хочете видалити: ");
                    int n = TO.Is_int32(Console.ReadLine());
                    while (n > count - 1 || n < 1)
                    {
                        Console.WriteLine("Ви ввели некоректний порядковий номер, введiть ще раз: ");
                        n = TO.Is_int32(Console.ReadLine());
                    }

                    Console.WriteLine("\nЯкщо ви бажаєте зберегти змiни, то натиснiть Enter, якщо нi, то будь-яку iншу клавiшу.");
                    while (true)
                    {
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                        {
                            tickets.RemoveAt(n - 1);
                            using (StreamWriter f = new StreamWriter(TO.AddressFILE))
                            {
                                f.WriteLine(TO.prt01);
                                foreach (var t in tickets)
                                    f.WriteLine("{0}\t\t\t{1}\t\t\t\t\t{2}\t\t\t{3}\t\t\t\t{4}", t.ticket_number, t.the_name_of_the_buyer, t.the_title_of_the_film, t.ticket_price, t.payment_status);
                            }
                            Console.WriteLine("Змiни збережено!\n\n");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nЗмiни не збережено!\n\n");
                            break;
                        }
                    }
                }
                else if (cki.Key == ConsoleKey.O)
                {
                    int count = File.ReadAllLines(TO.AddressFILE).Length;
                    Console.WriteLine("\nЯкщо ви бажаєте вивести весь список, то натиснiть Enter, якщо тiльки один рядок, то будь-яку iншу клавiшу.\n");
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine(TO.prt01);
                        foreach (var t in tickets)
                            Console.WriteLine("{0}\t\t\t{1}\t\t\t\t\t{2}\t\t\t{3}\t\t\t\t{4}", t.ticket_number, t.the_name_of_the_buyer, t.the_title_of_the_film, t.ticket_price, t.payment_status);
                    }
                    else
                    {
                        Console.WriteLine("\nВведiть порядковий номер рядка, який ви хочете вивести: ");
                        int n = TO.Is_int32(Console.ReadLine());
                        while (n > count - 1 || n < 1)
                        {
                            Console.WriteLine("Ви ввели некоректний порядковий номер, введiть ще раз: ");
                            n = TO.Is_int32(Console.ReadLine());
                        }
                        Console.WriteLine("\n" + TO.prt01 + "\n{0}\t\t\t{1}\t\t\t\t\t{2}\t\t\t{3}\t\t\t\t{4}", tickets[n - 1].ticket_number, tickets[n - 1].the_name_of_the_buyer, tickets[n - 1].the_title_of_the_film, tickets[n - 1].ticket_price, tickets[n - 1].payment_status);
                    }
                    Console.WriteLine("\n");
                }
                else if (cki.Key == ConsoleKey.Tab)
                {
                    Console.WriteLine("\nНатиснiть на одну з вказаних клавiш, щоб вибрати, за яким параметром сортувати: ");
                    Console.WriteLine("За номером квидка - 1");
                    Console.WriteLine("За прiзвищем покупця - 2");
                    Console.WriteLine("За назвою фiльму - 3");
                    Console.WriteLine("За цiною квидка - 4");
                    Console.WriteLine("За статусом оплати - 5");
                    Console.WriteLine("Вихiд з даного режиму - будь-яка iнша клавiша");

                    ConsoleKeyInfo cki0;
                    cki0 = Console.ReadKey(true);
                    if (cki0.Key == ConsoleKey.NumPad1)
                    {
                        tickets.Sort(new SortByTicket_number());
                        using (StreamWriter f = new StreamWriter(TO.AddressFILE))
                        {
                            Console.WriteLine();
                            Console.WriteLine(TO.prt01);
                            f.WriteLine(TO.prt01);
                            foreach (var t in tickets)
                            {
                                Console.WriteLine("{0}\t\t\t{1}\t\t\t\t\t{2}\t\t\t{3}\t\t\t\t{4}", t.ticket_number, t.the_name_of_the_buyer, t.the_title_of_the_film, t.ticket_price, t.payment_status);
                                f.WriteLine("{0}\t\t\t{1}\t\t\t\t\t{2}\t\t\t{3}\t\t\t\t{4}", t.ticket_number, t.the_name_of_the_buyer, t.the_title_of_the_film, t.ticket_price, t.payment_status);
                            }
                            Console.WriteLine("\nЗмiни збережено!\n\n");
                        }
                    }
                    else if (cki0.Key == ConsoleKey.NumPad2)
                    {
                        tickets.Sort(new SortByThe_name_of_the_buyer());
                        using (StreamWriter f = new StreamWriter(TO.AddressFILE))
                        {
                            Console.WriteLine();
                            Console.WriteLine(TO.prt01);
                            f.WriteLine(TO.prt01);
                            foreach (var t in tickets)
                            {
                                Console.WriteLine("{0}\t\t\t{1}\t\t\t\t\t{2}\t\t\t{3}\t\t\t\t{4}", t.ticket_number, t.the_name_of_the_buyer, t.the_title_of_the_film, t.ticket_price, t.payment_status);
                                f.WriteLine("{0}\t\t\t{1}\t\t\t\t\t{2}\t\t\t{3}\t\t\t\t{4}", t.ticket_number, t.the_name_of_the_buyer, t.the_title_of_the_film, t.ticket_price, t.payment_status);
                            }
                            Console.WriteLine("\nЗмiни збережено!\n\n");
                        }
                    }
                    else if (cki0.Key == ConsoleKey.NumPad3)
                    {
                        tickets.Sort(new SortByThe_title_of_the_film());
                        using (StreamWriter f = new StreamWriter(TO.AddressFILE))
                        {
                            Console.WriteLine();
                            Console.WriteLine(TO.prt01);
                            f.WriteLine(TO.prt01);
                            foreach (var t in tickets)
                            {
                                Console.WriteLine("{0}\t\t\t{1}\t\t\t\t\t{2}\t\t\t{3}\t\t\t\t{4}", t.ticket_number, t.the_name_of_the_buyer, t.the_title_of_the_film, t.ticket_price, t.payment_status);
                                f.WriteLine("{0}\t\t\t{1}\t\t\t\t\t{2}\t\t\t{3}\t\t\t\t{4}", t.ticket_number, t.the_name_of_the_buyer, t.the_title_of_the_film, t.ticket_price, t.payment_status);
                            }
                            Console.WriteLine("\nЗмiни збережено!\n\n");
                        }
                    }
                    else if (cki0.Key == ConsoleKey.NumPad4)
                    {
                        tickets.Sort(new SortByTicket_price());
                        using (StreamWriter f = new StreamWriter(TO.AddressFILE))
                        {
                            Console.WriteLine();
                            Console.WriteLine(TO.prt01);
                            f.WriteLine(TO.prt01);
                            foreach (var t in tickets)
                            {
                                Console.WriteLine("{0}\t\t\t{1}\t\t\t\t\t{2}\t\t\t{3}\t\t\t\t{4}", t.ticket_number, t.the_name_of_the_buyer, t.the_title_of_the_film, t.ticket_price, t.payment_status);
                                f.WriteLine("{0}\t\t\t{1}\t\t\t\t\t{2}\t\t\t{3}\t\t\t\t{4}", t.ticket_number, t.the_name_of_the_buyer, t.the_title_of_the_film, t.ticket_price, t.payment_status);
                            }
                            Console.WriteLine("\nЗмiни збережено!\n\n");
                        }
                    }
                    else if (cki0.Key == ConsoleKey.NumPad5)
                    {
                        tickets.Sort(new SortByPayment_status());
                        using (StreamWriter f = new StreamWriter(TO.AddressFILE))
                        {
                            Console.WriteLine();
                            Console.WriteLine(TO.prt01);
                            f.WriteLine(TO.prt01);
                            foreach (var t in tickets)
                            {
                                Console.WriteLine("{0}\t\t\t{1}\t\t\t\t\t{2}\t\t\t{3}\t\t\t\t{4}", t.ticket_number, t.the_name_of_the_buyer, t.the_title_of_the_film, t.ticket_price, t.payment_status);
                                f.WriteLine("{0}\t\t\t{1}\t\t\t\t\t{2}\t\t\t{3}\t\t\t\t{4}", t.ticket_number, t.the_name_of_the_buyer, t.the_title_of_the_film, t.ticket_price, t.payment_status);
                            }
                            Console.WriteLine("\nЗмiни збережено!\n\n");
                        }
                    }
                    else
                        Console.WriteLine();
                }
                else
                    break;
            }
        }
    }
}
