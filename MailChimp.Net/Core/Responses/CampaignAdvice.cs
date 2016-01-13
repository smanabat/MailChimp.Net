﻿using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class CampaignAdviceReport : BaseResponse
    {
        public CampaignAdviceReport()
        {
            Advice = new HashSet<Advice>();
        }


        [JsonProperty("advice")]
        public IEnumerable<Advice> Advice { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

    }
}