using System;
using System.Collections.Generic;
using System.Text;

namespace AutomobileTn.Models {
	public class Tweet {

		public string Text
		{ get; set; }

		public string UserName
		{ get; set; }

		public DateTime PublishDate
		{ get; set; }

		public string ImageUrl
		{ get; set; }

		public string ScreenName
		{ get; set; }
	}
}
