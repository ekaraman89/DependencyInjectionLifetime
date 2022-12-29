using DependencyInjectionLifetime.Services.Abstracts;

namespace DependencyInjectionLifetime.Services.Concretes;

public class SingletonService : ISingletonService
{
	private string _guid;

	public SingletonService()
	{
		_guid = Guid.NewGuid().ToString();
	}

	public string GetGuid()
	{
		return _guid;
	}
}