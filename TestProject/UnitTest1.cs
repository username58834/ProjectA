using ProjectA;
using System.Xml.Linq;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        private Library? library;

        [TestInitialize]
        public void Setup()
        {
            library = new Library("Library-1");
        }

        [TestMethod]
        [DataRow("BookANameSurname1", new Genres[] { Genres.Detective }, "Name", "Surname1", "2025-01-01")]
        [DataRow("BookBNameSurname1", new Genres[] { Genres.Adventure, Genres.Fantasy }, "Name", "Surname1", "2024-06-26")]
        [DataRow("BookANameSurname2", new Genres[] { Genres.FairyTale, Genres.Fantasy }, "Name", "Surname2", "2023-08-01")]

        public void TestAddBook(string title, Genres[] genres, string authorname, string authorsurname, string published)
        {
            Author? author = library.Authors.Find(x => x.Name == authorname && x.Surname == authorsurname);
            if (author == null)
            {
                author = new Author(authorname, authorsurname);
            }

            Book book = new Book(title, genres, author, published);

            Assert.AreEqual(book.Title, title);

            for (int i = 0; i < genres.Length; i++)
            {
                Assert.AreEqual(book.Genre[i], genres[i]);
            }
            Assert.AreEqual(book.Author.ID, author.ID);
        }

        [TestMethod]
        [DataRow("WorkerName1", "WorkerSurname1", "1990-01-01", 1000.00)]
        [DataRow("WorkerName2", "WorkerSurname2", "2005-01-11", 800.00)]
        [DataRow("WorkerName3", "WorkerSurname3", "2001-12-31", 1500.00)]

        public void TestHireWorker(string workername, string workersurname, string dateOfBirth, double salary)
        {
            Worker worker = new Worker(workername, workersurname, dateOfBirth, salary);

            library.HireWorker(worker);

            Assert.AreEqual(worker.Name, workername);
            Assert.AreEqual(worker.Surname, workersurname);
            Assert.AreEqual(worker.Salary, salary);
        }

        [TestMethod]
        [DataRow("MemberName1", "MemberSurname1", "2003-01-01")]
        [DataRow("MemberName2", "MemberSurname2", "1989-05-03")]
        [DataRow("MemberName3", "MemberSurname3", "2010-01-16")]

        public void TestAddMember(string membername, string membersurname, string dateOfBirth)
        {
            Member member = new Member(membername, membersurname, dateOfBirth);
            DateTime date = DateTime.Now;

            library.AddMemeber(member);

            Assert.AreEqual(member.Name, membername);
            Assert.AreEqual(member.Surname, membersurname);
            Assert.AreEqual(member.MemebershipDate, date);
        }
    }
}