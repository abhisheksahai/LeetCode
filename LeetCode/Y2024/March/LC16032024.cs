namespace LeetCode.Y2024.March
{
    public static class LC16032024
    {
        /// <summary>
        /// https://leetcode.com/problems/implement-trie-prefix-tree/
        /// </summary>
        public class Trie
        {

            public Trie()
            {

            }

            public void Insert(string word)
            {

            }

            public bool Search(string word)
            {
                return false;
            }

            public bool StartsWith(string prefix)
            {
                return false;
            }
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            return "";
        }


        /// <summary>
        /// https://leetcode.com/problems/lru-cache/
        /// </summary>
        public class LRUCache
        {
            private class CacheItem
            {
                public int Key { get; }
                public int Value { get; set; }

                public CacheItem(int key, int value)
                {
                    Key = key;
                    Value = value;
                }
            }

            private readonly int capacity;
            private readonly Dictionary<int, LinkedListNode<CacheItem>> cacheMap;
            private readonly LinkedList<CacheItem> cacheList;

            public LRUCache(int capacity)
            {
                this.capacity = capacity;
                cacheMap = new Dictionary<int, LinkedListNode<CacheItem>>(capacity);
                cacheList = new LinkedList<CacheItem>();
            }

            public int Get(int key)
            {
                if (cacheMap.TryGetValue(key, out var node))
                {
                    cacheList.Remove(node);
                    cacheList.AddFirst(node);
                    return node.Value.Value;
                }
                return -1;
            }

            public void Put(int key, int value)
            {
                if (cacheMap.TryGetValue(key, out var node))
                {
                    node.Value.Value = value;
                    cacheList.Remove(node);
                    cacheList.AddFirst(node);
                }
                else
                {
                    if (cacheMap.Count >= capacity)
                    {
                        var lastNode = cacheList.Last;
                        cacheMap.Remove(lastNode.Value.Key);
                        cacheList.RemoveLast();
                    }

                    var newNode = new LinkedListNode<CacheItem>(new CacheItem(key, value));
                    cacheMap.Add(key, newNode);
                    cacheList.AddFirst(newNode);
                }
            }
        }
    }
}