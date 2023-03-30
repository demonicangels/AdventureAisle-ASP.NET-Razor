﻿using AAClasslibrary.Entities;
using DAL;


namespace AAClasslibrary.Interfaces
{
    public interface IDatabaseServiceUsers<T>
    {
       
        void InsertUser(UserDTO user);

        void DeleteUser(string selectedDes);

        string SearchUserName(string name);

        List<User> GetAllUsers();

        string SelectedUser(string selectedName);

        bool TryLogin(string username, string password);

        UserDTO GetUserByName(string username);

        T GetUserById(int id);
    }
}
