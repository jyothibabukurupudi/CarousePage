using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6
{

    public class model
    {
        public string Name { get; set; }
    }
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            InitializeComponent();

            ItemsSource= new List<model> { 
                new model{Name="hello"},
                new model {Name="hi"},
                new model{Name="hello"},
                new model{Name="hello"},
                new model{Name="hello"},
            };
                
        }
    }
}
