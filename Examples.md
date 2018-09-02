# Simple request
```
ApiConfiguration.CreateEmpty()
  .SetApiKey(key)
  .SetLocale(Locale.en_GB)
  .SetRegion(Region.EU)
  .DeclareAsDefault();
  
DiabloApi api = new DiabloApi();
StoryAct act1 = await api.GetActAsync(1);
Console.WriteLine($"act 1 name: {act1.name}"); 
```
