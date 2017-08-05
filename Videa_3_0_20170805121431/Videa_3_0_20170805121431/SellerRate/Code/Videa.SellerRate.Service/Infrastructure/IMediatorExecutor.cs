using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
namespace Videa.SellerRateNS.Service
{
	public interface IMediatorExecutor
	{
		//methods go here
		Task<T> ExecuteAsync<T>(IRequest<T> data);
	}
}
