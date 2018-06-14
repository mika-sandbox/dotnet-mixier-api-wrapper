namespace Frau.Models.Flow
{
    public interface IPagenator
    {
        string First { get; set; }
        string Next { get; set; }
        string Prev { get; set; }
        string Last { get; set; }
        uint Total { get; set; }

        object Body { get; set; }
    }

    public class Pagenator<T> : IPagenator where T : class
    {
        private object _body;

        public T Body => _body as T;
        public string First { get; set; }
        public string Next { get; set; }
        public string Prev { get; set; }
        public string Last { get; set; }
        public uint Total { get; set; }

        object IPagenator.Body
        {
            get => _body;
            set => _body = value;
        }
    }
}