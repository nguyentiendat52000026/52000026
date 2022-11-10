using TestStudentLib;
namespace TestStudentProject
{
    [TestClass]
    public class TestStudentService
    {
        //Test AddStudent method from StudentService
        [TestMethod]
        public void addFirstStudentShouldSuccess()
        {
            StudentService service = new StudentService();
            Student student = new Student() { Id = 1, Name = "Nguyen Tien Dat", Age = 20 };
            bool addStudent = service.addStudent(student);
            int length = service.size();
            Assert.IsTrue(addStudent);
            Assert.AreEqual(1, length);
        }
        [TestMethod]
        public void addDuplicateStudent_ShouldReturnFalse()
        {
            StudentService service = new StudentService();
            Student student1 = new Student() { Id = 1, Name = "Nguyen Tien Dat", Age = 20 };
            Student student2 = new Student() { Id = 1, Name = "Nguyen Tien Dat", Age = 20 };
            service.addStudent(student1);
            bool addDuplicate = service.addStudent(student2);
            Assert.IsFalse(addDuplicate);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void addNullStudent_ShouldReturn_NullReferenceException()
        {
            StudentService service = new StudentService();
            service.addStudent(null);
        }
        [TestMethod]
        public void addStudentSuccess_ShouldAdd1ToStudentsSizeAndReturnTrue()
        {
            StudentService service = new StudentService();
            Student student1 = new Student() { Id = 1, Name = "Nguyen Tien Dat1", Age = 20 };
            Student student2 = new Student() { Id = 2, Name = "Nguyen Tien Dat2", Age = 20 };
            Student student3 = new Student() { Id = 3, Name = "Nguyen Tien Dat3", Age = 20 };
            service.addStudent(student1);
            service.addStudent(student2);
            int len2 = service.size();
            service.addStudent(student3);
            int len3 = service.size();
            Assert.AreEqual(len2, len3 - 1);
        }

        //Test method from Student class
        //[TestMethod]
        //[ExpectedException(typeof(SystemException))]
        //public void addNumberLessThan0ScoreForStudent_ShouldReturn_SystemException()
        //{
        //    StudentService service = new StudentService();
        //    Student student1 = new Student() { Id = 1, Name = "Nguyen Tien Dat1", Age = 20, Score = -1 };
        //}
    }
}