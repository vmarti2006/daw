# Guía Completa de Prácticas de PowerShell en Windows 11

Este documento en Markdown recopila todas las actividades de las prácticas proporcionadas. Cada sección incluye un resumen, guía paso a paso para Windows 11 y resumen de capturas de pantalla requeridas. Las prácticas cubren comandos básicos, gestión de usuarios, permisos, scripts, procesos y más. Asegúrate de ejecutar PowerShell como administrador para evitar problemas de permisos.

## Actividad 1: Ejercicio de comandos básicos en PowerShell para gestión de directorios y archivos

### RESUMEN DE LA PRÁCTICA  
Esta práctica (T3-Pt4c - Exercici comandes 3) trata de realizar operaciones en la consola de PowerShell: cambiar el prompt, crear directorios y subdirectorios, generar archivos con listas de archivos del sistema, copiar y renombrar archivos, añadir contenido, crear archivos con filtros específicos, guardar resultados de ping y eliminar todo al final. Se requiere una captura por punto mostrando el comando y el resultado.

### GUÍA PASO A PASO PARA WINDOWS 11  
Abre PowerShell como administrador. Trabaja en tu carpeta de usuario (ej. C:\Users\TuNombre).

1. Cambiar el prompt a: cognom, hora, directori >.  
   Comando: `function prompt { "TUCOGNOM $(Get-Date -Format HH:mm:ss) $(Get-Location)> " }` (sustituye TUCOGNOM por tu apellido).

2. Crear directorio SMX y subdirectorios Xarxes, FOL, Angles.  
   Comando: `mkdir SMX\Xarxes, SMX\FOL, SMX\Angles`

3. Crear archivo de texto con todos los archivos de c:\windows\system32 y guardarlo en Xarxes como "sys32Files.txt".  
   Comando: `Get-ChildItem C:\Windows\System32 | Out-File SMX\Xarxes\sys32Files.txt`

4. Copiar sys32Files.txt a FOL.  
   Comando: `Copy-Item SMX\Xarxes\sys32Files.txt SMX\FOL`

5. Cambiar nombre de sys32Files.txt en FOL a "sys-sys32Files.txt".  
   Comando: `Rename-Item SMX\FOL\sys32Files.txt sys-sys32Files.txt`

6. Añadir a "sys-sys32Files.txt" los archivos de "c:\windows\system".  
   Comando: `Get-ChildItem C:\Windows\System | Out-File SMX\FOL\sys-sys32Files.txt -Append`

7. En Angles, crear archivo de texto con archivos de c:\windows\system32 que comiencen por "t", llamado tatata.txt.  
   Comando: `Get-ChildItem C:\Windows\System32 t* | Out-File SMX\Angles\tatata.txt`

8. Poner en Angles un archivo con la respuesta de un ping a google.com.  
   Comando: `ping google.com | Out-File SMX\Angles\ping_google.txt`

9. Esborrar SMX\Xarxes\sys32Files.txt.  
   Comando: `Remove-Item SMX\Xarxes\sys32Files.txt`

10. Esborrar el subdirectori Xarxes.  
    Comando: `Remove-Item SMX\Xarxes -Recurse -Force`

11. Esborrar SMX y todos sus subdirectorios.  
    Comando: `Remove-Item SMX -Recurse -Force`

### RESUMEN DE CAPTURAS (una por punto)  
1: Prompt cambiado.  
2: Directorios creados (`dir SMX`).  
3: Archivo creado en Xarxes.  
4: Archivo copiado en FOL.  
5: Archivo renombrado.  
6: Contenido añadido (ver con `type`).  
7: tatata.txt creado y filtrado.  
8: Archivo de ping creado.  
9: Archivo eliminado.  
10: Subdirectorio eliminado.  
11: SMX eliminado.

## Actividad 2: Comandos para gestión de archivos y configuración de red en PowerShell

### RESUMEN DE LA PRÁCTICA  
Esta práctica (Pràctica 2.1 Comandes del sistema de fitxers power shell 2) consiste en cambiar el prompt, crear directorios, listar archivos de Windows, copiar y renombrar, añadir listas filtradas, guardar configuración de red y eliminar estructuras. Captura por punto con comando y resultado.

### GUÍA PASO A PASO PARA WINDOWS 11  
Abre PowerShell como administrador.

1. Cambiar prompt a: cognom, data i hora >.  
   Comando: `function prompt { "TUCOGNOM $(Get-Date -Format 'yyyy-MM-dd HH:mm:ss') > " }`

2. Crear directorio SMX y subdirectorios Muntatges, Monolloc, Ofimatica.  
   Comando: `mkdir SMX\Muntatges, SMX\Monolloc, SMX\Ofimatica`

3. Crear archivo con nombres de archivos en c:\windows y guardarlo en Muntatges como "arxius-windows".  
   Comando: `Get-ChildItem C:\Windows | Out-File SMX\Muntatges\arxius-windows`

4. Copiar "arxius-windows" a Monolloc.  
   Comando: `Copy-Item SMX\Muntatges\arxius-windows SMX\Monolloc`

5. Cambiar nombre en Monolloc a "aw-i-system32".  
   Comando: `Rename-Item SMX\Monolloc\arxius-windows aw-i-system32`

6. Añadir a "aw-i-system32" nombres de archivos en c:\windows\system32.  
   Comando: `Get-ChildItem C:\Windows\System32 | Out-File SMX\Monolloc\aw-i-system32 -Append`

7. En Ofimatica, crear aaa.txt con archivos de system32 que comiencen por "a".  
   Comando: `Get-ChildItem C:\Windows\System32 a* | Out-File SMX\Ofimatica\aaa.txt`

8. Poner en Ofimatica un archivo con la configuración de la xarxa.  
   Comando: `ipconfig | Out-File SMX\Ofimatica\xarxa.txt`

9. Esborrar SMX\Muntatges\arxius-windows.  
   Comando: `Remove-Item SMX\Muntatges\arxius-windows`

10. Esborrar subdirectori Muntatges.  
    Comando: `Remove-Item SMX\Muntatges -Recurse -Force`

11. Esborrar directorio SMX y todo dentro.  
    Comando: `Remove-Item SMX -Recurse -Force`

### RESUMEN DE CAPTURAS (una por punto)  
1: Prompt cambiado.  
2: Directorios creados (`dir SMX`).  
3: Archivo creado en Muntatges.  
4: Archivo copiado en Monolloc.  
5: Archivo renombrado.  
6: Contenido añadido (ver con `type`).  
7: aaa.txt creado y filtrado.  
8: Archivo de red creado.  
9: Archivo eliminado.  
10: Subdirectorio eliminado.  
11: SMX eliminado.

## Actividad 3: Gestión de usuarios y grupos mediante comandos en PowerShell

### RESUMEN DE LA PRÁCTICA  
Esta práctica (T3-Pt07 - Gestió d'usuaris i grups amb comandes) se centra en crear grupos de departamentos, usuarios profesores, añadirlos a grupos, mostrar listas y verificar creación de directorios. Captura por punto con comando, resultado y nombre visible.

### GUÍA PASO A PASO PARA WINDOWS 11  
Abre PowerShell como administrador. Usa contraseñas simples.

1. Crear grupo Angles.  
   `net localgroup Angles /add`

2. Crear grupo Matematiques.  
   `net localgroup Matematiques /add`

3. Crear grupo Socials.  
   `net localgroup Socials /add`

4. Crear profesor Francesc.  
   `net user Francesc password /add`

5. Ponerlo en grupo Angles.  
   `net localgroup Angles Francesc /add`

6. Crear profesora Angels.  
   `net user Angels password /add`

7. Ponerla en Matematiques.  
   `net localgroup Matematiques Angels /add`

8. Crear profesora Nuria.  
   `net user Nuria password /add`

9. Ponerla en Socials.  
   `net localgroup Socials Nuria /add`

10. Mostrar todos los usuarios.  
    `net user`

11. Mostrar todos los grupos.  
    `net localgroup`

12. Probar usuarios gráficamente y ejecutar `dir C:\Users`.

### RESUMEN DE CAPTURAS  
1-11: Comando y resultado.  
12: Logins y dir.

## Actividad 4: Programación de tareas automáticas en Windows

### RESUMEN DE LA PRÁCTICA  
Esta práctica (Tasques programades) trata de programar scripts de copias de seguridad, apagar el PC a una hora específica y compartir carpetas por red. Crear manual y video demostrando funcionamiento.

### GUÍA PASO A PASO PARA WINDOWS 11  
Usa Programador de tareas.

1. Programar scripts de backup: Crear tarea con trigger (diario/semanal), acción ejecutar script.ps1.

2. Programar apagado a 16:00: Tarea con `shutdown /s /f`, trigger diario.

3. Compartir carpetas por red: Propiedades > Compartir > Añadir grupos/usuaris. Acceder via \\nombrePC\carpeta.

4. Manual: Explicar pasos para tareas y compartición.

5. Demostrar: Video de ejecución y acceso.

### RESUMEN DE CAPTURAS  
Video o pantallas de tareas y acceso.

## Actividad 5: Ejercicio de comandos básicos en PowerShell para gestión de directorios y archivos

### RESUMEN DE LA PRÁCTICA  
Esta práctica (T3-Pt4c - Exercici comandes 3) trata de realizar operaciones en la consola de PowerShell: cambiar el prompt, crear directorios y subdirectorios, generar archivos con listas de archivos del sistema, copiar y renombrar archivos, añadir contenido, crear archivos con filtros específicos, guardar resultados de ping y eliminar todo al final. Se requiere una captura por punto mostrando el comando y el resultado.

### GUÍA PASO A PASO PARA WINDOWS 11  
Abre PowerShell como administrador. Trabaja en tu carpeta de usuario (ej. C:\Users\TuNombre).

1. Cambiar el prompt a: cognom, hora, directori >.  
   Comando: `function prompt { "TUCOGNOM $(Get-Date -Format HH:mm:ss) $(Get-Location)> " }` (sustituye TUCOGNOM por tu apellido).

2. Crear directorio SMX y subdirectorios Xarxes, FOL, Angles.  
   Comando: `mkdir SMX\Xarxes, SMX\FOL, SMX\Angles`

3. Crear archivo de texto con todos los archivos de c:\windows\system32 y guardarlo en Xarxes como "sys32Files.txt".  
   Comando: `Get-ChildItem C:\Windows\System32 | Out-File SMX\Xarxes\sys32Files.txt`

4. Copiar sys32Files.txt a FOL.  
   Comando: `Copy-Item SMX\Xarxes\sys32Files.txt SMX\FOL`

5. Cambiar nombre de sys32Files.txt en FOL a "sys-sys32Files.txt".  
   Comando: `Rename-Item SMX\FOL\sys32Files.txt sys-sys32Files.txt`

6. Añadir a "sys-sys32Files.txt" los archivos de "c:\windows\system".  
   Comando: `Get-ChildItem C:\Windows\System | Out-File SMX\FOL\sys-sys32Files.txt -Append`

7. En Angles, crear archivo de texto con archivos de c:\windows\system32 que comiencen por "t", llamado tatata.txt.  
   Comando: `Get-ChildItem C:\Windows\System32 t* | Out-File SMX\Angles\tatata.txt`

8. Poner en Angles un archivo con la respuesta de un ping a google.com.  
   Comando: `ping google.com | Out-File SMX\Angles\ping_google.txt`

9. Esborrar SMX\Xarxes\sys32Files.txt.  
   Comando: `Remove-Item SMX\Xarxes\sys32Files.txt`

10. Esborrar el subdirectori Xarxes.  
    Comando: `Remove-Item SMX\Xarxes -Recurse -Force`

11. Esborrar SMX y todos sus subdirectorios.  
    Comando: `Remove-Item SMX -Recurse -Force`

### RESUMEN DE CAPTURAS (una por punto)  
1: Prompt cambiado.  
2: Directorios creados (`dir SMX`).  
3: Archivo creado en Xarxes.  
4: Archivo copiado en FOL.  
5: Archivo renombrado.  
6: Contenido añadido (ver con `type`).  
7: tatata.txt creado y filtrado.  
8: Archivo de ping creado.  
9: Archivo eliminado.  
10: Subdirectorio eliminado.  
11: SMX eliminado.

## Actividad 6: Gestión de permisos en carpetas y archivos

### RESUMEN DE LA PRÁCTICA  
Esta práctica (T3-Pt11 - Permisos de carpetes i fitxers) consiste en solucionar problemas de permisos, crear usuarios adicionales, carpetas departamentales e institucionales con permisos específicos, desactivar herencia y añadir a backups. Documentar y demostrar.

### GUÍA PASO A PASO PARA WINDOWS 11  
Usa Explorador > Propiedades > Seguridad.

1. Crear usuario adicional por departamento (ej. Angles2).  
   `net user Angles2 password /add`, añade a grupo.

2. Crear carpeta por departamento (ej. C:\Departaments\Angles), control total para grupo Angles.

3. Crear carpeta instituto (C:\Institut), acceso para todos profesores.

4. Crear usuario director.  
   `net user Director password /add`

5. Crear carpeta director (C:\Director), control total para él, lectura para otros.

6. Desactivar herencia en carpetas usuarios y ajustar permisos (solo dueño full control).

7. Añadir carpetas a scripts backup (edita con Copy-Item).

8. Demostrar: Prueba acceso con usuarios, muestra backups.

### RESUMEN DE CAPTURAS  
Pruebas de accesos y backups.

## Actividad 7: Creación y configuración de usuarios familiares con control parental

### RESUMEN DE LA PRÁCTICA  
Esta práctica (Gestió d'usuaris) se enfoca en crear usuarios para una familia, configurar control parental para niños y documentar límites de uso.

### GUÍA PASO A PASO PARA WINDOWS 11  
Ve videos (busca "Crear usuarios Windows", "Control parental Windows"). Usa Configuración > Cuentas > Familia.

1. Crear usuario Maria (admin).

2. Crear Joan (estándar).

3. Crear Oriol (12 años, niño con límites).

4. Crear Jana (8 años, límites estrictos).

5. Configurar: horarios, apps, web en Familia.

6. Documenta: Monitoreo, cambios via app Familia.

7. Prueba: Logins, restricciones.

### RESUMEN DE CAPTURAS  
Configs, logins, límites activados.

## Actividad 8: Comandos básicos para creación y manipulación de archivos temáticos en PowerShell

### RESUMEN DE LA PRÁCTICA  
Esta práctica (Comandes del sistema de fitxers Power Shell 1) trata de crear directorios y archivos temáticos de "Rogue One", copiar, renombrar, modificar y eliminar. Captura por punto.

### GUÍA PASO A PASO PARA WINDOWS 11  
Abre PowerShell como administrador. Trabaja en carpeta usuario.

1. Crear "CASSIAN_ANDOR".  
   `mkdir CASSIAN_ANDOR`

2. Crear "ROGUE_ONE.TXT" con 3 alumnos usando Notepad.  
   `notepad CASSIAN_ANDOR\ROGUE_ONE.TXT` (escribe lista).

3. Crear subdirectorios "GALEN_ERSO", "BODHI_ROOK", "JYN_ERSO".  
   `mkdir CASSIAN_ANDOR\GALEN_ERSO, CASSIAN_ANDOR\BODHI_ROOK, CASSIAN_ANDOR\JYN_ERSO`

4. Copiar "ROGUE_ONE.TXT" a "GALEN_ERSO" y "JYN_ERSO".  
   `Copy-Item CASSIAN_ANDOR\ROGUE_ONE.TXT CASSIAN_ANDOR\GALEN_ERSO`  
   `Copy-Item CASSIAN_ANDOR\ROGUE_ONE.TXT CASSIAN_ANDOR\JYN_ERSO`

5. Renombrar en "JYN_ERSO" a "ROGUE_TWO.TXT".  
   `Rename-Item CASSIAN_ANDOR\JYN_ERSO\ROGUE_ONE.TXT ROGUE_TWO.TXT`

6. Modificar "ROGUE_TWO.TXT" añadiendo 2 alumnos.  
   `notepad CASSIAN_ANDOR\JYN_ERSO\ROGUE_TWO.TXT` (añade).

7. Copiar "JYN_ERSO" a "GALEN_ERSO".  
   `Copy-Item CASSIAN_ANDOR\JYN_ERSO -Destination CASSIAN_ANDOR\GALEN_ERSO\JYN_ERSO -Recurse`

8. Borrar "JYN_ERSO".  
   `Remove-Item CASSIAN_ANDOR\JYN_ERSO -Recurse -Force`

### RESUMEN DE CAPTURAS (una por punto)  
1: Carpeta creada (`dir`).  
2: Archivo y contenido (`type`).  
3: Subcarpetas (`dir CASSIAN_ANDOR`).  
4: Copiados (`dir` en subcarpetas).  
5: Renombrado.  
6: Modificado (`type`).  
7: Copiada.  
8: Borrada.

## Actividad 9: Creación de scripts en PowerShell para gestión de usuarios

### RESUMEN DE LA PRÁCTICA  
Esta práctica (Scripts de Windows) consiste en crear scripts para alta/baja de profesores/alumnos, incluyendo usuarios, grupos, carpetas y permisos. Probar y demostrar.

### GUÍA PASO A PASO PARA WINDOWS 11  
Crea .ps1 con Notepad. Habilita: `Set-ExecutionPolicy RemoteSigned`.

1. Alta profesor: Script con $nom, $dept. `New-LocalUser -Name $nom ... ; Add-LocalGroupMember ... ; mkdir Documents, Imatges ; icacls ...`

2. Alta alumne: Similar, grupo ciclo, carpeta personal.

3. Baja profesor: `Remove-LocalUser ... ; Remove-Item carpetas`

4. Baja alumne: Similar.

Prueba: `./alta_profesor.ps1 nom dept`

### RESUMEN DE CAPTURAS  
Scripts, ejecuciones.

## Actividad 10: Terminación de procesos en PowerShell

### RESUMEN DE LA PRÁCTICA  
Esta práctica (Matar processos) se centra en crear y matar un proceso de Notepad usando Get-Process y Stop-Process. Captura por punto con nombre de VM.

### GUÍA PASO A PASO PARA WINDOWS 11  
Abre PowerShell.

1. Abrir Notepad.  
   `notepad`

2. Abrir terminal (ya abierto).

3. Listar procesos.  
   `Get-Process`

4. Notar ID de notepad.

5. Matar.  
   `Stop-Process -Id ID`

6. Comprobar.  
   `Get-Process | Where-Object {$_.Name -eq "notepad"}` (vacío).

### RESUMEN DE CAPTURAS (una por punto)  
Comandos, resultados, nombre VM.

## Actividad 11: Terminación de procesos y uso de rutas relativas/absolutas en PowerShell

### RESUMEN DE LA PRÁCTICA  
Esta práctica (Matar processos i Rutes relatives i absolutes) incluye matar proceso (parte 1) y copiar/mover archivos con rutas relativas/absolutas (parte 2).

### GUÍA PASO A PASO PARA WINDOWS 11  
Parte 1:  
1. Abrir Notepad.  
2. Terminal.  
3. `Get-Process`  
4. ID.  
5. `Stop-Process -Id ID`  
6. Comprobar.

Parte 2:  
7. Abrir PowerShell.  
8. Copiar WIN.INI absoluta: `Copy-Item C:\WINDOWS\WIN.INI C:\Users\TuNombre\Desktop\WIN.INI`  
9. Copiar WRITE.EXE absoluta origen, relativa destí: cd Desktop; `Copy-Item C:\WINDOWS\SYSTEM32\WRITE.EXE .`  
10. Ir a escritorio: `cd Desktop`  
11. Mover relativa: `Move-Item WIN.INI ..`

### RESUMEN DE CAPTURAS  
Parte 1 como arriba. Parte 2: dir para archivos. 

*(Para guardar este documento como archivo .md, copia el texto completo en un editor como Notepad y guárdalo con extensión .md. Si necesitas ajustes, avísame.)*