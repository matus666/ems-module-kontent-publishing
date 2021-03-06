﻿using System.Collections.Generic;

using Newtonsoft.Json;

namespace Kentico.EMS.Kontent.Publishing
{
    internal class ItemsResponse
    {
        [JsonProperty("items")]
        public IEnumerable<ItemData> Items { get; set; }

        [JsonProperty("pagination")]
        public PaginationData Pagination { get; set; }
    }
}
