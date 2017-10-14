using System;
using System.Collections.Generic;
using System.Text;

namespace Brainmaps
{
    class Note
    {
        public string note;
        public int depth;
        public string title;
        public Tag tags;

        public Note(string text)
        {
            note = text;
        }
    }
}
