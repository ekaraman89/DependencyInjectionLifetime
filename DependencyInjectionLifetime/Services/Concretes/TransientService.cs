using DependencyInjectionLifetime.Services.Abstracts;

namespace DependencyInjectionLifetime.Services.Concretes;

public class TransientService : ITransientService
{
	private string _guid;

	public TransientService()
	{
		_guid = Guid.NewGuid().ToString();
	}

	public string GetGuid()
	{
		return _guid;
	}
}