using System;

namespace ConsoleApplication2
{
   public class UltimateFilesHurricaneManagerClassLibrary
    {
        public abstract class Node
        {
            public string Name { get; set; }
            public string Path { get; set; }
            public long Size { get; set; }
            public DateTime DateOfCreation { get; set; }
            public DateTime DateOfChange { get; set; }
            public DateTime DateOfLastAccess { get; set; }

            public abstract void CopyFile();
            public abstract void WriteBytes();
            public abstract void ReplaceFile();
            public abstract void RemoveFile();
            public abstract void OpenFile();
        }
    }
}
