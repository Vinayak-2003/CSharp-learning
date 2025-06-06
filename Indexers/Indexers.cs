namespace Indexers
{
    public class TempRecord
    {
        float[] temps = [56.2F, 56.7F, 56.5F, 56.9F, 58.8F, 61.3F, 65.9F, 62.1F, 59.2F, 57.5F];
        public int length => temps.Length;
        public float this[int index]
        {
            get => temps[index];
            set => temps[index] = value;
        }
    }
}