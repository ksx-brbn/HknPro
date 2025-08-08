namespace BourbonWeb.Models
{
    public class HomeViewModel
    {
        public required PaginatedList<HansokuSinsei> MainList { get; set; }
        public required PaginatedList<HansokuSinsei> QueryList { get; set; }
    }
}
