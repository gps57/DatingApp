namespace API.Helpers
{
    public class PaginationParams
    {
        private const int MaxPageSize = 50;  // Hmmmm.  what is a resonable number for when I paginate the jobs?
        public int PageNumber { get; set; } = 1;

        private int _pageSize = 10;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }
    }
}