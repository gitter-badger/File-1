using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ConsoleApplication2
{
    class Files: Node
    {
       public IEnumerable<int> _information()
        {
            //Проверка диска на доступность
          var d = new DriveInfo(Path);
              if (!d.IsReady) yield break;
              // Отображение всех файлов по пути
              var path = Directory.GetFiles(Path);
              for (var i = 0; i < 1; i++)
              {
                  foreach (var s in path)
                  {
                      var inform = new FileInfo(s);
                      Name = inform.Name;
                      Path = inform.DirectoryName;
                      Size = inform.Length;
                      DateOfCreation = File.GetCreationTime(s);
                      DateOfChange = File.GetLastAccessTimeUtc(s);
                      DateOfLastAccess = File.GetLastAccessTime(s);
                      yield return i;
                  }
              }
        }
        public override void Copy(Node nodeElement)
        {
            var fileInf = new FileInfo(Path);
            if (!fileInf.Exists) return;
            // чтение из файла
            using (var fstream = File.OpenRead(Path))
            {
                // преобразуем строку в байты
                var array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                fileInf.CopyTo(NewPath, true);
            }
        }
        public override void Write(byte[] batesArr)
        {
            using (var fstream = new FileStream(Path, FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                var array = System.Text.Encoding.Default.GetBytes(Path);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);

            }
        }
        public override void Replace(string inDirectory)
        {
            var fileInf = new FileInfo(Path);
            if (!fileInf.Exists) return; // чтение из файла
            using (var fstream = File.OpenRead(Path))
            {
                // преобразуем строку в байты
                var array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                fileInf.MoveTo(inDirectory);
            }
        }
        public override void Remove()
        {
            if (!File.Exists(Path)) return;
            File.Delete(Path);
        }
        public override void Open()
        {
            //Проверка на существование файла
            if (!File.Exists(Path)) return;
            //Открываем файл внешней программой
            var p1 = new Process { StartInfo = { FileName = Path } };
            p1.Start(); 
        }

       }
}
