﻿using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
namespace Videa.SellerRatingNS.Service
{
	public interface IMediatorExecutor
	{
		//methods go here
		Task<T> ExecuteAsync<T>(IRequest<T> data);
	}
}