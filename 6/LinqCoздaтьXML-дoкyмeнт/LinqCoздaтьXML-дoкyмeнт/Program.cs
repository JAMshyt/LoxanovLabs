using System;
using System.Xml.Linq;

namespace LinqСоздатьXML_документ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Корневой элемент XML-документа";
            // Создаем новый XML-документ:
            XDocument XMLдокумент = new XDocument(
            // Комментарий в XML-документе:
            new XComment("Телефонная_книга - это корневой элемент XMLдокумента:"),
            new XElement("Телефонная_книга",
            new XComment("Элемент СТРОКА содержит атрибут Контакт и два вложенных элемента"),
            new XElement("СТРОКА", 
            new XAttribute("Контакт", "Олег"),
            new XElement("Домашний_телефон", "236-23-67"), 
            new XElement("Мобильный_телефон", "+7(495)625-31-43")),
            new XComment("Атрибут Контакт имеет значение 'Прогноз погоды':"),
            new XElement("СТРОКА",
            new XAttribute("Контакт", "Прогноз погоды"), // - атрибут элемента
            new XElement("Домашний_телефон", "001"),
            new XElement("Мобильный_телефон", "")), // - имя элемента и его
            new XComment("Поскольку каждый элемент Контакт имеет атрибут и два вложенных => "),
            new XElement("СТРОКА",
            new XAttribute("Контакт", "Борис Григорьевич"), // - имя атрибута -
            new XElement("Домашний_телефон", "402-12-45"),
            new XElement("Мобильный_телефон", "+7(495)536-79-94")),
            new XComment("=> элемента, в MS Excel отобразится таблица с тремя колонками"),
            new XElement("СТРОКА",
            new XAttribute("Контакт", "Света"), // - значение атрибута - Света
            new XElement("Домашний_телефон", ""),
            new XElement("Мобильный_телефон", "+7(495)615-24-41")))
            );
            // Сохранить XML-документ:
            XMLдокумент.Save(@"..\..\lab6.XML");
            Console.WriteLine(XMLдокумент);
            Console.ReadKey();
        }
    }
}
