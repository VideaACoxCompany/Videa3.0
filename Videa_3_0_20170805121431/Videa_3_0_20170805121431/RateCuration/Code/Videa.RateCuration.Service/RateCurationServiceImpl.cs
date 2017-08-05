using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using System.Linq;
using Videa.RateCuration.Service.Proto.Types;

namespace Videa.RateCurationNS.Service
{
	public class RateCurationServiceImpl : RateCurationService.RateCurationServiceBase
	{
		#region Fields
		private  readonly  IMediatorExecutor _executor;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RateCurationServiceImpl(IMediatorExecutor executor)
		{
			_executor = executor;
		}
		#endregion Constructors
		#region Methods
		public  override async Task<CurateSellerRatesResponse> CurateSellerRates(CurateSellerRatesRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new CurateSellerRatesQuery
			{
				
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new CurateSellerRatesResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<CuratePricingEngineRatesResponse> CuratePricingEngineRates(CuratePricingEngineRatesRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new CuratePricingEngineRatesQuery
			{
				
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new CuratePricingEngineRatesResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<CurateSharebuilderRatesResponse> CurateSharebuilderRates(CurateSharebuilderRatesRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new CurateSharebuilderRatesQuery
			{
				
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new CurateSharebuilderRatesResponse
			{ 
			};
			
			return result;

		}
		#endregion Methods
	}
}
