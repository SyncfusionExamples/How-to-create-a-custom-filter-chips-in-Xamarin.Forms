using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace ChipCustomization
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Model> employees;
        public ObservableCollection<Model> Employees
        {
            get
            {
                return employees;
            }
            set
            {
                Employees = value;
                OnPropertyChanged("Employees");
            }
        }

        public ViewModel()
        {
            employees = new ObservableCollection<Model>();
            employees.Add(new Model() { Name = "John", ChipColor = Color.LightBlue });
            employees.Add(new Model() { Name = "Stephen", ChipColor = Color.LightYellow });
            employees.Add(new Model() { Name = "Michael", ChipColor = Color.LightPink });
            employees.Add(new Model() { Name = "Joel", ChipColor = Color.LightGray });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
