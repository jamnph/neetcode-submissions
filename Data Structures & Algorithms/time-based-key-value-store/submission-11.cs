public class TimeMap {
    // field
    private Dictionary<string, Dictionary<int, string>> keyStore;
    public TimeMap(){ // constructor
        keyStore = new Dictionary<string, Dictionary<int, string>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        // key is key but int is also a key because it's use later on in Get()
        if (!keyStore.ContainsKey(key)) {
            keyStore[key] = new Dictionary<int, string> { {timestamp, value}};
        }

        // above only takes care of adding a new key with timestamp for the first time
        // the case of already have a name, but a new timestamp & value
        if (!keyStore[key].ContainsKey(timestamp)) {
            keyStore[key][timestamp] = value;
        }
    }
    
    public string Get(string key, int timestamp) {
        // 1/ easiest case is if key doesn't exist, then return ""
        // 2/ return value if key & timestamp are valid
        // 3/ key is valid, but timestamp is not then return the most previous timestamp
        // timestamp of set are strictly increasing so the order is already sorted as we add it to the dictionary
        if  (!keyStore.ContainsKey(key)) return "";

        // can we combine logic for 2/ & 3/ ?
        int seen = 0; //temporary timestamp
        foreach (int entry in keyStore[key].Keys) {
            if (entry <= timestamp) seen = entry;
        }

        // now seen will either be 0 (if timestamp key doesn't exist)
        // or it will be up to or equal to (most recent) the timestamp we're looking for

        return (seen == 0) ? "" : keyStore[key][seen];
    }
}
