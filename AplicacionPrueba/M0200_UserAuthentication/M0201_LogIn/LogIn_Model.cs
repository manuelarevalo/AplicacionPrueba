using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AplicacionPrueba.M0200_UserAuthentication.M0201_LogIn
{
    public class LogIn_Model : INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
                OnPropertyChanged();
            }
        }
        private string _Email { get; set; } = string.Empty;


        /// <summary>
        /// 
        /// </summary>
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
                OnPropertyChanged();
            }
        }
        private string _Password { get; set; } = string.Empty;





        /*----- INTERFACE IMPLEMENTATION -----*/

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
