
## 1. Creació d'usuaris i grups (CMD)

Exemples:

```cmd
    net localgroup Angles /add
    net localgroup Matematiques /add
    net localgroup Socials /add

    net user Francesc /add
    net localgroup Angles Frances /add

    net user Angels /add
    net localgroup Matematiques Angels /add

    net user Nuria /add
    net localgroup Socials Nuria /add

    net user
    net localgroup

    dir C:\Users\
```

> Nota: Executa amb privilegis d'administrador si cal.

---

## 2. Matar processos (PowerShell)

```powershell
    # Mostrar
    Get-Process

    # Aturar per Id
    Stop-Process -Id <PID>

    # Obrir una aplicació
    notepad
```

---

## 3. Permisos NTFS (ICACLS)

```powershell
    # Veure permisos
    icacls "C:\Carpeta"

    # Control total
    icacls "C:\Carpeta" /grant Usuari:(F)

    # Modificar
    icacls "C:\Carpeta" /grant Usuari:(M)

    # Lectura i execució
    icacls "C:\Carpeta" /grant Usuari:(RX)

    # Permisos heretables
    icacls "C:\Carpeta" /grant Usuari:(OI)(CI)F

    # Treure permisos
    icacls "C:\Carpeta" /remove Usuari

    # Reset permisos
    icacls "C:\Carpeta" /reset

    # Herència
    icacls "C:\Carpeta" /inheritance:d   # desactivar
    icacls "C:\Carpeta" /inheritance:e   # activar
    icacls "C:\Carpeta" /inheritance:r   # eliminar heretats

    # Guardar i restaurar
    icacls "C:\Carpeta" /save permisos.txt /t
    icacls "C:\" /restore permisos.txt

    # Permisos múltiples
    icacls "C:\Carpeta" /grant profe1:(F) profe2:(R) profe3:(M)
```

---

## 4. Creació de directoris i permisos per departaments

```powershell
    New-LocalUser -Name dep-mates -Password (ConvertTo-SecureString "Pass123!" -AsPlainText -Force)
    New-LocalUser -Name dep-cat -Password (ConvertTo-SecureString "Pass123!" -AsPlainText -Force)
    New-LocalUser -Name dep-info -Password (ConvertTo-SecureString "Pass123!" -AsPlainText -Force)

    New-LocalGroup Mates
    New-LocalGroup Catala
    New-LocalGroup Informatica

    Add-LocalGroupMember -Group Mates -Member dep-mates

    # Assignar permisos a carpeta
    icacls "C:\Departaments\Mates" /inheritance:d
    icacls "C:\Departaments\Mates" /grant dep-mates:(OI)(CI)F
```

---

## 5. Carpeta comuna i direcció

```powershell
    icacls "C:\Institut\Professors" /grant Users:(OI)(CI)M
    icacls "C:\Institut\Direccio" /grant director:(OI)(CI)F
    icacls "C:\Institut\Direccio" /grant Users:(OI)(CI)R
```

---

## 6. Scripts PowerShell (alta/baixa)

Crides d'exemple:

```powershell
    # Alta professor
    .\alta_profesor.ps1 -NomUsuari prof1 -Departament Mates

    # Alta alumne
    .\alta_alumne.ps1 -NomUsuari alum1 -Grup ASIX1

    # Baixa professor
    .\baixa_profesor.ps1 -NomUsuari prof1

    # Baixa alumne
    .\baixa_alumne.ps1 -NomUsuari alum1
```

---

## 7. Tasques programades

```powershell
    # Crear acció i trigger diari a les 14:00
    $action = New-ScheduledTaskAction -Execute "powershell.exe" -Argument "C:\Scripts\copia.ps1"
    $trigger = New-ScheduledTaskTrigger -Daily -At 14:00
    Register-ScheduledTask -TaskName "CopiaDiaria" -Action $action -Trigger $trigger

    # Apagar PC
    New-ScheduledTaskAction -Execute "shutdown.exe" -Argument "/s /f /t 0"

    # Llistar tasques
    Get-ScheduledTask

    # Eliminar tasca
    Unregister-ScheduledTask -TaskName "CopiaDiaria" -Confirm:$false
```

---

## 8. Compartir carpetes SMB

```powershell
    New-SmbShare -Name Professors -Path "C:\Institut\Professors" -FullAccess Users
    New-SmbShare -Name Direccio -Path "C:\Direccio" -FullAccess Director -ReadAccess Users

    Get-SmbShare

    Remove-SmbShare -Name Professors -Force

    start \\NomPC\Professors
```

