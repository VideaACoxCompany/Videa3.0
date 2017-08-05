using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using System.Linq;
using Videa.RateCardConfirmation.Service.Proto.Types;

namespace Videa.RateCardConfirmationNS.Service
{
	public class RateCardConfirmationServiceImpl : RateCardConfirmationService.RateCardConfirmationServiceBase
	{
		#region Fields
		private  readonly  IMediatorExecutor _executor;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RateCardConfirmationServiceImpl(IMediatorExecutor executor)
		{
			_executor = executor;
		}
		#endregion Constructors
		#region Methods
		public  override async Task<ConfirmRateCardResponse> ConfirmRateCard(ConfirmRateCardRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new ConfirmRateCardQuery
			{
				
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new ConfirmRateCardResponse
			{ 
			};
			
			return result;

		}
		#endregion Methods
	}
}
