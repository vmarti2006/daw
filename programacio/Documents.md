Crear documents:
```pawershell
    dotnet new console -n exercici --use-program-main
```
---
Crear document soulucio 
```powershell
    dotnet new solution
```

Crear carpeta de test
``` pawershell
    dotnet new xunit -o TascaTest
```
---
validar que es una solucio
```powershwll
    dotnet sln add .\exercici\
    dotnet sln add .\TascaTest\

```
---
Vincular documentos:
```powershwell
    cd TascaTest
    dotnet add reference ..\(carpeta_projecte)
```
---

