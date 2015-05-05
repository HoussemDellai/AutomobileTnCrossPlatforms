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
using AutomobileTn.Models;
using AutomobileTn.Utils;
using Newtonsoft.Json;

namespace AutomobileTn.Services
{
    public class TweetsService
    {

        public async Task<List<Tweet>> GetTweetsAsync()
        {
            var client = new HttpClient();

            try
            {
                //string tweetsJson = string.Empty;

                //#if WINDOWS_PHONE_APP || WINDOWS_APP 
                //                if (DesignMode.DesignModeEnabled)
                //				{
                //tweetsJson =
                //#region DATA
                //		@"[{""Text"":""Mazda ouvre une nouvelle succursale à Sousse:
                //	Economic Auto, concessionnaire de la firme japonai... http://t.co/HaPbvfFDd5 #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/23/2014 6:36:38 PM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""BSB Toyota lance la nouvelle Corolla en Tunisie: La société BSB, concessionnaire officiel de la ... http://t.co/HVzSdMEmny #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/21/2014 2:06:24 PM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""#occasionsTN Audi TT RS: Prix :29 000 DTKilometrage :121 000 kmAnnee :1999 http://t.co/AmE8gTHuct #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/20/2014 4:15:50 PM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""#occasionsTN Toyota RAV 4: Prix :21 500 DTKilometrage :220 000 kmAnnee :2003 http://t.co/Aev4T8EJbQ #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/19/2014 5:31:56 PM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""#occasionsTN Seat Toledo: Prix :44 000 DTKilometrage :10 000 kmAnnee :2013 http://t.co/SNIyMxecGf #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/19/2014 1:37:38 PM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""Le Moteur lance la nouvelle Classe C en Tunisie: En marge de la célébration du 60ème Anniversair... http://t.co/J4X3BUCIWw #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/19/2014 1:09:45 AM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""#occasionsTN KIA Cerato 5p: Prix :44 000 DTKilometrage :19 200 kmAnnee :2014 http://t.co/Pq6rag3zm2 #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/18/2014 8:42:40 PM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""#occasionsTN Renault R 9: Prix :5 200 DTKilometrage :130 000 kmAnnee :1988 http://t.co/T04dd71Ipx #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/18/2014 7:46:30 PM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""#occasionsTN BMW Série 3 cabriolet: Prix :72 000 DTKilometrage :99 000 kmAnnee :2009 http://t.co/XiOI0fhLt4 #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/17/2014 1:02:37 PM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""#occasionsTN BMW X5: Prix :105 000 DTKilometrage :120 000 kmAnnee :2008 http://t.co/exrakYkVNL #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/16/2014 12:20:05 AM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""#occasionsTN Peugeot 508: Prix :65 000 DTAnnee :2014 http://t.co/x7QvJuB2NH #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/16/2014 12:20:03 AM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""#occasionsTN Nissan Micra: Prix :27 500 DTAnnee :2014 http://t.co/kmiWkuB2Ky #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/16/2014 12:20:02 AM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""#occasionsTN Mitsubishi L200 Double Cabine: Prix :15 500 DTKilometrage :360 000 kmAnnee :2000 http://t.co/Iq0sFxFN1Q #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/13/2014 5:51:47 PM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""Journées d'essais BMW et Mini chez Ben Jemâa Motors: Comme chaque année, le concessionnaire Ben ... http://t.co/C355wf86X1 #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/13/2014 11:55:37 AM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""#occasionsTN Hyundai Coupe: Prix :19 900 DTKilometrage :203 000 kmAnnee :2003 http://t.co/Nk4Nigu7SO #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/13/2014 11:21:10 AM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""#occasionsTN Daewoo Nubira: Prix :15 000 DTKilometrage :237 000 kmAnnee :2002 http://t.co/0Qg87s0yGE #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/12/2014 10:22:11 PM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""Essai Ford Tourneo Courier, un ludospace astucieux: Après le Tourneo Custom et le Tourneo Connec... http://t.co/6dJ1KrI73r #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/12/2014 5:09:24 PM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""#occasionsTN Suzuki Grand Vitara: Prix :22 000 DTKilometrage :120 000 kmAnnee :2001 http://t.co/BNIKWTjVJ1 #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/12/2014 2:47:50 PM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""#occasionsTN Daewoo Nubira: Prix :16 000 DTKilometrage :237 000 kmAnnee :2002 http://t.co/LT6MbnKTfq #automobileTN"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/11/2014 1:26:12 PM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""RT @AudiTunisie: @AutomobileTN L’Audi A3 Berline a été élue \""Voiture mondiale de l’année 2014\"" par 69 journalites de 22 pays http://t.co/CG…"",""UserName"":""@AutomobileTN"",""PublishDate"":""5/10/2014 7:08:37 PM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""Mazda ouvre une nouvelle succursale à Sousse: Economic Auto, concessionnaire de la firme japonai... http://t.co/HaPbvfFDd5 #automobileTN"",""UserName"":""@"",""PublishDate"":""5/23/2014 6:36:38 PM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""BSB Toyota lance la nouvelle Corolla en Tunisie: La société BSB, concessionnaire officiel de la ... http://t.co/HVzSdMEmny #automobileTN"",""UserName"":""@"",""PublishDate"":""5/21/2014 2:06:24 PM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""},{""Text"":""#occasionsTN Audi TT RS: Prix :29 000 DTKilometrage :121 000 kmAnnee :1999 http://t.co/AmE8gTHuct #automobileTN"",""UserName"":""@"",""PublishDate"":""5/20/2014 4:15:50 PM"",""ImageUrl"":""http://pbs.twimg.com/profile_images/432292882066587648/OHHCucfU_normal.png"",""ScreenName"":""automobile.tn""}]";
                //#endregion

                //while (tweetsJson.Contains("\r"))
                //{
                //	tweetsJson = tweetsJson.Replace("\r", "");
                //}
                //while (tweetsJson.Contains("\n"))
                //{
                //	tweetsJson = tweetsJson.Replace("\n", "");
                //}
                //while (tweetsJson.Contains("\t"))
                //{
                //	tweetsJson = tweetsJson.Replace("\t", "");
                //}
                //				}
                //				else
                //#endif
                //{
                var tweetsJson = await client.GetStringAsync(Constants.TweetsLink);

                return JsonConvert.DeserializeObject<List<Tweet>>(tweetsJson);
                //}

                //var stream = new MemoryStream(Encoding.UTF8.GetBytes(tweetsJson));

                //var jsonSerializer = new DataContractJsonSerializer(typeof(List<Tweet>),
                //	new DataContractJsonSerializerSettings
                //	{
                //		DateTimeFormat = new DateTimeFormat("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
                //		// 6/5/2014 2:30:09 PM
                //	});

                //return (List<Tweet>)jsonSerializer.ReadObject(stream);
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