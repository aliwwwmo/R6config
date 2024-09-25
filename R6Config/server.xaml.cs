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
using System.IO;
using System.Text.RegularExpressions;



namespace R6Config
{
    /// <summary>
    /// Interaction logic for server.xaml
    /// </summary>
    public partial class server : Window
    {
        public server()
        {
            InitializeComponent();
        }
        string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string directoryPath = documentsPath +@"\My Games\Rainbow Six - Siege";
            string newValue = "default";


            change_server modifier = new change_server();
            modifier.ReplaceDataCenterHint(directoryPath, newValue);

        }

        private void australia_Click(object sender, RoutedEventArgs e)
        {
            string directoryPath = documentsPath + @"\My Games\Rainbow Six - Siege";
            string newValue = "playfab/australiaeast";

            change_server modifier = new change_server();
            modifier.ReplaceDataCenterHint(directoryPath, newValue);

        }

        private void brazilso_Click(object sender, RoutedEventArgs e)
        {
            string directoryPath = documentsPath + @"\My Games\Rainbow Six - Siege";
            string newValue = "playfab/brazilsouth";

            change_server modifier = new change_server();
            modifier.ReplaceDataCenterHint(directoryPath, newValue);
        }


        private void cenus_Click_2(object sender, RoutedEventArgs e)
        {
            string directoryPath = documentsPath + @"\My Games\Rainbow Six - Siege";
            string newValue = "playfab/centralus";

            change_server modifier = new change_server();
            modifier.ReplaceDataCenterHint(directoryPath, newValue);
        }

        private void eastasia_Click(object sender, RoutedEventArgs e)
        {
            string directoryPath = documentsPath + @"\My Games\Rainbow Six - Siege";
            string newValue = "playfab/eastasia";

            change_server modifier = new change_server();
            modifier.ReplaceDataCenterHint(directoryPath, newValue);
        }

        private void eastus_Click(object sender, RoutedEventArgs e)
        {
            string directoryPath = documentsPath + @"\My Games\Rainbow Six - Siege";
            string newValue = "playfab/eastus";

            change_server modifier = new change_server();
            modifier.ReplaceDataCenterHint(directoryPath, newValue);
        }

        private void japan_Click(object sender, RoutedEventArgs e)
        {
            string directoryPath = documentsPath + @"\My Games\Rainbow Six - Siege";
            string newValue = "playfab/japaneast";

            change_server modifier = new change_server();
            modifier.ReplaceDataCenterHint(directoryPath, newValue);
        }

        private void northeu_Click(object sender, RoutedEventArgs e)
        {
            string directoryPath = documentsPath + @"\My Games\Rainbow Six - Siege";
            string newValue = "playfab/northeurope";

            change_server modifier = new change_server();
            modifier.ReplaceDataCenterHint(directoryPath, newValue);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string directoryPath = documentsPath + @"\My Games\Rainbow Six - Siege";
            string newValue = "playfab/southafricanorth";

            change_server modifier = new change_server();
            modifier.ReplaceDataCenterHint(directoryPath, newValue);
        }

        private void sous_Click(object sender, RoutedEventArgs e)
        {
            string directoryPath = documentsPath + @"\My Games\Rainbow Six - Siege";
            string newValue = "playfab/southcentralus";

            change_server modifier = new change_server();
            modifier.ReplaceDataCenterHint(directoryPath, newValue);
        }

        private void soasia_Click(object sender, RoutedEventArgs e)
        {
            string directoryPath = documentsPath + @"\My Games\Rainbow Six - Siege";
            string newValue = "playfab/southeastasia";

            change_server modifier = new change_server();
            modifier.ReplaceDataCenterHint(directoryPath, newValue);
        }

        private void uae_Click(object sender, RoutedEventArgs e)
        {
            string directoryPath = documentsPath + @"\My Games\Rainbow Six - Siege";
            string newValue = "playfab/uaenorth";

            change_server modifier = new change_server();
            modifier.ReplaceDataCenterHint(directoryPath, newValue);
        }

        private void westeu_Click(object sender, RoutedEventArgs e)
        {
            string directoryPath = documentsPath + @"\My Games\Rainbow Six - Siege";
            string newValue = "playfab/westeurope";

            change_server modifier = new change_server();
            modifier.ReplaceDataCenterHint(directoryPath, newValue);
        }

        private void westus_Click(object sender, RoutedEventArgs e)
        {
            string directoryPath = documentsPath + @"\My Games\Rainbow Six - Siege";
            string newValue = "playfab/westus";

            change_server modifier = new change_server();
            modifier.ReplaceDataCenterHint(directoryPath, newValue);
        }
    }
    
}
