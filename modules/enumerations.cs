
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace crytpoEnums
{

	enum leverage
	{
		zero = 0,
		one = 1,
		two = 2,
		three = 3,
		four = 4,
		five = 5,
	}

	enum crytoType
	{
		Bitcoin = 0,
		Ethereum = 1,
		Ripple = 2,
		Monero = 3,
	}

	enum orderType
	{
		buy = 0,
		sell = 1,
	}

	enum fiatType
	{
		USD = 0,
		EUR = 1,
	}

}
