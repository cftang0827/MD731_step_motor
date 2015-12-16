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
using System.IO.Ports;
using System.Windows.Shapes;



namespace Motor
{
    
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        SerialPort motor;
       
        

        public MainWindow()
        {
            InitializeComponent();
            downButton.IsEnabled = false;
            upButton.IsEnabled = false;

            string[] serialPorts = SerialPort.GetPortNames();
            foreach(string i in serialPorts )
            {
                comName.Items.Add(i);
                if(comName.Items.Count > 0)
                {
                    comName.SelectedIndex = 0;
                }
                
            }
            
        }

        private void down(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(downNum.Text);
            //Console.WriteLine("123");
            char t = 'a';
            string t1 = t.ToString();
            for(int i = 0; i < num; i++)
            {
                motor.WriteLine(t1);
            }
            
        }

        private void startConnection(object sender, RoutedEventArgs e)
        {

            string com = comName.SelectedItem.ToString();
            motor = new SerialPort(com, 9600);
            motor.Open();
            //.IsEnabled = false;
            startButton.IsEnabled = false;
            //comInput.IsEnabled = false;
            downButton.IsEnabled = true;
            upButton.IsEnabled = true;
        }

        private void up(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(upNum.Text);
            Console.WriteLine("123");
            char t = 'a';
            string t1 = t.ToString();
            for (int i = 0; i < num; i++)
            {
                motor.WriteLine(t1);
            }
            startButton.IsEnabled = true;
        }

        

        private void f5button(object sender, RoutedEventArgs e)
        {
            
            string[] serialPorts = SerialPort.GetPortNames();
            comName.Items.Clear();
            foreach (string i in serialPorts)
            {
                comName.Items.Add(i);
                if (comName.Items.Count > 0)
                {
                    comName.SelectedIndex = 0;
                }

            }
            startButton.IsEnabled = true;

        }



    }
}
