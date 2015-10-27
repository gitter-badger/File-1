using System;


namespace ConsoleApplication2
{
    internal class Program
    {
        private static void Main()
        {
            int i;
            do
            {
                Console.Write(
                    "Меню:\n1) Просмотр файлов  \n2) Копировать \n3) заменить \n4) удалить \n5) Открыть \n6) Выйти из программы\n\nВаше решение: ");
                // ReSharper disable once AssignNullToNotNullAttribute
                i = int.Parse(Console.ReadLine());
                ArchiveFile aZip = new ArchiveFile();
                Files fl = new Files();
                switch (i)
                {
                    case 1:
                     break;
                    case 2:
                      break;
                    case 3:
                       break;
                    case 4:
                       break;
                    case 5:
                      aZip.Open();
                       
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Вы что-то другое нажали...");
                        break;
                }
                Console.Write("\n\n\t\t\tНажмите любую клавишу...");
                Console.ReadLine();
                Console.Clear();
            } while (i != 6);
        }
    }
}
