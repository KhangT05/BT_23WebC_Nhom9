namespace baitap_nhom
{
    public enum UserRole
    {
        Member = 4,
        Timer = 3,
        Note = 2,
        Leader = 1
    }

    public class UsersDI
    {
        public string ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }

    public static class UsersDIExtensions
    {
        public static string GetRoleName(this UsersDI user)
        {
            return user.Role switch
            {
                UserRole.Member => "Member",
                UserRole.Timer => "Timer",
                UserRole.Note => "Note",
                UserRole.Leader => "Leader",
                _ => "Unknown"
            };
        }
    }

    public class UserDIManager
    {
        private readonly List<UsersDI> _users;
        public UserDIManager()
        {
            _users = new List<UsersDI>()
            {
                new UsersDI { ID = "1", Username = "Khang", Password = "member", Role = UserRole.Member },
                new UsersDI { ID = "2", Username = "Duong", Password = "note", Role = UserRole.Note },
                new UsersDI { ID = "3", Username = "Cuong", Password = "timer", Role = UserRole.Timer },
                new UsersDI { ID = "4", Username = "Nhat", Password = "leader", Role = UserRole.Leader },
                new UsersDI { ID = "5", Username = "Huy", Password = "member", Role = UserRole.Member }
            };
        }

        public List<UsersDI> GetAll() => _users;
    }
}
