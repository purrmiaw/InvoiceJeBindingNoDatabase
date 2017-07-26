using System;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using InvoiceJe.Models;
using System.Collections.Generic;
using System.Linq;
using InvoiceJe.Data;

namespace InvoiceJe.Droid.Fragments
{
    public class InvoicesFragment : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.invoices_fragment, container, false);

            var repository = new Repository();
            var invoices = repository.GetInvoices();

            RecyclerView recyclerView = view.FindViewById<RecyclerView>(Resource.Id.recyclerView);
            LinearLayoutManager layoutManager = new LinearLayoutManager(view.Context);
            recyclerView.SetLayoutManager(layoutManager);
            InvoicesRecyclerViewAdapter adapter = new InvoicesRecyclerViewAdapter(invoices);
            //adapter.ItemClick += OnItemClick; // register onItemClick
            recyclerView.SetAdapter(adapter);

            // divider
            // ref: https://stackoverflow.com/questions/24618829/how-to-add-dividers-and-spaces-between-items-in-recyclerview
            recyclerView.AddItemDecoration(new DividerItemDecoration(view.Context, DividerItemDecoration.Vertical));

            return view;
        }

        //void OnItemClick(object sender, int position)
        //{
        //    int photoNum = position + 1;
        //    Toast.MakeText(this.Context, "This is invoice " + photoNum.ToString(), ToastLength.Short).Show();
        //}
    }

    public class InvoiceRecyclerViewViewHolder : RecyclerView.ViewHolder
    {
        public TextView ReferenceNumber { get; private set; }
        public TextView InvoiceAmount { get; private set; }
        public TextView BillTo { get; private set; }

        // A Constructor with No clicks
        public InvoiceRecyclerViewViewHolder(View itemView) : base(itemView)
        {
            ReferenceNumber = itemView.FindViewById<TextView>(Resource.Id.invoiceReferenceNumber);
            BillTo = itemView.FindViewById<TextView>(Resource.Id.billTo);
            InvoiceAmount = itemView.FindViewById<TextView>(Resource.Id.invoiceAmount);
        }

        // A constructor with clicks
        //public InvoiceRecyclerViewViewHolder(View itemView, Action<int> listener) : base (itemView)
        //{
        //    ReferenceNumber = itemView.FindViewById<TextView>(Resource.Id.invoiceReferenceNumber);
        //    BillTo = itemView.FindViewById<TextView>(Resource.Id.billTo);
        //    InvoiceAmount = itemView.FindViewById<TextView>(Resource.Id.invoiceAmount);

        //    ItemView.Click += (sender, e) => listener(AdapterPosition);
        //}
    }

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
            invoiceViewHolder.ReferenceNumber.Text = "Invoice #" + _invoices.OrderBy(x => x.ReferenceNumber).ElementAt(position).ReferenceNumber;
            invoiceViewHolder.BillTo.Text = _invoices.OrderBy(x => x.ReferenceNumber).ElementAt(position).BillTo.ToString();
            invoiceViewHolder.InvoiceAmount.Text = "RM " + _invoices.OrderBy(x => x.ReferenceNumber).ElementAt(position).Amount.ToString();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {

            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.recyclerview_invoice, parent, false);

            //InvoiceRecyclerViewViewHolder invoiceViewHolder = new InvoiceRecyclerViewViewHolder(itemView, OnClick);
            InvoiceRecyclerViewViewHolder invoiceViewHolder = new InvoiceRecyclerViewViewHolder(itemView);

            return invoiceViewHolder;

        }

        //public event EventHandler<int> ItemClick;

        //void OnClick(int position)
        //{
        //    if (ItemClick != null)
        //    {
        //        ItemClick(this, position);
        //    }
        //}

    }

}