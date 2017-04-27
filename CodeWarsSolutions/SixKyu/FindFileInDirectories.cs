/* URL: https://www.codewars.com/kata/find-file-in-directories/train/csharp
 Search for a file in directories

So, files have only names, and folders have name and a list of folders and files.

Your task is to get the folder and file's name and return the address of the file.

public static string FindFileInFolder(Folder folder, String fileName)
You can suppose the file always exists and there is only one file with this name.

Example:

Folder myFolder = new Folder("All",
                new List<Item>()
                {
                    new File("readme"),
                    new File("question"),
                    new Folder("Docs",
                        new List<Item>()
                        {
                            new File("info"),
                            new File("answer")
                        })
                });
Then
FindFileInFolder(myFolder, "answer")
must return

All\Docs\answer
*/
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsSolutions.SixKyu
{
    public abstract class Item
    {
        public string Name { get; set; }
    }

    public class File : Item
    {
        public File(string name)
        {
            Name = name;
        }
    }

    public class Folder : Item
    {
        public Folder(string name, List<Item> items)
        {
            Name = name;
            Items = items;
        }
        public List<Item> Items { get; set; }
    }

    class FindFileInDirectories
    {
        public static string FindFileInFolder(Folder folder, string fileName)
        {

            var file = folder.Items.Where(x => x.Name == fileName).FirstOrDefault();
            if (file != null)
                return folder.Name + "\\" + file.Name;

            foreach (Item item in folder.Items)
                if (item is Folder)
                    return folder.Name + "\\" + FindFileInFolder(item as Folder, fileName);

            return null;
        }
    }
}
