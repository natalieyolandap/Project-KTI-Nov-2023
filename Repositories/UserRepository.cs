using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<UserModel> users = new List<UserModel>{
            new UserModel{Id=123,Name="nata",Password="rahasia",
            FavoriteColor="blue",Role="admin",GoogleId="11998877"}
        };
        public UserModel? GetByGoogleId(string googleId){
            throw new NotImplementedException();
        }

        public UserModel? GetByUsernameAndPassword(string username, string password){
            var user = users.SingleOrDefault(u=>u.Name == username && password == "rahasia");
            return user;
        }
    }
}