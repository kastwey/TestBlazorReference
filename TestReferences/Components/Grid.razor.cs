using Microsoft.AspNetCore.Components;
using System.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestReferences.Components
{

	public class RenderedItem
	{
		public Entities.Model Model { get; set; }

		public GridRow Row { get; set; }
	}
	
	public partial class Grid
	{

		[Parameter] public List<Entities.Model> GridRows { get; set; }

		public int RenderedRows { get; set; }

		public int ComponentReferences { get; set; }

		private List<RenderedItem> _items;

		protected override Task OnParametersSetAsync()
		{
			if (GridRows != null)
			{
				_items = GridRows.Select(m => new RenderedItem { Model = m }).ToList();
			}
			return base.OnParametersSetAsync();
		}

		protected override Task OnAfterRenderAsync(bool firstRender)
		{
			RenderedRows = _items.Count;
			ComponentReferences = _items.Count(i => i.Row != null);
			return base.OnAfterRenderAsync(firstRender);
		}
	}
}
