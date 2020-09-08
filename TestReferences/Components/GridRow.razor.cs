using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestReferences.Components
{
	public partial class GridRow
	{

		[Parameter] public Entities.Model Model { get; set; }

	}
}
