﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccess.DAO;
using LibertyWealth.DataAccess.Interfaces;
using LibertyWealth.Entities;

namespace LibertyWealth.DataAccess.DataStores
{
   public class tblUserDataStore:ItblUserDataStore
    {
        public readonly string Connection;
        public tblUserDataStore(string connection)
        {
            Connection = connection;
        }

        public bool AddUser(Entities.tblUser user)
        {
            throw new NotImplementedException();
        }

        public DAO.tblUser AddUser(DAO.tblUser user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(long userId)
        {
            throw new NotImplementedException();
        }

        public IList<Entities.tblUser> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public bool GetUserById(long userId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(Entities.tblUser user)
        {
            throw new NotImplementedException();
        }

        public DAO.tblUser UpdateUser(DAO.tblUser user)
        {
            throw new NotImplementedException();
        }

        void ItblUserDataStore.DeleteUser(long userId)
        {
            throw new NotImplementedException();
        }

        IList<DAO.tblUser> ItblUserDataStore.GetAllUser()
        {
            throw new NotImplementedException();
        }

        DAO.tblUser ItblUserDataStore.GetUserById(long userId)
        {
            throw new NotImplementedException();
        }
    }   
}
