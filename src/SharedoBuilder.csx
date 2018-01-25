using System;

public class Sharedo { public string Type {get;set;} public Guid Id {get;set;}}

public class SharedoBuilder : ISharedoBuilder
{
	private readonly Sharedo _sharedoInstance;
	
	public SharedoBuilder()
	{
		_sharedoInstance = new Sharedo();
	}
	
	public ISharedoBuilder WithId(Guid id)
	{
		_sharedoInstance.Id = id;
		
		return this;
	}
	
	public ISharedoBuilder AsType(string type)
	{
		_sharedoInstance.Type = type;
		
		return this;
	}
	
	public Sharedo Build()
	{		
		return _sharedoInstance;
	}
}

public interface ISharedoBuilder
{
	ISharedoBuilder WithId(Guid id);
	ISharedoBuilder AsType(string type);
	Sharedo Build();
}