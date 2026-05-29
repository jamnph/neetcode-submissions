public class TimeMap {
    public Dictionary<string, Dictionary<int, string>> keyStore;
    public TimeMap() {
        keyStore = new Dictionary<string, Dictionary<int, string>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        // each entry is a Dictionary<string key, some value X which is the string value & int timestamp
        // since operation Get() has 2 keys: key & timestamp, should make the timestamp the key as well in X value
        // so we have Dictionary<string, Dictionary<timestamp, value>>
        if (!keyStore.ContainsKey(key)){
            keyStore[key] = new Dictionary<int, string>() { {timestamp, value} };
        }

        // now what happens when we call timeMap.set("alice", "sad", 3); after timeMap.set("alice", "happy", 1);
        if (!keyStore[key].ContainsKey(timestamp)) {
            keyStore[key][timestamp] = value;
        }
    }
    
    public string Get(string key, int timestamp) {
        if (!keyStore.ContainsKey(key)) return "";
        // check for the newest timestamp
        var temp = keyStore[key];
        if (!keyStore[key].ContainsKey(timestamp)){
            // get previous timestamp
            int seen = 0;
            foreach (var entry in keyStore[key].Keys){
                if (entry < timestamp) {
                    seen = entry;
                }
            }
            if (seen == 0) return "";
            else return keyStore[key][seen];
        } else {
            return keyStore[key][timestamp];
        }
    }
}
