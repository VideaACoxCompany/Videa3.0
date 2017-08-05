using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Videa.InventoryGuideNS.Service
{
	public class MediatorExecutor : IMediatorExecutor
	{
		#region Fields
		private    IServiceScopeFactory _serviceScopeFactory;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public MediatorExecutor(IServiceScopeFactory serviceScopeFactory)
		{
			_serviceScopeFactory = serviceScopeFactory;
		}
		#endregion Constructors
		#region Methods
		public  async Task<T> ExecuteAsync<T>(IRequest<T> data )
		{
			using (var scope = _serviceScopeFactory.CreateScope())
                        {
                                var svc = scope.ServiceProvider.GetRequiredService<IMediator>();
                        return await svc.Send(data).ConfigureAwait(false);
                    }
		}
		#endregion Methods
	}
}
