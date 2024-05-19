using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERevit.RevitSystem
{
    public class MyExternalEventHandler : IExternalEventHandler
    {
        public void Execute(UIApplication app)
        {
            // Access the Revit API here, app provides the context
            TaskDialog.Show("Event Triggered", "This is an external event response.");
        }

        public string GetName()
        {
            return "SimpleExternalEventHandler";
        }
    }


}
