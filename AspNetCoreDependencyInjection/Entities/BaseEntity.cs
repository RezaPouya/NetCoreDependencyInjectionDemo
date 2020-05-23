namespace AspNetCoreDependencyInjection.Services
{
    public class BaseEntity 
    { 
        public long CreateDateTime { get; set; }
        public string CreatedBy { get; set; }
        public long UpdateDateTime { get; set; }
        public string LastUpdateBy { get; set; }
        public long DeleteDateTime { get; set; }
        public string DeleteBy { get; set; }
        public bool IsDeleted { get; set; }
        
    }
}
