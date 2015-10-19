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
                switch (i)
                {
                    case 1:
                      Console.WriteLine("Введите путь к архиву");
                        aZip.Path = Console.ReadLine();
                        // ReSharper disable once UnusedVariable
                        foreach (var i1 in aZip._archive())
                        {
                            Console.WriteLine(aZip.Name); 
                            Console.WriteLine(aZip.Size);
                           Console.WriteLine(aZip.DateOfChange);
                            Console.WriteLine("_________________");
                        }
                      
                        break;
                    case 2:
                        Console.WriteLine("Введите путь к архиву");
                        aZip.Path = Console.ReadLine();
                        Console.WriteLine("Введите путь к файлу");
                        aZip.NewPath = Console.ReadLine();
                       // aZip.Copy();
                        // ReSharper disable once UnusedVariable
                        foreach (var i1 in aZip._archive())
                        {
                            Console.WriteLine(aZip.Name);
                            Console.WriteLine(aZip.Size);
                            Console.WriteLine(aZip.DateOfChange);
                            Console.WriteLine("_________________");
                        }
                      
                        break;
                    case 3:
                        Console.WriteLine("Введите путь к архиву");
                        aZip.Path = Console.ReadLine();
                        Console.WriteLine("Введите путь к файлу");
                        aZip.Replace(Console.ReadLine());
                        // ReSharper disable once UnusedVariable
                        foreach (var i1 in aZip._archive())
                        {
                            Console.WriteLine(aZip.Name);
                            Console.WriteLine(aZip.Size);
                            Console.WriteLine(aZip.DateOfChange);
                            Console.WriteLine("_________________");
                        }
                      
                        break;
                    case 4:
                        Console.WriteLine("Введите путь к архиву");
                        aZip.Path = Console.ReadLine();
                        Console.WriteLine("Введите имя файла");
                        aZip.NewPath = (Console.ReadLine());
                        aZip.Remove();
                        break;
                    case 5:
                        Console.WriteLine("Введите путь к архиву");
                        aZip.Path = Console.ReadLine();
                        Console.WriteLine("Введите имя файла");
                        aZip.NewPath = (Console.ReadLine());
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
