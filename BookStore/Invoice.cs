using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public struct Invoice
    {
        private int code;
        private DateTime releaseDate;
        private DateTime buyDate;
        private double price;
        private String buyer;
        
        public int _code
        {
            get { return code; }
            set { code = value; }
        }
        public DateTime _releaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
        public DateTime _buyDate
        {
            get { return buyDate; }
            set { buyDate = value; }
        }
        public double _price
        {
            get { return price; }
            set { price = value; }
        }
        public String _buyer
        {
            get { return buyer; }
            set { buyer = value; }
        }

        public List<Invoice> AddInvoice(List<Invoice> lst, int _code, DateTime _releaseDate, DateTime _buyDate, double _price, String _buyer)
        {
            Invoice invoice = new Invoice();
            
            invoice.code = _code;
            invoice.releaseDate = _releaseDate;
            invoice.buyDate = _buyDate;
            invoice.price = _price;
            invoice.buyer = _buyer;
            lst.Add(invoice);
            return lst;
        }
        
        public List<Invoice> FindInvoice(List<Invoice> lst, int _code, DateTime _releaseDate, DateTime _buyDate, string _buyer)
        {
           
            lst = lst.Where(invoice =>
                invoice.code.Contains(_code) ||
                invoice.buyer.Contains(_buyer)
            ).ToList(); 
            return lst;

        }

        public void EditInvoice(List<Invoice> lst, int _code, DateTime _releaseDate, DateTime _buyDate, string _buyer)
        {
            Invoice foundedIdx = lst.Single(item => item._code == _code);
            
            foundedIdx._code = _code;
            foundedIdx._releaseDate = _releaseDate;
            foundedIdx._buyDate = _buyDate;
            foundedIdx._buyer = _buyer;

        }

        public List<Invoice> RemoveInvoiceByCode(List<Invoice> lst, int code)
        {
            List<Invoice> rawLst = new List<Invoice>();
            rawLst = lst.Where(invoice => invoice._code != code).ToList();
            return rawLst;

        }

    }
}