using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using System.Linq;
using Videa.Avail.Service.Proto.Types;

namespace Videa.AvailNS.Service
{
	public class AvailServiceImpl : AvailService.AvailServiceBase
	{
		#region Fields
		private  readonly  IMediatorExecutor _executor;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public AvailServiceImpl(IMediatorExecutor executor)
		{
			_executor = executor;
		}
		#endregion Constructors
		#region Methods
		public  override async Task<GetAvailResponse> GetAvail(GetAvailRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new GetAvailQuery
			{
				
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new GetAvailResponse
			{ 
			};
			
			return result;

		}
		#endregion Methods
	}
}
