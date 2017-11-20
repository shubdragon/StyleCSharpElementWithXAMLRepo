using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Text;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SO
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        HyperlinkButton hLinkButton = new HyperlinkButton();

        public MainPage()
        {
            this.InitializeComponent();

            //Style style = new Style { TargetType = typeof(HyperlinkButton) };
            //style.Setters.Add(new Setter(ForegroundProperty, new SolidColorBrush(Colors.Red)));
            //style.Setters.Add(new VisualState( (ForegroundProperty, new SolidColorBrush(Colors.Red)));
            //style.Setters.Add(new Setter(UIElement.VisibilityProperty, Visibility.Collapsed));

            //Application.Current.Resources["key1"] = style;

           /* DispatcherTimer timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(0) };
            timer.Tick += delegate (object sender, object e)
            {
                //VisualStateManager.GoToState(hLinkButton, "PointerOver", true)
               
                if (hLinkButton.IsPointerOver == true)
                {                   
                    hLinkButton.Foreground = new SolidColorBrush(Colors.Red);
                    LayoutGrid.Background = new SolidColorBrush(Colors.Violet);
                    LayoutGrid.Background = new SolidColorBrush(Colors.Bisque);
                }
                else
                {
                    LayoutGrid.Background = new SolidColorBrush(Colors.White);
                }
            };
            timer.Start();*/

            // var hLinkButton = new HyperlinkButton();

            hLinkButton.Name = "LearnMoreHyperLink";
            hLinkButton.Content = "Learn More...";
            //style i am using
            hLinkButton.Style = (Style)App.Current.Resources["MyHyperlinkButtonStyle"];
            hLinkButton.Background = new SolidColorBrush(Colors.Red);
            hLinkButton.Foreground = new SolidColorBrush(Colors.White);
            hLinkButton.FontWeight = FontWeights.SemiBold;
            hLinkButton.FontSize = 18.0;
            hLinkButton.HorizontalAlignment = HorizontalAlignment.Center;
            hLinkButton.VerticalAlignment = VerticalAlignment.Center;
            
            hLinkButton.PointerEntered += OnPointerEntered;
            // if you want to reverse back all thing on pointer out or moved you can use thi event.
            hLinkButton.PointerExited += HLinkButton_PointerExited;
            LayoutGrid.Children.Add(hLinkButton);            
        }        

        private void OnPointerEntered(object sender, PointerRoutedEventArgs e)
        {
            
            //var hLButton = sender as HyperlinkButton;
            hLinkButton.Background = new SolidColorBrush(Colors.White);
            hLinkButton.Foreground = new SolidColorBrush(Colors.Red);
            hLinkButton.FontSize = 30.0;
        }

        private void HLinkButton_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            hLinkButton.Background = new SolidColorBrush(Colors.Red);
            hLinkButton.Foreground = new SolidColorBrush(Colors.White);
            hLinkButton.FontSize = 18.0;
        }
    }
}