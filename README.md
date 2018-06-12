# Frau
"Frau" is Mixer API wrapper for .NET Standard 2.0.


## API

Frau provides same APIs as a document.
I will be careful to be as intuitive method names as possible.

```csharp
using Frau;

var mixerClient = new Frau("", "");

// GET           /interactive/games/owned
await mixerClient.Interactive.Games.OwnedAsync(user);

// If endpoints has subdirectories/subroutes, methods is one or more down class.
// GET           /oauth/clients/{client}
await mixerClient.OAuth.Clients.ShowAsync(client);

// As an exception, if there is a better name than a intuitive name, I use one.
// "Revoke" authorization
// DELETE        /oauth/authorized/{client}
await mixerClient.OAuth.Authorized.RevokeAsync(client);
```