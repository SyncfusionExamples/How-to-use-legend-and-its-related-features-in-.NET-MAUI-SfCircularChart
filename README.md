# How to use legend and its related features in .NET MAUI SfCircularChart
This article demonstrates how to use the legend and its related features in a [.NET MAUI Circular Chart](https://www.syncfusion.com/maui-controls/maui-circular-charts). Legends are used to provide information about the series or segments in the chart, making it easier for users to understand the data.

**Step 1:** Let’s configure the Syncfusion .NET MAUI SfCircular Chart using this [getting started documentation](https://help.syncfusion.com/maui/circular-charts/getting-started) and add the series to it as follows.
 
[XAML]
 ```xml
<chart:SfCircularChart>

   <chart:PieSeries ItemsSource="{Binding Data}"
                    XBindingPath="Country"
                    YBindingPath="Value"
                    PaletteBrushes="{Binding CustomBrushes}"/>

</chart:SfCircularChart> 
 ```

[C#]
 ```csharp
SfCircularChart chart = new SfCircularChart();
ViewModel viewModel = new ViewModel();

PieSeries pieSeries = new PieSeries ()
{
    ItemsSource = viewModel.Data,
    XBindingPath = "Country",
    YBindingPath = "Value",
    PaletteBrushes = viewModel.CustomBrushes,
};

chart.Series.Add(pieSeries);
this.Content=chart; 
 ```

**Step 2:** To add a [legend](https://help.syncfusion.com/maui/circular-charts/legend) to your MAUI Circular Chart, you need to configure the [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html?tabs=tabid-1%2Ctabid-5%2Ctabid-9%2Ctabid-3%2Ctabid-7#Syncfusion_Maui_Charts_ChartBase_Legend) property and initialize the [ChartLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html) bindable object
 
[XAML]
 ```xml
<chart:SfCircularChart>

    <chart:SfCircularChart.Legend>
        <chart:ChartLegend/>
    </chart:SfCircularChart.Legend>
    
</chart:SfCircularChart> 
 ```

[C#]
 ```csharp
chart.Legend = new ChartLegend(); 
 ```

###### Output:
 
 The following screenshot explains the legend for each segment of the pie chart, highlighting the significance of each individual section to the users.

 ![LegendImage](https://support.syncfusion.com/kb/agent/attachment/article/18792/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM0ODU2Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.ScOM3vo6FrOOHQK84o0G2_CsY9LX9YFLyYywDTapoIE)

**Legend Placement Customization**

To customize the legend position, use the [Placement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html?tabs=tabid-1%2Ctabid-3%2Ctabid-7%2Ctabid-12%2Ctabid-13%2Ctabid-5%2Ctabid-10%2Ctabid-15#Syncfusion_Maui_Charts_ChartLegend_Placement) property. It offers four built-in positions: Top, Bottom, Left, and Right.
 
[XAML]
 ```xml
<chart:SfCircularChart.Legend>
    <chart:ChartLegend Placement="Bottom">
    </chart:ChartLegend>
</chart:SfCircularChart.Legend>
 ```

[C#]
 ```csharp
SfCircularChart chart = new SfCircularChart();
. . .
chart.Legend = new ChartLegend()
{ 
    Placement = LegendPlacement.Bottom 
};

this.Content = chart; 
 ```
The legend has been shifted to the bottom of the chart, as you can see in the screenshot below.

 ![LegendPlacementImage](https://support.syncfusion.com/kb/agent/attachment/article/18792/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM0ODQ4Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.AKe_xffCM8GmpWqnyqtYOYW-NqDGhGAoCp9p8aYGNK4)

**Legend icon Customization**

To customize the legend icon in chart, use the [LegendIcon](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html?tabs=tabid-9%2Ctabid-11%2Ctabid-5%2Ctabid-7%2Ctabid-18%2Ctabid-1%2Ctabid-22%2Ctabid-24%2Ctabid-16%2Ctabid-20%2Ctabid-14%2Ctabid-13%2Ctabid-3#Syncfusion_Maui_Charts_ChartSeries_LegendIcon) property and set it to one of the values from the [ChartLegendIconType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendIconType.html) enum. 
 
[XAML]
 ```xml
<chart:SfCircularChart>

    <chart:SfCircularChart.Legend>
       <chart:ChartLegend Placement="Bottom"/>
    </chart:SfCircularChart.Legend>

    <chart:PieSeries ItemsSource="{Binding Data}"
                     XBindingPath="Country"
                     YBindingPath="Value"
                     LegendIcon = "Diamond"
                     PaletteBrushes="{Binding CustomBrushes}"/>
                     
</chart:SfCircularChart> 
 ```

[C#]
 ```csharp
SfCircularChart chart = new SfCircularChart();

chart.Legend = new ChartLegend()
{ 
    Placement = LegendPlacement.Bottom 
};

ViewModel viewModel = new ViewModel();

PieSeries pieSeries = new PieSeries ()
{
    ItemsSource = viewModel.Data,
    XBindingPath = "Country",
    YBindingPath = "Value",
    LegendIcon = ChartLegendIconType.Diamond,
    PaletteBrushes = viewModel.CustomBrushes,
};

chart.Series.Add(pieSeries);
this.Content=chart; 
 ```
 In the screenshot below you can observe that the legend icon shape is diamond-shaped. 

 ![LegendIconImage](https://support.syncfusion.com/kb/agent/attachment/article/18792/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM0ODQ1Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.v_06t7ztJEtM7jF4PUUQYCc0NBGpxISLZflqpYSAUtg)

**Legend labels Customization**

The appearance of the legend label can be customized using the [LabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html?tabs=tabid-1%2Ctabid-3%2Ctabid-7%2Ctabid-12%2Ctabid-13%2Ctabid-5%2Ctabid-10%2Ctabid-15#Syncfusion_Maui_Charts_ChartLegend_LabelStyle) property.

* [TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendLabelStyle.html?tabs=tabid-2%2Ctabid-11%2Ctabid-9%2Ctabid-7%2Ctabid-5%2Ctabid-3#Syncfusion_Maui_Charts_ChartLegendLabelStyle_TextColor) – Gets or sets the color of the label.
* [FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendLabelStyle.html?tabs=tabid-2%2Ctabid-11%2Ctabid-9%2Ctabid-7%2Ctabid-5%2Ctabid-3#Syncfusion_Maui_Charts_ChartLegendLabelStyle_FontFamily) - Gets or sets the font family for the legend label.
* [FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendLabelStyle.html?tabs=tabid-2%2Ctabid-11%2Ctabid-9%2Ctabid-7%2Ctabid-5%2Ctabid-3#Syncfusion_Maui_Charts_ChartLegendLabelStyle_FontAttributes) - Gets or sets the font style for the legend label.
* [FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendLabelStyle.html?tabs=tabid-2%2Ctabid-11%2Ctabid-9%2Ctabid-7%2Ctabid-5%2Ctabid-3#Syncfusion_Maui_Charts_ChartLegendLabelStyle_FontSize) - Gets or sets the font size for the legend label.
* [Margin](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendLabelStyle.html?tabs=tabid-2%2Ctabid-11%2Ctabid-9%2Ctabid-7%2Ctabid-5%2Ctabid-3#Syncfusion_Maui_Charts_ChartLegendLabelStyle_Margin) - Gets or sets the margin size of labels.
 
[XAML]
 ```xml
<chart:SfCircularChart.Legend>
    <chart:ChartLegend>
        <chart:ChartLegend.LabelStyle>
            <chart:ChartLegendLabelStyle TextColor="Blue" Margin="5" FontSize="18" FontAttributes="Bold" 
                                         FontFamily="PlaywriteAUSA-VariableFont_wght"/>
        </chart:ChartLegend.LabelStyle>
    </chart:ChartLegend>
</chart:SfCircularChart.Legend>
 ```

[C#]
 ```csharp
SfCircularChart chart = new SfCircularChart();

chart.Legend = new ChartLegend();
ChartLegendLabelStyle labelStyle = new ChartLegendLabelStyle()
{
    TextColor = Colors.Blue,
    FontSize = 18,
    FontAttributes = FontAttributes.Bold,
    Margin = 5,
    FontFamily = "PlaywriteAUSA-VariableFont_wght"
};
chart.Legend.LabelStyle = labelStyle;
.........
this.Content = chart; 
 ```
In the screenshot below you can observe that the legend label has been customized.
 
 ![LegendLabelStyleImage](https://support.syncfusion.com/kb/agent/attachment/article/18792/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM0ODQ5Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9._LiRzilkTD0Y0WafOYPryLPYw74hHqLoGICKJeWx6Ug)

**Legend Visibility**

To hide the legend, use the [IsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html?tabs=tabid-1%2Ctabid-3%2Ctabid-7%2Ctabid-12%2Ctabid-13%2Ctabid-5%2Ctabid-10%2Ctabid-15#Syncfusion_Maui_Charts_ChartLegend_IsVisible) property. This will allow to enable or disable the legend in chart.
 
[XAML]
 ```xml
<chart:SfCircularChart.Legend>
    <chart:ChartLegend IsVisible="False"/>
</chart:SfCircularChart.Legend>
 ```
 
[C#]
 ```csharp
chart.Legend = new ChartLegend()
{ 
    IsVisible = false
}; 
 ```
You can see that the chart's legend has been disabled in the screenshot below.

 ![LegendIsVisibleImage](https://support.syncfusion.com/kb/agent/attachment/article/18792/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM0ODQ2Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.o0taFE-o4GH3BiCnPWvMJ-3IxxNuFyIhfw4BqdTs2Oo)

**Toggle Series Visibility**

To hide a particular segment in the MAUI circular charts by toggling the legend, use the [ToggleSeriesVisibility](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html?tabs=tabid-1%2Ctabid-3%2Ctabid-7%2Ctabid-12%2Ctabid-13%2Ctabid-5%2Ctabid-10%2Ctabid-15#Syncfusion_Maui_Charts_ChartLegend_ToggleSeriesVisibility) property. This property allows to dynamically change the visibility of a segment by tapping the respective legend item.
 
[XAML]
 ```xml
<chart:SfCircularChart.Legend>
    <chart:ChartLegend Placement="Bottom" ToggleSeriesVisibility="True">
    </chart:ChartLegend>
</chart:SfCircularChart.Legend>
 ```

[C#]
 ```csharp
chart.Legend = new ChartLegend()
{ 
    Placement = LegendPlacement.Bottom ,
    ToggleSeriesVisibility = true 
}; 
 ```
 
In the screenshot below you can observe that the Thailand segment is disabled.

 ![LegendToggleSeriesVisibilityImage](https://support.syncfusion.com/kb/agent/attachment/article/18792/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM1MjE1Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.Zt85M1UVgVmWEyyPOHLXayuZjajHDdJUUIxHNC2bmqc)

**Legend item visibility**

The visibility of individual legend items for specific series can be controlled using the [IsVisibleOnLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html?tabs=tabid-9%2Ctabid-11%2Ctabid-5%2Ctabid-7%2Ctabid-18%2Ctabid-1%2Ctabid-22%2Ctabid-24%2Ctabid-16%2Ctabid-20%2Ctabid-14%2Ctabid-13%2Ctabid-3#Syncfusion_Maui_Charts_ChartSeries_IsVisibleOnLegend) property of the series. Can disable the legend for particular series using this property.
 
[XAML]
 ```xml
<chart:SfCircularChart>
    <chart:SfCircularChart.Legend>
        <chart:ChartLegend/>
    </chart:SfCircularChart.Legend>

    <chart:PieSeries ItemsSource="{Binding Data}"
                     XBindingPath="Country"
                     IsVisibleOnLegend="True"
                     YBindingPath="Value"
                     PaletteBrushes="{Binding CustomBrushes}"/>
</chart:SfCircularChart> 
 ```

[C#]
 ```csharp
SfCircularChart chart = new SfCircularChart();

chart.Legend = new ChartLegend();
ViewModel viewModel = new ViewModel();

PieSeries pieSeries = new PieSeries()
{
    ItemsSource = viewModel.Data,
    XBindingPath = "Country",
    YBindingPath = "Value",
    PaletteBrushes = viewModel.CustomBrushes,
    IsVisibleOnLegend = true,
};

chart.Series.Add(pieSeries);
this.Content = chart; 
 ```

 ![IsVisibleOnLegend](https://support.syncfusion.com/kb/agent/attachment/article/18792/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM0ODU2Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.ScOM3vo6FrOOHQK84o0G2_CsY9LX9YFLyYywDTapoIE)

**Legend maximum size request**

The [GetMaximumSizeCoefficient](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html?tabs=tabid-1%2Ctabid-3%2Ctabid-7%2Ctabid-12%2Ctabid-13%2Ctabid-5%2Ctabid-10%2Ctabid-15#Syncfusion_Maui_Charts_ChartLegend_GetMaximumSizeCoefficient) protected function of the ChartLegend class must be overridden in order to set the maximum size request for the legend view. The value should be between 0 and 1.

[XAML]
 ```xml
<chart:SfCircularChart.Legend>
    <local:LegendExt/>
</chart:SfCircularChart.Legend> 
 ```

[C#]
 ```csharp
public class LegendExt : ChartLegend
 {
     // Override the GetMaximumSizeCoefficient method to customize the legend size
     protected override double GetMaximumSizeCoefficient()
     {
         return 0.2;
     }
 } 
 ```
 
As you can see in the screenshot below, the legend view has been reduced in size due to the large number of data elements
 
 ![LegendMaximumSizeRequestImage](https://support.syncfusion.com/kb/agent/attachment/article/18792/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM1MjE0Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.zOifIwhl07TTBamS6Q9Y4g3d3DC-L1fX-ejA5JoFYzk)

**Items layout Customization**

Each legend item's position and arrangement can be customized using the [ItemsLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html?tabs=tabid-1%2Ctabid-3%2Ctabid-7%2Ctabid-12%2Ctabid-13%2Ctabid-5%2Ctabid-10%2Ctabid-15#Syncfusion_Maui_Charts_ChartLegend_ItemsLayout) property. Any layout type can be used with this feature.
 
[XAML]
 ```xml
<chart:SfCircularChart.Legend>
    <chart:ChartLegend>
        <chart:ChartLegend.ItemsLayout>
            <FlexLayout Wrap="Wrap"
                        WidthRequest="350">
            </FlexLayout>
        </chart:ChartLegend.ItemsLayout>
    </chart:ChartLegend>
</chart:SfCircularChart.Legend> 
 ```

[C#]
 ```csharp
SfCircularChart chart = new SfCircularChart();
. . .
ChartLegend legend = new ChartLegend();
legend.ItemsLayout = new FlexLayout()
{
    Wrap = FlexWrap.Wrap,
    WidthRequest = 350
};

chart.Legend = legend;
this.Content = chart; 
 ```
 In the screenshot below, you can observe that the legend layout is customized using FlexLayout. The legend will wrap if it exceeds the WidthRequest.

 ![LegendItemLayoutImage](https://support.syncfusion.com/kb/agent/attachment/article/18792/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM0ODUyIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.AM8hPpSyjvyRY61H2r8TZZGKYeQxCIIuR7kMwqKczV4)

**Item Template Customization**

To customize the appearance of legend items, can utilize the [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html?tabs=tabid-1%2Ctabid-3%2Ctabid-7%2Ctabid-12%2Ctabid-13%2Ctabid-5%2Ctabid-10%2Ctabid-15#Syncfusion_Maui_Charts_ChartLegend_ItemTemplate) property. This allows to define how each item in the legend should be displayed.

 [XAML]
 ```xml
 <chart:SfCircularChart.Resources>
     <DataTemplate x:Key="legendTemplate">
         <Grid ColumnDefinitions="20,80,Auto" VerticalOptions="Center">
             <BoxView Grid.Column="0" 
                      HeightRequest="15" 
                      WidthRequest="15"
                      Margin="0,0,0,15"
                      Background="{Binding IconBrush}" 
                      VerticalOptions="Center"/>

             <Label Grid.Column="1"
                    Text="{Binding Item.Country}"
                    Margin="0,0,5,15"
                    Padding="0,0,0,3"
                    HorizontalTextAlignment="Start"
                    FontSize="14"
                    VerticalOptions="Center"/>

             <Label Grid.Column="2"
                    Text="{Binding Item.Value, StringFormat='{0}M'}"
                    FontSize="14"
                    HorizontalTextAlignment="End"
                    Margin="0,0,50,15"
                    Padding="0,0,0,3"
                    VerticalOptions="Center"/>
         </Grid>
     </DataTemplate>
 </chart:SfCircularChart.Resources>

<chart:SfCircularChart.Legend>
    <chart:ChartLegend Placement="Right" ItemTemplate="{StaticResource legendTemplate}">
    </chart:ChartLegend>
</chart:SfCircularChart.Legend> 
 ```

[C#]
 ```csharp
SfCircularChart chart = new SfCircularChart();
ChartLegend legend = new ChartLegend();
legend.ItemTemplate = chart.Resources["legendTemplate"] as DataTemplate;
...
chart.Legend = legend;
this.Content = chart; 
 ```

 You can observe the customized chart legend items in the screenshot below.

 ![LegendItemTemplateImage](https://support.syncfusion.com/kb/agent/attachment/article/18792/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM0OTczIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.CWrC6Dy_CNOTuoUQVHyU85i-NmrWIeVEaSGBdpOdX1I)

**Troubleshooting:**

###### Path too long exception

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

For more details, refer to the KB on How to use legend and its related features in .NET MAUI SfCircularChart ?