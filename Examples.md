# Simple example

You have a simple example based on a commandline client in [BlizzardAppiReader.Client](./BlizzardApiReader.Client/Program.cs)

# Simple request

* Get the API clientID and secret from Blizzard developer portal

* Configure the API
```
ApiConfiguration.CreateDefault()
  .SetClientId(clientId)
  .SetClientSecret(secret)
  .SetLocale(locale)
  .SetRegion(region)
  .DeclareAsDefault();
```

* Create the game API
```  
DiabloApi api = new DiabloApi();
```  

* Use the game API
```  
//Get first Act information
StoryAct act1 = await api.GetActAsync(1);
Console.WriteLine($"act 1 name: {act1.Name}");
```
