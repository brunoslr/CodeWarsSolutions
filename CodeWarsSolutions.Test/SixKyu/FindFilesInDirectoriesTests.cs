using System.Collections.Generic;
using NUnit.Framework;
using CodeWarsSolutions.SixKyu;

namespace CodeWarsSolutions.Test.SixKyu
{
    [TestFixture]
    public class FindFilesInDirectoriesTests
    {
        [Test]
        public void FirstTest()
        {
            Folder myFolder = new Folder("main",
                new List<Item>()
                {
                    new File("readme"),
                    new File("question"),
                    new Folder("docs",
                        new List<Item>()
                        {
                            new File("info"),
                            new Folder("pics",
                                new List<Item>()
                                {
                                    new File("summer"),
                                    new File("winter"),
                                    new Folder("all", null),
                                    new File("spring")
                                })
                        })
                });
            StringAssert.AreEqualIgnoringCase("main\\docs\\pics\\winter", FindFileInDirectories.FindFileInFolder(myFolder, "winter"), "Expect: 'main\\docs\\pics\\winter'");
        }

        [Test]
        public void SecondTest()
        {
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
            StringAssert.AreEqualIgnoringCase("All\\Docs\\answer", FindFileInDirectories.FindFileInFolder(myFolder, "answer"), "Expect: 'All\\Docs\\answer'");
        }
    }
}
