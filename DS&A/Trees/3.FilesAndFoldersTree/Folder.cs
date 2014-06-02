namespace _3.FilesAndFoldersTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    public class Folder
    {
        const int MegabyteDivider = 1024 * 1024;

        public Folder(string name)
        {
            this.Name = name;
            this.Parent = null;
            this.Files = new List<File>();
            this.childFolders = new List<Folder>();
        }

        public string Name { get; set; }

        public IList<File> Files { get; set; }

        public IList<Folder> childFolders { get; set; }

        public Folder Parent { get; set; }

        public long FilesSizeInMegabytes { get; set; }

        private BigInteger CalculateFilesSize()
        {
            BigInteger size = 0;

            foreach (var file in this.Files)
            {
                size += file.Size;
            }

            return size;
        }

        private BigInteger CalculateFoldersSize()
        {
            BigInteger size = 0;

            foreach (var folder in this.childFolders)
            {
                size += folder.GetFolderSizeInMegabytes();
            }

            return size;
        }

        public BigInteger GetFolderSizeInMegabytes()
        {
            return CalculateFilesSize() + CalculateFoldersSize();
        }

        public void AddChildFile(File file)
        {
            this.Files.Add(file);
        }

        public void AddChildFolder(Folder folder)
        {
            this.childFolders.Add(folder);
        }        
    }
}
