using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastSeenTest_goodGitStructure
{
    public class OnlinePresenceTest
    {
        [Fact]
        public void Expect_Online_When_UserIsOnline()
        {
            User theUser = new User(new UserData
            {
                userId = "e13412b2-fe46-7149-6593-e47043f39c91",
                nickname = "Terry_Weber",
                firstName = "Terry",
                lastName = "Weber",
                registrationDate = "2022-10-24T17:46:53.1388008+00:00",
                lastSeenDate = null,
                isOnline = true
            });
            var userState = theUser.ToString();
            Assert.Equal("Terry_Weber is online.", userState);
        }
    }
}
