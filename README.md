# How to create a custom filter chips in Xamarin.Forms

Filter type Xamarin.Forms ChipGroup allows us to select more than one chip along with UI customization to differentiate the selected and unselected chips.

Xamarin.Forms ChipGroup has template support to add your desired view to each chip. When applying the template chip view, it will limit its default customization on UI. To maintain the same thing even adding the template view to the filter typed chip group, please refer to the below code sample.

Both selected and unselected chip backgrounds have been set as Transparent and SfChip has been added as a templated view of filter typed chips.

**[XAML]**

```
<buttons:SfChipGroup ItemsSource="{Binding Employees}" 
                    x:Name="chipGroup"  DisplayMemberPath="Name" 
                    ChipBackgroundColor="Transparent"
                    SelectedChipBackgroundColor="Transparent" 
                    SelectionChanged="TagsChipGroup_SelectionChanged"
                    Type="Filter" >
 
     <buttons:SfChipGroup.ItemTemplate>
            <DataTemplate>
                  <StackLayout InputTransparent="True">
                      <buttons:SfChip Text="{Binding Name}" TextColor="{Binding TextColor}" BackgroundColor="{Binding ChipColor}"/>
                  </StackLayout>
            </DataTemplate>
      </buttons:SfChipGroup.ItemTemplate>
</buttons:SfChipGroup>
```

Default text and background color have been applied from its corresponding Model class. To maintain the color changes on dynamic selection, the SelectionChanged event has been hooked.
The event returns the selected and unselected chip models, need to maintain the desired color as follows.

 
**[C#]**

```
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
```

## How to run this application?

To run this application, you need to first clone the How-to-create-a-custom-filter-chips-in-Xamarin.Form repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.