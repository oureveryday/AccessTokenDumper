AccessTokenDumper
===============

Steam app/package access token dumper utilizing the SteamKit2 library. Supports .NET 5.0  
Modified from https://github.com/SteamRE/DepotDownloader  
All tokens and keys are global and are always the same to every Steam user, they are not unique to your account and do not identify you.  

### Dumping access tokens in the steam account
```
dotnet AccessTokenDumper.dll -username <username> -password <password> [other options]
```

## Parameters

Parameter | Description
--------- | -----------
-username \<user>		| the username of the account to access tokens.
-password \<pass>		| the password of the account to access tokens.
-remember-password		| if set, remember the password for subsequent logins of this user. (Use -username <username> -remember-password as login credentials)
-loginid \<#>			| a unique 32-bit integer Steam LogonID in decimal, required if running multiple instances of AccessTokenDumper concurrently. 
-select                 | select app to access tokens.
## Result files
**app.token**
* Contains "appId;AccessToken" lines

**package.tokens**
* Contains "packageId;AccessToken" lines

