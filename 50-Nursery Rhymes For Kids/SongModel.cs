using System;

namespace _50_Nursery_Rhymes_For_Kids
{
    internal class SongModel
    {
        public SongModel()
        {
        }

        public Sp MediaSource { get; internal set; }
        public Uri MediaUri { get; internal set; }
        public string Title { get; internal set; }
    }
}