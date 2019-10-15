namespace freetime_simulator
{
    class Media
    {
        public int Length { get; }
        public string Title { get; }

        public Media(int length, string title)
        {
            Length = length;
            Title = title;
        }

        public virtual bool MediaPlayable(LivingRoom room)
        {
            
            return true;
        }
    }
}