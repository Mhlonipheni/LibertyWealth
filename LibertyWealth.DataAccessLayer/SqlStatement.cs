using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibertyWealth.DataAccessLayer
{
    public static class SqlStatement
    {
        public static string USERPROFILE_ADD = @"INSERT INTO [dbo].[UserProfile]
                                               ([UserProfileId]
                                               ,[FirstName]
                                               ,[LastName]
                                               ,[CountryCode]
                                               ,[MobilePhone]
                                               ,[HomePhone]
                                               ,[Email]
                                               ,[CurrencyCode]
                                               ,[Employer]
                                               ,[CreatedDateTime]
                                               ,[SessionTimeoutMinutes])
                                         VALUES
                                               (@UserProfileId
                                               ,@FirstName,
                                               ,@LastName,
                                               ,@CountryCode,
                                               ,@MobilePhone,
                                               ,@HomePhone,
                                               ,@Email,
                                               ,@CurrencyCode,
                                               ,@Employer,
                                               ,@CreatedDateTime,
                                               ,@SessionTimeoutMinutes";
    }
}
