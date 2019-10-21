namespace freetime_simulator
{
    class MusicAlbum : Media
    {
        public string Artist { get; }
        public MusicAlbum(int length, string title, string artist) : base(length, title)
        {
               Artist = artist;
        }

        public override bool MediaPlayable(LivingRoom room)
        {
            return room.HasRecordPlayer();
        }

        public override string ToString()
        {
            string str = $"Title: {Title} | Artist: {Artist} | Length: {Length}";
            return str;
        }

        
        public static MusicAlbum StringToAlbum(string[] data)
        {
            MusicAlbum album = new MusicAlbum(
                int.Parse(data[0]),
                data[1],
                data[2]
            );
            return album;
        }
    }
}