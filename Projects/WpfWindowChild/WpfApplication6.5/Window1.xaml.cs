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
using System.Windows.Shapes;

namespace WpfApplication6._5
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private static Window1 _instance;
        public static Window1 Instance
        {
            get {
                if (_instance == null)
                {
                    _instance = new Window1();
                }
                return _instance;
            }
        }
        private Window1()
        {
            InitializeComponent();
            this.Closed+=Window1_Closed ;
        }

        private void Window1_Closed(object sender, EventArgs e)
        {
            _instance = null;
        }
    }
}
