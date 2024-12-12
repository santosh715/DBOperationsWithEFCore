public class Language{
    public int Id{get;set;}
    public string? Title{get;set;}

    public string? Description{get;set;} 

    public ICollection<Student>? students{get;set;}
}