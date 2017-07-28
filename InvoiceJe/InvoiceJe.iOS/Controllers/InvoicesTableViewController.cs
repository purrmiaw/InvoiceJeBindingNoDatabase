//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Foundation;
//using UIKit;
//using InvoiceJe.Models;
//using InvoiceJe.Data;

//namespace InvoiceJe.iOS.Controllers
//{
//    public class InvoicesTableViewController : UITableViewController
//    {
//        public override void ViewDidLoad()
//        {
//            base.ViewDidLoad();
//        }

//        public override void ViewWillAppear(bool animated)
//        {
//            base.ViewWillAppear(animated);

//            var repository = new Repository();
//            TableView.Source = new InvoicesTableSource(repository.GetInvoices());
//        }
//    }

//    public class InvoicesTableSource : UITableViewSource
//    {

//        private IEnumerable<Invoice> _invoices;
//        private string _cellIdentifier = "TaskCell";

//        public InvoicesTableSource(IEnumerable<Invoice> invoices)
//        {
//            _invoices = invoices;
//        }

//        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
//        {
//            UITableViewCell cell = tableView.DequeueReusableCell(_cellIdentifier);

//            // If there are no cells to reuse, create a new one
//            if (cell == null)
//            {
//                cell = new UITableViewCell(UITableViewCellStyle.Default, _cellIdentifier);
//            }

//            Invoice invoice = _invoices.ElementAt(indexPath.Row);
//            cell.TextLabel.Text = invoice.ReferenceNumber;

//            return cell;
//        }

//        public override nint RowsInSection(UITableView tableview, nint section)
//        {
//            return _invoices.Count();
//        }
//    }
//}