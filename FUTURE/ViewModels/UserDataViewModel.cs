using DAL3.Models;
using System.ComponentModel;

namespace FUTURE.ViewModels
{
    public class UserDataViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public UserData userData { get; set; }

        public UserDataViewModel()
        {
            userData = new UserData();
        }
        public string Mail
        {
            get { return userData.Mail; }
            set
            {
                if (userData.Mail != value)
                {
                    userData.Mail = value;
                    OnPropertyChanged("Mail");
                }
            }
        }
        public int Age
        {
            get { return userData.Age; }
            set
            {
                if (userData.Age != value)
                {
                    userData.Age = value;
                    OnPropertyChanged("Age");
                }
            }
        }
        public float Weight
        {
            get { return userData.Weight; }
            set
            {
                if (userData.Weight != value)
                {
                    userData.Weight = value;
                    OnPropertyChanged("Weight");
                }
            }
        }
        public int Height
        {
            get { return userData.Height; }
            set
            {
                if (userData.Height != value)
                {
                    userData.Height = value;
                    OnPropertyChanged("Height");
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}