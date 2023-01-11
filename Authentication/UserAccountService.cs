namespace SmartCompany.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users;

        public UserAccountService()
        {
            _users = new List<UserAccount>
            {
                new UserAccount{ UserName = "", Password = "", Role = "Administrator" },
                new UserAccount{ UserName = "dir", Password = "123", Role = "Director" },
                new UserAccount{ UserName = "manager", Password = "123", Role = "Manager" }
            };
        }

        public UserAccount? GetByUserName(string userName)
        {
            return _users.FirstOrDefault(x => x.UserName == userName);
        }
    }
}
