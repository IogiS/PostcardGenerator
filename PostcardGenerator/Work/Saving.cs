using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PostcardGenerator.Work;

namespace PostcardGenerator
{
    public static class Saving
    {
        public static List<string> savingString = new List<string>();
        public static List<string> savingImages = new List<string>();
        static public void addPropertiesLabels(byte[] image, string name,string value , string elemName, Font elementFont, Color elementForeColor)
        {
            SavingSettings setting = new SavingSettings() { SettingName = name, SettingValue = value, SettingImage = image, ElementName = elemName , Font = elementFont, Color = elementForeColor };

            if (elemName == "Panel")
                savingImages.Add(JsonConvert.SerializeObject(setting));
            else if (elemName == "Label")
                savingString.Add(JsonConvert.SerializeObject(setting));
        }

        static public void save()
        {
            File.AppendAllLines("settings.json", savingString);
            File.AppendAllLines("settings.json", savingImages);
        }







    }
}
