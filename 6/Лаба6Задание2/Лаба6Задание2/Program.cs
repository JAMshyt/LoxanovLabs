using System;
using System.Xml.Linq;


namespace Лаба6Задание2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "XML";
            XDocument Документ = new XDocument(
                new XElement("Доходовые_сведенья",
                    new XElement("Строка",
                        new XAttribute("Источник", "Продажи камней"),
                        new XElement("Январь", 100),
                        new XElement("Февраль", 200),
                        new XElement("Март", 150),
                        new XElement("Апрель", 125),
                        new XElement("Май", 110),
                        new XElement("Июнь", 90),
                        new XElement("Июль", 80),
                        new XElement("Август", 80),
                        new XElement("Сентябрь", 40),
                        new XElement("Октябрь", 40),
                        new XElement("Ноябрь", 80),
                        new XElement("Декабрь", 100)
                        ),
                    new XElement("Строка",
                        new XAttribute("Источник", "Продажи пожарных гидрантов"),
                        new XElement("Ян варь", 20000),
                        new XElement("Февраль", 30000),
                        new XElement("Март", 34000),
                        new XElement("Апрель", 40000),
                        new XElement("Май", 20000),
                        new XElement("Июнь", 25000),
                        new XElement("Июль", 27000),
                        new XElement("Август", 32000),
                        new XElement("Сентябрь", 40000),
                        new XElement("Октябрь", 37000),
                        new XElement("Ноябрь", 35000),
                        new XElement("Декабрь", 32000)
                        ),
                    new XElement("Строка",
                        new XAttribute("Источник", "Поставки оружия"),
                        new XElement("Январь", 100000),
                        new XElement("Февраль", 100000),
                        new XElement("Март", 125000),
                        new XElement("Апрель", 150000),
                        new XElement("Май", 175000),
                        new XElement("Июнь", 190000),
                        new XElement("Июль", 230000),
                        new XElement("Август", 270000),
                        new XElement("Сентябрь", 300000),
                        new XElement("Октябрь", 222000),
                        new XElement("Ноябрь", 170000),
                        new XElement("Декабрь", 90000)
                        ),
                    new XElement("Строка",
                        new XAttribute("Источник", "Толкания пыли"),
                        new XElement("Январь", 1000000),
                        new XElement("Февраль", 900000),
                        new XElement("Март", 980000),
                        new XElement("Апрель", 960000),
                        new XElement("Май", 920000),
                        new XElement("Июнь", 1200000),
                        new XElement("Июль", 1150000),
                        new XElement("Август", 1050000),
                        new XElement("Сентябрь", 900000),
                        new XElement("Октябрь", 930000),
                        new XElement("Ноябрь", 920000),
                        new XElement("Декабрь", 950000)
                        ),
                    new XElement("Строка",
                        new XAttribute("Источник", "Доходы с рекламы"),
                        new XElement("Январь", 18),
                        new XElement("Февраль", 15),
                        new XElement("Март", 20),
                        new XElement("Апрель", 40),
                        new XElement("Май", 44),
                        new XElement("Июнь", 42),
                        new XElement("Июль", 48),
                        new XElement("Август", 44),
                        new XElement("Сентябрь", 46),
                        new XElement("Октябрь", 42),
                        new XElement("Ноябрь", 48),
                        new XElement("Декабрь", 42)
                        )
                )
                );
            Документ.Save(@"..\..\lab6-2.XML");
            Console.WriteLine(Документ);
            Console.ReadKey();
        }
    }
}
