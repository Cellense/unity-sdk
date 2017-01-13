using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Infinario.Commands
{
	internal class GetCampaignDataCommand: Command
	{	
		private string projectToken;
		private Dictionary<string, object> ids;
		
		public GetCampaignDataCommand(string projectToken, Dictionary<string, object> ids)
		{		
			this.projectToken = projectToken;
			this.ids = ids;
		}
		
		public object Execute()
		{
		   return new Dictionary<string, object>() {
				{"name", Constants.ENDPOINT_CAMPAIGNS_JSONP},
				{"data", new Dictionary<string, object>() {
						{"ids", ids},
						{"project_id", projectToken},
				}}
			};
		}
	}
}

// {"company_id":"d29ec908-d979-11e5-b66c-b083fedeed2e","customer_ids":{"cookie":"8652c6a6-61ee-4d13-81bb-f8897bff04f2"},"banner_ids":["57f6d710f4cf7964e8813f84"],"params":null}
// &callback=callback_json1