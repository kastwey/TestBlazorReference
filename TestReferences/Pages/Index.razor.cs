using Microsoft.AspNetCore.Builder;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

using TestReferences.Components;
using TestReferences.Entities;

namespace TestReferences.Pages
{
	public partial class Index
	{

		private List<Model> _firstRows;
		private List<Model> _secondRows;

		private List<Model> _gridRows;

		protected override Task OnInitializedAsync()
		{
			int numberOfItemsFirst  = 1000, numberOfItemsSecond = 100;
			var rnd = new Random((int)DateTime.Now.Ticks);
			_firstRows = new List<Model>();
			for (var i = 0; i < numberOfItemsFirst; i++)
			{
				_firstRows.Add(new Model { Id = Guid.NewGuid().ToString(), Number = rnd.Next(1, 100001) });
			}

			_secondRows = new List<Model>();
			for (var i = 0; i < numberOfItemsSecond; i++)
			{
				_secondRows.Add(new Model { Id = Guid.NewGuid().ToString(), Number = rnd.Next(1, 100001) });
			}
			return base.OnInitializedAsync();
		}

		public void RenderGrid1()
		{
			_gridRows = _firstRows;
		}


		public void RenderGrid2()
		{
			_gridRows = _secondRows;
		}


	}
}
