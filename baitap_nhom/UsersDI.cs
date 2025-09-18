namespace baitap_nhom
{
    public class UsersDI
    {
        public string ID { get;set; }
        public string Username { get;set; }
        public string Password { get;set; }
        public int Role { get;set; }
    }
    public class UserDIManager
    {
        private readonly List<UsersDI> _users;
        public UserDIManager() {
            _users = new List<UsersDI>()
            {
                new UsersDI { ID = "1", Username = "Khang", Password = "member", Role = 3 },
                new UsersDI { ID = "2", Username = "Duong", Password = "note", Role = 2 },
                new UsersDI { ID = "3", Username = "Cuong", Password = "timer", Role = 2 },
                new UsersDI { ID = "4", Username = "Nhat", Password = "leader", Role = 1 },
                new UsersDI { ID = "5", Username = "Huy", Password = "member", Role = 3 }
            };
        }
        public List<UsersDI> GetAll()
        {
            return _users;
        }
    }
}
