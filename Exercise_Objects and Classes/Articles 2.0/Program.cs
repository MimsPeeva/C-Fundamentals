int n = int.Parse(Console.ReadLine());
List<Article> art = new List<Article>();
for (int i = 0; i < n; i++)
{
    string[] line = Console.ReadLine().Split(", ").ToArray();
Article article = new Article(line[0], line[1], line[2]);
    art.Add(article);
}
Console.WriteLine(string.Join("\n", art));
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
    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}
/*
3
title1, C, author1
title2, B, author2
title3, A, author3
*/
