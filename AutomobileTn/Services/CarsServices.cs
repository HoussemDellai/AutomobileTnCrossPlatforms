using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AutomobileTn.Models;

namespace AutomobileTn.Services
{
	public class CarsServices
	{

		private string _dataXml =
		#region DATA
			@"<?xml version=""1.0"" encoding=""UTF-8"" ?>
<rss version = ""2.0"" >
    <channel>
        <title> www.automobile.tn </title>
        <link> http://www.automobile.tn</link>
        <description></description>
        <language>fr-FR</language>
        <copyright>Droits de reproduction et de diffusion réservés © automobile.tn</copyright>
        <managingEditor>contact @automobile.tn(Automobile.tn)</managingEditor>
        <webMaster>contact @sameteam.com.tn(SAME TEAM)</webMaster>
        <pubDate>Sat, 14 Mar 2015 15:58:21 +0100</pubDate>
        <lastBuildDate>Sat, 14 Mar 2015 15:58:21 +0100</lastBuildDate>
        <category></category>
        <docs>http://www.automobile.tn/rss/neuf.php</docs>
        <ttl>1</ttl>
        <image>
            <title>www.automobile.tn</title>
            <url>http://automobile.tn/rss/logo.gif</url>
            <link>http://www.automobile.tn</link>
            <description></description>
        </image>
        <item>
            <title>
                <![CDATA[Skoda Octavia]]>
            </title>
            <link>http://www.automobile.tn/neuf/skoda/octavia.1218/</link>
            <description>
                <![CDATA[Prix: A partir de 49 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/skoda/octavia.1218/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2015/02/16686.jpg"" length= ""11789"" type= ""image/jpeg""/>
            <pubDate > Fri, 27 Feb 2015 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/skoda/octavia.1218/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Skoda Rapid]]>
            </title>
            <link>http://www.automobile.tn/neuf/skoda/rapid/1-6-mpi-ambition.16676/</link>
            <description>
                <![CDATA[Prix: A partir de 39 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/skoda/rapid/1-6-mpi-ambition.16676/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2015/02/16676.jpg"" length= ""13137"" type= ""image/jpeg""/>
            <pubDate > Thu, 26 Feb 2015 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/skoda/rapid/1-6-mpi-ambition.16676/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mahindra XUV 500]]>
            </title>
            <link>http://www.automobile.tn/neuf/mahindra/xuv-500/7-places-4wd.16100/</link>
            <description>
                <![CDATA[Prix: A partir de 79 800 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mahindra/xuv-500/7-places-4wd.16100/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2015/01/16100.jpg"" length= ""13324"" type= ""image/jpeg""/>
            <pubDate > Thu, 29 Jan 2015 00:01:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mahindra/xuv-500/7-places-4wd.16100/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mercedes-Benz Classe C]]>
            </title>
            <link>http://www.automobile.tn/neuf/mercedes-benz/classe-c.140/</link>
            <description>
                <![CDATA[Prix: A partir de 100 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mercedes-benz/classe-c.140/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/05/11176.jpg"" length= ""10500"" type= ""image/jpeg""/>
            <pubDate > Tue, 23 Dec 2014 00:12:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mercedes-benz/classe-c.140/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Dacia Duster]]>
            </title>
            <link>http://www.automobile.tn/neuf/dacia/duster.65/</link>
            <description>
                <![CDATA[Prix: A partir de 47 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/dacia/duster.65/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/09/15068.jpg"" length= ""10994"" type= ""image/jpeg""/>
            <pubDate > Tue, 02 Dec 2014 00:12:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/dacia/duster.65/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Fiat 500L]]>
            </title>
            <link>http://www.automobile.tn/neuf/fiat/500l/1-4-l-lounge.15221/</link>
            <description>
                <![CDATA[Prix: A partir de 54 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/fiat/500l/1-4-l-lounge.15221/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/11/15221.jpg"" length= ""12370"" type= ""image/jpeg""/>
            <pubDate > Fri, 28 Nov 2014 00:11:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/fiat/500l/1-4-l-lounge.15221/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Nissan Sunny]]>
            </title>
            <link>http://www.automobile.tn/neuf/nissan/sunny.1004/</link>
            <description>
                <![CDATA[Prix: A partir de 32 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/nissan/sunny.1004/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/11/14984.jpg"" length= ""10808"" type= ""image/jpeg""/>
            <pubDate > Fri, 28 Nov 2014 00:11:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/nissan/sunny.1004/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Audi A3 Berline]]>
            </title>
            <link>http://www.automobile.tn/neuf/audi/a3-berline.1494/</link>
            <description>
                <![CDATA[Prix: A partir de 66 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/audi/a3-berline.1494/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/11/14550.jpg"" length= ""10800"" type= ""image/jpeg""/>
            <pubDate > Mon, 10 Nov 2014 00:11:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/audi/a3-berline.1494/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Peugeot Boxer]]>
            </title>
            <link>http://www.automobile.tn/neuf/peugeot/boxer.1509/</link>
            <description>
                <![CDATA[Prix: A partir de 54 200 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/peugeot/boxer.1509/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/10/14233.jpg"" length= ""9469"" type= ""image/jpeg""/>
            <pubDate > Tue, 28 Oct 2014 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/peugeot/boxer.1509/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Toyota Corolla]]>
            </title>
            <link>http://www.automobile.tn/neuf/toyota/corolla.1285/</link>
            <description>
                <![CDATA[Prix: A partir de 53 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/toyota/corolla.1285/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/10/14074.jpg"" length= ""11660"" type= ""image/jpeg""/>
            <pubDate > Wed, 22 Oct 2014 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/toyota/corolla.1285/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Hyundai Veloster]]>
            </title>
            <link>http://www.automobile.tn/neuf/hyundai/veloster.1416/</link>
            <description>
                <![CDATA[Prix: A partir de 54 950 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/hyundai/veloster.1416/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/10/13881.jpg"" length= ""13133"" type= ""image/jpeg""/>
            <pubDate > Wed, 15 Oct 2014 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/hyundai/veloster.1416/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Nissan NP 300]]>
            </title>
            <link>http://www.automobile.tn/neuf/nissan/np-300/hardbody-4x4.13395/</link>
            <description>
                <![CDATA[Prix: A partir de 49 800 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/nissan/np-300/hardbody-4x4.13395/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/09/13395.jpg"" length= ""12289"" type= ""image/jpeg""/>
            <pubDate > Tue, 23 Sep 2014 00:09:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/nissan/np-300/hardbody-4x4.13395/</guid>
        </item>
        <item>
            <title>
                <![CDATA[BMW Série 3 GT]]>
            </title>
            <link>http://www.automobile.tn/neuf/bmw/serie-3-gt.1506/</link>
            <description>
                <![CDATA[Prix: A partir de 121 700 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/bmw/serie-3-gt.1506/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/09/13218.jpg"" length= ""12438"" type= ""image/jpeg""/>
            <pubDate > Mon, 15 Sep 2014 00:09:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/bmw/serie-3-gt.1506/</guid>
        </item>
        <item>
            <title>
                <![CDATA[BMW Série 5]]>
            </title>
            <link>http://www.automobile.tn/neuf/bmw/serie-5.57/</link>
            <description>
                <![CDATA[Prix: A partir de 134 200 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/bmw/serie-5.57/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/09/13221.jpg"" length= ""11466"" type= ""image/jpeg""/>
            <pubDate > Mon, 15 Sep 2014 00:09:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/bmw/serie-5.57/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mitsubishi Mirage]]>
            </title>
            <link>http://www.automobile.tn/neuf/mitsubishi/mirage.1505/</link>
            <description>
                <![CDATA[Prix: A partir de 24 720 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mitsubishi/mirage.1505/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/08/12927.jpg"" length= ""10460"" type= ""image/jpeg""/>
            <pubDate > Fri, 29 Aug 2014 00:08:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mitsubishi/mirage.1505/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mazda 3 sedan]]>
            </title>
            <link>http://www.automobile.tn/neuf/mazda/3-sedan.1441/</link>
            <description>
                <![CDATA[Prix: A partir de 48 200 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mazda/3-sedan.1441/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/08/12794.jpg"" length= ""10486"" type= ""image/jpeg""/>
            <pubDate > Wed, 20 Aug 2014 00:08:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mazda/3-sedan.1441/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mazda 3]]>
            </title>
            <link>http://www.automobile.tn/neuf/mazda/3.844/</link>
            <description>
                <![CDATA[Prix: A partir de 49 200 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mazda/3.844/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/08/12793.jpg"" length= ""10386"" type= ""image/jpeg""/>
            <pubDate > Wed, 20 Aug 2014 00:08:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mazda/3.844/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Audi A3 Sportback]]>
            </title>
            <link>http://www.automobile.tn/neuf/audi/a3-sportback.129/</link>
            <description>
                <![CDATA[Prix: A partir de 64 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/audi/a3-sportback.129/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/08/12714.jpg"" length= ""10793"" type= ""image/jpeg""/>
            <pubDate > Thu, 14 Aug 2014 00:08:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/audi/a3-sportback.129/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Toyota Yaris]]>
            </title>
            <link>http://www.automobile.tn/neuf/toyota/yaris/1-3l-vvti.12182/</link>
            <description>
                <![CDATA[Prix: A partir de 36 800 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/toyota/yaris/1-3l-vvti.12182/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/07/12182.jpg"" length= ""13195"" type= ""image/jpeg""/>
            <pubDate > Sun, 13 Jul 2014 00:07:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/toyota/yaris/1-3l-vvti.12182/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Volkswagen Polo]]>
            </title>
            <link>http://www.automobile.tn/neuf/volkswagen/polo.48/</link>
            <description>
                <![CDATA[Prix: A partir de 31 480 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/volkswagen/polo.48/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/07/12053.jpg"" length= ""10974"" type= ""image/jpeg""/>
            <pubDate > Wed, 09 Jul 2014 00:07:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/volkswagen/polo.48/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Peugeot 308]]>
            </title>
            <link>http://www.automobile.tn/neuf/peugeot/308.81/</link>
            <description>
                <![CDATA[Prix: A partir de 42 500 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/peugeot/308.81/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/07/11966.jpg"" length= ""11087"" type= ""image/jpeg""/>
            <pubDate > Sat, 05 Jul 2014 00:07:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/peugeot/308.81/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Audi A4]]>
            </title>
            <link>http://www.automobile.tn/neuf/audi/a4.22/</link>
            <description>
                <![CDATA[Prix: A partir de 82 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/audi/a4.22/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/05/11376.jpg"" length= ""11239"" type= ""image/jpeg""/>
            <pubDate > Fri, 30 May 2014 00:05:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/audi/a4.22/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Fiat Ducato]]>
            </title>
            <link>http://www.automobile.tn/neuf/fiat/ducato.305/</link>
            <description>
                <![CDATA[Prix: A partir de 45 500 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/fiat/ducato.305/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/04/10737.jpg"" length= ""11972"" type= ""image/jpeg""/>
            <pubDate > Fri, 25 Apr 2014 00:04:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/fiat/ducato.305/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mini Countryman]]>
            </title>
            <link>http://www.automobile.tn/neuf/mini/countryman/1-6-l-pepper-bva.10625/</link>
            <description>
                <![CDATA[Prix: A partir de 98 500 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mini/countryman/1-6-l-pepper-bva.10625/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/04/10625.png"" length= ""18072"" type= ""image/jpeg""/>
            <pubDate > Mon, 21 Apr 2014 00:04:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mini/countryman/1-6-l-pepper-bva.10625/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mini Paceman]]>
            </title>
            <link>http://www.automobile.tn/neuf/mini/paceman/1-6-l-pepper-bva.10617/</link>
            <description>
                <![CDATA[Prix: A partir de 106 500 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mini/paceman/1-6-l-pepper-bva.10617/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/04/10617.jpg"" length= ""10891"" type= ""image/jpeg""/>
            <pubDate > Mon, 21 Apr 2014 00:04:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mini/paceman/1-6-l-pepper-bva.10617/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Fiat Doblo]]>
            </title>
            <link>http://www.automobile.tn/neuf/fiat/doblo/1-2-l-multijet.10602/</link>
            <description>
                <![CDATA[Prix: A partir de 24 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/fiat/doblo/1-2-l-multijet.10602/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/04/10602.jpg"" length= ""13258"" type= ""image/jpeg""/>
            <pubDate > Sun, 20 Apr 2014 00:04:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/fiat/doblo/1-2-l-multijet.10602/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mercedes-Benz Classe E]]>
            </title>
            <link>http://www.automobile.tn/neuf/mercedes-benz/classe-e.141/</link>
            <description>
                <![CDATA[Prix: A partir de 130 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mercedes-benz/classe-e.141/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/04/10551.jpg"" length= ""10961"" type= ""image/jpeg""/>
            <pubDate > Sat, 19 Apr 2014 00:04:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mercedes-benz/classe-e.141/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mahindra Scorpio SUV]]>
            </title>
            <link>http://www.automobile.tn/neuf/mahindra/scorpio-suv/2-5-l-4x4.10475/</link>
            <description>
                <![CDATA[Prix: A partir de 63 990 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mahindra/scorpio-suv/2-5-l-4x4.10475/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/04/10475.jpg"" length= ""10679"" type= ""image/jpeg""/>
            <pubDate > Tue, 15 Apr 2014 00:04:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mahindra/scorpio-suv/2-5-l-4x4.10475/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mahindra Pick-up SC]]>
            </title>
            <link>http://www.automobile.tn/neuf/mahindra/pick-up-sc.1499/</link>
            <description>
                <![CDATA[Prix: A partir de 38 300 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mahindra/pick-up-sc.1499/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/04/10471.jpg"" length= ""9710"" type= ""image/jpeg""/>
            <pubDate > Tue, 15 Apr 2014 00:04:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mahindra/pick-up-sc.1499/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Ssangyong Rodius]]>
            </title>
            <link>http://www.automobile.tn/neuf/ssangyong/rodius.1232/</link>
            <description>
                <![CDATA[Prix: A partir de 92 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/ssangyong/rodius.1232/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/04/10465.jpg"" length= ""12445"" type= ""image/jpeg""/>
            <pubDate > Tue, 15 Apr 2014 00:04:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/ssangyong/rodius.1232/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mahindra Pick-up DC]]>
            </title>
            <link>http://www.automobile.tn/neuf/mahindra/pick-up-dc.1500/</link>
            <description>
                <![CDATA[Prix: A partir de 44 500 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mahindra/pick-up-dc.1500/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/04/10474.jpg"" length= ""10182"" type= ""image/jpeg""/>
            <pubDate > Tue, 15 Apr 2014 00:04:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mahindra/pick-up-dc.1500/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Hyundai Grand i10]]>
            </title>
            <link>http://www.automobile.tn/neuf/hyundai/grand-i10.641/</link>
            <description>
                <![CDATA[Prix: A partir de 25 800 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/hyundai/grand-i10.641/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/04/10431.jpg"" length= ""13442"" type= ""image/jpeg""/>
            <pubDate > Mon, 14 Apr 2014 00:04:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/hyundai/grand-i10.641/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mitsubishi L200 Simple Cabine]]>
            </title>
            <link>http://www.automobile.tn/neuf/mitsubishi/l200-simple-cabine/4x2.10288/</link>
            <description>
                <![CDATA[Prix: A partir de 38 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mitsubishi/l200-simple-cabine/4x2.10288/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/04/10288.jpg"" length= ""10720"" type= ""image/jpeg""/>
            <pubDate > Fri, 04 Apr 2014 00:04:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mitsubishi/l200-simple-cabine/4x2.10288/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Ford Mondeo]]>
            </title>
            <link>http://www.automobile.tn/neuf/ford/mondeo.95/</link>
            <description>
                <![CDATA[Prix: A partir de 49 850 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/ford/mondeo.95/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/04/10238.jpg"" length= ""11170"" type= ""image/jpeg""/>
            <pubDate > Tue, 01 Apr 2014 00:04:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/ford/mondeo.95/</guid>
        </item>
        <item>
            <title>
                <![CDATA[BMW Série 4 Coupé]]>
            </title>
            <link>http://www.automobile.tn/neuf/bmw/serie-4-coupe.1480/</link>
            <description>
                <![CDATA[Prix: A partir de 120 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/bmw/serie-4-coupe.1480/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/03/10172.jpg"" length= ""13606"" type= ""image/jpeg""/>
            <pubDate > Fri, 28 Mar 2014 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/bmw/serie-4-coupe.1480/</guid>
        </item>
        <item>
            <title>
                <![CDATA[KIA Carens]]>
            </title>
            <link>http://www.automobile.tn/neuf/kia/carens/1-7-l-diesel.10000/</link>
            <description>
                <![CDATA[Prix: A partir de 78 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/kia/carens/1-7-l-diesel.10000/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/03/10000.jpg"" length= ""10821"" type= ""image/jpeg""/>
            <pubDate > Tue, 18 Mar 2014 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/kia/carens/1-7-l-diesel.10000/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Citroën C4 Picasso]]>
            </title>
            <link>http://www.automobile.tn/neuf/citroen/c4-picasso/1-6-l-e-hdi-intensive.9660/</link>
            <description>
                <![CDATA[Prix: A partir de 73 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/citroen/c4-picasso/1-6-l-e-hdi-intensive.9660/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/02/9660.jpg"" length= ""13315"" type= ""image/jpeg""/>
            <pubDate > Fri, 28 Feb 2014 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/citroen/c4-picasso/1-6-l-e-hdi-intensive.9660/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Citroën Grand C4 Picasso]]>
            </title>
            <link>http://www.automobile.tn/neuf/citroen/grand-c4-picasso/1-6-l-e-hdi-intensive.9663/</link>
            <description>
                <![CDATA[Prix: A partir de 76 550 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/citroen/grand-c4-picasso/1-6-l-e-hdi-intensive.9663/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/02/9663.jpg"" length= ""11341"" type= ""image/jpeg""/>
            <pubDate > Fri, 28 Feb 2014 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/citroen/grand-c4-picasso/1-6-l-e-hdi-intensive.9663/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Opel Insignia]]>
            </title>
            <link>http://www.automobile.tn/neuf/opel/insignia.145/</link>
            <description>
                <![CDATA[Prix: A partir de 77 120 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/opel/insignia.145/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/02/9406.jpg"" length= ""9878"" type= ""image/jpeg""/>
            <pubDate > Fri, 14 Feb 2014 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/opel/insignia.145/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Volkswagen Golf 7]]>
            </title>
            <link>http://www.automobile.tn/neuf/volkswagen/golf-7.1451/</link>
            <description>
                <![CDATA[Prix: A partir de 50 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/volkswagen/golf-7.1451/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/02/3870.jpg"" length= ""10351"" type= ""image/jpeg""/>
            <pubDate > Tue, 11 Feb 2014 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/volkswagen/golf-7.1451/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Opel Astra GTC]]>
            </title>
            <link>http://www.automobile.tn/neuf/opel/astra-gtc/1-4-l-turbo-140-ch.9351/</link>
            <description>
                <![CDATA[Prix: A partir de 59 290 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/opel/astra-gtc/1-4-l-turbo-140-ch.9351/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/02/9351.jpg"" length= ""13289"" type= ""image/jpeg""/>
            <pubDate > Tue, 11 Feb 2014 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/opel/astra-gtc/1-4-l-turbo-140-ch.9351/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Peugeot 2008]]>
            </title>
            <link>http://www.automobile.tn/neuf/peugeot/2008.1458/</link>
            <description>
                <![CDATA[Prix: A partir de 45 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/peugeot/2008.1458/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/02/9203.jpg"" length= ""10760"" type= ""image/jpeg""/>
            <pubDate > Tue, 04 Feb 2014 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/peugeot/2008.1458/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Peugeot 208 3P]]>
            </title>
            <link>http://www.automobile.tn/neuf/peugeot/208-3p.1457/</link>
            <description>
                <![CDATA[Prix: A partir de 33 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/peugeot/208-3p.1457/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/12/3461.jpg"" length= ""12515"" type= ""image/jpeg""/>
            <pubDate > Mon, 03 Feb 2014 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/peugeot/208-3p.1457/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Peugeot 208]]>
            </title>
            <link>http://www.automobile.tn/neuf/peugeot/208.1398/</link>
            <description>
                <![CDATA[Prix: A partir de 31 800 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/peugeot/208.1398/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/11/3037.jpg"" length= ""10877"" type= ""image/jpeg""/>
            <pubDate > Mon, 03 Feb 2014 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/peugeot/208.1398/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mazda 6 2014]]>
            </title>
            <link>http://www.automobile.tn/neuf/mazda/6-2014/2-0-l-skyactiv-bva.8952/</link>
            <description>
                <![CDATA[Prix: A partir de 76 500 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mazda/6-2014/2-0-l-skyactiv-bva.8952/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/01/8952.jpg"" length= ""13251"" type= ""image/jpeg""/>
            <pubDate > Thu, 23 Jan 2014 00:01:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mazda/6-2014/2-0-l-skyactiv-bva.8952/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Renault Captur]]>
            </title>
            <link>http://www.automobile.tn/neuf/renault/captur/tce-90.8815/</link>
            <description>
                <![CDATA[Prix: A partir de 42 950 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/renault/captur/tce-90.8815/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/01/8815.jpg"" length= ""11608"" type= ""image/jpeg""/>
            <pubDate > Wed, 15 Jan 2014 00:01:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/renault/captur/tce-90.8815/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Land Rover Discovery]]>
            </title>
            <link>http://www.automobile.tn/neuf/land-rover/discovery/sdv6-hse.8569/</link>
            <description>
                <![CDATA[Prix: A partir de 258 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/land-rover/discovery/sdv6-hse.8569/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/12/8569.png"" length= ""16690"" type= ""image/jpeg""/>
            <pubDate > Fri, 27 Dec 2013 00:12:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/land-rover/discovery/sdv6-hse.8569/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Hyundai i30]]>
            </title>
            <link>http://www.automobile.tn/neuf/hyundai/i30/1-6-dohc.8555/</link>
            <description>
                <![CDATA[Prix: A partir de 47 950 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/hyundai/i30/1-6-dohc.8555/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/12/8555.jpg"" length= ""11205"" type= ""image/jpeg""/>
            <pubDate > Thu, 26 Dec 2013 00:12:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/hyundai/i30/1-6-dohc.8555/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Renault Symbol]]>
            </title>
            <link>http://www.automobile.tn/neuf/renault/symbol.75/</link>
            <description>
                <![CDATA[Prix: A partir de 25 250 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/renault/symbol.75/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/12/8413.jpg"" length= ""10883"" type= ""image/jpeg""/>
            <pubDate > Tue, 17 Dec 2013 00:12:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/renault/symbol.75/</guid>
        </item>
        <item>
            <title>
                <![CDATA[KIA Cerato 5p]]>
            </title>
            <link>http://www.automobile.tn/neuf/kia/cerato-5p.1487/</link>
            <description>
                <![CDATA[Prix: A partir de 54 380 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/kia/cerato-5p.1487/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/11/7966.jpg"" length= ""12463"" type= ""image/jpeg""/>
            <pubDate > Wed, 20 Nov 2013 00:11:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/kia/cerato-5p.1487/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Volkswagen Passat]]>
            </title>
            <link>http://www.automobile.tn/neuf/volkswagen/passat.50/</link>
            <description>
                <![CDATA[Prix: A partir de 68 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/volkswagen/passat.50/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/11/7911.jpg"" length= ""11404"" type= ""image/jpeg""/>
            <pubDate > Sun, 17 Nov 2013 00:11:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/volkswagen/passat.50/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Dacia Dokker Van]]>
            </title>
            <link>http://www.automobile.tn/neuf/dacia/dokker-van.1484/</link>
            <description>
                <![CDATA[Prix: A partir de 25 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/dacia/dokker-van.1484/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/10/7384.jpg"" length= ""10114"" type= ""image/jpeg""/>
            <pubDate > Tue, 22 Oct 2013 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/dacia/dokker-van.1484/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Dacia Sandero]]>
            </title>
            <link>http://www.automobile.tn/neuf/dacia/sandero/1-2-l.7385/</link>
            <description>
                <![CDATA[Prix: A partir de 25 450 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/dacia/sandero/1-2-l.7385/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/10/7385.jpg"" length= ""11112"" type= ""image/jpeg""/>
            <pubDate > Tue, 22 Oct 2013 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/dacia/sandero/1-2-l.7385/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Land Rover Range Rover Sport]]>
            </title>
            <link>http://www.automobile.tn/neuf/land-rover/range-rover-sport.139/</link>
            <description>
                <![CDATA[Prix: A partir de 296 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/land-rover/range-rover-sport.139/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/10/7336.jpg"" length= ""11264"" type= ""image/jpeg""/>
            <pubDate > Fri, 18 Oct 2013 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/land-rover/range-rover-sport.139/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Peugeot 508]]>
            </title>
            <link>http://www.automobile.tn/neuf/peugeot/508.45/</link>
            <description>
                <![CDATA[Prix: A partir de 63 600 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/peugeot/508.45/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/09/7072.jpg"" length= ""10463"" type= ""image/jpeg""/>
            <pubDate > Sun, 29 Sep 2013 00:09:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/peugeot/508.45/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Citroën DS5]]>
            </title>
            <link>http://www.automobile.tn/neuf/citroen/ds5.1452/</link>
            <description>
                <![CDATA[Prix: A partir de 82 400 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/citroen/ds5.1452/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/09/2584.jpg"" length= ""10994"" type= ""image/jpeg""/>
            <pubDate > Tue, 17 Sep 2013 00:09:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/citroen/ds5.1452/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Toyota RAV 4]]>
            </title>
            <link>http://www.automobile.tn/neuf/toyota/rav-4/2-0-l-4x2-bva.6486/</link>
            <description>
                <![CDATA[Prix: A partir de 84 800 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/toyota/rav-4/2-0-l-4x2-bva.6486/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/08/6486.jpg"" length= ""10892"" type= ""image/jpeg""/>
            <pubDate > Tue, 27 Aug 2013 00:08:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/toyota/rav-4/2-0-l-4x2-bva.6486/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mercedes-Benz GLA]]>
            </title>
            <link>http://www.automobile.tn/neuf/mercedes-benz/gla.1502/</link>
            <description>
                <![CDATA[Prix: A partir de 115 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mercedes-benz/gla.1502/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/08/15459.jpg"" length= ""10731"" type= ""image/jpeg""/>
            <pubDate > Sat, 24 Aug 2013 00:08:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mercedes-benz/gla.1502/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mercedes-Benz Classe A]]>
            </title>
            <link>http://www.automobile.tn/neuf/mercedes-benz/classe-a.143/</link>
            <description>
                <![CDATA[Prix: A partir de 75 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mercedes-benz/classe-a.143/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/08/6451.jpg"" length= ""10841"" type= ""image/jpeg""/>
            <pubDate > Sat, 24 Aug 2013 00:08:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mercedes-benz/classe-a.143/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mercedes-Benz CLA]]>
            </title>
            <link>http://www.automobile.tn/neuf/mercedes-benz/cla.1469/</link>
            <description>
                <![CDATA[Prix: A partir de 99 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mercedes-benz/cla.1469/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/08/6406.jpg"" length= ""10994"" type= ""image/jpeg""/>
            <pubDate > Tue, 20 Aug 2013 00:08:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mercedes-benz/cla.1469/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Volkswagen Polo Sedan]]>
            </title>
            <link>http://www.automobile.tn/neuf/volkswagen/polo-sedan.1481/</link>
            <description>
                <![CDATA[Prix: A partir de 33 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/volkswagen/polo-sedan.1481/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/08/6217.jpg"" length= ""11809"" type= ""image/jpeg""/>
            <pubDate > Thu, 01 Aug 2013 00:08:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/volkswagen/polo-sedan.1481/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Toyota GT86]]>
            </title>
            <link>http://www.automobile.tn/neuf/toyota/gt86/2-0-l-act-bva.5703/</link>
            <description>
                <![CDATA[Prix: A partir de 92 400 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/toyota/gt86/2-0-l-act-bva.5703/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/06/5703.jpg"" length= ""13176"" type= ""image/jpeg""/>
            <pubDate > Tue, 25 Jun 2013 00:06:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/toyota/gt86/2-0-l-act-bva.5703/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Citroën Berlingo Utilitaire]]>
            </title>
            <link>http://www.automobile.tn/neuf/citroen/berlingo-utilitaire.1479/</link>
            <description>
                <![CDATA[Prix: A partir de 34 200 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/citroen/berlingo-utilitaire.1479/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/06/5544.jpg"" length= ""12263"" type= ""image/jpeg""/>
            <pubDate > Thu, 13 Jun 2013 00:06:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/citroen/berlingo-utilitaire.1479/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Citroën Jumpy Fourgon]]>
            </title>
            <link>http://www.automobile.tn/neuf/citroen/jumpy-fourgon/1-6-l-hdi-l1h1-climatisee.5540/</link>
            <description>
                <![CDATA[Prix: A partir de 43 600 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/citroen/jumpy-fourgon/1-6-l-hdi-l1h1-climatisee.5540/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/06/5540.jpg"" length= ""12363"" type= ""image/jpeg""/>
            <pubDate > Thu, 13 Jun 2013 00:06:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/citroen/jumpy-fourgon/1-6-l-hdi-l1h1-climatisee.5540/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Citroën Jumpy Combi]]>
            </title>
            <link>http://www.automobile.tn/neuf/citroen/jumpy-combi/1-6-l-hdi-l1h1-clim.5542/</link>
            <description>
                <![CDATA[Prix: A partir de 68 300 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/citroen/jumpy-combi/1-6-l-hdi-l1h1-clim.5542/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/06/5542.jpg"" length= ""11855"" type= ""image/jpeg""/>
            <pubDate > Thu, 13 Jun 2013 00:06:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/citroen/jumpy-combi/1-6-l-hdi-l1h1-clim.5542/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Citroën Jumper]]>
            </title>
            <link>http://www.automobile.tn/neuf/citroen/jumper/30-l1h1-2-2-l-hdi-8m3.5504/</link>
            <description>
                <![CDATA[Prix: A partir de 49 800 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/citroen/jumper/30-l1h1-2-2-l-hdi-8m3.5504/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/06/5504.jpg"" length= ""11711"" type= ""image/jpeg""/>
            <pubDate > Wed, 12 Jun 2013 00:06:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/citroen/jumper/30-l1h1-2-2-l-hdi-8m3.5504/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Nissan Micra]]>
            </title>
            <link>http://www.automobile.tn/neuf/nissan/micra/1-2-l-acenta-bvm.5476/</link>
            <description>
                <![CDATA[Prix: A partir de 27 300 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/nissan/micra/1-2-l-acenta-bvm.5476/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/06/5476.jpg"" length= ""11697"" type= ""image/jpeg""/>
            <pubDate > Mon, 10 Jun 2013 00:06:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/nissan/micra/1-2-l-acenta-bvm.5476/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Ford Ka]]>
            </title>
            <link>http://www.automobile.tn/neuf/ford/ka.225/</link>
            <description>
                <![CDATA[Prix: A partir de 28 500 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/ford/ka.225/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/06/5447.jpg"" length= ""11885"" type= ""image/jpeg""/>
            <pubDate > Sun, 09 Jun 2013 00:06:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/ford/ka.225/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Opel Corsa 3p]]>
            </title>
            <link>http://www.automobile.tn/neuf/opel/corsa-3p/1-2-l.5446/</link>
            <description>
                <![CDATA[Prix: A partir de 27 698 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/opel/corsa-3p/1-2-l.5446/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/06/5446.jpg"" length= ""10718"" type= ""image/jpeg""/>
            <pubDate > Sun, 09 Jun 2013 00:06:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/opel/corsa-3p/1-2-l.5446/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Volvo V40]]>
            </title>
            <link>http://www.automobile.tn/neuf/volvo/v40/1-6-l-turbo.5359/</link>
            <description>
                <![CDATA[Prix: A partir de 82 500 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/volvo/v40/1-6-l-turbo.5359/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/06/5359.jpg"" length= ""11117"" type= ""image/jpeg""/>
            <pubDate > Mon, 03 Jun 2013 00:06:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/volvo/v40/1-6-l-turbo.5359/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mazda BT-50 Pro]]>
            </title>
            <link>http://www.automobile.tn/neuf/mazda/bt-50-pro.156/</link>
            <description>
                <![CDATA[Prix: A partir de 49 500 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mazda/bt-50-pro.156/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/05/5339.jpg"" length= ""12847"" type= ""image/jpeg""/>
            <pubDate > Fri, 31 May 2013 00:05:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mazda/bt-50-pro.156/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mitsubishi L200 Double Cabine]]>
            </title>
            <link>http://www.automobile.tn/neuf/mitsubishi/l200-double-cabine/4x2.5342/</link>
            <description>
                <![CDATA[Prix: A partir de 43 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mitsubishi/l200-double-cabine/4x2.5342/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/05/5342.jpg"" length= ""11253"" type= ""image/jpeg""/>
            <pubDate > Fri, 31 May 2013 00:05:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mitsubishi/l200-double-cabine/4x2.5342/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Seat Leon]]>
            </title>
            <link>http://www.automobile.tn/neuf/seat/leon.87/</link>
            <description>
                <![CDATA[Prix: A partir de 41 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/seat/leon.87/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/05/5301.jpg"" length= ""10785"" type= ""image/jpeg""/>
            <pubDate > Tue, 28 May 2013 00:05:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/seat/leon.87/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Citroën Berlingo First]]>
            </title>
            <link>http://www.automobile.tn/neuf/citroen/berlingo-first/clim-plc.4932/</link>
            <description>
                <![CDATA[Prix: A partir de 30 100 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/citroen/berlingo-first/clim-plc.4932/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/05/4932.jpg"" length= ""11439"" type= ""image/jpeg""/>
            <pubDate > Sun, 05 May 2013 00:05:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/citroen/berlingo-first/clim-plc.4932/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Citroën C5]]>
            </title>
            <link>http://www.automobile.tn/neuf/citroen/c5.59/</link>
            <description>
                <![CDATA[Prix: A partir de 64 600 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/citroen/c5.59/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/05/4935.jpg"" length= ""10056"" type= ""image/jpeg""/>
            <pubDate > Sun, 05 May 2013 00:05:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/citroen/c5.59/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Toyota Camry]]>
            </title>
            <link>http://www.automobile.tn/neuf/toyota/camry/2-5-l.4877/</link>
            <description>
                <![CDATA[Prix: A partir de 86 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/toyota/camry/2-5-l.4877/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/05/4877.jpg"" length= ""10871"" type= ""image/jpeg""/>
            <pubDate > Wed, 01 May 2013 00:05:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/toyota/camry/2-5-l.4877/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Audi A5 Coupé]]>
            </title>
            <link>http://www.automobile.tn/neuf/audi/a5-coupe/1-8-l-tfsi-s-line-bva.4798/</link>
            <description>
                <![CDATA[Prix: A partir de 143 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/audi/a5-coupe/1-8-l-tfsi-s-line-bva.4798/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/04/4798.jpg"" length= ""11199"" type= ""image/jpeg""/>
            <pubDate > Wed, 24 Apr 2013 00:04:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/audi/a5-coupe/1-8-l-tfsi-s-line-bva.4798/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Seat Toledo]]>
            </title>
            <link>http://www.automobile.tn/neuf/seat/toledo/1-6-l-style.4459/</link>
            <description>
                <![CDATA[Prix: A partir de 48 480 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/seat/toledo/1-6-l-style.4459/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/04/4459.jpg"" length= ""10266"" type= ""image/jpeg""/>
            <pubDate > Wed, 03 Apr 2013 00:04:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/seat/toledo/1-6-l-style.4459/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Citroën C-Elysée]]>
            </title>
            <link>http://www.automobile.tn/neuf/citroen/c-elysee.1462/</link>
            <description>
                <![CDATA[Prix: A partir de 29 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/citroen/c-elysee.1462/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/04/4467.jpg"" length= ""9875"" type= ""image/jpeg""/>
            <pubDate > Wed, 03 Apr 2013 00:04:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/citroen/c-elysee.1462/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Land Rover Freelander]]>
            </title>
            <link>http://www.automobile.tn/neuf/land-rover/freelander.374/</link>
            <description>
                <![CDATA[Prix: A partir de 119 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/land-rover/freelander.374/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/03/4347.jpg"" length= ""13120"" type= ""image/jpeg""/>
            <pubDate > Mon, 25 Mar 2013 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/land-rover/freelander.374/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Land Rover Range Rover]]>
            </title>
            <link>http://www.automobile.tn/neuf/land-rover/range-rover.1468/</link>
            <description>
                <![CDATA[Prix: A partir de 380 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/land-rover/range-rover.1468/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/03/4256.jpg"" length= ""10375"" type= ""image/jpeg""/>
            <pubDate > Sun, 17 Mar 2013 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/land-rover/range-rover.1468/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Citroën DS3]]>
            </title>
            <link>http://www.automobile.tn/neuf/citroen/ds3.33/</link>
            <description>
                <![CDATA[Prix: A partir de 43 400 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/citroen/ds3.33/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/03/16351.jpg"" length= ""12473"" type= ""image/jpeg""/>
            <pubDate > Fri, 15 Mar 2013 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/citroen/ds3.33/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Peugeot 301]]>
            </title>
            <link>http://www.automobile.tn/neuf/peugeot/301.1444/</link>
            <description>
                <![CDATA[Prix: A partir de 29 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/peugeot/301.1444/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/03/4140.jpg"" length= ""11130"" type= ""image/jpeg""/>
            <pubDate > Fri, 08 Mar 2013 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/peugeot/301.1444/</guid>
        </item>
        <item>
            <title>
                <![CDATA[BMW Série 3]]>
            </title>
            <link>http://www.automobile.tn/neuf/bmw/serie-3.113/</link>
            <description>
                <![CDATA[Prix: A partir de 85 200 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/bmw/serie-3.113/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/03/4093.jpg"" length= ""11071"" type= ""image/jpeg""/>
            <pubDate > Thu, 07 Mar 2013 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/bmw/serie-3.113/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Citroën C3]]>
            </title>
            <link>http://www.automobile.tn/neuf/citroen/c3.44/</link>
            <description>
                <![CDATA[Prix: A partir de 31 950 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/citroen/c3.44/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/03/40.jpg"" length= ""9595"" type= ""image/jpeg""/>
            <pubDate > Thu, 07 Mar 2013 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/citroen/c3.44/</guid>
        </item>
        <item>
            <title>
                <![CDATA[BMW Série 1 3p]]>
            </title>
            <link>http://www.automobile.tn/neuf/bmw/serie-1-3p/114i-urban-line.4071/</link>
            <description>
                <![CDATA[Prix: A partir de 75 600 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/bmw/serie-1-3p/114i-urban-line.4071/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/03/4071.jpg"" length= ""11926"" type= ""image/jpeg""/>
            <pubDate > Wed, 06 Mar 2013 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/bmw/serie-1-3p/114i-urban-line.4071/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Ford Ranger]]>
            </title>
            <link>http://www.automobile.tn/neuf/ford/ranger.361/</link>
            <description>
                <![CDATA[Prix: A partir de 53 950 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/ford/ranger.361/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/03/4057.jpg"" length= ""11688"" type= ""image/jpeg""/>
            <pubDate > Tue, 05 Mar 2013 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/ford/ranger.361/</guid>
        </item>
        <item>
            <title>
                <![CDATA[BMW X1]]>
            </title>
            <link>http://www.automobile.tn/neuf/bmw/x1/1-8i-sdrive-access-bva.1321/</link>
            <description>
                <![CDATA[Prix: A partir de 96 300 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/bmw/x1/1-8i-sdrive-access-bva.1321/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/03/1321.jpg"" length= ""10666"" type= ""image/jpeg""/>
            <pubDate > Fri, 01 Mar 2013 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/bmw/x1/1-8i-sdrive-access-bva.1321/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Toyota Avanza]]>
            </title>
            <link>http://www.automobile.tn/neuf/toyota/avanza.1461/</link>
            <description>
                <![CDATA[Prix: A partir de 30 400 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/toyota/avanza.1461/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2013/01/3771.jpg"" length= ""12382"" type= ""image/jpeg""/>
            <pubDate > Tue, 29 Jan 2013 00:01:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/toyota/avanza.1461/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Volkswagen Caddy]]>
            </title>
            <link>http://www.automobile.tn/neuf/volkswagen/caddy.191/</link>
            <description>
                <![CDATA[Prix: A partir de 33 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/volkswagen/caddy.191/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/12/495.jpg"" length= ""9740"" type= ""image/jpeg""/>
            <pubDate > Sun, 02 Dec 2012 00:12:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/volkswagen/caddy.191/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Alfa Romeo Giulietta]]>
            </title>
            <link>http://www.automobile.tn/neuf/alfa-romeo/giulietta.16/</link>
            <description>
                <![CDATA[Prix: A partir de 63 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/alfa-romeo/giulietta.16/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/10/29.jpg"" length= ""12442"" type= ""image/jpeg""/>
            <pubDate > Wed, 10 Oct 2012 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/alfa-romeo/giulietta.16/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mazda CX-5]]>
            </title>
            <link>http://www.automobile.tn/neuf/mazda/cx-5/2-0-l-skyactiv-bva.2649/</link>
            <description>
                <![CDATA[Prix: A partir de 86 500 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mazda/cx-5/2-0-l-skyactiv-bva.2649/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/09/2649.jpg"" length= ""12506"" type= ""image/jpeg""/>
            <pubDate > Fri, 21 Sep 2012 00:09:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mazda/cx-5/2-0-l-skyactiv-bva.2649/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Jaguar XF]]>
            </title>
            <link>http://www.automobile.tn/neuf/jaguar/xf.128/</link>
            <description>
                <![CDATA[Prix: A partir de 139 600 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/jaguar/xf.128/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/08/2387.jpg"" length= ""11333"" type= ""image/jpeg""/>
            <pubDate > Thu, 30 Aug 2012 00:08:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/jaguar/xf.128/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Citroën C4 Aircross]]>
            </title>
            <link>http://www.automobile.tn/neuf/citroen/c4-aircross/2-0-l-bva-4x4-pack-techno.2331/</link>
            <description>
                <![CDATA[Prix: A partir de 83 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/citroen/c4-aircross/2-0-l-bva-4x4-pack-techno.2331/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/08/2331.jpg"" length= ""11643"" type= ""image/jpeg""/>
            <pubDate > Thu, 23 Aug 2012 00:08:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/citroen/c4-aircross/2-0-l-bva-4x4-pack-techno.2331/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mazda 6]]>
            </title>
            <link>http://www.automobile.tn/neuf/mazda/6/2-0l-147-ch.1278/</link>
            <description>
                <![CDATA[Prix: A partir de 59 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mazda/6/2-0l-147-ch.1278/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/07/1278.jpg"" length= ""11553"" type= ""image/jpeg""/>
            <pubDate > Mon, 30 Jul 2012 00:07:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mazda/6/2-0l-147-ch.1278/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Peugeot Bipper]]>
            </title>
            <link>http://www.automobile.tn/neuf/peugeot/bipper.1072/</link>
            <description>
                <![CDATA[Prix: A partir de 26 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/peugeot/bipper.1072/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/07/2099.jpg"" length= ""10618"" type= ""image/jpeg""/>
            <pubDate > Wed, 25 Jul 2012 00:07:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/peugeot/bipper.1072/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Toyota Hilux]]>
            </title>
            <link>http://www.automobile.tn/neuf/toyota/hilux.213/</link>
            <description>
                <![CDATA[Prix: A partir de 52 800 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/toyota/hilux.213/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/06/1971.jpg"" length= ""10844"" type= ""image/jpeg""/>
            <pubDate > Sat, 30 Jun 2012 00:06:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/toyota/hilux.213/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Toyota Yaris Sedan]]>
            </title>
            <link>http://www.automobile.tn/neuf/toyota/yaris-sedan/1-3l.1960/</link>
            <description>
                <![CDATA[Prix: A partir de 34 800 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/toyota/yaris-sedan/1-3l.1960/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/06/1960.jpg"" length= ""10698"" type= ""image/jpeg""/>
            <pubDate > Fri, 29 Jun 2012 00:06:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/toyota/yaris-sedan/1-3l.1960/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Citroën Nemo]]>
            </title>
            <link>http://www.automobile.tn/neuf/citroen/nemo.279/</link>
            <description>
                <![CDATA[Prix: A partir de 27 580 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/citroen/nemo.279/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/05/1685.jpg"" length= ""11826"" type= ""image/jpeg""/>
            <pubDate > Tue, 22 May 2012 00:05:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/citroen/nemo.279/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Volvo S60]]>
            </title>
            <link>http://www.automobile.tn/neuf/volvo/s60/1-6-l-turbo.1642/</link>
            <description>
                <![CDATA[Prix: A partir de 77 500 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/volvo/s60/1-6-l-turbo.1642/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/05/1642.jpg"" length= ""11102"" type= ""image/jpeg""/>
            <pubDate > Fri, 18 May 2012 00:05:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/volvo/s60/1-6-l-turbo.1642/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Audi Q3]]>
            </title>
            <link>http://www.automobile.tn/neuf/audi/q3/2-0-l-tdi-ambiente.1586/</link>
            <description>
                <![CDATA[Prix: A partir de 106 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/audi/q3/2-0-l-tdi-ambiente.1586/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/05/1586.jpg"" length= ""10883"" type= ""image/jpeg""/>
            <pubDate > Fri, 11 May 2012 00:05:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/audi/q3/2-0-l-tdi-ambiente.1586/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Volkswagen CC]]>
            </title>
            <link>http://www.automobile.tn/neuf/volkswagen/cc.1397/</link>
            <description>
                <![CDATA[Prix: A partir de 116 480 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/volkswagen/cc.1397/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/04/1314.jpg"" length= ""10861"" type= ""image/jpeg""/>
            <pubDate > Thu, 05 Apr 2012 00:04:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/volkswagen/cc.1397/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Volkswagen Amarok]]>
            </title>
            <link>http://www.automobile.tn/neuf/volkswagen/amarok.110/</link>
            <description>
                <![CDATA[Prix: A partir de 53 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/volkswagen/amarok.110/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/03/1257.jpg"" length= ""11631"" type= ""image/jpeg""/>
            <pubDate > Mon, 26 Mar 2012 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/volkswagen/amarok.110/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Renault Clio]]>
            </title>
            <link>http://www.automobile.tn/neuf/renault/clio.67/</link>
            <description>
                <![CDATA[Prix: A partir de 35 150 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/renault/clio.67/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/03/4168.jpg"" length= ""12957"" type= ""image/jpeg""/>
            <pubDate > Sun, 11 Mar 2012 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/renault/clio.67/</guid>
        </item>
        <item>
            <title>
                <![CDATA[BMW X3]]>
            </title>
            <link>http://www.automobile.tn/neuf/bmw/x3.121/</link>
            <description>
                <![CDATA[Prix: A partir de 135 800 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/bmw/x3.121/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/03/311.png"" length= ""17470"" type= ""image/jpeg""/>
            <pubDate > Thu, 01 Mar 2012 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/bmw/x3.121/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Land Rover Range Rover Evoque]]>
            </title>
            <link>http://www.automobile.tn/neuf/land-rover/range-rover-evoque.138/</link>
            <description>
                <![CDATA[Prix: A partir de 141 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/land-rover/range-rover-evoque.138/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/02/973.jpg"" length= ""12306"" type= ""image/jpeg""/>
            <pubDate > Thu, 23 Feb 2012 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/land-rover/range-rover-evoque.138/</guid>
        </item>
        <item>
            <title>
                <![CDATA[KIA Cerato]]>
            </title>
            <link>http://www.automobile.tn/neuf/kia/cerato.55/</link>
            <description>
                <![CDATA[Prix: A partir de 53 780 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/kia/cerato.55/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/02/3917.jpg"" length= ""13064"" type= ""image/jpeg""/>
            <pubDate > Sun, 19 Feb 2012 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/kia/cerato.55/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Volvo XC60]]>
            </title>
            <link>http://www.automobile.tn/neuf/volvo/xc60/2-0-t-d3.893/</link>
            <description>
                <![CDATA[Prix: A partir de 119 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/volvo/xc60/2-0-t-d3.893/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/02/893.jpg"" length= ""10048"" type= ""image/jpeg""/>
            <pubDate > Wed, 15 Feb 2012 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/volvo/xc60/2-0-t-d3.893/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Citroën C4]]>
            </title>
            <link>http://www.automobile.tn/neuf/citroen/c4.130/</link>
            <description>
                <![CDATA[Prix: A partir de 44 600 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/citroen/c4.130/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/02/137.jpg"" length= ""12601"" type= ""image/jpeg""/>
            <pubDate > Wed, 15 Feb 2012 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/citroen/c4.130/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Citroën DS4]]>
            </title>
            <link>http://www.automobile.tn/neuf/citroen/ds4/vti-120-ch-so-chic.330/</link>
            <description>
                <![CDATA[Prix: A partir de 63 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/citroen/ds4/vti-120-ch-so-chic.330/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/02/330.jpg"" length= ""11410"" type= ""image/jpeg""/>
            <pubDate > Wed, 15 Feb 2012 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/citroen/ds4/vti-120-ch-so-chic.330/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Fiat 500]]>
            </title>
            <link>http://www.automobile.tn/neuf/fiat/500.91/</link>
            <description>
                <![CDATA[Prix: A partir de 33 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/fiat/500.91/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/02/3887.jpg"" length= ""10129"" type= ""image/jpeg""/>
            <pubDate > Wed, 15 Feb 2012 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/fiat/500.91/</guid>
        </item>
        <item>
            <title>
                <![CDATA[KIA Quoris]]>
            </title>
            <link>http://www.automobile.tn/neuf/kia/quoris/3-8-l-v6.3864/</link>
            <description>
                <![CDATA[Prix: A partir de 194 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/kia/quoris/3-8-l-v6.3864/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/02/3864.jpg"" length= ""10577"" type= ""image/jpeg""/>
            <pubDate > Sat, 11 Feb 2012 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/kia/quoris/3-8-l-v6.3864/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Hyundai ix35]]>
            </title>
            <link>http://www.automobile.tn/neuf/hyundai/ix35.647/</link>
            <description>
                <![CDATA[Prix: A partir de 88 950 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/hyundai/ix35.647/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/02/16541.jpg"" length= ""10662"" type= ""image/jpeg""/>
            <pubDate > Tue, 07 Feb 2012 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/hyundai/ix35.647/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Alfa Romeo Mito]]>
            </title>
            <link>http://www.automobile.tn/neuf/alfa-romeo/mito/1-4-l-multiair.24/</link>
            <description>
                <![CDATA[Prix: A partir de 46 500 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/alfa-romeo/mito/1-4-l-multiair.24/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/01/24.jpeg"" length= ""10903"" type= ""image/jpeg""/>
            <pubDate > Fri, 27 Jan 2012 00:01:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/alfa-romeo/mito/1-4-l-multiair.24/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mercedes-Benz Classe B]]>
            </title>
            <link>http://www.automobile.tn/neuf/mercedes-benz/classe-b/180-blueefficiency-sports-tourer.3712/</link>
            <description>
                <![CDATA[Prix: A partir de 75 200 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mercedes-benz/classe-b/180-blueefficiency-sports-tourer.3712/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/01/3712.jpg"" length= ""10614"" type= ""image/jpeg""/>
            <pubDate > Sun, 22 Jan 2012 00:01:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mercedes-benz/classe-b/180-blueefficiency-sports-tourer.3712/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Volkswagen Tiguan]]>
            </title>
            <link>http://www.automobile.tn/neuf/volkswagen/tiguan.194/</link>
            <description>
                <![CDATA[Prix: A partir de 99 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/volkswagen/tiguan.194/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2012/01/704.jpg"" length= ""11591"" type= ""image/jpeg""/>
            <pubDate > Fri, 13 Jan 2012 00:01:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/volkswagen/tiguan.194/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mazda CX-7]]>
            </title>
            <link>http://www.automobile.tn/neuf/mazda/cx-7/2-3-l.238/</link>
            <description>
                <![CDATA[Prix: A partir de 89 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mazda/cx-7/2-3-l.238/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/12/238.png"" length= ""16669"" type= ""image/jpeg""/>
            <pubDate > Sat, 17 Dec 2011 00:12:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mazda/cx-7/2-3-l.238/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mazda CX-9]]>
            </title>
            <link>http://www.automobile.tn/neuf/mazda/cx-9/3-7l-v6.239/</link>
            <description>
                <![CDATA[Prix: A partir de 117 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mazda/cx-9/3-7l-v6.239/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/12/239.jpg"" length= ""11863"" type= ""image/jpeg""/>
            <pubDate > Sat, 17 Dec 2011 00:12:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mazda/cx-9/3-7l-v6.239/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mazda BT-50]]>
            </title>
            <link>http://www.automobile.tn/neuf/mazda/bt-50/double-cabine-mid.577/</link>
            <description>
                <![CDATA[Prix: A partir de 54 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mazda/bt-50/double-cabine-mid.577/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/12/577.jpg"" length= ""10518"" type= ""image/jpeg""/>
            <pubDate > Thu, 15 Dec 2011 00:12:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mazda/bt-50/double-cabine-mid.577/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Dacia Logan MCV]]>
            </title>
            <link>http://www.automobile.tn/neuf/dacia/logan-mcv/1-2-l.422/</link>
            <description>
                <![CDATA[Prix: A partir de 26 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/dacia/logan-mcv/1-2-l.422/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/11/422.jpg"" length= ""10467"" type= ""image/jpeg""/>
            <pubDate > Tue, 22 Nov 2011 00:11:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/dacia/logan-mcv/1-2-l.422/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Jaguar XJ]]>
            </title>
            <link>http://www.automobile.tn/neuf/jaguar/xj/2-0-l-premium-luxury.142/</link>
            <description>
                <![CDATA[Prix: A partir de 245 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/jaguar/xj/2-0-l-premium-luxury.142/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/11/142.jpg"" length= ""10763"" type= ""image/jpeg""/>
            <pubDate > Thu, 17 Nov 2011 00:11:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/jaguar/xj/2-0-l-premium-luxury.142/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Ford Focus]]>
            </title>
            <link>http://www.automobile.tn/neuf/ford/focus.93/</link>
            <description>
                <![CDATA[Prix: A partir de 42 500 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/ford/focus.93/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/11/376.jpg"" length= ""12634"" type= ""image/jpeg""/>
            <pubDate > Fri, 11 Nov 2011 00:11:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/ford/focus.93/</guid>
        </item>
        <item>
            <title>
                <![CDATA[KIA Cadenza]]>
            </title>
            <link>http://www.automobile.tn/neuf/kia/cadenza/3-5l-v6-bva.103/</link>
            <description>
                <![CDATA[Prix: A partir de 104 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/kia/cadenza/3-5l-v6-bva.103/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/11/103.jpg"" length= ""11904"" type= ""image/jpeg""/>
            <pubDate > Fri, 11 Nov 2011 00:11:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/kia/cadenza/3-5l-v6-bva.103/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Peugeot Expert]]>
            </title>
            <link>http://www.automobile.tn/neuf/peugeot/expert/1-6-l-hdi-l1h1-clim.361/</link>
            <description>
                <![CDATA[Prix: A partir de 42 800 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/peugeot/expert/1-6-l-hdi-l1h1-clim.361/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/11/361.png"" length= ""16084"" type= ""image/jpeg""/>
            <pubDate > Fri, 04 Nov 2011 00:11:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/peugeot/expert/1-6-l-hdi-l1h1-clim.361/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Peugeot Expert Tepee]]>
            </title>
            <link>http://www.automobile.tn/neuf/peugeot/expert-tepee/hdi.360/</link>
            <description>
                <![CDATA[Prix: A partir de 60 500 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/peugeot/expert-tepee/hdi.360/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/11/360.png"" length= ""19389"" type= ""image/jpeg""/>
            <pubDate > Fri, 04 Nov 2011 00:11:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/peugeot/expert-tepee/hdi.360/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Peugeot Bipper Tepee]]>
            </title>
            <link>http://www.automobile.tn/neuf/peugeot/bipper-tepee.80/</link>
            <description>
                <![CDATA[Prix: A partir de 36 100 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/peugeot/bipper-tepee.80/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/11/71.png"" length= ""18162"" type= ""image/jpeg""/>
            <pubDate > Tue, 01 Nov 2011 00:11:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/peugeot/bipper-tepee.80/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Peugeot Partner]]>
            </title>
            <link>http://www.automobile.tn/neuf/peugeot/partner.924/</link>
            <description>
                <![CDATA[Prix: A partir de 34 200 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/peugeot/partner.924/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/11/353.jpg"" length= ""11360"" type= ""image/jpeg""/>
            <pubDate > Tue, 01 Nov 2011 00:11:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/peugeot/partner.924/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Peugeot Partner Tepee]]>
            </title>
            <link>http://www.automobile.tn/neuf/peugeot/partner-tepee/1-6-l.63/</link>
            <description>
                <![CDATA[Prix: A partir de 46 200 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/peugeot/partner-tepee/1-6-l.63/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/11/63.png"" length= ""16713"" type= ""image/jpeg""/>
            <pubDate > Tue, 01 Nov 2011 00:11:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/peugeot/partner-tepee/1-6-l.63/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Volkswagen Multivan]]>
            </title>
            <link>http://www.automobile.tn/neuf/volkswagen/multivan.197/</link>
            <description>
                <![CDATA[Prix: A partir de 86 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/volkswagen/multivan.197/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/10/343.jpg"" length= ""10134"" type= ""image/jpeg""/>
            <pubDate > Fri, 28 Oct 2011 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/volkswagen/multivan.197/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Nissan X-trail]]>
            </title>
            <link>http://www.automobile.tn/neuf/nissan/x-trail.376/</link>
            <description>
                <![CDATA[Prix: A partir de 69 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/nissan/x-trail.376/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/10/340.png"" length= ""17647"" type= ""image/jpeg""/>
            <pubDate > Tue, 25 Oct 2011 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/nissan/x-trail.376/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Nissan Murano]]>
            </title>
            <link>http://www.automobile.tn/neuf/nissan/murano/3-5-l-v6.339/</link>
            <description>
                <![CDATA[Prix: A partir de 110 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/nissan/murano/3-5-l-v6.339/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/10/339.jpg"" length= ""10873"" type= ""image/jpeg""/>
            <pubDate > Thu, 20 Oct 2011 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/nissan/murano/3-5-l-v6.339/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Land Rover Defender]]>
            </title>
            <link>http://www.automobile.tn/neuf/land-rover/defender.373/</link>
            <description>
                <![CDATA[Prix: A partir de 120 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/land-rover/defender.373/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/10/15689.jpg"" length= ""9552"" type= ""image/jpeg""/>
            <pubDate > Mon, 17 Oct 2011 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/land-rover/defender.373/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Seat Ibiza]]>
            </title>
            <link>http://www.automobile.tn/neuf/seat/ibiza.42/</link>
            <description>
                <![CDATA[Prix: A partir de 28 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/seat/ibiza.42/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/10/74.jpg"" length= ""12785"" type= ""image/jpeg""/>
            <pubDate > Tue, 11 Oct 2011 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/seat/ibiza.42/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Fiat Punto Easy]]>
            </title>
            <link>http://www.automobile.tn/neuf/fiat/punto-easy/1-2-l.79/</link>
            <description>
                <![CDATA[Prix: A partir de 30 500 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/fiat/punto-easy/1-2-l.79/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/10/79.jpg"" length= ""11869"" type= ""image/jpeg""/>
            <pubDate > Tue, 11 Oct 2011 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/fiat/punto-easy/1-2-l.79/</guid>
        </item>
        <item>
            <title>
                <![CDATA[BMW Série 3 coupé]]>
            </title>
            <link>http://www.automobile.tn/neuf/bmw/serie-3-coupe/316i-confort-tv.303/</link>
            <description>
                <![CDATA[Prix: A partir de 91 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/bmw/serie-3-coupe/316i-confort-tv.303/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/10/303.jpg"" length= ""10531"" type= ""image/jpeg""/>
            <pubDate > Tue, 11 Oct 2011 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/bmw/serie-3-coupe/316i-confort-tv.303/</guid>
        </item>
        <item>
            <title>
                <![CDATA[BMW Série 1 5p]]>
            </title>
            <link>http://www.automobile.tn/neuf/bmw/serie-1-5p.112/</link>
            <description>
                <![CDATA[Prix: A partir de 70 800 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/bmw/serie-1-5p.112/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/10/299.png"" length= ""15209"" type= ""image/jpeg""/>
            <pubDate > Tue, 11 Oct 2011 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/bmw/serie-1-5p.112/</guid>
        </item>
        <item>
            <title>
                <![CDATA[KIA Rio]]>
            </title>
            <link>http://www.automobile.tn/neuf/kia/rio/1-2-l.91/</link>
            <description>
                <![CDATA[Prix: A partir de 33 480 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/kia/rio/1-2-l.91/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/10/91.jpg"" length= ""11878"" type= ""image/jpeg""/>
            <pubDate > Mon, 10 Oct 2011 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/kia/rio/1-2-l.91/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Renault Mégane]]>
            </title>
            <link>http://www.automobile.tn/neuf/renault/megane/1-6-16v-dynamique.57/</link>
            <description>
                <![CDATA[Prix: A partir de 44 400 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/renault/megane/1-6-16v-dynamique.57/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/10/57.jpg"" length= ""10304"" type= ""image/jpeg""/>
            <pubDate > Sun, 09 Oct 2011 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/renault/megane/1-6-16v-dynamique.57/</guid>
        </item>
        <item>
            <title>
                <![CDATA[BMW Série 3 cabriolet]]>
            </title>
            <link>http://www.automobile.tn/neuf/bmw/serie-3-cabriolet/320i-bva.118/</link>
            <description>
                <![CDATA[Prix: A partir de 149 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/bmw/serie-3-cabriolet/320i-bva.118/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/10/118.png"" length= ""15700"" type= ""image/jpeg""/>
            <pubDate > Sun, 09 Oct 2011 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/bmw/serie-3-cabriolet/320i-bva.118/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Ssangyong Actyon Sports]]>
            </title>
            <link>http://www.automobile.tn/neuf/ssangyong/actyon-sports.1229/</link>
            <description>
                <![CDATA[Prix: A partir de 51 200 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/ssangyong/actyon-sports.1229/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/10/1094.jpg"" length= ""12387"" type= ""image/jpeg""/>
            <pubDate > Fri, 07 Oct 2011 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/ssangyong/actyon-sports.1229/</guid>
        </item>
        <item>
            <title>
                <![CDATA[KIA Rio 5p]]>
            </title>
            <link>http://www.automobile.tn/neuf/kia/rio-5p/1-2-l.92/</link>
            <description>
                <![CDATA[Prix: A partir de 35 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/kia/rio-5p/1-2-l.92/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/10/92.jpg"" length= ""11640"" type= ""image/jpeg""/>
            <pubDate > Fri, 07 Oct 2011 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/kia/rio-5p/1-2-l.92/</guid>
        </item>
        <item>
            <title>
                <![CDATA[KIA Sorento]]>
            </title>
            <link>http://www.automobile.tn/neuf/kia/sorento/2-2-l-crdi-bva.102/</link>
            <description>
                <![CDATA[Prix: A partir de 99 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/kia/sorento/2-2-l-crdi-bva.102/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/10/102.jpg"" length= ""11846"" type= ""image/jpeg""/>
            <pubDate > Tue, 04 Oct 2011 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/kia/sorento/2-2-l-crdi-bva.102/</guid>
        </item>
        <item>
            <title>
                <![CDATA[KIA Optima]]>
            </title>
            <link>http://www.automobile.tn/neuf/kia/optima.97/</link>
            <description>
                <![CDATA[Prix: A partir de 66 480 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/kia/optima.97/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/10/96.jpg"" length= ""10708"" type= ""image/jpeg""/>
            <pubDate > Tue, 04 Oct 2011 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/kia/optima.97/</guid>
        </item>
        <item>
            <title>
                <![CDATA[KIA Sportage]]>
            </title>
            <link>http://www.automobile.tn/neuf/kia/sportage/bva.99/</link>
            <description>
                <![CDATA[Prix: A partir de 88 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/kia/sportage/bva.99/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/10/99.jpg"" length= ""11279"" type= ""image/jpeg""/>
            <pubDate > Tue, 04 Oct 2011 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/kia/sportage/bva.99/</guid>
        </item>
        <item>
            <title>
                <![CDATA[KIA Picanto]]>
            </title>
            <link>http://www.automobile.tn/neuf/kia/picanto.49/</link>
            <description>
                <![CDATA[Prix: A partir de 26 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/kia/picanto.49/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/10/15.jpg"" length= ""11515"" type= ""image/jpeg""/>
            <pubDate > Sat, 01 Oct 2011 00:10:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/kia/picanto.49/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Fiat Linea]]>
            </title>
            <link>http://www.automobile.tn/neuf/fiat/linea/s-dynamic-fire.285/</link>
            <description>
                <![CDATA[Prix: A partir de 33 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/fiat/linea/s-dynamic-fire.285/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/09/285.jpg"" length= ""10057"" type= ""image/jpeg""/>
            <pubDate > Tue, 20 Sep 2011 00:09:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/fiat/linea/s-dynamic-fire.285/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Volkswagen Touareg]]>
            </title>
            <link>http://www.automobile.tn/neuf/volkswagen/touareg/3-0-l-bva-pack-luxe.254/</link>
            <description>
                <![CDATA[Prix: A partir de 220 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/volkswagen/touareg/3-0-l-bva-pack-luxe.254/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/09/254.png"" length= ""17833"" type= ""image/jpeg""/>
            <pubDate > Sun, 18 Sep 2011 00:09:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/volkswagen/touareg/3-0-l-bva-pack-luxe.254/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Fiat Panda]]>
            </title>
            <link>http://www.automobile.tn/neuf/fiat/panda.312/</link>
            <description>
                <![CDATA[Prix: A partir de 26 790 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/fiat/panda.312/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/09/15495.jpg"" length= ""12939"" type= ""image/jpeg""/>
            <pubDate > Sat, 10 Sep 2011 00:09:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/fiat/panda.312/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Fiat Punto Pop]]>
            </title>
            <link>http://www.automobile.tn/neuf/fiat/punto-pop/1-2-fire.2513/</link>
            <description>
                <![CDATA[Prix: A partir de 27 200 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/fiat/punto-pop/1-2-fire.2513/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/09/2513.png"" length= ""18585"" type= ""image/jpeg""/>
            <pubDate > Sat, 10 Sep 2011 00:09:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/fiat/punto-pop/1-2-fire.2513/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Ssangyong Chairman]]>
            </title>
            <link>http://www.automobile.tn/neuf/ssangyong/chairman/cw-700.354/</link>
            <description>
                <![CDATA[Prix: A partir de 175 400 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/ssangyong/chairman/cw-700.354/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/09/354.jpg"" length= ""9362"" type= ""image/jpeg""/>
            <pubDate > Fri, 02 Sep 2011 00:09:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/ssangyong/chairman/cw-700.354/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Ssangyong Korando]]>
            </title>
            <link>http://www.automobile.tn/neuf/ssangyong/korando.222/</link>
            <description>
                <![CDATA[Prix: A partir de 75 800 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/ssangyong/korando.222/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/09/15526.jpg"" length= ""13323"" type= ""image/jpeg""/>
            <pubDate > Fri, 02 Sep 2011 00:09:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/ssangyong/korando.222/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Chevrolet Cruze 5P]]>
            </title>
            <link>http://www.automobile.tn/neuf/chevrolet/cruze-5p/1-6-l-16v-ls.2412/</link>
            <description>
                <![CDATA[Prix: A partir de 36 671 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/chevrolet/cruze-5p/1-6-l-16v-ls.2412/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/09/2412.jpg"" length= ""10977"" type= ""image/jpeg""/>
            <pubDate > Fri, 02 Sep 2011 00:09:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/chevrolet/cruze-5p/1-6-l-16v-ls.2412/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Ssangyong Kyron]]>
            </title>
            <link>http://www.automobile.tn/neuf/ssangyong/kyron/2-l-bvm.357/</link>
            <description>
                <![CDATA[Prix: A partir de 74 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/ssangyong/kyron/2-l-bvm.357/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/09/357.jpg"" length= ""11883"" type= ""image/jpeg""/>
            <pubDate > Fri, 02 Sep 2011 00:09:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/ssangyong/kyron/2-l-bvm.357/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Ssangyong Rexton]]>
            </title>
            <link>http://www.automobile.tn/neuf/ssangyong/rexton/2-7-l.356/</link>
            <description>
                <![CDATA[Prix: A partir de 89 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/ssangyong/rexton/2-7-l.356/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/09/356.jpg"" length= ""11763"" type= ""image/jpeg""/>
            <pubDate > Fri, 02 Sep 2011 00:09:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/ssangyong/rexton/2-7-l.356/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Nissan Juke]]>
            </title>
            <link>http://www.automobile.tn/neuf/nissan/juke/1-6-l-tekna-4x2.264/</link>
            <description>
                <![CDATA[Prix: A partir de 61 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/nissan/juke/1-6-l-tekna-4x2.264/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/08/264.png"" length= ""16699"" type= ""image/jpeg""/>
            <pubDate > Tue, 23 Aug 2011 00:08:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/nissan/juke/1-6-l-tekna-4x2.264/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Mercedes-Benz Classe E coupé]]>
            </title>
            <link>http://www.automobile.tn/neuf/mercedes-benz/classe-e-coupe/200-cgi.245/</link>
            <description>
                <![CDATA[Prix: A partir de 170 000 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/mercedes-benz/classe-e-coupe/200-cgi.245/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/08/245.jpg"" length= ""12603"" type= ""image/jpeg""/>
            <pubDate > Sat, 20 Aug 2011 00:08:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/mercedes-benz/classe-e-coupe/200-cgi.245/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Audi A6]]>
            </title>
            <link>http://www.automobile.tn/neuf/audi/a6/2-0-tfsi-ambition-luxe-bva.230/</link>
            <description>
                <![CDATA[Prix: A partir de 144 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/audi/a6/2-0-tfsi-ambition-luxe-bva.230/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/08/230.jpg"" length= ""10300"" type= ""image/jpeg""/>
            <pubDate > Mon, 15 Aug 2011 00:08:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/audi/a6/2-0-tfsi-ambition-luxe-bva.230/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Audi Q5]]>
            </title>
            <link>http://www.automobile.tn/neuf/audi/q5.29/</link>
            <description>
                <![CDATA[Prix: A partir de 145 980 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/audi/q5.29/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/08/36.jpg"" length= ""11395"" type= ""image/jpeg""/>
            <pubDate > Fri, 12 Aug 2011 00:08:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/audi/q5.29/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Hyundai Accent]]>
            </title>
            <link>http://www.automobile.tn/neuf/hyundai/accent.627/</link>
            <description>
                <![CDATA[Prix: A partir de 36 500 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/hyundai/accent.627/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/07/2012.jpg"" length= ""10781"" type= ""image/jpeg""/>
            <pubDate > Wed, 06 Jul 2011 00:07:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/hyundai/accent.627/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Hyundai i20]]>
            </title>
            <link>http://www.automobile.tn/neuf/hyundai/i20.642/</link>
            <description>
                <![CDATA[Prix: A partir de 29 650 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/hyundai/i20.642/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/07/1852.jpg"" length= ""9974"" type= ""image/jpeg""/>
            <pubDate > Wed, 06 Jul 2011 00:07:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/hyundai/i20.642/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Hyundai Elantra]]>
            </title>
            <link>http://www.automobile.tn/neuf/hyundai/elantra/1-6-l-130-ch-bvm6.2011/</link>
            <description>
                <![CDATA[Prix: A partir de 49 950 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/hyundai/elantra/1-6-l-130-ch-bvm6.2011/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/07/2011.jpg"" length= ""12076"" type= ""image/jpeg""/>
            <pubDate > Wed, 06 Jul 2011 00:07:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/hyundai/elantra/1-6-l-130-ch-bvm6.2011/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Nissan Navara]]>
            </title>
            <link>http://www.automobile.tn/neuf/nissan/navara/lux-4x4-double-cabine.106/</link>
            <description>
                <![CDATA[Prix: A partir de 64 700 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/nissan/navara/lux-4x4-double-cabine.106/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/07/106.png"" length= ""16365"" type= ""image/jpeg""/>
            <pubDate > Tue, 05 Jul 2011 00:07:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/nissan/navara/lux-4x4-double-cabine.106/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Peugeot 3008]]>
            </title>
            <link>http://www.automobile.tn/neuf/peugeot/3008/1-6-l-vti-120-ch-premium.67/</link>
            <description>
                <![CDATA[Prix: A partir de 60 400 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/peugeot/3008/1-6-l-vti-120-ch-premium.67/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/07/67.jpg"" length= ""10051"" type= ""image/jpeg""/>
            <pubDate > Sat, 02 Jul 2011 00:07:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/peugeot/3008/1-6-l-vti-120-ch-premium.67/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Renault Trafic]]>
            </title>
            <link>http://www.automobile.tn/neuf/renault/trafic/1-9-dci-100-ch.59/</link>
            <description>
                <![CDATA[Prix: A partir de 60 500 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/renault/trafic/1-9-dci-100-ch.59/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/07/59.jpg"" length= ""14121"" type= ""image/jpeg""/>
            <pubDate > Fri, 01 Jul 2011 00:07:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/renault/trafic/1-9-dci-100-ch.59/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Renault Mégane coupé]]>
            </title>
            <link>http://www.automobile.tn/neuf/renault/megane-coupe/vp-1-6-16v.58/</link>
            <description>
                <![CDATA[Prix: A partir de 49 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/renault/megane-coupe/vp-1-6-16v.58/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/07/58.jpg"" length= ""10533"" type= ""image/jpeg""/>
            <pubDate > Fri, 01 Jul 2011 00:07:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/renault/megane-coupe/vp-1-6-16v.58/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Renault Fluence]]>
            </title>
            <link>http://www.automobile.tn/neuf/renault/fluence.68/</link>
            <description>
                <![CDATA[Prix: A partir de 45 300 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/renault/fluence.68/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/06/53.jpg"" length= ""11884"" type= ""image/jpeg""/>
            <pubDate > Thu, 30 Jun 2011 00:06:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/renault/fluence.68/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Lancia Ypsilon]]>
            </title>
            <link>http://www.automobile.tn/neuf/lancia/ypsilon/1-2-l.1952/</link>
            <description>
                <![CDATA[Prix: A partir de 35 200 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/lancia/ypsilon/1-2-l.1952/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/06/1952.jpg"" length= ""11778"" type= ""image/jpeg""/>
            <pubDate > Tue, 28 Jun 2011 00:06:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/lancia/ypsilon/1-2-l.1952/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Volvo S80]]>
            </title>
            <link>http://www.automobile.tn/neuf/volvo/s80/2-0-t-d3.231/</link>
            <description>
                <![CDATA[Prix: A partir de 107 900 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/volvo/s80/2-0-t-d3.231/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/06/231.jpg"" length= ""12408"" type= ""image/jpeg""/>
            <pubDate > Wed, 15 Jun 2011 00:06:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/volvo/s80/2-0-t-d3.231/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Chevrolet Cruze]]>
            </title>
            <link>http://www.automobile.tn/neuf/chevrolet/cruze/1-6-16v.235/</link>
            <description>
                <![CDATA[Prix: A partir de 34 450 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/chevrolet/cruze/1-6-16v.235/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/03/235.png"" length= ""15891"" type= ""image/jpeg""/>
            <pubDate > Thu, 17 Mar 2011 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/chevrolet/cruze/1-6-16v.235/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Chevrolet Spark]]>
            </title>
            <link>http://www.automobile.tn/neuf/chevrolet/spark/1-2-l.236/</link>
            <description>
                <![CDATA[Prix: A partir de 24 230 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/chevrolet/spark/1-2-l.236/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/03/236.jpg"" length= ""13249"" type= ""image/jpeg""/>
            <pubDate > Tue, 15 Mar 2011 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/chevrolet/spark/1-2-l.236/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Chevrolet Aveo]]>
            </title>
            <link>http://www.automobile.tn/neuf/chevrolet/aveo/ls.155/</link>
            <description>
                <![CDATA[Prix: A partir de 25 261 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/chevrolet/aveo/ls.155/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/03/155.png"" length= ""15743"" type= ""image/jpeg""/>
            <pubDate > Tue, 08 Mar 2011 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/chevrolet/aveo/ls.155/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Chevrolet Captiva]]>
            </title>
            <link>http://www.automobile.tn/neuf/chevrolet/captiva/ltz.156/</link>
            <description>
                <![CDATA[Prix: A partir de 104 698 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/chevrolet/captiva/ltz.156/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/03/156.jpg"" length= ""12265"" type= ""image/jpeg""/>
            <pubDate > Tue, 08 Mar 2011 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/chevrolet/captiva/ltz.156/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Chevrolet Sonic 4p]]>
            </title>
            <link>http://www.automobile.tn/neuf/chevrolet/sonic-4p/1-2-l.1059/</link>
            <description>
                <![CDATA[Prix: A partir de 30 492 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/chevrolet/sonic-4p/1-2-l.1059/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/03/1059.jpg"" length= ""10534"" type= ""image/jpeg""/>
            <pubDate > Wed, 02 Mar 2011 00:03:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/chevrolet/sonic-4p/1-2-l.1059/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Ford Fiesta]]>
            </title>
            <link>http://www.automobile.tn/neuf/ford/fiesta.34/</link>
            <description>
                <![CDATA[Prix: A partir de 32 200 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/ford/fiesta.34/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/02/3944.jpg"" length= ""12530"" type= ""image/jpeg""/>
            <pubDate > Tue, 22 Feb 2011 00:02:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/ford/fiesta.34/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Opel Corsa]]>
            </title>
            <link>http://www.automobile.tn/neuf/opel/corsa/1-2-l.157/</link>
            <description>
                <![CDATA[Prix: A partir de 28 801 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/opel/corsa/1-2-l.157/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/01/157.jpg"" length= ""11081"" type= ""image/jpeg""/>
            <pubDate > Mon, 10 Jan 2011 00:01:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/opel/corsa/1-2-l.157/</guid>
        </item>
        <item>
            <title>
                <![CDATA[Opel Astra]]>
            </title>
            <link>http://www.automobile.tn/neuf/opel/astra/1-4-l-turbo.152/</link>
            <description>
                <![CDATA[Prix: A partir de 57 729 DT<br>]]>
            </description>
            <author>contact @automobile.tn(www.automobile.tn)</author>
            <category>Auto Occasion</category>
            <comments>http://www.automobile.tn/neuf/opel/astra/1-4-l-turbo.152/</comments>
            <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2011/01/152.jpg"" length= ""12550"" type= ""image/jpeg""/>
            <pubDate > Mon, 10 Jan 2011 00:01:00 +0100</pubDate>
            <guid>http://www.automobile.tn/neuf/opel/astra/1-4-l-turbo.152/</guid>
        </item>
    </channel>
</rss>";
#endregion

		public async Task<List<Car>> GetCarsCollectionAsync()
		{

			var httpClient = new HttpClient();

			try
			{

				var xmlContent = await httpClient.GetStringAsync("http://www.automobile.tn/rss/neuf.php");

				//var xmlContent = _dataXml;

				if (string.IsNullOrEmpty(xmlContent))
				{
					xmlContent = _dataXml;
				}

				var xml = XElement.Parse(xmlContent);

				var items = xml.Element("channel").Elements("item");

				var result = new List<Car>();

				foreach (var article in items)
				{
					var car = new Car
					{
						Title = article.Element("title").Value,
						//Link = article.Element(""link"").Value,
						Description = article.Element("description").Value,
						PubDate = article.Element("pubDate").Value,//Convert.ToDateTime(article.Element(""date"").Value),
						ImageUrl = article.Element("enclosure").Attribute("url").Value,
						//SmallImageUrl = article.Element(""photo"").Value.Replace(""jpg/"", ""thumb/small_""),
						//TextNews = article.Element(""teaser"").Value
					};

					result.Add(car);
				}

				//<item>
				//  <title> <![CDATA[Mazda 2]]> </title>
				//  <link> http://www.automobile.tn/neuf/mazda/2/1-3-l-mzr.11287 </link> 
				//  <description> <![CDATA[Prix: A partir de 29 900 DT<br>]]> </description>
				//  <author> contact @automobile.tn(www.automobile.tn) </ author >
				//  <category> Auto Occasion </ category >
				//  <comments> http://www.automobile.tn/neuf/mazda/2/1-3-l-mzr.11287/</comments> 
				//  <enclosure url = ""http://www.automobile.tn/images/catalogue/min/2014/05/11287.jpg"" length = ""11283"" type = ""image/jpeg""/>
				//  <pubDate> Sun, 25 May 2014 00:05:00 + 0100 </ pubDate >
				//  <guid> http://www.automobile.tn/neuf/mazda/2/1-3-l-mzr.11287/</guid> 
				//</item>

				return result;
			}
			catch (Exception exc)
			{
				return null;
			}
		}
	}
}
