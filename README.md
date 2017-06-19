# ExpandableListView.Xamarin
Xamarin forms example for ExpandableListView without any renderers

The idea is very simple, I have a ```ListView``` with ```HasUnevenRows="True"```
and the ViewCell is CollapsibleControl (A custom ContentView)

```XAML
<local:CollapsibleControl  HorizontalOptions="Fill" VerticalOptions="Fill"
                                         Title="{Binding Title}" Subtitle="{Binding SubTitle}" SubtitleTextColor="White" >
                <local:CollapsibleControl.ExpandedView>
                  <Grid HorizontalOptions="Fill" VerticalOptions="Fill" Padding="12" BackgroundColor="#e2e2e2">
                    <Grid.RowDefinitions>
                      <RowDefinition Height="Auto"/>
                      <RowDefinition Height="Auto"/>
                    </Grid.RowDefinitions>
                    <Label Grid.Row="0" Text="Details text " FontSize="Small" TextColor="{StaticResource DarkColor}"/>
                    <Label Grid.Row="1" Text="Details text  2 " FontSize="Small" TextColor="{StaticResource DarkColor}"/>
                  </Grid>
                </local:CollapsibleControl.ExpandedView>
              </local:CollapsibleControl>
```              

The CollapsibleControl consists of title, subtitle, epand icon, collapse icon, and a frame for the ExpandedView.


###  Screen shots ###

![Alt text](/screenshots/android.gif?raw=true "Android")



### TODO ###
1. Add animation for showing and hiding the content.




