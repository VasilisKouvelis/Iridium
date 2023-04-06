using Iridium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iridium.Managers {
    public class SpamManager {
        public void Start(Dictionary<int, SpamKey> spamKeyList) {       
            foreach (var item in spamKeyList) {
                var spamkey = item.Value;
                if (!spamkey.Active) continue;
                if (spamkey.SpamRunning) continue;
                    spamkey.StartSpam();
            }          
        }

        public void Stop(Dictionary<int, SpamKey> spamKeyList) { 
            foreach (var item in spamKeyList) {
                var spamkey = item.Value;
                if (!spamkey.Active) continue;
                if (!spamkey.SpamRunning) continue;
                    spamkey.StopSpam();
            }
            
        }
    }
}
