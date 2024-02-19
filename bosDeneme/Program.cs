 using System;
using System.Collections;

namespace fileNames
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example for recursive methods

            List<FileInfo> files = DosyaYazdir("/Users/emirhansahbaz/Desktop/GH/Proje1");
            foreach (FileInfo file in files)
                Console.WriteLine(file.FullName);

            List<FileInfo> DosyaYazdir(string path)
            {
                List<FileInfo> fileInfos = new();

                DirectoryInfo directoryInfo = new(path);
                DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
                if (directoryInfos.Any())
                    foreach (DirectoryInfo directory in directoryInfos)
                        fileInfos.AddRange(DosyaYazdir(directory.FullName));
                else
                    fileInfos.AddRange(directoryInfo.GetFiles());
                return fileInfos;
             }

        }        
    }
}