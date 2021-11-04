using AutomatedProjectEPS.ClassHelpers;
//using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomatedProjectEPS.PageObjects
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            SeleniumExtras.PageObjects.PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static Login Login { get { return GetPage<Login>(); } }
        public static Controller Controller { get { return GetPage<Controller>(); } }
        public static Common Common { get { return GetPage<Common>(); } }
        public static Calibration Calibration { get { return GetPage<Calibration>(); } }
        public static Flash Flash { get { return GetPage<Flash>(); } }
        public static Home Home { get { return GetPage<Home>(); } }
        public static Management Management { get { return GetPage<Management>(); } }
        public static BinarySearch BinarySearch { get { return GetPage<BinarySearch>(); } }
        public static BinaryUpload BinaryUpload { get { return GetPage<BinaryUpload>(); } }
        public static History History { get { return GetPage<History>(); } }
        public static Navigation Navigation { get { return GetPage<Navigation>(); } }
        public static ClientInfo ClientInfo { get { return GetPage<ClientInfo>(); } }

    }
}
