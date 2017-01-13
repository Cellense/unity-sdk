using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Infinario.Commands
{
	internal class GetCampaignsListCommand: Command
	{	
		private string projectToken;
		
		public GetCampaignsListCommand(string projectToken)
		{		
			this.projectToken = projectToken;

		}
		
		public object Execute()
		{
		   return new Dictionary<string, object>() {
				{"name", Constants.ENDPOINT_CAMPAIGNS},
				{"data", new Dictionary<string, object>() {
						{"company_id", projectToken},
				}}
			};
		}
	}
}
