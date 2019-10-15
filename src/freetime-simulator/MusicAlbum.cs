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
            return true;
        }
        

        public override string ToString()
        {
            string str = $"Title: {Title} | Artist: {Artist} | Length: {Length}";
            return str;
        }
    }
}