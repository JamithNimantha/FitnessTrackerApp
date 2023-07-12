using System.Collections.Generic;
using System.Linq;
using FitnessTrackerApp.Exceptions;
using FitnessTrackerApp.Model;
using FitnessTrackerApp.Utility;

namespace FitnessTrackerApp.Service
{
    public class UserService
    {
        private static UserService instance;
        private static readonly object lockObject = new object();

        public static UserService Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new UserService();
                        }
                    }
                }
                return instance;
            }
        }

        public bool Authenticate(string Username, string Password)
        {
            List<User> UserList = DataStorage.LoadData<User>();
            var user = FindUserByUserName(UserList, Username);
            if (user != null)
            {
                return PasswordManager.VerifyPassword(Password, user.Password);
            }
            return false;
        }

        public User FindUserByUserName(List<User> UserList, string UserName)
        {
            return UserList.FirstOrDefault(obj => obj.UserName.Equals(UserName));
        }

        public User FindUserByUserName(string UserName)
        {
            return GetAllUsers().FirstOrDefault(obj => obj.UserName.Equals(UserName));
        }

        public User AddUser(User User)
        {
            List<User> UserList = DataStorage.LoadData<User>();
            var ExistingUser = FindUserByUserName(UserList, User.UserName);
            if (ExistingUser != null)
            {
                throw new UserNameAlreadyExistsExeption(User.UserName);
            }
            UserList.Add(User);
            DataStorage.SaveData(UserList);

            return User;
        }

        public void DeleteUser(User UserDetail)
        {
            List<User> UserList = GetAllUsers();
            var user = FindUserByUserName(UserList, UserDetail.UserName);
            if (user != null)
            {
                UserList.Remove(user);
                DataStorage.SaveData(UserList);
            } 
            else
            {
                throw new UserNameNotFoundException(UserDetail.UserName);
            }
            
        }

        public User UpdateUser(User UpdatedUser)
        {
            List<User> UserList = GetAllUsers();
            var ExistingUser = FindUserByUserName(UserList, UpdatedUser.UserName);
            if (ExistingUser != null)
            {

                ExistingUser.Password = UpdatedUser.Password;
                ExistingUser.Height = UpdatedUser.Height;
                ExistingUser.Gender = UpdatedUser.Gender;
                ExistingUser.DateofBirth = UpdatedUser.DateofBirth;
                ExistingUser.Name = UpdatedUser.Name;
                DataStorage.SaveData(UserList);
            }
            else
            {
                throw new UserNameNotFoundException(UpdatedUser.UserName);
            }
            return ExistingUser;
        }

        public static List<User> GetAllUsers()
        {
            return DataStorage.LoadData<User>();
        }

    }
}
