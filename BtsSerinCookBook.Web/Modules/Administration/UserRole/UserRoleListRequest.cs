using Serenity.Services;

namespace BtsSerinCookBook.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}