using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LinqN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string СтрокаXML =
@"<?xml version=""1.0""?>
<ТаблицаТелефонов>
<Строка>
<Имена>Витя</Имена>
<Номера_телефонов>274 28 44</Номера_телефонов>
</Строка>
<Строка>
<Имена>Андрей</Имена>
<Номера_телефонов>8-085-456-2378</Номера_телефонов>
</Строка>
<Строка>
<Имена>Карапузова Таня</Имена>
<Номера_телефонов>445-56-47</Номера_телефонов>
</Строка>
<Строка>
<Имена>Витя</Имена>
<Номера_телефонов>099 72 161 52</Номера_телефонов>
</Строка>
<Строка>
<Имена>Никипелов</Имена>
<Номера_телефонов>236-77-76</Номера_телефонов>
</Строка>
<Строка>
<Имена>Зиборов</Имена>
<Номера_телефонов>254 67 97</Номера_телефонов>
</Строка>
</ТаблицаТелефонов>";
            var КорневойЭлемент =
            System.Xml.Linq.XElement.Parse(СтрокаXML);
            // Запись строки, содержащей XML в файл:
            // System.IO.File.WriteAllText("ТаблицаТелефонов.xml", СтрокаXML);
            // var КорневойЭлемент = System.Xml.Linq.
            // XElement.Load("ТаблицаТелефонов.xml");
            var Записи =
            from x in КорневойЭлемент.Elements("Строка")
            where (string)x.Element("Имена") == "Витя"
            select x.Element("Номера_телефонов").Value;
            richTextBox1.Text += @"Строки, содержащие имя ""Витя"":" + "\r\n";
            // Вывод коллекции записей в текстовое поле textBox1:
            foreach (var x in Записи)
                richTextBox1.Text += x + "\r\n";

            //1
            var tab1 = XElement.Load(@"..\..\..\..\lab6-3.XML");
            var Maria =
            from x in tab1.Elements("Строка")
            where (string)x.Element("Имя") == "Мария"
            select new
            {
                Surname = x.Element("Фамилия").Value,
                Name = x.Element("Имя").Value,
                Patr = x.Element("Отчество").Value,
                DateBorn = x.Element("Дата_рождения").Value,
                Obr = x.Element("Образов").Value,
                DataZach = x.Element("Дата_зачисления").Value,
                Dol = x.Element("Должность").Value,
                Spec = x.Element("Специальность").Value,
            };
            foreach (var z in Maria)
                richTextBox2.Text += "Кто: " + z.Surname + " " + z.Name + " " + z.Patr + "\nРождение: "
                    + z.DateBorn + "\nОбразование: " + z.Obr + "\nЗачисление:  " + z.DataZach + "\nДолжность:  " + z.Dol + "\nСпециальность: " + z.Spec;

            //2

            var tab2 = XElement.Load(@"..\..\..\..\lab6-1.XML");
            var Stud =
            from x in tab2.Elements("Строка")
            where (string)x.Attribute("ФИО") == "Щербаков Захар Михайлович"
            select new
            {
                FIO = x.Attribute("ФИО").Value,
                Alg = x.Element("Алгоритмы").Value,
                Mat = x.Element("Матан").Value,
                SRPO = x.Element("СРПО").Value,
                Kyr = x.Element("Курсач").Value,
                Dip = x.Element("Диплом").Value,
            };
            foreach (var z in Stud)
                richTextBox3.Text += z.FIO + "\nАлгоримы: " + z.Alg + "\nМатан: " + z.Mat + "\nСРПО: " + z.SRPO + "\nКурсач: " + z.Kyr + "\nДиплом: " + z.Dip;

            //3
            var Kontr =
            from x in tab1.Elements("Строка")
            where (string)x.Element("Должность") == "контролер"
            select new
            {
                F = x.Element("Фамилия").Value,
                N = x.Element("Имя").Value,
                P = x.Element("Отчество").Value,
            };
            richTextBox4.Text += "Контролеры:";
            foreach (var x in Kontr)
                richTextBox4.Text += "\n" + x.F + " " + x.N + " " + x.P ;

            //4

            var DolSpec =
            from x in tab1.Elements("Строка")
            where (string)x.Element("Должность") == (string)x.Element("Специальность")
            select new
            {
                FIO = x.Element("Фамилия").Value + " " + x.Element("Имя").Value + " " + x.Element("Отчество").Value,
                dol = x.Element("Должность").Value,
                spec = x.Element("Специальность").Value
            };
            richTextBox5.Text += "Должность = специальность:\n";
            foreach (var x in DolSpec)
                richTextBox5.Text += x.FIO + "\nДолжность: " + x.dol + "\nСпециальность: " + x.spec + "\n";
        }
    }
}
