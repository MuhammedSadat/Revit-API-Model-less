using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using ERevit.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERevit.RevitSystem.Command
{
    [Transaction(TransactionMode.Manual)]
    public class OpenWindowCommand : IExternalCommand
    {
        public static Document doc { get; set; }
        private static ExternalEvent exEvent;
        private static MyExternalEventHandler handler;

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            doc = uidoc.Document;

            try
            {
                // Initialize the handler and external event if not already done
                if (handler == null || exEvent == null)
                {
                    handler = new MyExternalEventHandler();
                    exEvent = ExternalEvent.Create(handler);
                }

                // Open or focus the modeless form
                MainUi mainui = new MainUi(exEvent, handler); // Ensure your MainUi class can accept these parameters
                mainui.Show();

                return Result.Succeeded;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Result.Failed;
            }
        }
    }
}

