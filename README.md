
![Logo](https://cdn.discordapp.com/attachments/986282378341265509/986283143524925550/banner.png)


# AWU (Advanced Windows Utility)

One Platforms Advanced Windows Utility, makes it easier to use Win32 API and WMI resources.

<div align='center' text-algin='center'>
<img src="https://img.shields.io/github/forks/One-Platforms/OnePlatforms.AWU">
<img src="https://img.shields.io/github/stars/One-Platforms/OnePlatforms.AWU">
<img src="https://img.shields.io/github/license/One-Platforms/OnePlatforms.AWU">
</div>

## Guide
- [Setup Project](#setup)
- [Accessing Functions](#accessing-functions)
- [Uses of Functions and Their Results](#uses-of-functions-and-their-results)
	- [Synchronous Functions](#synchronous-functions)
	- [Asynchronous Functions](#asynchronous-functions)
- [Project Informations](#authors)

## Setup

To download the package

* Package Manager


```bash
  Install-Package OnePlatforms.AWU -Version 1.0.2
```
* .NET CLI

```bash
  dotnet add package OnePlatforms.AWU --version 1.0.2
```

* Package Reference
```xml
<PackageReference Include="OnePlatforms.AWU" Version="1.0.2" />
```

## Accessing Functions

To access Win32 Methods, you need to import the package you downloaded.

```CSharp
using AdvancedWindowsUtility;
```

# Uses of Functions and Their Results

## Synchronous Functions

* Synchronous functions that handle operating system information.

```CSharp
using AdvancedWindowsUtility;

/* 
Function Name: GetAvailableMemorySpace
Parameter Status: string (type) [Packet Type] [Types: Bytes, KBytes, MBytes, GBytes]
Return Value: System.String
Function Description: Returns the amount of memory available from the package type you specify.
Thread Type: Synchronous [Sync]
*/

Windows.GetAvailableMemorySpace("MBytes"); // Example Result: 62424796


/* 
Function Name: IsRunningProcess
Parameter Status: string (procParam) [Process Name]
Return Value: System.String
Function Description: Returns whether the specified application is running.
Thread Type: Synchronous [Sync]
*/

Windows.IsRunningProcess("devenv.exe"); // Example Result: true


/* 
Function Name: GetRegisteredMail
Parameter Status: Without parameters
Return Value: System.String
Function Description: Returns the Microsoft mail address registered to the operating system.
Thread Type: Synchronous [Sync]
*/

Windows.GetRegisteredMail(); //Example Result: omerhuseyingul@outlook.com


/* 
Function Name: GetOperatingSystemName
Parameter Status: Without parameters
Return Value: System.String
Function Description: Returns your operating system product name.
Thread Type: Synchronous [Sync]
*/

Windows.GetOperatingSystemName(); // Example Result: Microsoft Windows 11 Pro


/* 
Function Name: GetUsername
Parameter Status: Without parameters
Return Value: System.String
Function Description: Returns your operating system username.
Thread Type: Synchronous [Sync]
*/

Windows.GetUsername(); // Example Result: OMERH
```
***

## Asynchronous Functions

* Asynchronous functions that handle operating system information.

```CSharp
using AdvancedWindowsUtility;

/* 
Function Name: GetAvailableMemorySpaceAsync
Parameter Status: string (type) [Packet Type] [Types: Bytes, KBytes, MBytes, GBytes]
Return Value: System.String
Function Description: Returns the amount of memory available from the package type you specify.
Thread Type: Asynchronous [Async]
*/

await Windows.GetAvailableMemorySpaceAsync("MBytes"); // Example Result: 62424796


/* 
Function Name: IsRunningProcess
Parameter Status: string (procParam) [Process Name]
Return Value: System.String
Function Description: Returns whether the specified application is running.
Thread Type: Asynchronous [Async]
*/

await Windows.IsRunningProcessAsync("devenv.exe"); // Example Result: true


/* 
Function Name: GetRegisteredMailAsync
Parameter Status: Without parameters
Return Value: System.String
Function Description: Returns the Microsoft mail address registered to the operating system.
Thread Type: Asynchronous [Async]
*/

await Windows.GetRegisteredMail(); //Example Result: omerhuseyingul@outlook.com


/* 
Function Name: GetOperatingSystemNameAsync
Parameter Status: Without parameters
Return Value: System.String
Function Description: Returns your operating system product name.
Thread Type: Asynchronous [Async]
*/

await Windows.GetOperatingSystemName(); // Example Result: Microsoft Windows 11 Pro


/* 
Function Name: GetUsernameAsync
Parameter Status: Without parameters
Return Value: System.String
Function Description: Returns your operating system username.
Thread Type: Asynchronous [Async]
*/

await Windows.GetUsername(); // Example Result: OMERH
```




## Authors

- [@omerhuseyingul](https://www.github.com/omerhuseyingul)


## Tech Stack

**Programming Language:** C# (CSharp)

**Framework:** .NET Core



## Used By

This project is used by the following companies.

- qSoft Systems
- One Platforms Open Source Software Unit
- gamesense Entertainment
- nuxonic Development


## Support

To contact the developer, see the communication channels below.
- [Mail](mailto:omerhuseyingul@outlook.com)
- [Discord](https://www.discord.com/users/852923308877545503)


## License

[MIT](https://github.com/One-Platforms/OnePlatforms.AWU/blob/main/LICENSE)
