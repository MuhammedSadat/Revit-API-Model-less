using ERevit.ViewModel;
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
using System.Windows;
using Autodesk.Revit.UI;
using ERevit.RevitSystem;
namespace ERevit.View
{
    

    public partial class MainUi : Window
    {
        private ExternalEvent exEvent;
        private MyExternalEventHandler handler;

        public MainUi(ExternalEvent exEvent, MyExternalEventHandler handler)
        {
            InitializeComponent();
            this.exEvent = exEvent;
            this.handler = handler;
        }

        private void BtnCommand1_Click(object sender, RoutedEventArgs e)
        {
            // Set some value or command type in the handler or a shared location
            RevitRequestHandler.Request = RevitRequestType.Command1;
            exEvent.Raise();  // This will call the handler's Execute method asynchronously
        }

        private void BtnCommand2_Click(object sender, RoutedEventArgs e)
        {
            RevitRequestHandler.Request = RevitRequestType.Command2;
            exEvent.Raise();  // This will call the handler's Execute method asynchronously
        }
    }
}
