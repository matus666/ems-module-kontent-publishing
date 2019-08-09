﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Kentico.KenticoCloudPublishing
{
    internal class SnippetData
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("elements")]
        public IEnumerable<ElementData> Elements { get; set; }
    }
}