using CafeBlazor.DataBase;

namespace CafeBlazor.Services
{
    public class CurrentElementService
    {
        public Account? CurrentAccount { get; set; }
        public User? CurrentUser { get; set; }
        public string? CurrentRole { get; set; }
    }
}
