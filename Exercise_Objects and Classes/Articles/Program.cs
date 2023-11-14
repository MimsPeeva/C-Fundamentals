string[] input = Console.ReadLine().Split(", ").ToArray();
Article article = new Article(input[0], input[1], input[2]);
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] line = Console.ReadLine().Split(": ");
    string command = line[0];
    string newStr = line[1];
    if (command == "Edit")
    {
        article.Edit(newStr);
    }
    else if (command == "ChangeAuthor")
    {
        article.ChangeAuthor(newStr);
    }
    else if (command == "Rename")
    {
        article.Rename(newStr);
    }
}
Console.WriteLine(article.ToString());
public class Article
{
    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public void Edit(string newContent)
    { Content = newContent; }
    public void ChangeAuthor(string newAuthor)
    { Author = newAuthor; }
    public void Rename(string newTitle)
    {
        Title = newTitle;
    }
    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}
/*
some title, some content, some author
3
Edit: better content
ChangeAuthor: better author
Rename: better title
*/