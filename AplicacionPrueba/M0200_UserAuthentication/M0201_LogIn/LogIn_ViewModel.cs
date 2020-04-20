using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AplicacionPrueba.M000_BaseApp.M0001_Resources;
using Xamarin.Forms;

namespace AplicacionPrueba.M0200_UserAuthentication.M0201_LogIn
{
    public class LogIn_ViewModel : LogIn_Model
    {
        /*----- PROPERTIES -----*/

        public bool IsPaswordVisible
        {
            get
            {
                return _IsPaswordVisible;
            }
            set
            {
                _IsPaswordVisible = value;
                OnPropertyChanged();
            }
        }
        private bool _IsPaswordVisible { get; set; } = false;



        /*----- CONSTRUCTORS -----*/

        /// <summary>
        /// 
        /// </summary>
        public LogIn_ViewModel() {

            VisiblePassword_Command = new Command(()=> VisiblePassword());
        }




        /*----- COMMANDS -----*/

        public Command VisiblePassword_Command { get; set; }
        private void VisiblePassword() {
            IsPaswordVisible = !IsPaswordVisible;
        }


        /*----- TASKS -----*/




        /*----- METHODS -----*/

    }
}
