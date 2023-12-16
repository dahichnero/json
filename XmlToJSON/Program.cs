using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using XmlToJSON;

/*XmlDocument xmlDocument = new XmlDocument();//1
xmlDocument.Load("valutes.xml");
var valutes = xmlDocument.DocumentElement;//InnerText?

var options=new JsonSerializerOptions
{
    Encoder=System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
    WriteIndented=true
};
string jsonText = JsonConvert.SerializeXmlNode(valutes);
Console.WriteLine(jsonText);*/

HttpClient client = new HttpClient();//2

HttpResponseMessage response = await client.GetAsync("https://api.waifu.im/search/?many=true");

string json = await response.Content.ReadAsStringAsync();
/*Tag tag = JsonConvert.DeserializeObject<Tag>(json);
Image image = JsonConvert.DeserializeObject<Image>(json);*/
MainPic Mainpic =  JsonConvert.DeserializeObject<MainPic>(json);

for (int i = 0; i < Mainpic.images.Length; i++)
{
    Image v = Mainpic.images[i];
    Console.WriteLine(v.signature);
    Console.WriteLine(v.extension);
    Console.WriteLine(v.image_id);
    Console.WriteLine(v.favourites);
    Console.WriteLine(v.dominant_color);
    Console.WriteLine(v.source);
    Console.WriteLine(v.uploaded_at);
    Console.WriteLine(v.liked_at);
    Console.WriteLine(v.is_nsfw);
    Console.WriteLine(v.url);
    Console.WriteLine(v.width);
    Console.WriteLine(v.height);
    Console.WriteLine(v.preview_url);
    foreach (Tag tag in v.tags)
    {
        Console.WriteLine(tag.tag_id);
        Console.WriteLine(tag.name);
        Console.WriteLine(tag.description);
        Console.WriteLine(tag.is_nsfw);
    }
}
