namespace RecruitmentTaskShared.Paging
{
    public class PaginationParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public string SortBy { get; set; }
        public bool SortDescending { get; set; }
        public int PageSize 
        { 
            get => pageSize; 
            set => pageSize = (value > MaxPageSize) ? MaxPageSize : value; 
        }
    }
}