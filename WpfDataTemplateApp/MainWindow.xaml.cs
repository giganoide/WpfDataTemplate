using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfDataTemplateApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string LabelExample { get; set; }
        public ObservableCollection<IMacchina> ListSource { get; set; }
        public MainWindow()
        {
            this.DataContext = this;
            LabelExample = "Prova";
            ListSource = new ObservableCollection<IMacchina> {new Fresa(), new Tornio(), new Combinato(), new Combinato(), new Fresa(), new Fresa(), new Fresa()};
            InitializeComponent();
        }
    }
}
