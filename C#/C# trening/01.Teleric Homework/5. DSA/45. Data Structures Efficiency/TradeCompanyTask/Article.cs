using System;
namespace TradeCompanyTask
{

    public class Article : IComparable<Article>
    {
        public int Barcode { get; set; }
        public string Vendor { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        public Article(int barcode, string vendor, string title, int price)
        {
            this.Barcode = barcode;
            this.Vendor = vendor;
            this.Title = title;
            this.Price = price;
        }

        public int CompareTo(Article other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return string.Format("{0}       {1}     {2}     {3}", this.Barcode, this.Vendor, this.Title, this.Price);
        }
    }
}
