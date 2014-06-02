namespace _3.FilesAndFoldersTree
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class Program
    {
        private static Folder CreateFolderTree(string path, Folder parent = null)
        {

            Folder currentFolder = new Folder(path);
            if (parent != null)
            {
                currentFolder.Parent = parent;
            }

            try
            {
                var currentFiles = Directory.GetFiles(path);
                foreach (var file in currentFiles)
                {
                    string fileName = Path.GetFileName(file);
                    long fileSize = new FileInfo(file).Length;
                    File childFile = new File(fileName, fileSize);
                    currentFolder.AddChildFile(childFile);
                }

                var currentDirs = Directory.GetDirectories(path);
                foreach (var dir in currentDirs)
                {

                    CreateFolderTree(dir, currentFolder);
                }

                parent.AddChildFolder(currentFolder);


            }
            catch (UnauthorizedAccessException e)
            {

                Console.WriteLine(e.Message);                
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            return currentFolder;
        }
       
        static void Main(string[] args)
        {
            Folder rootFolder = CreateFolderTree(@"C:\WINDOWS");
            BigInteger filesSize = rootFolder.GetFolderSizeInMegabytes();
            Console.WriteLine(filesSize + " bytes");


        }
    }
}
