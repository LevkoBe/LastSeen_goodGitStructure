using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastSeenTest_goodGitStructure
{
    public class LoaderTest
    {

        [Fact]
        public void Expect_AnyResult_When_FetchingData()
        {
            // Arrange
            IGetData dataProvider = new GetData();
            string apiUrl = "fakeUrl";
            MockUserLoader userLoader = new MockUserLoader(dataProvider, apiUrl);

            // Act
            User[] users = userLoader.GetAllUsers();

            // Assert
            Assert.NotEmpty(users);
            Assert.True(users.Length > 0);
        }

        [Fact]
        public void Expect_MoreThan200rows_When_FetchData()
        {
            // Arrange
            IGetData dataProvider = new GetData();
            string apiUrl = "fakeUrl";
            MockUserLoader userLoader = new MockUserLoader(dataProvider, apiUrl);

            // Act
            User[] users = userLoader.GetAllUsers();

            // Assert
            Assert.True(users.Length >= 200);
        }
    }
}
