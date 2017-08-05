using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using System.Linq;
using Videa.RatingCuration.Service.Proto.Types;

namespace Videa.RatingCurationNS.Service
{
	public class RatingCurationServiceImpl : RatingCurationService.RatingCurationServiceBase
	{
		#region Fields
		private  readonly  IMediatorExecutor _executor;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RatingCurationServiceImpl(IMediatorExecutor executor)
		{
			_executor = executor;
		}
		#endregion Constructors
		#region Methods
		public  override async Task<CurateSellerRatingsResponse> CurateSellerRatings(CurateSellerRatingsRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new CurateSellerRatingsQuery
			{
				
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new CurateSellerRatingsResponse
			{ 
			};
			
			return result;

		}
		#endregion Methods
	}
}
