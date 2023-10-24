using System;
using System.Xml.Linq;


namespace Лаба6Задание1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "XML";
            XDocument Документ = new XDocument(
                new XElement("Успеваемость_студентов",
                    new XElement("Строка",
                        new XAttribute("ФИО", "Щербаков Захар Михайлович"),
                        new XElement("Алгоритмы",4),
                        new XElement("Матан", 4),
                        new XElement("СРПО", 4),
                        new XElement("Курсач", 4),
                        new XElement("Диплом", 4)
                        ),
                    new XElement("Строка",
                        new XAttribute("ФИО", "Новожилов Илья Александрович"),
                        new XElement("Алгоритмы", 5),
                        new XElement("Матан", 5),
                        new XElement("СРПО", 5),
                        new XElement("Курсач", 5),
                        new XElement("Диплом", 5)
                        ),
                    new XElement("Строка",
                        new XAttribute("ФИО", "Тимченко Елисей Андреевич"),
                        new XElement("Алгоритмы", 3),
                        new XElement("Матан", 3),
                        new XElement("СРПО", 3),
                        new XElement("Курсач", 3),
                        new XElement("Диплом", 3)
                        ),
                    new XElement("Строка",
                        new XAttribute("ФИО", "Лапицкий Семён Сергеевич"),
                        new XElement("Алгоритмы", 3),
                        new XElement("Матан", 3),
                        new XElement("СРПО", 3),
                        new XElement("Курсач", 4),
                        new XElement("Диплом", 4)
                        ),
                    new XElement("Строка",
                        new XAttribute("ФИО", "Гниенко Камень Половодьевич"),
                        new XElement("Алгоритмы", 1),
                        new XElement("Матан", 2),
                        new XElement("СРПО", 3),
                        new XElement("Курсач", 4),
                        new XElement("Диплом", 5)
                        )
                )
                );
            Документ.Save(@"..\..\lab6-1.XML");
            Console.WriteLine(Документ);
            Console.ReadKey();
        }
    }
}
