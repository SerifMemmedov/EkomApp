namespace Entities
{
    public class CategoryRecord : BaseEntity
    {

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public int LanguageID { get; set; }
        public string Name { get; set; }
        public string? Summary { get; set; }
        public string? Desciprtion { get; set; }
    }
}
