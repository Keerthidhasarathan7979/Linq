using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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

namespace linqquery
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
        

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //   


        //    MessageBoxResult res = MessageBox.Show("Registered Successfully", "Success", MessageBoxButton.OKCancel, MessageBoxImage.Information);

        //}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ArrayList kl = new ArrayList();
               kl.Add(txtname.Text);
               kl.Add(txtage.Text);
               kl.Add(txtemail.Text);
               kl.Add(txtpswd.Text);

            kl.Add(kl);
            listview.ItemsSource = kl;

            MessageBoxResult result = MessageBox.Show("Successfully Saved", "Saved", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        //    kls.Add(txtname.Text);
        //    kls.Add(txtage.Text);
        //    kls.Add(txtemail.Text);
        //    kls.Add(txtpswd.Text);

        //    kls.Add(kls);
        //    listview.ItemsSource = kl;
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{


        //ArrayList kl = new ArrayList();
        //kl.Add("keerthi");
        //kl.Add("sakthi");
        //kl.Add(199);
        //kl.Add(true);
        //kl.Add(new student { sid = 10, name = "subu" });


        //string val = "";

        //foreach (var item in  kl)
        //{
        //val += "\n" + item;
        //}

        //MessageBox.Show(val.ToString(), "LinqQuery");

        // }

    }

}
