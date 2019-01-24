using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotKreida.Models;

namespace DotKreida.ViewModels {
    public class ContentTopicsViewModel {
        public List<Topic> Topics { get; set; }

        public ContentTopicsViewModel(List<Topic> topics) {
            Topics = topics;
        }
    }
}