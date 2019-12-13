// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
	private readonly IWebHostEnvironment _env;

	public Startup(IConfiguration configuration, IWebHostEnvironment env)
	{
		Configuration = configuration;
		_env = env;
	}

	public IConfiguration Configuration { get; }

}
