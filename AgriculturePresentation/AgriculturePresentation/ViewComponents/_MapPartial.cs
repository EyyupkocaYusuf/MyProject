using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _MapPartial:ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			Context context = new Context();
			var values = context.Addresses.Select(x => x.Mapinfo).FirstOrDefault();
			ViewBag.v = values;
			return View();
		}
	}
}
