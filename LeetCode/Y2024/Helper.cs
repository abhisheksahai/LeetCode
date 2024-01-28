namespace LeetCode.Y2024
{
    public class ListNodeDelete
    {
        public int val;
        public ListNodeDelete next;
        public ListNodeDelete(int x) { val = x; }
    }

    public class ListNodeRemove
    {
        public int val;
        public ListNodeRemove next;
        public ListNodeRemove(int val = 0, ListNodeRemove next = null)
        {
            this.val = val;
            this.next = next;
        }
    }