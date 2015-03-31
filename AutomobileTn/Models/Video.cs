using System;
using System.Runtime.Serialization;

namespace AutomobileTn.Models
{
	public class Video
    {

		public string Id
		{ get; set; }

		public string Title
		{ get; set; }

		public DateTime PubDate
		{ get; set; }

		public string YoutubeLink
		{ get; set; }

		public string VideoLink
		{ get; set; }

		/// <summary>
		/// Large thumbnail.
		/// </summary>
		public string Thumbnail
		{ get; set; }

		public string MediumThumbnail
		{ get; set; }

		public string SmallThumbnail
		{ get; set; }
	}
}
