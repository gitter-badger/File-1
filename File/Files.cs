using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;


namespace ConsoleApplication2
{
    class Files: UltimateFilesHurricaneManagerClassLibrary.Node
    {
        public string Per;
        public IEnumerable<int> _information()
        {
            // Отображение всех файлов по пути
            var path = Directory.GetFiles(Per);
            for (var i = 0; i < 10; i++ )
            {

                yield return i;
            }
            foreach (var i in path)
            {
                var inform = new FileInfo(i);
                Name = inform.Name;
                Path = inform.DirectoryName;
                Size = inform.Length;
                DateOfCreation = File.GetCreationTime(i);
                DateOfChange = File.GetLastAccessTimeUtc(i);
                DateOfLastAccess = File.GetLastAccessTime(i);
                
               }
           
        }
        public override void CopyFile(UltimateFilesHurricaneManagerClassLibrary.Node file)
        {
            throw new NotImplementedException();
        }
        public override void WriteBytes(byte[] batesArr)
        {
            throw new NotImplementedException();
        }
        public override void ReplaceFile(string inDirectory)
        {
            throw new NotImplementedException();
        }
        public override void RemoveFile()
        {
            throw new NotImplementedException();
        }

        public override void OpenFile()
        {
            var p1 = new Process { StartInfo = { FileName = Per } };
                p1.Start();
            
        }

      
    }
}
