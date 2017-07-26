using System.Collections.Generic;
using System.Linq;
using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
using InvoiceJe.Models;
using System;

namespace InvoiceJe.Droid.Adapters
{
    public class InvoicesRecyclerViewAdapter : RecyclerView.Adapter
    {

        private IEnumerable<Invoice> _invoices;

        public InvoicesRecyclerViewAdapter(IEnumerable<Invoice> invoices)
        {
            _invoices = invoices;
        }

        public override int ItemCount => _invoices.Count();

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            InvoiceRecyclerViewViewHolder invoiceViewHolder = holder as InvoiceRecyclerViewViewHolder;

            var currentInvoice = _invoices.OrderBy(x => x.ReferenceNumber).ElementAt(position);
            invoiceViewHolder.ReferenceNumber.Text = "Invoice #" + currentInvoice.ReferenceNumber;
            invoiceViewHolder.BillTo.Text = currentInvoice.BillTo.ToString();
            invoiceViewHolder.InvoiceAmount.Text = "RM " + currentInvoice.Amount.ToString();
            invoiceViewHolder.InvoiceId = currentInvoice.Id;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {

            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.recyclerview_invoice, parent, false);

            //InvoiceRecyclerViewViewHolder invoiceViewHolder = new InvoiceRecyclerViewViewHolder(itemView); // No clicks
            InvoiceRecyclerViewViewHolder invoiceViewHolder = new InvoiceRecyclerViewViewHolder(itemView, OnClick); // With clicks

            return invoiceViewHolder;
        }

        public event EventHandler<int> ItemClick;

        void OnClick(int invoiceId)
        {
            if (ItemClick != null)
            {
                ItemClick(this, invoiceId);
            }
        }

    }

    public class InvoiceRecyclerViewViewHolder : RecyclerView.ViewHolder
    {
        public TextView ReferenceNumber { get; private set; }
        public TextView InvoiceAmount { get; private set; }
        public TextView BillTo { get; private set; }
        public int InvoiceId { get; set; }

        //// A Constructor with No clicks
        //public InvoiceRecyclerViewViewHolder(View itemView) : base(itemView)
        //{
        //    ReferenceNumber = itemView.FindViewById<TextView>(Resource.Id.invoiceReferenceNumber);
        //    BillTo = itemView.FindViewById<TextView>(Resource.Id.billTo);
        //    InvoiceAmount = itemView.FindViewById<TextView>(Resource.Id.invoiceAmount);
        //}

        //A constructor with clicks
        public InvoiceRecyclerViewViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            ReferenceNumber = itemView.FindViewById<TextView>(Resource.Id.invoiceReferenceNumber);
            BillTo = itemView.FindViewById<TextView>(Resource.Id.billTo);
            InvoiceAmount = itemView.FindViewById<TextView>(Resource.Id.invoiceAmount);

            ItemView.Click += (sender, e) => listener(InvoiceId);
        }
    }

}