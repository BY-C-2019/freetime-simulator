using System;

namespace freetime_simulator
{
    abstract class Media
    {
        public int Length { get; }
        public string Title { get; }

        public Media(int length, string title)
        {
            Length = length;
            Title = title;
        }

        protected virtual string GetMediaType()
        {
            Type type = this.GetType();
            string name = type.Name;
            return name;
        }
    }
}