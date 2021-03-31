using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace ChipCustomization
{
    public class Model : INotifyPropertyChanged
    {
        public string Name { get; set; }

        private Color chipColor;
        public Color ChipColor
        {
            get { return chipColor; }
            set
            {
                chipColor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChipColor"));
            }
        }

        private Color textColor;
        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TextColor"));
            }
        }

        public Color ActualTextColor { get; set; }

        public Model()
        {
            TextColor = ActualTextColor = Color.Red;
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
