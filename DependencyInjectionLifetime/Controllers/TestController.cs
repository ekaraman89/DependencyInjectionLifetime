using DependencyInjectionLifetime.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionLifetime.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class TestController : ControllerBase
	{
		private readonly ITransientService _transientService1;
		private readonly ITransientService _transientService2;
		private readonly IScopedService _scopedService1;
		private readonly IScopedService _scopedService2;
		private readonly ISingletonService _singletonService1;
		private readonly ISingletonService _singletonService2;

		public TestController(
			ITransientService transientService1,
			ITransientService transientService2,
			IScopedService scopedService1,
			IScopedService scopedService2,
			ISingletonService singletonService1,
			ISingletonService singletonService2)
		{
			_transientService1 = transientService1;
			_transientService2 = transientService2;
			_scopedService1 = scopedService1;
			_scopedService2 = scopedService2;
			_singletonService1 = singletonService1;
			_singletonService2 = singletonService2;
		}

		[HttpGet]
		public ActionResult Get()
		{
			var model = new[]
			{
				new
				{
					title="Singleton Service",
					name = "singletonService1",
					value = _singletonService1.GetGuid()
				},
				new
				{
					title="Singleton Service",
					name = "singletonService2",
					value = _singletonService2.GetGuid()
				},
				new
				{
					title="Scoped Service",
					name = "_scopedService1",
					value = _scopedService1.GetGuid()
				},
				new
				{
					title="Scoped Service",
					name = "_scopedService2",
					value = _scopedService2.GetGuid()
				},              new
				{
					title="Transient Service",
					name = "_transientService1",
					value = _transientService1.GetGuid()
				},
				new
				{
					title="Transient Service",
					name = "_transientService2",
					value = _transientService2.GetGuid()
				}
			};

			return Ok(model);
		}

		[HttpGet]
		public ActionResult Get2()
		{
			var model = new[]
			{
				new
				{
					title="Singleton Service",
					name = "singletonService1",
					value = _singletonService1.GetGuid()
				},
				new
				{
					title="Singleton Service",
					name = "singletonService2",
					value = _singletonService2.GetGuid()
				},
				new
				{
					title="Scoped Service",
					name = "_scopedService1",
					value = _scopedService1.GetGuid()
				},
				new
				{
					title="Scoped Service",
					name = "_scopedService2",
					value = _scopedService2.GetGuid()
				},              new
				{
					title="Transient Service",
					name = "_transientService1",
					value = _transientService1.GetGuid()
				},
				new
				{
					title="Transient Service",
					name = "_transientService2",
					value = _transientService2.GetGuid()
				}
			};

			return Ok(model);
		}
	}
}