using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExpandableListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ItemsListView.ItemsSource = new List<RowItem>()
            {
                new RowItem () {
                     Title = "Title 1",
                     SubTitle = "Subtitle 1"
                },
                new RowItem () {
                     Title = "Title 2",
                     SubTitle = "Subtitle 2"
                },
                new RowItem () {
                     Title = "Title 3",
                     SubTitle = "Subtitle 3"
                },
                new RowItem () {
                     Title = "Title 4",
                     SubTitle = "Subtitle 4"
                },
                new RowItem () {
                     Title = "Title 5",
                     SubTitle = "Subtitle 5"
                },
                new RowItem () {
                     Title = "Title 6",
                     SubTitle = "Subtitle 6"
                },
            };
        }
    }
}
