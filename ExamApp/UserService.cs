using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public class UserService
    {
        public List<User> GetAllUsers()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();
                return users;
            }
        }

        public User GetUser(int id) 
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var user = db.Users.Find(id);

                return user;
            }
        }

        public void SaveUser(User user)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public void UpdateUser(User user) 
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Users.Update(user);
                db.SaveChanges ();
            }
        }
    }
}
