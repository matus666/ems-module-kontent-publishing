﻿using System.Collections.Generic;

using Newtonsoft.Json;

namespace Kentico.EMS.Kontent.Publishing
{
    internal class SnippetsResponse
    {
        [JsonProperty("snippets")]
        public IEnumerable<SnippetData> Snippets { get; set; }

        [JsonProperty("pagination")]
        public PaginationData Pagination { get; set; }
    }
}
