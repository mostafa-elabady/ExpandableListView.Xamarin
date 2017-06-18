using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ExpandableListView
{
    public partial class CollapsibleControl : ContentView
    {
        private ViewCell _parentViewCell;

        public CollapsibleControl()
        {
            InitializeComponent();
            HeaderGrid.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    ToggleFrameVisibility();
                })
            });
        }

        private void ToggleFrameVisibility()
        {
            frame.IsVisible = !frame.IsVisible;
            if (_parentViewCell == null)
            {
                _parentViewCell = getParentViewCell();
            }

            if (_parentViewCell != null)
            {
                _parentViewCell.ForceUpdateSize();
            }
        }



        private ViewCell getParentViewCell()
        {
            try
            {
                Element currentView = this;
                for (int i = 0; i < 5; i++)
                {
                    currentView = currentView.Parent;
                    if (currentView is ViewCell)
                        return currentView as ViewCell;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == ExpandedViewProperty.PropertyName)
            {
                frame.Content = ExpandedView;
            }
            if (propertyName == TitleProperty.PropertyName)
            {
                TitleLabel.Text = Title;
            }
            else if (propertyName == SubtitleProperty.PropertyName)
            {
                if (string.IsNullOrEmpty(Subtitle))
                {
                    SubtitleLabel.IsVisible = false;
                }
                else
                {
                    SubtitleLabel.TextColor = SubtitleTextColor;
                    SubtitleLabel.Text = Subtitle;
                    SubtitleLabel.IsVisible = true;

                }
            }
            else if (propertyName == SubtitleTextColorProperty.PropertyName)
            {
                SubtitleLabel.TextColor = SubtitleTextColor;
            }
        }


        #region ExpandedView property       
        public static readonly BindableProperty ExpandedViewProperty =
                   BindableProperty.Create("ExpandedView", typeof(View), typeof(CollapsibleControl), default(View), propertyChanged: OnExpandedViewChanged);

        private static void OnExpandedViewChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // ExpandedView Property changed implementation goes here
        }

        public View ExpandedView
        {
            get { return (View)GetValue(ExpandedViewProperty); }
            set { SetValue(ExpandedViewProperty, value); }
        }
        #endregion


        #region Title property       
        public static readonly BindableProperty TitleProperty =
                   BindableProperty.Create("Title", typeof(string), typeof(CollapsibleControl), default(string), propertyChanged: OnTitleChanged);

        private static void OnTitleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Title Property changed implementation goes here
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        #endregion



        #region Subtitle property       
        public static readonly BindableProperty SubtitleProperty =
                   BindableProperty.Create("Subtitle", typeof(string), typeof(CollapsibleControl), default(string), propertyChanged: OnSubtitleChanged);

        private static void OnSubtitleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Subtitle Property changed implementation goes here
        }

        public string Subtitle
        {
            get { return (string)GetValue(SubtitleProperty); }
            set { SetValue(SubtitleProperty, value); }
        }
        #endregion




        #region SubtitleTextColor property       
        public static readonly BindableProperty SubtitleTextColorProperty =
                   BindableProperty.Create("SubtitleTextColor", typeof(Color), typeof(CollapsibleControl), Color.White, propertyChanged: OnSubtitleTextColorChanged);

        private static void OnSubtitleTextColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // SubtitleTextColor Property changed implementation goes here
        }

        public Color SubtitleTextColor
        {
            get { return (Color)GetValue(SubtitleTextColorProperty); }
            set { SetValue(SubtitleTextColorProperty, value); }
        }
        #endregion
    }
}
