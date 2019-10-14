using System;
using System.Collections.Generic;

namespace freetime_simulator
{
    class Experiment
    { 
        public int id;
        public string name;
        public int mediaConsumed;
        public bool movieAccess;
        public bool musicAccess;
        public bool bookAccess;


        public Experiment(int id, string name, int mediaConsumed, bool movieAccess, bool musicAccess, bool bookAccess)
        {
            this.id = id;
            this.name = name;
            this.mediaConsumed = mediaConsumed;
            this.movieAccess = movieAccess;
            this.musicAccess = musicAccess;
            this.bookAccess = bookAccess;

        }
        //id, lista över genomförda experiment, deras rumskonfiguration, vem som var försöksperson samt vilka medier som hann avnjutas under den givna tiden.
    }
}