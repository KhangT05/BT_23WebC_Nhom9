namespace baitap_nhom
{
    public class DataLoader
    {
        private readonly UserDIManager _manager;
        public DataLoader(UserDIManager manager)
        {
            _manager = manager;
        }
        public List<UsersDI> LoadUsers()
        {
            return _manager.GetAll();
        }

    }
}
