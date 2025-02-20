
namespace LastSeenTest_goodGitStructure
{
    public class LastSeenTest
    {

        [Fact]
        public void Expect_JustNow_When_UpTo30Secs()
        {
            DateTime lastSeen = DateTime.Now.AddSeconds(-15);
            User theUser = new User(new UserData
            {
                userId = "e13412b2-fe46-7149-6593-e47043f39c91",
                nickname = "Terry_Weber",
                firstName = "Terry",
                lastName = "Weber",
                registrationDate = "2022-10-24T17:46:53.1388008+00:00",
                lastSeenDate = lastSeen.ToString("o"), // Format DateTime to ISO 8601
                isOnline = false
            });
            var userState = theUser.ToString();
            Assert.Equal("Terry_Weber was online just now.", userState);
        }

        [Fact]
        public void Expect_LessThanAMinuteAgo_When_UpTo1Min()
        {
            DateTime lastSeen = DateTime.Now.AddSeconds(-45);
            User theUser = new User(new UserData
            {
                userId = "e13412b2-fe46-7149-6593-e47043f39c91",
                nickname = "Terry_Weber",
                firstName = "Terry",
                lastName = "Weber",
                registrationDate = "2022-10-24T17:46:53.1388008+00:00",
                lastSeenDate = lastSeen.ToString("o"), // Format DateTime to ISO 8601
                isOnline = false
            });
            var userState = theUser.ToString();
            Assert.Equal("Terry_Weber was online less than a minute ago.", userState);
        }

        [Fact]
        public void Expect_LessThanAnHourAgo_When_UpTo1Hour()
        {
            DateTime lastSeen = DateTime.Now.AddMinutes(-30);
            User theUser = new User(new UserData
            {
                userId = "e13412b2-fe46-7149-6593-e47043f39c91",
                nickname = "Terry_Weber",
                firstName = "Terry",
                lastName = "Weber",
                registrationDate = "2022-10-24T17:46:53.1388008+00:00",
                lastSeenDate = lastSeen.ToString("o"), // Format DateTime to ISO 8601
                isOnline = false
            });
            var userState = theUser.ToString();
            Assert.Equal("Terry_Weber was online less than an hour ago.", userState);
        }

        [Fact]
        public void Expect_AnHourAgo_When_UpTo2Hours()
        {
            DateTime lastSeen = DateTime.Now.AddHours(-1.5);
            User theUser = new User(new UserData
            {
                userId = "e13412b2-fe46-7149-6593-e47043f39c91",
                nickname = "Terry_Weber",
                firstName = "Terry",
                lastName = "Weber",
                registrationDate = "2022-10-24T17:46:53.1388008+00:00",
                lastSeenDate = lastSeen.ToString("o"), // Format DateTime to ISO 8601
                isOnline = false
            });
            var userState = theUser.ToString();
            Assert.Equal("Terry_Weber was online an hour ago.", userState);
        }

        [Fact]
        public void Expect_LongTimeAgo_When_MoreThen7Days()
        {
            DateTime lastSeen = DateTime.Now.AddDays(-8);
            User theUser = new User(new UserData
            {
                userId = "e13412b2-fe46-7149-6593-e47043f39c91",
                nickname = "Terry_Weber",
                firstName = "Terry",
                lastName = "Weber",
                registrationDate = "2022-10-24T17:46:53.1388008+00:00",
                lastSeenDate = lastSeen.ToString("o"), // Format DateTime to ISO 8601
                isOnline = false
            });
            var userState = theUser.ToString();
            Assert.Equal("Terry_Weber was online long time ago.", userState);
        }

        [Fact]
        public void Expect_Today_When_TodayAfter2AM()
        {
            DateTime now = DateTime.Now;
            DateTime lastSeen = new DateTime(now.Year, now.Month, now.Day, 5, 0, 0);
            User theUser = new User(new UserData
            {
                userId = "e13412b2-fe46-7149-6593-e47043f39c91",
                nickname = "Terry_Weber",
                firstName = "Terry",
                lastName = "Weber",
                registrationDate = "2022-10-24T17:46:53.1388008+00:00",
                lastSeenDate = lastSeen.ToString("o"), // Format DateTime to ISO 8601
                isOnline = false
            });
            var userState = theUser.ToString();
            Assert.Equal("Terry_Weber was online today.", userState);
        }

        [Fact]
        public void Expect_Yesterday_When_YesterdayAfter2AM()
        {
            DateTime now = DateTime.Now;
            DateTime lastSeen = new DateTime(now.Year, now.Month, now.Day, 5, 0, 0).AddDays(-1);
            User theUser = new User(new UserData
            {
                userId = "e13412b2-fe46-7149-6593-e47043f39c91",
                nickname = "Terry_Weber",
                firstName = "Terry",
                lastName = "Weber",
                registrationDate = "2022-10-24T17:46:53.1388008+00:00",
                lastSeenDate = lastSeen.ToString("o"), // Format DateTime to ISO 8601
                isOnline = false
            });
            var userState = theUser.ToString();
            Assert.Equal("Terry_Weber was online yesterday.", userState);
        }

        [Fact]
        public void Expect_ThisWeek_When_Between2and7days()
        {
            DateTime lastSeen = DateTime.Now.AddDays(-4);
            User theUser = new User(new UserData
            {
                userId = "e13412b2-fe46-7149-6593-e47043f39c91",
                nickname = "Terry_Weber",
                firstName = "Terry",
                lastName = "Weber",
                registrationDate = "2022-10-24T17:46:53.1388008+00:00",
                lastSeenDate = lastSeen.ToString("o"), // Format DateTime to ISO 8601
                isOnline = false
            });
            var userState = theUser.ToString();
            Assert.Equal("Terry_Weber was online this week.", userState);
        }
    }
}