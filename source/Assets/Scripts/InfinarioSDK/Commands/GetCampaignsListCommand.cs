using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Infinario.Commands
{
	internal class GetCampaignsListCommand: Command
	{	
		private string projectToken;
		private Dictionary<string, object> ids;
		
		public GetCampaignsListCommand(string projectToken, Dictionary<string, object> ids)
		{		
			this.projectToken = projectToken;
			this.ids = ids;
		}
		
		public object Execute()
		{
		   return new Dictionary<string, object>() {
				{"name", Constants.ENDPOINT_CAMPAIGNS},
				{"data", new Dictionary<string, object>() {
						{"ids", ids},
						{"project_id", projectToken},
				}}
			};
		}
	}
}
