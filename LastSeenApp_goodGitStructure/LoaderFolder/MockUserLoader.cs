namespace LastSeenTest_goodGitStructure
{
    public class MockUserLoader
    {
        private readonly IGetData _data;
        private readonly string _url;

        public MockUserLoader(IGetData data, string url)
        {
            _data = data;
            _url = url;
        }
        public User[] GetAllUsers()
        {
            List<User> users = new();
            for (int i = 0; i < 202; i++)
            {
                users.Add(new User(new UserData
                {
                    userId = "e13412b2-fe46-7149-6593-e47043f39c91",
                    nickname = "Terry_Weber",
                    firstName = "Terry",
                    lastName = "Weber",
                    registrationDate = "2022-10-24T17:46:53.1388008+00:00",
                    lastSeenDate = DateTime.Now.ToString("o"), // Format DateTime to ISO 8601
                    isOnline = false
                }));
            }
            return users.ToArray();
        }

    }
}
