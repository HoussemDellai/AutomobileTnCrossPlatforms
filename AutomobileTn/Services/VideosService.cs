using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
#if WINDOWS_PHONE_APP || WINDOWS_APP
using Windows.Data.Json;
#endif
using AutomobileTn.Models;
using AutomobileTn.Utils;

namespace AutomobileTn.Services
{
	public class VideosService
	{
		public async Task<List<Video>> GetYoutubeVideosAsync()
		{
			var client = new HttpClient();

			try
			{
				var youtubeVideosJson = await client.GetStringAsync(Constants.VideosLink);

				var stream = new MemoryStream(Encoding.UTF8.GetBytes(youtubeVideosJson));

				var jsonSerializer = new DataContractJsonSerializer(typeof(List<Video>),
					new DataContractJsonSerializerSettings
				{
					DateTimeFormat = new DateTimeFormat("ddd, dd MMM yyyy HH:mm:ss zzz", CultureInfo.InvariantCulture)
                    //Wed, 04 Jun 2014 01:30:21 + 0000
                });

				return (List<Video>) jsonSerializer.ReadObject(stream);
			}
			catch (Exception exc)
			{
				Debug.WriteLine(exc.Data);
				Debug.WriteLine(exc.Message);
				Debug.WriteLine(exc.InnerException);

				return null;
			}
		}
	}
}
