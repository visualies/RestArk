using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using RestArk.Core.Entities;

namespace RestArk.Services.Services
{
    public static class FileReaderService
    {
        public static BaseConfig GetConfig()
        {
            var file = "./Config/Config.json";
            var data = File.ReadAllText(file);
            return JsonConvert.DeserializeObject<BaseConfig>(data);
        }
    }
}
