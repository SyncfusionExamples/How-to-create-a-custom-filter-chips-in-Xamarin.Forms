using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChipCustomization
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            foreach(var chip in chipGroup.GetChips())
            {
                chip.Padding = new Thickness(0);
               // chip.CornerRadius = new Thickness(20);
            }
        }
        private void TagsChipGroup_SelectionChanged(object sender, Syncfusion.Buttons.XForms.SfChip.SelectionChangedEventArgs e)
        {
            var selectedColor = Color.Blue;
            if (e.AddedItem != null)
            {
                var item = e.AddedItem as Model;
                if (item != null)
                {
                    item.TextColor = selectedColor;
                }
                else
                {
                    var items = e.AddedItem as List<Model>;
                    foreach (var model in items)
                    {
                        model.TextColor = selectedColor;
                    }
                }
            }

            if (e.RemovedItem != null)
            {
                var item = e.RemovedItem as Model;
                if (item != null)
                {
                    item.TextColor = item.ActualTextColor;
                }
                else
                {
                    var items = e.RemovedItem as List<Model>;
                    foreach (var model in items)
                    {
                        model.TextColor = model.ActualTextColor;
                    }
                }
            }
        }
    }
}
