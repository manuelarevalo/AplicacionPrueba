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
        public string Empty
        {
            get
            {
                return _Empty;
            }
            set
            {
                _Empty = value;
                OnPropertyChanged();
            }
        }
        private string _Empty { get; set; } = string.Empty;





        /*----- INTERFACE IMPLEMENTATION -----*/

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
