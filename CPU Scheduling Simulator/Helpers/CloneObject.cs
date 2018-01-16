using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPU_Scheduling_Simulator.Models;
using Newtonsoft.Json;

namespace CPU_Scheduling_Simulator.Helpers
{
    public static class CloneObject
    {
        public static T CloneJson<T>(this T source)
        {
            if (Object.ReferenceEquals(source, null))
            {
                return default(T);
            }

            var deserializeSettings = new JsonSerializerSettings { ObjectCreationHandling = ObjectCreationHandling.Replace };

            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(source), deserializeSettings);
        }

        public static IList<Process> CloneList(IList<Process> initialList)
        {
            IList<Process> finalList = new List<Process>();

            if (initialList.Count > 0)
            {
                for (int it = 0; it < initialList.Count; it++)
                {
                    finalList.Add(CloneJson(initialList[it]));
                }
            }

            return finalList;
        }
    }
}
