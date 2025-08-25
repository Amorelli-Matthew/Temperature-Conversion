# Temperature Conversion

### Description
This project is a Windows Forms application that converts temperatures between Celsius and Fahrenheit. The user can input a value and choose whether to convert it to the other scale using buttons on the form. It was written as a simple exercise, but also dedicated to fixing the functionality of an older family temperature clock.

### Prerequisites To Compile
Windows 10 [Windows 11 Recommended]
[Download and install Microsoft Visual studio 2019 or newer[**Not Code**]](https://visualstudio.microsoft.com/downloads/)
Choose the  .NET desktop Environment
Make sure the .NET Framework version 4.7.2 is installed(check the box when installing the .NET desktop env)

### To Compile
Open Developer Command Prompted for Visual Studio
go into the project directory(Something like `C:\Users\YourUsername\source\repos\Project`)
Then run: `msbuild TemperatureConversion.sln /p:Configuration=Release`
### To Run
go to the inclass1/bin/Release/ where the Application is located.

### To Clean Build Files
In the current directory, run `msbuild TemperatureConversion.sln /t:Clean`

# License
This project is licensed under GPLV3. See `LICENSE` for details.

## Credits
This project uses technologies licensed by Microsoft Corporation:
- **.NET Framework 4.7.2** – © Microsoft Corporation. Licensed under the [.NET Framework License Terms](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472).
- **Windows Forms** – Part of the .NET Framework. © Microsoft Corporation. Licensed under the same terms as the .NET Framework.
- **Visual Studio / MSBuild** – © Microsoft Corporation. Licensed under the [Visual Studio License Terms](https://visualstudio.microsoft.com/license-terms/).

No ownership of Microsoft trademarks or software is claimed. All Microsoft products are used under their respective licenses.

