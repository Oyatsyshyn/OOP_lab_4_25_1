using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("����� �i���� ����� ����i���� ��������!", OOP_lab_4_25_1.Student.StudentRating(58));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("�i���� �i��i�����!", OOP_lab_4_25_1.Student.StudentRating(100));
        }
    }
}
