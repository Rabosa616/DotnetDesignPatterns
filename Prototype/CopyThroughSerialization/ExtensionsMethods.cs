using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace Prototype.CopyThroughSerialization;

public static class ExtensionsMethods
{
    public static T DeepCopy<T>(this T self)
    {
        string jsonString = JsonSerializer.Serialize(self);

        var response = JsonSerializer.Deserialize<T>(jsonString);

        return (T)response;
    }

    // With Xml Serializer we dont need to tag all clases with [Serializable]
    public static T DeepCopyXml<T>(this T self)
    {
        using var ms = new MemoryStream();
        var s = new XmlSerializer(typeof(T));
        s.Serialize(ms, self);
        ms.Position = 0;
        return (T)s.Deserialize(ms);
    }
}