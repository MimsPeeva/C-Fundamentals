int numberSongs = int.Parse(Console.ReadLine());
List<Song> playlist = new List<Song>();
for (int i = 0; i < numberSongs; i++)
{
string[] lineTokens = Console.ReadLine().Split("_");
    string type = lineTokens[0];
    string name = lineTokens[1];
    string time = lineTokens[2];
    Song song = new Song(type,name,time);
    playlist.Add(song); 
}
string filter = Console.ReadLine();
if (filter != "all")
{
    foreach (Song song in playlist)
    {
        if (song.typeList == filter)
        {
            Console.WriteLine(song.name);
        }
    }
        return;
}
foreach (Song song in playlist)
{
    Console.WriteLine(song.name);
}
 public class Song 
{
    public Song(string typeList, string name, string time)
    {
        this.typeList = typeList;
        this.name = name;
        this.time = time;

    }
    public string typeList { get; set;  }
    public string name { get; set;  }
    public string time { get; set; }
}