# Encrypt.Net
[![NuGet version (Encrypt.Net)](https://img.shields.io/nuget/v/Encrypt.Net.svg?style=flat-square)](https://www.nuget.org/packages/Encrypt.Net/)
[![License](https://img.shields.io/github/license/Jose-LeonJL/Times-Net.svg?label=License&maxAge=86400)](LICENSE.md)

Encrypt.Net Librería creada con el propósito de hacer mas ligero el trabajo de cifrado de distintos tipos.
### Soporte
-  .Net Framework
- .Net Core
- .Net Standar

### Instalacion
- Package Manager `Install-Package Encrypt.Net -Version 1.0.4`
- .Net CLI `dotnet add package Encrypt.Net --version 1.0.4`
- PackageReference `<PackageReference Include="Encrypt.Net" Version="1.0.4" />`
### Uso

> C#

```csharp
Using Encrypt.Net.Text;
public class Ejemplo
{
  public void Times_Test()
  {
    Console.WriteLine(Cifrado.sha256("Hola").HASH);
  }
}
```
>Vb.Net

```vb
Imports Times
Public Class Ejemplo
  Public sub Times_Test()
    Console.WriteLine(Cifrado.sha256("Hola").HASH)
  end sub
end Class
```
