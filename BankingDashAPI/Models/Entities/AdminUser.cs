namespace BankingDashAPI.Models.Entities
{
    public class AdminUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
    }
}
