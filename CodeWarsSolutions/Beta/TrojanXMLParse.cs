using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

/* O XML retorna o estado atual em uma estrutura de 
 * organizada em SNAPSHOTs (GIT - Like). Todo arquivo que estiver na mesma estrutura do
 * arquivo infectado tambem esta comprometido. Crie uma funcao que retorne o total de
 * arquivos comprometidos
 */

namespace CurrentTest
{

    [XmlRoot("root")]
    public class Data
    {
        [XmlElement("snapshot")]
        public List<Snapshot> snapshots { get; set; }
    }

    public class Snapshot
    {
        [XmlElement("folder")]
        public List<Folder> folders { get; set; }
    }

    public class Folder
    {
        [XmlElement("file")]
        public List<File> files { get; set; }

        [XmlElement("folder")]
        public List<Folder> folders { get; set; }

        public void CheckFolder(string infectedFileId)
        {
            if (files.Any(item => item.fileID == infectedFileId))
            {
                foreach (File fil in files)
                {
                    Trojan.AddNewElemToList(fil.fileID);
                }
            }

            foreach (Folder fol in folders)
            {
                fol.CheckFolder(infectedFileId);
            }
        }

    }

    public class File
    {
        [XmlAttribute("fileId")]
        public string fileID { get; set; }
    }

    public class Trojan
    {
        static List<string> infectedList = new List<string>();

        public static int CountCompromised(string xml, string infectedFileId)
        {
            Data data;
            using (XmlReader reader = XmlReader.Create(new StringReader(xml)))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Data));
                data = serializer.Deserialize(reader) as Data;
            }

            foreach (Snapshot s in data.snapshots)
            {
                foreach (Folder f in s.folders)
                {
                    f.CheckFolder(infectedFileId);
                }

            }
            Console.WriteLine(string.Join(",", infectedList));
            return infectedList.Count - 1;
        }


        public static void AddNewElemToList(string elem)
        {
            if (!infectedList.Contains(elem))
                infectedList.Add(elem);
        }




        static void Main(string[] args)
        {
            string xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<root>" +
                "   <snapshot>" +
                "      <folder>" +
                "         <file fileId=\"1\"/>" +
                "         <file fileId=\"3\"/>" +
                "         <file fileId=\"6\"/>" +
                "         <folder>" +
                "            <file fileId=\"3\"/>" +
                "            <file fileId=\"4\"/>" +
                "            <folder> " +
                "               <file fileId=\"3\"/>" +
                "               <file fileId=\"5\"/>" +
                "               <folder> " +
                "                   <file fileId=\"7\"/>" +
                "                   <file fileId=\"2\"/>" +
                "               </folder>" +
                "            </folder>" +
                "         </folder>" +
                "      </folder>" +
                "   </snapshot>" +
                "   <snapshot>" +
                "      <file fileId=\"1\"/>" +
                "      <file fileId=\"3\"/>" +
                "      <folder>" +
                "         <file fileId=\"2\"/>" +
                "         <file fileId=\"4\"/>" +
                "         <folder>" +
                "            <file fileId=\"3\"/>" +
                "            <file fileId=\"4\"/>" +
                "         </folder>" +
                "      </folder>" +
                "   </snapshot>" +
                "</root>";

            Console.WriteLine(CountCompromised(xml, "2"));
        }
    }
}

