using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotKreida.Contracts.Services;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;

namespace DotKreida.Services {
    public class YouTubeService : IYouTubeService {
        public List<string> GetPlaylistVideo(string channel, string playlist) {
            throw new NotImplementedException();
        }
    }
}