using System;
using System.Collections.Generic;
using System.Runtime.Loader;
using System.Threading;

namespace Videa.AvailMartNS.Service
{
	public class Program
	{
		#region Fields
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		#endregion Constructors
		#region Methods
		public  static void Main(string [] args)
		{
			var wait = new ManualResetEventSlim();
            AssemblyLoadContext.Default.Unloading += context =>
            {
                System.Console.WriteLine("Unloaded services app");
            };

            var app = new App();
            app.Start();
            wait.Wait();
            app.Stop(); 
		}
		#endregion Methods
	}
}
