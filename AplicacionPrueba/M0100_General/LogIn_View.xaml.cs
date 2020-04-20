using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AplicacionPrueba.M0200_UserAuthentication.M0201_LogIn
{
    public partial class LogIn_View : ContentPage
    {
        /*----- PROPERTIES -----*/

        private LogIn_ViewModel context = new LogIn_ViewModel();



        /*----- ATTRIBUTES -----*/




        /*----- CONSTRUCTORS -----*/

        public LogIn_View()
        {
            InitializeComponent();

            BindingContext = context;
        }
    }
}
