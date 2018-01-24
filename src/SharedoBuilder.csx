using System;

public class Sharedo { public string Type {get;set;} public Guid Id {get;set;}}

public class SharedoBuilder
{
	private Sharedo SharedoInstance = new Sharedo();
	
	public Sharedo Build()
	{
		SharedoInstance.Type = "matter";
		SharedoInstance.Id = Guid.NewGuid();
		
		return SharedoInstance;
	}
}