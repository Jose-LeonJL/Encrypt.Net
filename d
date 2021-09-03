[33mcommit 8f0a462a1b22a2aedcf7200b432c396273be1995[m[33m ([m[1;36mHEAD -> [m[1;32mmain[m[33m)[m
Author: Jose_LeonJL <60480200+Jose-LeonJL@users.noreply.github.com>
Date:   Fri Sep 3 14:16:27 2021 -0600

    Pruebas

[1mdiff --git a/.gitignore b/.gitignore[m
[1mindex dfcfd56..6c3d08b 100644[m
[1m--- a/.gitignore[m
[1m+++ b/.gitignore[m
[36m@@ -9,7 +9,7 @@[m
 *.user[m
 *.userosscache[m
 *.sln.docstates[m
[31m-[m
[32m+[m[32m*.config[m
 # User-specific files (MonoDevelop/Xamarin Studio)[m
 *.userprefs[m
 [m
[1mdiff --git a/Encrypt.Net/Encrypt.Net.csproj b/Encrypt.Net/Encrypt.Net.csproj[m
[1mindex d4c395e..7477c51 100644[m
[1m--- a/Encrypt.Net/Encrypt.Net.csproj[m
[1m+++ b/Encrypt.Net/Encrypt.Net.csproj[m
[36m@@ -2,6 +2,20 @@[m
 [m
   <PropertyGroup>[m
     <TargetFramework>netstandard2.1</TargetFramework>[m
[32m+[m[32m    <GeneratePackageOnBuild>true</GeneratePackageOnBuild>[m
[32m+[m[32m    <PackageRequireLicenseAcceptance>true</PackageRequireLicenseAcceptance>[m
[32m+[m[32m    <Authors>Jose-LeonJL</Authors>[m
[32m+[m[32m    <PackageLicenseFile>LICENSE</PackageLicenseFile>[m
[32m+[m[32m    <PackageProjectUrl>https://github.com/Jose-LeonJL/Encrypt.Net</PackageProjectUrl>[m
[32m+[m[32m    <RepositoryUrl>https://github.com/Jose-LeonJL/Encrypt.Net</RepositoryUrl>[m
[32m+[m[32m    <Description>Librería creada con el propósito de hacer mas ligero el trabajo de cifrado de distintos tipos.</Description>[m
   </PropertyGroup>[m
 [m
[32m+[m[32m  <ItemGroup>[m
[32m+[m[32m    <None Include="..\LICENSE">[m
[32m+[m[32m      <Pack>True</Pack>[m
[32m+[m[32m      <PackagePath></PackagePath>[m
[32m+[m[32m    </None>[m
[32m+[m[32m  </ItemGroup>[m
[32m+[m
 </Project>[m
[1mdiff --git a/Encrypt.Net/nuget.config b/Encrypt.Net/nuget.config[m
[1mnew file mode 100644[m
[1mindex 0000000..efc870e[m
[1m--- /dev/null[m
[1m+++ b/Encrypt.Net/nuget.config[m
[36m@@ -0,0 +1,13 @@[m
[32m+[m[32m﻿<?xml version="1.0" encoding="utf-8"?>[m
[32m+[m[32m<configuration>[m
[32m+[m	[32m<packageSources>[m
[32m+[m		[32m<clear />[m
[32m+[m		[32m<add key="github" value="https://nuget.pkg.github.com/Jose-LeonJL/index.json" />[m
[32m+[m	[32m</packageSources>[m
[32m+[m	[32m<packageSourceCredentials>[m
[32m+[m		[32m<github>[m
[32m+[m			[32m<add key="Username" value="Jose-LeonJL" />[m
[32m+[m			[32m<add key="ClearTextPassword" value="" />[m
[32m+[m		[32m</github>[m
[32m+[m	[32m</packageSourceCredentials>[m
[32m+[m[32m</configuration>[m
\ No newline at end of file[m
