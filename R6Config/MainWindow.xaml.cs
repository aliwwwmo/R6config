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
using System.Diagnostics;


namespace R6Config
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            server show_server = new server();
            show_server.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            moussens show_mouse = new moussens();
            show_mouse.Show();
        }

        private void freez_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName("RainbowSix");
                if (processes.Length > 0)
                {
                    foreach (Process process in processes)
                    {
                        int cpuCount = Environment.ProcessorCount;
                        process.ProcessorAffinity = (IntPtr)1;  // CPU 0 on
                        process.ProcessorAffinity = (IntPtr)((1 << cpuCount) - 1); // All processors on
                    }
                    MessageBox.Show("It was successful for RainbowSix");
                }
                else
                {
                    MessageBox.Show("RainbowSix is not running.");
                }

                Process[] processes2 = Process.GetProcessesByName("RainbowSix_BE");
                if (processes2.Length > 0)
                {
                    foreach (Process process in processes2)
                    {
                        int cpuCount = Environment.ProcessorCount;
                        process.ProcessorAffinity = (IntPtr)1;  // CPU 0 on
                        process.ProcessorAffinity = (IntPtr)((1 << cpuCount) - 1); // All processors on
                    }
                    MessageBox.Show("It was successful for RainbowSix_BE");
                }
                else
                {
                    MessageBox.Show("RainbowSix_BE is not running.");
                }
            }
            catch
            {
                MessageBox.Show("Something is wrong");
            }
           
        }
    }
}
