using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using System.Linq;
using Videa.ExcelRateCardImport.Service.Proto.Types;

namespace Videa.ExcelRateCardImportNS.Service
{
	public class ExcelRateCardImportServiceImpl : ExcelRateCardImportService.ExcelRateCardImportServiceBase
	{
		#region Fields
		private  readonly  IMediatorExecutor _executor;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public ExcelRateCardImportServiceImpl(IMediatorExecutor executor)
		{
			_executor = executor;
		}
		#endregion Constructors
		#region Methods
		public  override async Task<ImportRateCardResponse> ImportRateCard(ImportRateCardRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new ImportRateCardQuery
			{
				
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new ImportRateCardResponse
			{ 
			};
			
			return result;

		}
		#endregion Methods
	}
}
