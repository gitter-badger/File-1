using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;


namespace ConsoleApplication2
{
    class Files: UltimateFilesHurricaneManagerClassLibrary.Node
    {
        
        public IEnumerable<int> _information(string per)
        {
            // Отображение всех файлов по пути
            string [] path = Directory.GetFiles(per);
            for (var i = 0; i < 1; i++ )
            {
                foreach (var i1 in path)
                {
                    var inform = new FileInfo(i1);
                    Name = inform.Name;
                    Path = inform.DirectoryName;
                    Size = inform.Length;
                    DateOfCreation = File.GetCreationTime(i1);
                    DateOfChange = File.GetLastAccessTimeUtc(i1);
                    DateOfLastAccess = File.GetLastAccessTime(i1);
                    yield return i;
                }
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
            string per = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            var p1 = new Process { StartInfo = { FileName = per } };
                p1.Start(); 
            
        }

      
    }
}
