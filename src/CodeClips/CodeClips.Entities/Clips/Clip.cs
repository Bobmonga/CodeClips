using System.Collections.Generic;

namespace CodeClips.Entities.Clips
{
    public class Clip
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public List<string> Tags { get; set; }
    }
}
