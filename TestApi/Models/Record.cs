using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public class Record
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public int PublicationYear { get; set; }

        public Record(string title, string artist, int duration, int publicationYear)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            PublicationYear = publicationYear;
        }

        public Record()
        {
        }

        public override string ToString()
        {
            // Duration is not included, because we use this method for filtering. Duration is an unreliable search variable.
            return $"{Title}, {Artist}, {PublicationYear}";
        }
    }
}
