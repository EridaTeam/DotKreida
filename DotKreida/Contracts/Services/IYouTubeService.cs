using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotKreida.Contracts.Services {
    public interface IYouTubeService {
        List<string> GetPlaylistVideo(string channel, string playlist);
    }
}