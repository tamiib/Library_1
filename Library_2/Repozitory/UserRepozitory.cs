using Library_2.DAL;
using Library_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_2.Repozitory
{
    public class UserRepozitory
    {
        private DatabaseContext _databaseContext;
        public UserRepozitory(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public List<User> GetUsers()
        {
            var Users = new List<User>();
            Users = _databaseContext.Users.ToList();
            return Users;
        }
        public void AddUsers(User user)
        {
            _databaseContext.Users.Add(user);
            _databaseContext.SaveChanges();
        }
        public void DeleteUsers(User user)
        {
            _databaseContext.Users.Remove(user);
            _databaseContext.SaveChanges();
        }
        public void UpdateUsers(User updateUser)
        {
            var temp = _databaseContext.Users.FirstOrDefault(item => item.Id == updateUser.Id);
            if (temp != null)
            {
                temp.Id = updateUser.Id;
                temp.FirstName = updateUser.FirstName;
                temp.LastName = updateUser.LastName;
                _databaseContext.SaveChanges();
            }
        }

    }
}
