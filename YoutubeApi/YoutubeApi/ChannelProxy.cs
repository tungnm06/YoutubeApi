using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApi
{
    class ChannelProxy
    {
        public async static Task<RootObject> GetWeather()
        {
            var Client = new HttpClient();
           

            var reponse = await Client.GetAsync("https://www.googleapis.com/youtube/v3/videos?id=NyiyFp2V_Xs&key=a%20&part=snippet,contentDetails,statistics,status");

            var result = await reponse.Content.ReadAsStringAsync();

            var serializer = new DataContractJsonSerializer(typeof(RootObject));// Tao ra doi tuong chuyen doi DatoContractJson sang RootObject
            var memory = new MemoryStream(Encoding.UTF8.GetBytes(result)); // TAO RA memory stream de serialzer object
            var data = (RootObject)serializer.ReadObject(memory);

            return data;
        }
        [DataContract]
        public class PageInfo
        {
            [DataMember]
            public int totalResults { get; set; }
            [DataMember]
            public int resultsPerPage { get; set; }
        }
        [DataContract]
        public class Default
        {
            [DataMember]
            public string url { get; set; }
            [DataMember]
            public int width { get; set; }
            [DataMember]
            public int height { get; set; }
        }
        [DataContract]
        public class Medium
        {
            [DataMember]
            public string url { get; set; }
            [DataMember]
            public int width { get; set; }
            [DataMember]
            public int height { get; set; }
        }
        [DataContract]
        public class High
        {
            [DataMember]
            public string url { get; set; }
            [DataMember]
            public int width { get; set; }
            [DataMember]
            public int height { get; set; }
        }
        [DataContract]
        public class Standard
        {
            [DataMember]
            public string url { get; set; }
            [DataMember]
            public int width { get; set; }
            [DataMember]
            public int height { get; set; }
        }
        [DataContract]
        public class Maxres
        {
            [DataMember]
            public string url { get; set; }
            [DataMember]
            public int width { get; set; }
            [DataMember]
            public int height { get; set; }
        }
        [DataContract]
        public class Thumbnails
        {
            [DataMember]
            public Default @default { get; set; }
            [DataMember]
            public Medium medium { get; set; }
            [DataMember]
            public High high { get; set; }
            [DataMember]
            public Standard standard { get; set; }
            [DataMember]
            public Maxres maxres { get; set; }
        }
        [DataContract]
        public class Localized
        {
            [DataMember]
            public string title { get; set; }
            [DataMember]
            public string description { get; set; }
        }
        [DataContract]
        public class Snippet
        {
            [DataMember]
            public DateTime publishedAt { get; set; }
            [DataMember]
            public string channelId { get; set; }
            [DataMember]
            public string title { get; set; }
            [DataMember]
            public string description { get; set; }
            [DataMember]
            public Thumbnails thumbnails { get; set; }
            [DataMember]
            public string channelTitle { get; set; }
            [DataMember]
            public List<string> tags { get; set; }
            [DataMember]
            public string categoryId { get; set; }
            [DataMember]
            public string liveBroadcastContent { get; set; }
            [DataMember]
            public Localized localized { get; set; }
            [DataMember]
            public string defaultAudioLanguage { get; set; }
        }
        [DataContract]
        public class ContentDetails
        {
            [DataMember]
            public string duration { get; set; }
            [DataMember]
            public string dimension { get; set; }
            [DataMember]
            public string definition { get; set; }
            [DataMember]
            public string caption { get; set; }
            [DataMember]
            public bool licensedContent { get; set; }
            [DataMember]
            public string projection { get; set; }
        }
        [DataContract]
        public class Status
        {
            [DataMember]
            public string uploadStatus { get; set; }
            [DataMember]
            public string privacyStatus { get; set; }
            [DataMember]
            public string license { get; set; }
            [DataMember]
            public bool embeddable { get; set; }
            [DataMember]
            public bool publicStatsViewable { get; set; }
        }
        [DataContract]
        public class Statistics
        {
            public string viewCount { get; set; }
            public string likeCount { get; set; }
            public string dislikeCount { get; set; }
            public string favoriteCount { get; set; }
            public string commentCount { get; set; }
        }
        [DataContract]
        public class Item
        {
            public string kind { get; set; }
            public string etag { get; set; }
            public string id { get; set; }
            public Snippet snippet { get; set; }
            public ContentDetails contentDetails { get; set; }
            public Status status { get; set; }
            public Statistics statistics { get; set; }
        }
        [DataContract]
        public class RootObject
        {
            public string kind { get; set; }
            public string etag { get; set; }
            public PageInfo pageInfo { get; set; }
            public List<Item> items { get; set; }
        }
    }
}
