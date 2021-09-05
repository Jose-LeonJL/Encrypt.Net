# Encrypt.Net
[![NuGet version (Encrypt.Net)](https://img.shields.io/nuget/v/Encrypt.Net.svg?style=flat-square)](https://www.nuget.org/packages/Encrypt.Net/)
[![License](https://img.shields.io/github/license/Jose-LeonJL/Times-Net.svg?label=License&maxAge=86400)](LICENSE.md)

Encrypt.Net Librería creada con el propósito de hacer mas ligero el trabajo de cifrado de distintos tipos.
Encrypt.Net Library created with the purpose of making the encryption work of different types lighter.
Herramientas de encriptado y desencriptado
Encryption and decryption tools
AES128, AES256, SHA1, SHA256, SHA384, SHA512, HMAC-SHA1, HMAC-SHA256, HMAC-SHA384, HMAC-SHA512, HMAC-MD5, MD5, BASE64
### Soporte
-  .Net Framework
- .Net Core
- .Net Standar

### Instalacion
- Package Manager `Install-Package Encrypt.Net -Version 1.0.8`
- .Net CLI `dotnet add package Encrypt.Net --version 1.0.8`
- PackageReference `<PackageReference Include="Encrypt.Net" Version="1.0.8" />`
### Uso

> C#

```csharp
Using Encrypt.Net.Text;
public class Ejemplo
{
  //SHA Examples
  public void SHA_Test()
  {
    Console.WriteLine(Cifrado.sha256("Hola").HASH);
    Console.WriteLine(Cifrado.sha256("Hola").Base64);
  }
  
  //AES Examples
  public void AES_Test()
  {
    var AES128 = Cifrado.AES128("Hola", "password");
    var AES256 = Cifrado.AES256("Hola", "password");
    
    var Decrypt_AES128 = Decifrado.AES128(AES128.Data, "password");
    var Decrypt_AES256 = Decifrado.AES256(AES256.Data, "password");
    Console.WriteLine($"AES");
    Console.WriteLine($"Opciones de Cifrados");
    Console.WriteLine($"Hash  ----  {AES128.Hash}");
    Console.WriteLine($"Hash  ----  {AES128.Hash}");
    Console.WriteLine($"Base64  ----  {AES128.Base64}");
    Console.WriteLine($"Base64  ----  {AES128.Base64}\n");
    Console.WriteLine($"Opciones de Decifrados");
    Console.WriteLine($"{Decrypt_AES128.Hash}");
    Console.WriteLine($"{Decrypt_AES256.Hash}");
  }
}
```
>Vb.Net

```vb
Imports Times
Public Class Ejemplo
'SHA examples
  Public sub SHA_Test()
    Console.WriteLine(Cifrado.sha256("Hola").HASH)
    Console.WriteLine(Cifrado.sha256("Hola").Base64)
  end sub
  
'AES examples
  public sub AES_Test()
    dim AES128 = Cifrado.AES128("Hola", "password")
    dim AES256 = Cifrado.AES256("Hola", "password")

    dim Decrypt_AES128 = Decifrado.AES128(AES128.Data, "password")
    dim Decrypt_AES256 = Decifrado.AES256(AES256.Data, "password")
    Console.WriteLine($"AES")
    Console.WriteLine($"Opciones de Cifrados")
    Console.WriteLine($"Hash  ----  {AES128.Hash}")
    Console.WriteLine($"Hash  ----  {AES128.Hash}")
    Console.WriteLine($"Base64  ----  {AES128.Base64}")
    Console.WriteLine($"Base64  ----  {AES128.Base64}\n")
    Console.WriteLine($"Opciones de Decifrados")
    Console.WriteLine($"{Decrypt_AES128.Hash}")
    Console.WriteLine($"{Decrypt_AES256.Hash}")
  end sub
end Class
```
