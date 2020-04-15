using System;
namespace AplicacionPrueba.M000_BaseApp.M0005_Services.WebServices
{
    public static class URLCreator
    {
        /// <summary>
        /// URL base de los servicios web
        /// </summary>
        private static string HOST { get; } = "https://api.spame.co";





        /*----- CATEGORIAS -----*/

        public static string GET_CATEGORIES_URL() { return HOST + "/api/categories"; }

        public static string GET_SUBCATEGORIES_URL(string categoryId) { return HOST + "/api/categories/" + categoryId + "/subcategories"; }
    }
}
