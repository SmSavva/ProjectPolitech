using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace �������_6
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
            using (MiniApp app = new MiniApp())
            {
                app.Users.Add(new User() { Name = "Alexandra", Age = 21 });
                app.SaveChanges();
                //��� ���������� ����� �������� ������, �������� ��������� �������
                //���� �� �����������, �������� ������� �� ���������
                User? user = app.Users.OrderBy(x => x.Id).LastOrDefault();
                Assert.AreEqual(user.Name, "Alexandra");
                Assert.IsTrue(user.Age == 21);
            }
        }

        [Test]
        public void TestRemove()
        {
            using(MiniApp app = new MiniApp())
            {
                User? user = app.Users.OrderBy(x=>x.Id).LastOrDefault();
                int count1 = app.Users.Count();
                app.Users.Remove(user);
                app.SaveChanges();
                int count2 = app.Users.Count();
                Assert.IsTrue(count1 == count2 + 1);
            }
        }

        [Test]
        public void TestUpdate()
        {
            using(MiniApp app = new MiniApp())
            {
                User? user = app.Users.FirstOrDefault();
                user.Name = "�����";
                app.Users.Update(user);
                app.SaveChanges();
                Assert.IsTrue(user.Name == "�����");
            }
        }
    }
}