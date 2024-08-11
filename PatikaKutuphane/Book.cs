using System;

public class Book
{
    // Field
    public string Name { get; set; }
    public string WriterName { get; set; }
    public string WriterLastName { get; set; }
    public int PageNum { get; set; }
    public string Publisher { get; set; }
    public DateTime PubDate { get; set; }

    // Constructors
    public Book() //no params, auto-creates a book object
    {
        Name = "Adı Aylin";
        WriterName = "Ayşe";
        WriterLastName = "Kulin";
        PageNum = 398;
        Publisher = "Remzi Kitabevi";
        PubDate = DateTime.Now;
    }
    //below one uses params to create a new book object:
    public Book(string name, string writerName, string writerLastName, int pageNum, string publisher)
    {
        Name = name;
        WriterName = writerName;
        WriterLastName = writerLastName;
        PageNum = pageNum;
        Publisher = publisher;
        PubDate = DateTime.Now;
    }
}
