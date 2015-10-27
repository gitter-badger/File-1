using System;
using System.IO;
using SevenZip;


namespace ConsoleApplication2
{
    internal class ArchiveFile : Files
    {
        public override void Copy(Node nodeElement)
        {

        }

        public override void Write(byte[] batesArr)
        {

        }

        public override void Replace(string inDirectory)
        {

        }

        public override void Remove()
        {

        }

        public override void Open()
        {
            string source_folder = @"D:\test";
                //путь к папке, которую нужно поместить в архив
            string archive_name = "qwerty.zip"; //имя архива
            string library_source = "SevenZipSharp.dll"; //Путь к файлу 7zip.dll
            if (File.Exists(library_source)) //Если библиотека 7zip существует
            {
                SevenZipBase.SetLibraryPath(library_source); //Подгружаем библиотеку 7zip
                var compressor = new SevenZipCompressor(); //Объявляем переменную архиватора
                compressor.ArchiveFormat = OutArchiveFormat.SevenZip; //Выбираем формат архива
                compressor.CompressionLevel = CompressionLevel.Ultra; // ультра режим сжатия
                compressor.CompressionMode = CompressionMode.Create; //подтверждаются настройки
                compressor.TempFolderPath = System.IO.Path.GetTempPath();//объявляется временная папка
                compressor.CompressDirectory(source_folder, archive_name, false); //сам процесс сжатия
            }
        }
    }
}

    



