using BlogApp.BusinessLayer.Abstract;
using BlogApp.DataAccesLayer.Abstract;
using BlogApp.EntitityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void TAdd(User entity)
        {
            _userDal.Add(entity);
        }

        public void TDelete(User entity)
        {
            _userDal.Delete(entity);
        }

        public User TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(User entity)
        {
            _userDal.Update(entity);
        }
    }
}
