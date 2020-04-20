using System;
using System.Collections.Generic;

namespace AplicacionPrueba.M000_BaseApp.M0001_Resources
{
    public static class Strings
    {
        /*----- SESSION -----*/

        /// <summary>
        /// 
        /// </summary>
        public static string USER_ID_STRING { get; } = "userId";

        /// <summary>
        /// 
        /// </summary>
        public static string USER_NAME_STRING { get; } = "userName";

        /// <summary>
        /// 
        /// </summary>
        public static string USER_LASTNAME_STRING { get; } = "userLastame";

        /// <summary>
        /// 
        /// </summary>
        public static string USER_EMAIL_STRING { get; } = "userEmail";

        /*----- TIME -----*/

        /// <summary>
        /// 
        /// </summary>
        public static List<string> MONTHS { get; } = new List<string>() { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

        /// <summary>
        /// 
        /// </summary>
        public static List<string> DAYS_OF_WEEK { get; } = new List<string>() { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

        /// <summary>
        /// 
        /// </summary>
        public static List<string> ABBREVIATED_DAYS_OF_WEEK { get; } = new List<string>() { "Lun", "Mar", "Mié", "Jue", "Vie", "Sáb", "Dom" };





        /*----- GENDER -----*/

        /// <summary>
        /// 
        /// </summary>
        public static string MALE_STRING { get { return "Masculino"; } }

        /// <summary>
        /// 
        /// </summary>
        public static string FEMALE_STRING { get { return "Femenino"; } }

        /// <summary>
        /// 
        /// </summary>
        public static string UNISEX_STRING { get { return "Unisex"; } }



        /// <summary>
        /// 
        /// </summary>
        public static string EMAIL_STRING { get { return "Correo"; } }
    }
}
