using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using System.Linq;
using Videa.RateCardManager.Service.Proto.Types;

namespace Videa.RateCardManagerNS.Service
{
	public class RateCardManagerServiceImpl : RateCardManagerService.RateCardManagerServiceBase
	{
		#region Fields
		private  readonly  IMediatorExecutor _executor;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RateCardManagerServiceImpl(IMediatorExecutor executor)
		{
			_executor = executor;
		}
		#endregion Constructors
		#region Methods
		public  override async Task<GetRateCardResponse> GetRateCard(GetRateCardRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new GetRateCardQuery
			{
				
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new GetRateCardResponse
			{ 
			};
			
			return result;

		}
		#endregion Methods
	}
}
