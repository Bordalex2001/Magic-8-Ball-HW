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

namespace Magic_8_Ball_HW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region IView Implementation
        public string Question
        {
            get { return questionTxtBox.Text; }
            set { questionTxtBox.Text = value; }
        }

        public string Answer
        {
            get { return answerTxtBox.Text; }
            set { answerTxtBox.Text = value; }
        }
        #endregion

        public event EventHandler<EventArgs> Ask;
        
        private void askBtn_Click(object sender, RoutedEventArgs e)
        {
            Ask?.Invoke(this, EventArgs.Empty);
        }
    }
}
