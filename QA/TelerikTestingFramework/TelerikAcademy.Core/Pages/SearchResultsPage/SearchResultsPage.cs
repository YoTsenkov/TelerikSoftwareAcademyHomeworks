namespace TelerikAcademy.Core.Pages.SearchResultsPage
{
    using System.Linq;

    using ArtOfTest.Common.UnitTesting;    

    public class SearchResultsPage
    {
        private static SearchResultsPage instance;

        public static SearchResultsPage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SearchResultsPage();
                }

                return instance;
            } 
        }

        public SearchResultsPageMap Map
        {
            get
            {
                return new SearchResultsPageMap();
            }
        }

        public void AssertUsersResultsCount(int expectedCount)
        {
            int usersCount = 0;
            if (this.Map.UsersList != null)
            {
                usersCount = this.Map.UsersList.Items.Count();
            }

            Assert.AreEqual(expectedCount, usersCount);
        }

        public void AssertCoursesResultsCount(int expectedCount)
        {
            int usersCount = 0;
            if (this.Map.CoursesList != null)
            {
                usersCount = this.Map.CoursesList.Items.Count();
            }

            Assert.AreEqual(expectedCount, usersCount);
        }

        public void AssertTracksResultsCount(int expectedCount)
        {
            int usersCount = 0;
            if (this.Map.TracksList != null)
            {
                usersCount = this.Map.TracksList.Items.Count();
            }

            Assert.AreEqual(expectedCount, usersCount);
        }
    }
}
