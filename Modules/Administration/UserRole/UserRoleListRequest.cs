using Serenity.Services;

namespace SeAdminSiswa.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}