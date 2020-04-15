using System;
using AplicacionPrueba.M000_BaseApp.M0001_Resources;
using Xamarin.Essentials;

namespace AplicacionPrueba.M000_BaseApp.M0003_Data
{
    public static class User_Data
    {
        /// <summary>
        /// 
        /// </summary>
        public static string ID
        {
            get { return Preferences.Get(Strings.USER_ID_STRING, string.Empty); }
            set { Preferences.Set(Strings.USER_ID_STRING, value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string NAME
        {
            get { return Preferences.Get(Strings.USER_NAME_STRING, string.Empty); }
            set { Preferences.Set(Strings.USER_NAME_STRING, value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string LASTNAME
        {
            get { return Preferences.Get(Strings.USER_LASTNAME_STRING, string.Empty); }
            set { Preferences.Set(Strings.USER_LASTNAME_STRING, value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string EMAIL
        {
            get { return Preferences.Get(Strings.USER_EMAIL_STRING, string.Empty); }
            set { Preferences.Set(Strings.USER_EMAIL_STRING, value); }
        }
    }
}
