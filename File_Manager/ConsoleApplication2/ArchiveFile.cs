using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;


namespace ConsoleApplication2
{
    class ArchiveFile : Files
    {
        public  IEnumerable<int> _archive()
        {
            var archive = ZipFile.Open(Path, ZipArchiveMode.Read);
                
                for (var i = 0; i < 1; i++)
                {
                    foreach (var s in archive.Entries)
                    {
                        Name = s.FullName;
                        Size = s.CompressedLength;
                        DateOfChange = s.LastWriteTime.DateTime;
                        yield return i;
                    }
                }
            }
        public override void Copy(Node nodeElement)
        {
            using (var zipToOpen = new FileStream(Path, FileMode.Open))
            {
                using (var archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                  archive.CreateEntry(NewPath);
                    
                }
            }
        }
        public override void Write(byte[] batesArr)
        {

        }
        public override void Replace(string inDirectory)
        {
            using (var zipToOpen = new FileStream(Path, FileMode.Open))
            {
                using (var archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    archive.CreateEntry(inDirectory);
                    File.Delete(inDirectory);
                }
            }
        }
        public override void Remove()
        {
            using (var zipToOpen = new FileStream(Path, FileMode.Open))
            {
                using (var archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))

                    foreach (var entry in archive.Entries.Where(entry => entry.FullName.EndsWith(NewPath)))
                    {
                        entry.Delete();
                        return;
                    }
            }
        }
        public override void Open()
        {
            
        }
    }
}



