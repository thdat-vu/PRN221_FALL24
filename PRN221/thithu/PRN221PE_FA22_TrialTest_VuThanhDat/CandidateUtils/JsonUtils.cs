using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CandidateUtils
{
    public static class JsonUtils<T>
    {
        public static void writeJson(List<T> list, string path)
        {
            var option = new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles
            };
            string profilesJson = JsonSerializer.Serialize(list, option);
            //string profilesPath = "E:\\NewUniversityStuff\\PRN221\\thithu\\PRN221PE_FA22_TrialTest_VuThanhDat\\Candidate_Dao\\profiles.json";
            System.IO.File.WriteAllText(path, profilesJson);
           
        }
    }
}
