using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Modal
{
    /// <summary>
    /// Lógica de interacción para CustomModal.xaml
    /// </summary>
    public partial class CustomModal : UserControl
    {


        public string TitleModal
        {
            get { return (string)GetValue(TitleModalProperty); }
            set { SetValue(TitleModalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TitleModal.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleModalProperty =
            DependencyProperty.Register("TitleModal", typeof(string), typeof(CustomModal));



        public string MessageBody
        {
            get { return (string)GetValue(MessageBodyProperty); }
            set { SetValue(MessageBodyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MessageBody.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MessageBodyProperty =
            DependencyProperty.Register("MessageBody", typeof(string), typeof(CustomModal));



        public CustomModal()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Visibility=Visibility.Collapsed;
        }
    }
}
