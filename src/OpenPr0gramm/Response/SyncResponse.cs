﻿using System.Collections.Generic;
using Newtonsoft.Json;
using OpenPr0gramm.Json;
using OpenPr0gramm.Model;

namespace OpenPr0gramm
{
    public class SyncResponse : Pr0grammResponse
    {
        public int InboxCount { get; private set; }
        [JsonConverter(typeof(SyncLogItemConverter))]
        [JsonProperty(PropertyName = "log")]
        public IEnumerable<SyncLogItem> LogItems { get; private set; }
        public int LogLength { get; private set; }
        public int Score { get; private set; }
    }
}
