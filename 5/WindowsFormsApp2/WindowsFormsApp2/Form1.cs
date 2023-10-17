using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public class Sotr
        {
            public string FIO { get; set; }
            public string Job { get; set; }
            public int Oklad { get; set; }
        }

        public class Styd
        {
            public string FIO { get; set; }
            public int Group { get; set; }
            public double Ball { get; set; }
        }

        public class Client
        {
            public string FIO { get; set; }
            public string Status { get; set; }
            public int Age { get; set; }
        }

        public class bankClient
        {
            public string FIO { get; set; }
            public List<int> Ostatok;
        }

        public class Groups
        {
            public string Title { get; set; }
            public List<string> Surname;
        }

        public class Cotryd
        {
            public string FIO { get; set; }
            public int plata { get; set; }
        }

        public class skladu
        {
            public string Sklad { get; set; }
            public List<string> Tovar { get; set; }
            public List<int> Price { get; set; }

        }
        public Form1()
        {
            InitializeComponent();
            int[] numArr = new int[] { -7, 2, 7, 3, 4, 10, -5, 6, 7, -9, 2 };
            string[] strArr = new string[] { "Новожилов", "Щербаков", "Ян", "Гит", "Лер", "Адольфовна" };
            richTextBox1.Text += "Массив чисел\n";
            foreach (var x in numArr) richTextBox1.Text += x + " ";

            richTextBox1.Text += "\n___________________\n";

            richTextBox1.Text += "Массив фамилий\n";
            foreach (var x in strArr) richTextBox1.Text += x + " ";

            richTextBox1.Text += "\n___________________\n";

            richTextBox1.Text += "Числа >5 и <10\n";
            foreach (var x in numArr.Where(x => x > 5 & x < 10)) richTextBox1.Text += x + " ";

            richTextBox1.Text += "\n____________________\n";

            richTextBox1.Text += "Сумма элементов >5\n";
            richTextBox1.Text += numArr.Where(x => x > 5).Sum();

            richTextBox1.Text += "\n____________________\n";

            richTextBox1.Text += "Количество фамилий длиньше 4\n";
            richTextBox1.Text += strArr.Where(x => x.Length > 4).Count();

            richTextBox1.Text += "\n____________________\n";

            richTextBox1.Text += "Четные элементы\n";
            foreach (var x in numArr.Where(x => x % 2 == 0)) richTextBox1.Text += x + " ";

            richTextBox1.Text += "\n____________________\n";

            richTextBox1.Text += "Среднее арифметическое нечетных\n";
            richTextBox1.Text += Math.Round(numArr.Where(x => x % 2 != 0).Average(), 2) + " ";

            //5.2

            List<Sotr> kadr = new List<Sotr>
            {
                new Sotr{ FIO="Щербаков Захар Михайлович",Job="Главный главный директор",Oklad = 99999},
                new Sotr{ FIO="Новожилов Илья Александрович",Job="Оператор ЭВМ",Oklad = 18},
                new Sotr{ FIO="Фамилович Имя Отчествович",Job="Юрист",Oklad = 15000},
                new Sotr{ FIO="Добренко Иван Иванович",Job="Лентяй",Oklad = 9000},
                new Sotr{ FIO="Глыба Сергей Петрович",Job="Смотритель телевизора",Oklad = 3000},
                new Sotr{ FIO="Zn2Fe(PO4)2•4H2O",Job="Камень",Oklad = 12},
                new Sotr{ FIO="Этилович Напиток Спиртов",Job="Алкоголь",Oklad = 2000},
                new Sotr{ FIO="Острые Пузырьки",Job="Пикиблиндерс",Oklad = 20000},
                new Sotr{ FIO="Мой Друг",Job="Парковка",Oklad = 50000},
                new Sotr{ FIO="Серёга",Job="дота плеер",Oklad = 10000}
            };

            List<Styd> stud = new List<Styd>
            {
                new Styd{ FIO="Щербаков Захар Михайлович",Group=31,Ball = 4.6},
                new Styd{ FIO="Новожилов Илья Александрович",Group=30,Ball = 5.0},
                new Styd{ FIO="Фамилович Имя Отчествович",Group=31,Ball = 5.0},
                new Styd{ FIO="Добренко Иван Иванович",Group = 31,Ball = 3.5},
                new Styd{ FIO="Глыба Сергей Петрович",Group = 31, Ball = 3.5},
                new Styd{ FIO="Zn2Fe(PO4)2•4H2O",Group = 30, Ball = 3.5},
                new Styd{ FIO="Этилович Напиток Спиртов",Group = 30, Ball = 4.5},
                new Styd{ FIO="Острые Пузырьки",Group = 31, Ball = 4.5},
                new Styd{ FIO="Мой Друг",Group = 30, Ball = 3.5},
                new Styd{ FIO="Серёга",Group = 30, Ball = 5.5}
            };

            List<Client> client = new List<Client>
            {
                new Client{ FIO="Щербаков Захар Михайлович",Status="VIP",Age = 19},
                new Client{ FIO="Новожилов Илья Александрович",Status="VIP",Age = 21},
                new Client{ FIO="Фамилович Имя Отчествович",Status="VIP",Age = 29},
                new Client{ FIO="Добренко Иван Иванович",Status="VIP",Age = 10},
                new Client{ FIO="Глыба Сергей Петрович",Status="неVIP",Age = 21},
                new Client{ FIO="Zn2Fe(PO4)2•4H2O",Status="неVIP",Age = 29},
                new Client{ FIO="Этилович Напиток Спиртов",Status="неVIP",Age = 19},
                new Client{ FIO="Острые Пузырьки",Status = "неVIP", Age = 19},
                new Client{ FIO="Мой Друг",Status = "неVIP", Age = 19},
                new Client{ FIO="Серёга",Status = "VIP", Age = 25}
            };

            List<bankClient> bank = new List<bankClient>
            {
                new bankClient{ FIO="Щербаков Захар Михайлович", Ostatok= new List<int>{11000,12000,800 } },
                new bankClient{ FIO="Новожилов Илья Александрович",Ostatok=new List<int>{800,200,11000 } },
                new bankClient{ FIO="Фамилович Имя Отчествович",Ostatok=new List<int>{11000}},
                new bankClient{ FIO="Добренко Иван Иванович", Ostatok = new List < int > { 200 }},
                new bankClient{ FIO="Глыба Сергей Петрович", Ostatok = new List < int > { 11000, 2000 }},
                new bankClient{ FIO="Zn2Fe(PO4)2•4H2O", Ostatok = new List < int > { 100, 12000 }},
                new bankClient{ FIO="Этилович Напиток Спиртов", Ostatok = new List < int > { 11 }},
                new bankClient{ FIO="Острые Пузырьки", Ostatok = new List < int > { 11000 }},
                new bankClient{ FIO="Мой Друг", Ostatok = new List < int > { 11000 }},
                new bankClient{ FIO="Серёга", Ostatok = new List < int > { 11000 }}
            };

            List<Groups> groupt = new List<Groups>
            {
                new Groups{Title = "ПКсп-120", Surname = new List < String > { "Щербаков", "Новожилов", "Дебик"}},
                new Groups{Title = "ПКспк-120", Surname = new List < String > { "Жариков", "Жаров", "Дубосёл"}},
                new Groups{Title = "ИСп-120", Surname = new List < String > { "Баранов", "Новосёлов", "Лист" }},
                new Groups{Title = "ПК0", Surname = new List < String > { "Камень2", "123", "123" }},
                new Groups{Title = "ПКсп-111120", Surname = new List < String > { "Шестистрочный", "Двусмысленный", "ПростоДебик" }},
            };

            

            richTextBox2.Text += "Оклад >10.000\n\n";
            foreach (var x in kadr.Where(x => x.Oklad > 10000)) richTextBox2.Text += x.FIO + " " + x.Oklad + "\n";

            richTextBox2.Text += "____________________\n";

            richTextBox2.Text += "группа 31 и средний балл >4.5\n\n";
            foreach (var x in stud.Where(x => x.Group == 31 & x.Ball > 4.5)) richTextBox2.Text += x.FIO + " | " + x.Group + " | " + x.Ball + "\n";

            richTextBox2.Text += "____________________\n";

            richTextBox2.Text += "VIP страше 20 моложе 30 лет\n\n";
            foreach (var x in client.Where(x => x.Status == "VIP" & x.Age > 20 & x.Age < 30)) richTextBox2.Text += x.FIO + " | " + x.Status + " | " + x.Age + "\n";

            richTextBox2.Text += "\nКлиенты с счетами меньше 1000\n\n";
            var low = from name in bank
                      from ost in name.Ostatok
                      where ost < 1000
                      select new { name.FIO, ost };
            foreach (var z in low) richTextBox2.Text += z.FIO + " имеет " + z.ost + "\n";

            richTextBox2.Text += "____________________\n";

            richTextBox2.Text += "Фамилии длиньше 6\n\n";
            var log = from name in groupt
                      from ost in name.Surname
                      where ost.Length > 6
                      select new { name.Title, ost };
            foreach (var z in log) richTextBox2.Text += z.Title + " студент " + z.ost + "\n";

            //5.3

            List<Cotryd> cotr = new List<Cotryd>
            {
                new Cotryd{ FIO="Щербаков Захар Михайлович",plata = 20000},
                new Cotryd{ FIO="Новожилов Илья Александрович",plata = 15000},
                new Cotryd{ FIO="Фамилович Имя Отчествович",plata = 200},
                new Cotryd{ FIO="Добренко Иван Иванович",plata = 200},
                new Cotryd{ FIO="Глыба Сергей Петрович",plata = 20000},
                new Cotryd{ FIO="Zn2Fe(PO4)2•4H2O",plata = 20000},
                new Cotryd{ FIO="Этилович Напиток Спиртов",plata = 2000},
                new Cotryd{ FIO="Острые Пузырьки",plata = 800},
                new Cotryd{ FIO="Мой Друг",plata = 30000},
                new Cotryd{ FIO="Серёга",plata = 40000}
            };

            List<skladu> sklads = new List<skladu>
            {
                new skladu{ Sklad = "Древесный",Tovar=new List<string>{ "Хвоя","Береста","Стружка","Древесный уголь"},Price=new List<int>{ 1000,500,100,800} },
                new skladu{  Sklad = "Грунторвый",Tovar=new List<string>{ "Фосфофиллит","Кинноварь","Борт","Рутил","Падпараджа","Призрачный кварц","Антаркцицид"},Price=new List<int>{ 32,30,100,90,60,100,10}},
                new skladu{Sklad = "Шахтёрный", Tovar = new List < string > { "Уголь", "Соль", "Нефть", "Камень","Пила-струна" }, Price = new List < int > { 1200, 200, 1500, 10,9999 }},
            };

            richTextBox3.Text += "Оплата < 10.000\n\n";
            foreach (var x in cotr.Where(x => x.plata < 10000)) richTextBox3.Text += x.FIO + " " + x.plata + "\n";

            richTextBox3.Text += "____________________\n";
            richTextBox3.Text += "Товары складов и их макс цены\n";

            var skladu = from poop in sklads
                         group poop by new
                         {
                             sk1 = poop.Sklad == "Древесный",
                             sk2 = poop.Sklad == "Грунторвый",
                             sk3 = poop.Sklad == "Шахтёрный"
                         } into g
                         select g;

            var inWoods = from a in sklads
                          from t in a.Tovar
                          group a by a.Sklad == "Древесный" into g
                          select new
                          {
                              Max = g.Max(x => x.Price.Max())
                          };

            var inGrynt = from a in sklads
                          from t in a.Tovar
                          group a by a.Sklad == "Грунторвый" into g
                          select new
                          {
                              Max = g.Max(x => x.Price.Max())
                          };

            var inCave = from a in sklads
                          from t in a.Tovar
                          group a by a.Sklad == "Шахтёрный" into g
                          select new
                          {
                              Max = g.Max(x => x.Price.Max())
                          };

            foreach (var z in skladu)
            {
                if (z.Key.sk1)
                {
                    richTextBox3.Text += "Древесный (макс цена: "+ inWoods.ElementAt(0).Max + "):\n";
                    foreach(var x in z)
                    {
                        int i = 0;
                        foreach (var c in x.Tovar)
                        {
                            richTextBox3.Text += "\t"+c + " " + x.Price[i] + "\n";
                            i++;
                        }
                    }
                }

                if (z.Key.sk2)
                {
                    richTextBox3.Text += "Грунторвый (макс цена: " + inGrynt.ElementAt(1).Max + "):\n";
                    foreach (var x in z)
                    {
                        int i = 0;
                        foreach (var c in x.Tovar)
                        {
                            richTextBox3.Text += "\t" + c + " " + x.Price[i] + "\n";
                            i++;
                        }
                    }
                }

                if (z.Key.sk3)
                {
                    richTextBox3.Text += "Шахтёрный (макс цена: " + inCave.ElementAt(1).Max + "):\n";
                    foreach (var x in z)
                    {
                        int i = 0;
                        foreach (var c in x.Tovar)
                        {
                            richTextBox3.Text += "\t" + c + " " + x.Price[i] + "\n";
                            i++;
                        }
                    }
                }
            }

        }
    }
}
