using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace R6Config
{
    /// <summary>
    /// Interaction logic for moussens.xaml
    /// </summary>
    public partial class moussens : Window
    {
        public moussens()
        {
            InitializeComponent();
        }

        private void btn_sens_Click(object sender, RoutedEventArgs e)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (!IsNumeric(txt_sens.Text.Replace(" ","")))
            {
                MessageBox.Show("Please enter only numbers");
                return;
            }
            else
            {
                string directoryPath = documentsPath + @"\My Games\Rainbow Six - Siege";
                string newValue = txt_sens.Text.Replace(" ","");

                change_server modifier = new change_server();
                modifier.Replacesens(directoryPath, newValue);
            }
        }
        private bool IsNumeric(string text)
        {
            return Regex.IsMatch(text, @"^[0-9]+(\.[0-9]+)?$");
        }
    }

    
}
