using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewSQL;
using InterviewSQL.Entity;
using NUnit.Framework;

namespace UnitTestSQL
{
    public class BasicSQL
    {
        [Test]
        public void FirtExample()
        {

            using (UserContext db = new UserContext())
            {
                // создаем два объекта User
                User user1 = new User {Name = "Tom", Age = 33};
                User user2 = new User {Name = "Sam", Age = 26};

                // добавляем их в бд
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();

                var users = db.Users;
            }

        }

    }
}
