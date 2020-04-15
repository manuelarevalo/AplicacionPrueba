using System;
using Xamarin.Forms;

namespace AplicacionPrueba.M000_BaseApp.M0001_Resources
{
    public static class Colors
    {
        /*----- PALETTE -----*/

        /// <summary>
        /// Ejemplo de un color estático
        /// </summary>
        public static Color PRIMARY { get { return BRIGHT_VIOLET; } }

        /// <summary>
        /// Ejemplo de un color estático
        /// </summary>
        public static Color SECONDARY { get { return SOFT_BLUE; } }

        /// <summary>
        /// Ejemplo de un color estático
        /// </summary>
        public static Color TERTIARY { get { return VERY_SOFT_MAGENTA; } }





        /*----- GRAY SCALE -----*/

        public static Color LIGHTNESS_100 { get; } = Color.FromHex("#FFFFFF");

        public static Color LIGHTNESS_98 { get; } = Color.FromHex("#FAFAFA");

        public static Color LIGHTNESS_95 { get; } = Color.FromHex("#F1F1F1");

        public static Color LIGHTNESS_90 { get; } = Color.FromHex("#E1E6EB");

        public static Color LIGHTNESS_83 { get; } = Color.FromHex("#D4D4D4");

        public static Color LIGHTNESS_10 { get; } = Color.FromHex("#151820");

        public static Color LIGHTNESS_0 { get; } = Color.FromHex("#000000");




        /*----- WHOLE COLORS -----*/

        /// <summary>
        /// Ejemplo de un color estático
        /// </summary>
        public static Color BRIGHT_VIOLET { get; } = Color.FromHex("#A533EF");

        /// <summary>
        /// Ejemplo de un color estático
        /// </summary>
        public static Color SOFT_BLUE { get; } = Color.FromHex("#81CCF7");

        /// <summary>
        /// Ejemplo de un color estático
        /// </summary>
        public static Color VERY_SOFT_MAGENTA { get; } = Color.FromHex("#F7A9F5");
    }
}
