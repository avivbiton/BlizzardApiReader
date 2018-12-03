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
//For Diablo API
DiabloApi d3api = new DiabloApi();

//For World of Warcraft API
WorldOfWarcraftApi wowApi = new WorldOfWarcraftApi();
```  

* Use the game API
```  
//Using Diablo API
//Get first Act information
StoryAct act1 = await d3api.GetActAsync(1);
Console.WriteLine($"act 1 name: {act1.Name}");

//Using World of Warcraft API
List<Boss> bosses = wowApi.GetBossesAsync().Result;
foreach (Boss boss in bosses)
{
	Console.WriteLine($"Encounter: {boss.Name} Description: {boss.Description}");
}

```
