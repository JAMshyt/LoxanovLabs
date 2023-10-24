using System;
using System.Xml.Linq;


namespace lab6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Таблица";
            XDocument Документ = new XDocument(
                new XElement("Таблица",
                    new XElement("Строка",
                        new XAttribute("N_ПП", "72"),
                        new XElement("Фамилия", "Уласевич"),
                        new XElement("Имя", "Мария"),
                        new XElement("Отчество", "Ивановна"),
                        new XElement("Дата_рождения", "05.01.1955"),
                        new XElement("Образов", "среднее спец"),
                        new XElement("Дата_зачисления", "01.08.1973"),
                        new XElement("Должность", "бухгалтер"),
                        new XElement("Специальность", "бухгалтер")
                        ),
                    new XElement("Строка",
                        new XAttribute("N_ПП", "73"),
                        new XElement("Фамилия", "Юркевич"),
                        new XElement("Имя", "Любовь"),
                        new XElement("Отчество", "Васильевна"),
                        new XElement("Дата_рождения", "14.07.1957"),
                        new XElement("Образов", "среднее спец"),
                        new XElement("Дата_зачисления", "25.06.1984"),
                        new XElement("Должность", "контролер"),
                        new XElement("Специальность", "гидротехник")
                        ),
                    new XElement("Строка",
                        new XAttribute("N_ПП", "11"),
                        new XElement("Фамилия", "Будыкина"),
                        new XElement("Имя", "Галина"),
                        new XElement("Отчество", "Константиновна"),
                        new XElement("Дата_рождения", "12.05.1961"),
                        new XElement("Образов", "среднее спец"),
                        new XElement("Дата_зачисления", "28.04.1990"),
                        new XElement("Должность", "контролер"),
                        new XElement("Специальность", "техник-электрик")
                        ),
                    new XElement("Строка",
                        new XAttribute("N_ПП", "13"),
                        new XElement("Фамилия", "Вакарев"),
                        new XElement("Имя", "Вячеслав"),
                        new XElement("Отчество", "Васильевич"),
                        new XElement("Дата_рождения", "23.03.1941"),
                        new XElement("Образов", "среднее спец"),
                        new XElement("Дата_зачисления", "16.02.1992"),
                        new XElement("Должность", "старший контролер"),
                        new XElement("Специальность", "техник радиосвязи")
                        ),
                    new XElement("Строка",
                        new XAttribute("N_ПП", "64"),
                        new XElement("Фамилия", "Трусов"),
                        new XElement("Имя", "Игорь"),
                        new XElement("Отчество", "Евгеньевич"),
                        new XElement("Дата_рождения", "12.08.1948"),
                        new XElement("Образов", "среднее спец"),
                        new XElement("Дата_зачисления", "28.06.1996"),
                        new XElement("Должность", "контролер"),
                        new XElement("Специальность", "техник электрик")
                        ),
                    new XElement("Строка",
                        new XAttribute("N_ПП", "18"),
                        new XElement("Фамилия", "Гринько "),
                        new XElement("Имя", "Наталья"),
                        new XElement("Отчество", "Никитична"),
                        new XElement("Дата_рождения", "01.01.1960"),
                        new XElement("Образов", "среднее спец"),
                        new XElement("Дата_зачисления", "24.04.1998"),
                        new XElement("Должность", "контролер"),
                        new XElement("Специальность", "техник-плановик")
                        ),
                    new XElement("Строка",
                        new XAttribute("N_ПП", "5"),
                        new XElement("Фамилия", "Бибко "),
                        new XElement("Имя", "Владимир"),
                        new XElement("Отчество", "Михайлович"),
                        new XElement("Дата_рождения", "01.01.1960"),
                        new XElement("Образов", "среднее спец"),
                        new XElement("Дата_зачисления", "24.04.1998"),
                        new XElement("Должность", "техгик"),
                        new XElement("Специальность", "техник-строитель")
                        ),
                    new XElement("Строка",
                        new XAttribute("N_ПП", "10"),
                        new XElement("Фамилия", "Бородко "),
                        new XElement("Имя", "Татьяна"),
                        new XElement("Отчество", "Николаевна"),
                        new XElement("Дата_рождения", "01.01.1960"),
                        new XElement("Образов", "среднее спец"),
                        new XElement("Дата_зачисления", "24.04.1998"),
                        new XElement("Должность", "контролер"),
                        new XElement("Специальность", "инжинер-экономитс")
                        )
                )
                );
            Документ.Save(@"..\..\..\..\lab6-3.XML");
            Console.WriteLine(Документ);
            Console.ReadKey();
        }
    }
}
