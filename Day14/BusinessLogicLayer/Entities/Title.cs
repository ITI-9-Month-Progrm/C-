using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Entities
{
    public class Title:EntityBase
    {
		private string _title_id, _title, _type, _pub_id, _notes;
		private decimal? _price, _advance;
		private int? _royalty, _ytd_sales;
		private DateTime _pubdate;

		public string title_id {
			get { return _title_id; }
			set
			{
				if ((value != _title_id) && (_title_id is null))
				{
					_title_id = value;
					this.State = EntityState.Added;
				}
			}
		}
		public string title {
			get { return _title; }
            set
            {
				if((value != _title) && (this.State != EntityState.Added))
                {
					
					_title = value;
					this.State = EntityState.Modified;
				}else if ((value != _title) && (_title is null))
                {

					_title = value;
					this.State = EntityState.Added;
				}
            }
		}
		public string type
		{
			get { return _type; }
			set
			{
				if ((value != _type) && (this.State != EntityState.Added))
				{
					this.State = EntityState.Modified;
					_type = value;
				}
				else if ((value != _type) && (_type is null))
				{

					_type = value;
					this.State = EntityState.Added;
				}
			}
		}
		public string pub_id {
			get { return _pub_id; }
			set
			{
				if ((value != _pub_id) && (this.State != EntityState.Added))
				{
					this.State = EntityState.Modified;
					_pub_id = value;
				}
				else if ((value != _pub_id) && (_pub_id is null))
				{

					_pub_id = value;
					this.State = EntityState.Added;
				}
			}
		}
		public string notes {
			get { return _notes; }
			set
			{
				if ((value != _notes) && (this.State != EntityState.Added))
				{
					this.State = EntityState.Modified;
					_notes = value;
				}
				else if ((value != _notes) && (_notes is null))
				{

					_notes = value;
					this.State = EntityState.Added;
				}
			}
		}
		public Nullable<decimal> price {
			get { return _price; }
			set
			{
				if ((value != _price) && (this.State != EntityState.Added))
				{
					this.State = EntityState.Modified;
					_price = value;
				}
				else if ((value != _price) && (_price is null))
				{

					_price = value;
					this.State = EntityState.Added;
				}
			}
		}
		public Nullable<decimal> advance {
			get { return _advance; }
			set
			{
				if ((value != _advance) && (this.State != EntityState.Added))
				{
					this.State = EntityState.Modified;
					_advance = value;
				}
				else if ((value != _advance) && (_advance is null))
				{

					_advance = value;
					this.State = EntityState.Added;
				}
			}
		}
		public int? royalty {
			get { return _royalty; }
			set
			{
				if ((value != _royalty) && (this.State != EntityState.Added))
				{
					this.State = EntityState.Modified;
					_royalty = value;
				}
				else if ((value != _royalty) && (_royalty is null))
				{

					_royalty = value;
					this.State = EntityState.Added;
				}
			}
		}
		public int? ytd_sales {
			get { return _ytd_sales; }
			set
			{
				if ((value != _ytd_sales) && (this.State != EntityState.Added))
				{
					this.State = EntityState.Modified;
					_ytd_sales = value;
				}
				else if ((value != _ytd_sales) && (_ytd_sales is null))
				{

					_ytd_sales = value;
					this.State = EntityState.Added;
				}
			}
		}
		public DateTime pubdate {
			get { return _pubdate; }
			set
			{
				if ((value != _pubdate) && (this.State != EntityState.Added))
				{
					this.State = EntityState.Modified;
					_pubdate = value;
				}
				else
				{

					_pubdate = value;
					this.State = EntityState.Added;
				}
			}
		}
	}
}
