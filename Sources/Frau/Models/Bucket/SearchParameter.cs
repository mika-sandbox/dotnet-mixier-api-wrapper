namespace Frau.Models.Bucket
{
    public class SearchParameter
    {
        public string Order { get; set; }

        public uint? Page { get; set; }

        public uint? Limit { get; set; }

        public string Where { get; set; }

        public string Fields { get; set; }

        public bool? NoCount { get; set; }
    }
}