public class Student{
    public int Id{get;set;}
    public string? Name{get;set;}

    public string? Email{get;set;}

    public DateTime CreatedOn{get;set;}

    public int LanguageId{get;set;}

    public Language? Language{get;set;}
}