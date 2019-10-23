namespace freetime_simulator
{
    class MusicAlbum : Media
    {
        public string Artist { get; }
        public MusicAlbum(int length, string title, string artist) : base(length, title)
        {
               Artist = artist;
        }

        public override string ToString()
        {
            string str = "";
            str += $"Type: {GetMediaType()} | ";
            str += $"Title: {Title} | ";
            str += $"Artist: {Artist} | ";
            str += $"Length: {Length}";
            return str;
        }
        
        public static MusicAlbum StringToAlbum(string[] data)
        {
            MusicAlbum album = new MusicAlbum(
                int.Parse(data[2]),
                data[0],
                data[1]
            );
            return album;
        }
    }
}