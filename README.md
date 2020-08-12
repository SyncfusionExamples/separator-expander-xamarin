# How to show separator for Xamarin.Forms Expander (SfExpander)

You can add separator for Expander with [Header](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.Expander.XForms~Syncfusion.XForms.Expander.SfExpander~Header.html) and [Content](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.Expander.XForms~Syncfusion.XForms.Expander.SfExpander~Content.html) by using [BoxView](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/boxview) in Xamarin.Forms [SfExpander](https://help.syncfusion.com/xamarin/expander/getting-started). By using custom HeaderIcon, you can add the separator line for the entire Header.

You can refer to the following document to customize the HeaderIcon in SfExpander,

[https://www.syncfusion.com/kb/11378/how-to-customize-header-icon-in-xamarin-forms-expander-sfexpander](https://www.syncfusion.com/kb/11378/how-to-customize-header-icon-in-xamarin-forms-expander-sfexpander)

You can also refer the following article.

https://www.syncfusion.com/kb/11867/how-to-show-separator-for-xamarin-forms-expander-sfexpander

**XAML**

**BoxView** added with Height as 2 in the Header and Content. [Converter](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.binding.converter#Xamarin_Forms_Binding_Converter) bound to the [IsVisible](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.visualelement.isvisible?view=xamarin-forms#Xamarin_Forms_VisualElement_IsVisible) property to change the visibility of the separator line and [ConverterParameter](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.binding.converterparameter#Xamarin_Forms_Binding_ConverterParameter) defined with Header and Content.

``` xml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ExpanderXamarin"
             xmlns:syncfusion="clr-namespace:Syncfusion.XForms.Expander;assembly=Syncfusion.Expander.XForms"
             x:Class="ExpanderXamarin.MainPage" Padding="0,15,0,0">

    <ContentPage.Resources>
        <ResourceDictionary>
            <local:ExpanderIconConverter x:Key="ExpanderIconConverter"/>
            <local:SeperatorVisibilityConverter x:Key="SeperatorVisibilityConverter"/>
        </ResourceDictionary>
    </ContentPage.Resources>
    
    <ContentPage.Content>
        <ScrollView BackgroundColor="#EDF2F5">
            <StackLayout>
                <syncfusion:SfExpander x:Name="expander1" HeaderIconPosition="None">
                    <syncfusion:SfExpander.Header>
                        <Grid>
                            <Grid.RowDefinitions>
                                <RowDefinition Height="50"/>
                                <RowDefinition Height="2"/>
                            </Grid.RowDefinitions>
                            <Grid>
                                <Label Text="Veg Pizza" TextColor="#495F6E" VerticalTextAlignment="Center" Margin="10,0,0,0"/>
                                <Image Margin="10" HorizontalOptions="End" HeightRequest="15" WidthRequest="15" Source="{Binding IsExpanded,Source={x:Reference expander1},Converter={StaticResource ExpanderIconConverter}}"/>
                            </Grid>
                            <BoxView Grid.Row="1" IsVisible="{Binding Path=IsExpanded, Source={x:Reference expander1}, Converter={StaticResource SeperatorVisibilityConverter}, ConverterParameter='Header'}" BackgroundColor="Green"/>
                        </Grid>
                    </syncfusion:SfExpander.Header>
                    <syncfusion:SfExpander.Content>
                        <Grid BackgroundColor="#FFFFFF">
                            <Grid.RowDefinitions>
                                <RowDefinition Height="Auto"/>
                                <RowDefinition Height="2"/>
                            </Grid.RowDefinitions>
                            <Label BackgroundColor="#FFFFFF" HeightRequest="50" Text="Veg pizza is prepared with the items that meet vegetarian standards by not including any meat or animal tissue products." TextColor="#303030" Margin="10,10,10,10" VerticalTextAlignment="Center"/>
                            <BoxView Grid.Row="1" IsVisible="{Binding Path=IsExpanded, Source={x:Reference expander1}, Converter={StaticResource SeperatorVisibilityConverter}, ConverterParameter='Content'}" BackgroundColor="Green"/>
                        </Grid>
                    </syncfusion:SfExpander.Content>
                </syncfusion:SfExpander>
            </StackLayout>
        </ScrollView>
    </ContentPage.Content>
</ContentPage>
```

**C#**

Converter used to show or hide the separator line based on the [IsExpanded](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.Expander.XForms~Syncfusion.XForms.Expander.SfExpander~IsExpanded.html) property.

``` c#
public class SeperatorVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if((string)parameter == "Header")
        {
            return (bool)value ? false : true;
        }
        else
            return (bool)value ? true : false;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
```
**Output**

![ExpanderSeparator](https://github.com/SyncfusionExamples/separator-expander-xamarin/blob/master/ScreenShot/ExpanderSeparator.gif)
