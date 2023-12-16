namespace XmlToJSON
{
    public class Image
    {
        public string signature { get; set; }
        public string extension { get; set; }
        public int image_id { get; set; }
        public int favourites { get; set; }
        public string dominant_color { get; set; }
        public string source { get; set; }
        public DateTime uploaded_at { get; set; }
        public object liked_at { get; set; }
        public bool is_nsfw { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
        public string preview_url { get; set; }
        public Tag[] tags { get; set; }
    }

}
