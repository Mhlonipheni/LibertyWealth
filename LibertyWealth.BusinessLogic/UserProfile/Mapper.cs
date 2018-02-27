using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.Entities;
using LibertyWealth.DataAccess.Interfaces;

namespace LibertyWealth.BusinessLogic.UserProfile
{
    public  static class Mapper 
    {
        public static Entities.UserProfile MapToEntity(this DataAccess.DAO.UserProfile dao)
        {
            var mapToEntity = new Entities.UserProfile
            {
                CountryCode = dao.CountryCode,
                CreatedDateTime = dao.CreatedDateTime,
                CurrencyCode = dao.CurrencyCode,
                Email = dao.Email,
                Employer = dao.Employer,
                FirstName = dao.FirstName,
                HomePhone = dao.HomePhone,
                LastName = dao.LastName,
                MobilePhone = dao.MobilePhone,
                SessionTimeoutMinutes = dao.SessionTimeoutMinutes
            };

            return mapToEntity;
        }

        public static DataAccess.DAO.UserProfile MapToDao(this Entities.UserProfile profile)
        {
            var userProfile = new DataAccess.DAO.UserProfile
            {
                CountryCode = profile.CountryCode,
                CreatedDateTime = profile.CreatedDateTime,
                CurrencyCode = profile.CurrencyCode,
                Email = profile.Email,
                Employer = profile.Employer,
                FirstName = profile.FirstName,
                HomePhone = profile.HomePhone,
                LastName = profile.LastName,
                MobilePhone = profile.MobilePhone,
                SessionTimeoutMinutes = profile.SessionTimeoutMinutes
            };

            return userProfile;
        }

    }
}
