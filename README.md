# New York Times API .NET Core Client

## 🚧 WORK IN PROGRESS 🚧

## Getting Started

In the *ConfigureServices* method of *Startup.cs*, register the Client:

```csharp
using NytApiClient;
// ...
public void ConfigureServices(IServiceCollection services)
{ 
    services.AddSingleton(sp => 
    {
        var client = Client.For<INytApiClient>();
        client.ApiKey = "YOUR_NYT_API_KEY";
        return client;
    });
    // ...
}
```