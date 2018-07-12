using CodeClips.Entities.Clips;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeClips.Data.Repos
{
    public interface IRepo
    {
        Clip GetClip(Guid id);

        Clip AddClip(Clip item);

        IEnumerable<Clip> GetAllClips();

        bool RemoveClip(Guid id);
    }
}
