# Exercicis de Sistemes Windows

## Exercici 1: Comandes del sistema de fitxers Power Shell 1 
Exercici de comandes Power Shell  
1. Crea al directori del teu usuari un directori que es digui "CASSIAN_ANDOR"  
   **Comanda:** `New-Item -Path ~\CASSIAN_ANDOR -ItemType Directory`  
   **Explicació:** Aquesta comanda crea un nou directori anomenat "CASSIAN_ANDOR" al directori home de l'usuari actual (~ representa el directori home).

2. A dins del directori "CASSIAN_ANDOR" crea el document "ROGUE_ONE.TXT" que ha de contenir una llista de tres alumnes de la classe. Utilitza l'editor NOTEPAD per fer-ho.  
   **Comanda:** `notepad ~\CASSIAN_ANDOR\ROGUE_ONE.TXT`  
   **Explicació:** Obre el Notepad per crear i editar el fitxer. Dins del fitxer, escriu una llista com: Alumne1, Alumne2, Alumne3. Guarda i tanca.

3. A dins del directori "CASSIAN_ANDOR" crea els directoris "GALEN_ERSO", "BODHI_ROOK" i "JYN_ERSO"  
   **Comanda:** `New-Item -Path ~\CASSIAN_ANDOR\GALEN_ERSO -ItemType Directory; New-Item -Path ~\CASSIAN_ANDOR\BODHI_ROOK -ItemType Directory; New-Item -Path ~\CASSIAN_ANDOR\JYN_ERSO -ItemType Directory`  
   **Explicació:** Crea tres subdirectoris dins de "CASSIAN_ANDOR" utilitzant comandes separades o en una línia amb ;.

4. Copia el document "ROGUE_ONE.TXT" als directoris "GALEN_ERSO" i "JYN_ERSO"  
   **Comanda:** `Copy-Item ~\CASSIAN_ANDOR\ROGUE_ONE.TXT ~\CASSIAN_ANDOR\GALEN_ERSO; Copy-Item ~\CASSIAN_ANDOR\ROGUE_ONE.TXT ~\CASSIAN_ANDOR\JYN_ERSO`  
   **Explicació:** Copia el fitxer a cadascun dels subdirectoris especificats.

5. Reanomena el document "ROGUE_ONE.TXT" que es troba a "JYN_ERSO" a "ROGUE_TWO.TXT"  
   **Comanda:** `Rename-Item ~\CASSIAN_ANDOR\JYN_ERSO\ROGUE_ONE.TXT -NewName ROGUE_TWO.TXT`  
   **Explicació:** Canvia el nom del fitxer dins del subdirectori "JYN_ERSO".

6. Modifica "ROGUE_TWO.TXT" i posa-hi dos alumnes més  
   **Comanda:** `notepad ~\CASSIAN_ANDOR\JYN_ERSO\ROGUE_TWO.TXT`  
   **Explicació:** Obre el fitxer amb Notepad, afegeix dos alumnes més (ex: Alumne4, Alumne5), guarda i tanca.

7. Copia directori "JYN_ERSO" al directori "GALEN_ERSO"  
   **Comanda:** `Copy-Item ~\CASSIAN_ANDOR\JYN_ERSO ~\CASSIAN_ANDOR\GALEN_ERSO -Recurse`  
   **Explicació:** Copia el directori sencer (incloent contingut) a dins de "GALEN_ERSO" amb l'opció -Recurse.

8. Esborra "JYN_ERSO"  
   **Comanda:** `Remove-Item ~\CASSIAN_ANDOR\JYN_ERSO -Recurse -Force`  
   **Explicació:** Elimina el directori i el seu contingut amb -Recurse i -Force per confirmar sense prompts.  
Fes una captura per cada punt de l'activitat. Escriu a sota de cada captura la comanda completa que has utilitzat.

## Exercici 2: Comandes del sistema de fitxers power shell 2 
En la consola del sistema fes les següents operacions mitjançant les comandes de consola: 
1. Canvia el prompt, posa-hi el teu cognom, data i hora i el simbol ">"  
   **Comanda:** `$function:prompt = { "Cognom $(Get-Date -Format 'yyyy-MM-dd HH:mm:ss') > " }`  
   **Explicació:** Redefineix la funció prompt per incloure el cognom, data i hora.

2. Crea el directori SMX i a dins els subdirectoris Muntatges, Monolloc, Ofimatica  
   **Comanda:** `New-Item -Path ~\SMX -ItemType Directory; New-Item -Path ~\SMX\Muntatges -ItemType Directory; New-Item -Path ~\SMX\Monolloc -ItemType Directory; New-Item -Path ~\SMX\Ofimatica -ItemType Directory`  
   **Explicació:** Crea el directori principal i els subdirectoris.

3. Crea un arxiu de text amb tots els noms dels arxius que hi ha a c:\windows i guarda'l a Muntatges. L'arxiu s'ha de dir "arxius-windows"  
   **Comanda:** `Get-ChildItem C:\Windows | Select-Object Name | Out-File ~\SMX\Muntatges\arxius-windows.txt`  
   **Explicació:** Llista els noms d'arxius i els guarda en un fitxer de text.

4. Copia "arxius-windows" a Monolloc  
   **Comanda:** `Copy-Item ~\SMX\Muntatges\arxius-windows.txt ~\SMX\Monolloc`  
   **Explicació:** Copia el fitxer al subdirectori especificat.

5. Canvia el nom a "arxius-windows" de Monolloc i posa-li "aw-i-system32"  
   **Comanda:** `Rename-Item ~\SMX\Monolloc\arxius-windows.txt -NewName aw-i-system32.txt`  
   **Explicació:** Reanomena el fitxer dins de Monolloc.

6. Afegeix a "aw-i-system32" els noms dels arxius que es troben a "c:\windows\system32"  
   **Comanda:** `Get-ChildItem C:\Windows\System32 | Select-Object Name | Out-File ~\SMX\Monolloc\aw-i-system32.txt -Append`  
   **Explicació:** Afegeix la llista de noms al final del fitxer existent amb -Append.

7. A Ofimatica Posa-hi un arxiu de text on hi hagi tots els noms dels arxius de c:\windows\system32 que comencin per "a", l'arxiu s'ha de dir aaa.txt  
   **Comanda:** `Get-ChildItem C:\Windows\System32 a* | Select-Object Name | Out-File ~\SMX\Ofimatica\aaa.txt`  
   **Explicació:** Filtra arxius que comencen per "a" i guarda els noms.

8. Posa a Ofimatica un arxiu amb la configuració de la xarxa del teu ordinador.  
   **Comanda:** `ipconfig /all | Out-File ~\SMX\Ofimatica\xarxa.txt`  
   **Explicació:** Executa ipconfig i guarda la sortida en un fitxer.

9. Esborra SMX\Muntatges\arxius-windows  
   **Comanda:** `Remove-Item ~\SMX\Muntatges\arxius-windows.txt`  
   **Explicació:** Elimina el fitxer especificat.

10. Esborra el subdirectori Muntatges  
    **Comanda:** `Remove-Item ~\SMX\Muntatges -Recurse -Force`  
    **Explicació:** Elimina el subdirectori i contingut.

11. Esborra el directori SMX i tot el que hi ha a dins.  
    **Comanda:** `Remove-Item ~\SMX -Recurse -Force`  
    **Explicació:** Elimina el directori principal i tot el contingut.  
Escriu la comanda que has utilitzat en cada punt i la captura de pantalla amb el resultat.

## Exercici 3: Exercici comandes 3 
En la consola del sistema fes les següents operacions mitjançant les comandes de consola: 
1. Canvia el prompt, posa-hi el teu cognom, hora, directori on ets i el simbol ">"  
   **Comanda:** `$function:prompt = { "Cognom $(Get-Date -Format 'HH:mm:ss') $(Get-Location) > " }`  
   **Explicació:** Redefineix el prompt amb cognom, hora i directori actual.

2. Crea el directori SMX i a dins els subdirectoris Xarxes, FOL, Angles  
   **Comanda:** `New-Item -Path ~\SMX -ItemType Directory; New-Item -Path ~\SMX\Xarxes -ItemType Directory; New-Item -Path ~\SMX\FOL -ItemType Directory; New-Item -Path ~\SMX\Angles -ItemType Directory`  
   **Explicació:** Crea el directori i subdirectoris.

3. Crea un arxiu de text amb tots els arxius que hi ha a c:\windows\system32 i guarda'l a Xarxes. L'arxiu s'ha de dir "sys32Files.txt"  
   **Comanda:** `Get-ChildItem C:\Windows\System32 | Select-Object Name | Out-File ~\SMX\Xarxes\sys32Files.txt`  
   **Explicació:** Llista noms i guarda.

4. Copia sys32Files.txt a FOL  
   **Comanda:** `Copy-Item ~\SMX\Xarxes\sys32Files.txt ~\SMX\FOL`  
   **Explicació:** Copia el fitxer.

5. Canvia el nom a sys32Files.txt de FOL i posa-li "sys-sys32Files.txt"  
   **Comanda:** `Rename-Item ~\SMX\FOL\sys32Files.txt -NewName sys-sys32Files.txt`  
   **Explicació:** Reanomena.

6. Afegeix a "sys-sys32Files.txt" els arxius que es troben a "c:\windows\system"  
   **Comanda:** `Get-ChildItem C:\Windows\System | Select-Object Name | Out-File ~\SMX\FOL\sys-sys32Files.txt -Append`  
   **Explicació:** Afegeix llista.

7. A Angles posa-hi un arxiu de text on hi hagi tots els arxius de c:\windows\system32 que comencin per "t", l'arxiu s'ha de dir tatata.txt  
   **Comanda:** `Get-ChildItem C:\Windows\System32 t* | Select-Object Name | Out-File ~\SMX\Angles\tatata.txt`  
   **Explicació:** Filtra per "t" i guarda.

8. Posa a Angles un arxiu amb la resposta de un ping a google.com  
   **Comanda:** `ping google.com | Out-File ~\SMX\Angles\ping.txt`  
   **Explicació:** Executa ping i guarda la sortida.

9. Esborra SMX\Xarxes\sys32Files.txt  
   **Comanda:** `Remove-Item ~\SMX\Xarxes\sys32Files.txt`  
   **Explicació:** Elimina fitxer.

10. Esborra el subdirectori Xarxes  
    **Comanda:** `Remove-Item ~\SMX\Xarxes -Recurse -Force`  
    **Explicació:** Elimina subdirectori.

11. Esborra SMX i tots els seus subdirectoris  
    **Comanda:** `Remove-Item ~\SMX -Recurse -Force`  
    **Explicació:** Elimina tot.

## Exercici 4
*(Sense contingut detallat. Si cal, afegeix passos basats en context anterior, però roman buit com a l'original.)*

## Exercici 5: Gestió d'usuaris i grups amb comandes 
Estàs fent les pràctiques en un institut on ajudes al coordinador d'informàtica. Cada departament té un ordinador. Cal configurar-hi un grup amb el nom del departament I un usuari per cada professor. Com que fer-ho a mà amb l'entorn gràfic és molt engorrós ho faràs amb comandes. A totes les captures ha de sortir el vostre nom i cognom. Mira aquests dos enllaços amb ajuda de les comandes necessàries: 
● https://technet.microsoft.com/en-us/library/bb490706.aspx 
● https://technet.microsoft.com/en-us/library/cc771865(v=ws.11).aspx 
Ara que ja saps com es fa. Crea els següents usuaris i grups. Fes una captura de pantalla per cada punt on es vegi la comanda i el seu resultat: 
1. Crea el grup Angles  
   **Comanda:** `net localgroup Angles /add`  
   **Explicació:** Crea un grup local anomenat Angles.

2. Crea el grup Matematiques  
   **Comanda:** `net localgroup Matematiques /add`  
   **Explicació:** Crea grup Matematiques.

3. Crea el grup Socials  
   **Comanda:** `net localgroup Socials /add`  
   **Explicació:** Crea grup Socials.

4. Crea el professor Francesc  
   **Comanda:** `net user Francesc /add /passwordreq:yes` (defineix contrasenya amb /passwordchg o similar)  
   **Explicació:** Crea usuari Francesc (afegeix contrasenya si cal).

5. Posa'l al grup d'Angles  
   **Comanda:** `net localgroup Angles Francesc /add`  
   **Explicació:** Afegeix usuari al grup.

6. Crea la professora Angels  
   **Comanda:** `net user Angels /add /passwordreq:yes`  
   **Explicació:** Crea usuari Angels.

7. Posa-la al grup de Matematiques  
   **Comanda:** `net localgroup Matematiques Angels /add`  
   **Explicació:** Afegeix al grup.

8. Crea la professora Nuria  
   **Comanda:** `net user Nuria /add /passwordreq:yes`  
   **Explicació:** Crea usuari Nuria.

9. Posa-la al grup de Socials  
   **Comanda:** `net localgroup Socials Nuria /add`  
   **Explicació:** Afegeix al grup.

10. Mostra tots els usuaris que hi ha a l'ordinador.  
    **Comanda:** `net user`  
    **Explicació:** Llista tots els usuaris locals.

11. Mostra tots els grups que hi ha a l'ordinador.  
    **Comanda:** `net localgroup`  
    **Explicació:** Llista tots els grups locals.

12. Amb entorn gràfic prova tots els usuaris. I amb comandes executa DIR C:\USERS per tal de veure si s'han creat els directoris corresponents.  
    **Comanda:** `dir C:\Users`  
    **Explicació:** Verifica directoris d'usuaris; prova login gràficament per confirmar.

## Exercici 6: Matar processos i Rutes relatives i absolutes 
En aquesta primera part faràs servir les comandes del PowerShell:  Get-Process, Stop-Process 
Si necessites ajuda per saber com funciona alguna comanda utilitza la comanda Get-Help, per exemple Get-Help Get-Process 
Heu d'utilitzar el terminal PowerShell per fer aquesta activitat 
1. Crear un procés amb el teu usuari obrint el NOTEPAD.  
   **Comanda:** `notepad`  
   **Explicació:** Obre Notepad, creant un procés.

2. Obrir un terminal  
   **Pas:** Obre PowerShell (ja estàs dins).

3. Executar l'ordre Get-Process per saber quin procés s'ha de matar  
   **Comanda:** `Get-Process notepad`  
   **Explicació:** Llista processos de Notepad, nota l'ID.

4. Apunta el Id del procés que vols matar  
   **Pas:** Nota l'ID de la sortida anterior.

5. Utilitza l'ordre Stop-Process per matar el procés  
   **Comanda:** `Stop-Process -Id <ID>` (substitueix <ID>)  
   **Explicació:** Mata el procés per ID.

6. Comprova que el procés s'ha acabat.  
   **Comanda:** `Get-Process notepad` (hauria de mostrar error o res)  
   **Explicació:** Verifica si encara existeix.  
En les pràctiques anteriors, sense saber-ho, a vegades hem fet servir rutes relatives i altres rutes absolutes. 
Les rutes absolutes comencen sempre per una lletra d'unitat i dos punts (C:, D:, ...), posem la ruta completa d'un directori o d'un fitxer, per exemple 'C:\USERS\JESUS\DESKTOP\FOTO.JPG' 
Les rutes relatives fan referència a un directori o una carpeta a partir de la ubicació actual, per exemple 'DESKTOP\FOTO.JPG' 
En les rutes relatives farem servir '..' per pujar un directori. 
En segona part faràs servir les comandes del sistema: COPY, MOVE, MD 
7. Obrir un PowerShell (PowerShell)  
   **Pas:** Ja obert.

8. Copia el fitxer C:\WINDOWS\WIN.INI a l'escriptori del teu usuari fent servir rutes absolutes tant per l'origen com pel destí.  
   **Comanda:** `Copy-Item C:\Windows\win.ini C:\Users\$env:USERNAME\Desktop\win.ini`  
   **Explicació:** Usa rutes completes.

9. Copia el fixer C:\WINDOWS\SYSTEM32\WRITE.EXE a l'escriptori del teu usuari fent servir ruta absoluta per l'origen i relativa pel destí.  
   **Comanda:** `cd ~; Copy-Item C:\Windows\System32\write.exe Desktop\write.exe`  
   **Explicació:** Origen absoluta, destí relativa des de home.

10. Ves a l'escriptori.  
    **Comanda:** `cd Desktop`  
    **Explicació:** Canvia directori.

11. Mou el fitxer WIN.INI que hi ha a l'escriptori al teu directori home (C:\USERS\nom_usuari), fent servir rutes relatives tant en l'origen com al destí.  
    **Comanda:** `Move-Item win.ini ..`  
    **Explicació:** Mou des de Desktop a home amb relativa (..).

12. Descarrega 4 imatges d'Internet utilitzant el navegador (Edge, Chrome, ...) i guarda-les al teu directori de descarregues.  
    **Pas:** Obre navegador, descarrega imatges manualment a Downloads.

13. Torna al PowerShell i ves al teu directori home.  
    **Comanda:** `cd ~`  
    **Explicació:** Torna a home.

14. Des d'aquí crea quatre directoris a l'escriptori, amb els noms Fotos_Gener, Fotos_Febrer, Fotos_Març i Fotos_Abril. Fes servir rutes absolutes per crear els dos primer i relatives pels dos últims.  
    **Comanda:** `New-Item -Path C:\Users\$env:USERNAME\Desktop\Fotos_Gener -ItemType Directory; New-Item -Path C:\Users\$env:USERNAME\Desktop\Fotos_Febrer -ItemType Directory; New-Item -Path Desktop\Fotos_Març -ItemType Directory; New-Item -Path Desktop\Fotos_Abril -ItemType Directory`  
    **Explicació:** Primers dos amb absoluta, últims amb relativa.

15. Sense moure't del teu directori home mou una imatge a cada un dels directoris creats abans. Fes-ho amb rutes relatives, tant amb l'origen com al destí.  
    **Comanda:** `Move-Item Downloads\imatge1.jpg Desktop\Fotos_Gener;` (repetir per cada imatge)  
    **Explicació:** Mou amb relatives des de home.

16. Esborra els directoris creats al punt 14.  
    **Comanda:** `Remove-Item Desktop\Fotos_Gener -Recurse -Force;` (repetir)  
    **Explicació:** Elimina cada un.

17. Crea amb el NOTEPAD un fitxer anomenat P8_Imatges.PS1 i guarda'l al teu directori home. Posa-hi ha dins les comandes utilitzades al punt 14 i 15  
    **Comanda:** `notepad P8_Imatges.PS1`  
    **Explicació:** Edita i posa les comandes de 14 i 15 dins del script.

18. Torna a descarregar les fotos del punt 12. Han de tenir el mateix nom.  
    **Pas:** Repeteix descàrregues manualment.

19. Torna al Powershell i des de la teva carpeta home escriu .\P8_Imatges.PS1 i comprova que passa. Explica-ho. Si no funciona, busca què cal fer per poder executar scripts amb PowerShell. Tens un enllaç al missatge d'error.  
    **Comanda:** `Set-ExecutionPolicy RemoteSigned` (si cal per permetre scripts); després `.\P8_Imatges.PS1`  
    **Explicació:** Executa el script; si error de política, canvia-la. El script recrea directoris i mou imatges.  


## Exercici 7: Matar processos 
En aquesta pràctica faràs servir les comandes del PowerShell:  Get-Process, Stop-Process 
Obrir un terminal (PowerShell) 
1. Crear un procés com amb el teu usuari obrint el NOTEPAD.  
   **Comanda:** `notepad`  
   **Explicació:** Obre procés.

2. Obrir un terminal  
   **Pas:** Ja obert.

3. Executar l'ordre Get-Process per saber quin procés s'ha de matar  
   **Comanda:** `Get-Process notepad`  
   **Explicació:** Llista ID.

4. Apunta el Id del procés que vols matar  
   **Pas:** Nota ID.

5. Utilitza l'ordre Stop-Process per matar el procés  
   **Comanda:** `Stop-Process -Id <ID>`  
   **Explicació:** Mata.

6. Comprova que el procés s'ha acabat.  
   **Comanda:** `Get-Process notepad`  
   **Explicació:** Verifica.  


## Exercici 8: Permisos de carpetes i fitxers. 
1. Crear un usuari addicional per cada un dels tres departaments.  
   **Comanda:** `net user NouAngles /add; net user NouMatematiques /add; net user NouSocials /add`  
   **Explicació:** Crea usuaris nous i afegeix-los als grups corresponents amb `net localgroup Grup Usuari /add`.

2. Crear una carpeta per cada departament a la que hi han de tenir control total tots els professors del departament corresponent.  
   **Comanda:** `New-Item C:\Departaments\Angles -ItemType Directory` (repetir); després `icacls C:\Departaments\Angles /grant Angles:(OI)(F)` (control total per grup).  
   **Explicació:** Crea carpeta i assigna permisos amb icacls.

3. Crear una carpeta per tot l'institut a la que hi han de poder accedir tots els professors.  
   **Comanda:** `New-Item C:\Institut -ItemType Directory; icacls C:\Institut /grant Users:(OI)(RX)` (lectura per usuaris).  
   **Explicació:** Assigna permisos generals.

4. Crear un usuari pel director.  
   **Comanda:** `net user Director /add`  
   **Explicació:** Crea usuari.

5. Crear una carpeta on només hi tingui control total el director i la resta de professors només lectura.  
   **Comanda:** `New-Item C:\DirectorOnly -ItemType Directory; icacls C:\DirectorOnly /grant Director:(OI)(F) /grant Users:(OI)(RX)`  
   **Explicació:** Permisos específics.

6. Solucionar el problema dels permisos amb tots usuaris. Per fer-ho haurem de desactivar l'herència dels permisos a la carpeta.  
   **Comanda:** `icacls C:\Users\<Usuari> /inheritance:d /grant <Usuari>:(OI)(F) /remove:g Everyone`  
   **Explicació:** Desactiva herència i assigna permisos privats.

7. Afegir les carpetes que hagis creat als scripts de còpies de seguretat.  
   **Pas:** Edita scripts existents per incloure `Copy-Item C:\Departaments C:\Backup -Recurse` (exemple).  
   **Explicació:** Modifica scripts per copiar noves carpetes.

8. Finalment, demostra al professor que funcionen correctament els permisos i les còpies.  
   **Pas:** Prova accés amb diferents usuaris i executa scripts; captura resultats.  
No cal que facis captures de tots els passos, però, documenta correctament l'activitat per tal que et sigui fàcil fer aquest passos més endavant i puguis demostrar que ho has fet.

## Exercici 9: Scripts de Windows.  
1. Alta de professor (usuari, afegir-lo al seu departament, carpeta de Documents, d'Imatges, permisos d'aquestes carpetes ...)  
   **Exemple de script (AltaProfessor.ps1):**  
   ```powershell
   param($Nom, $Departament, $Password)
   net user $Nom $Password /add
   net localgroup $Departament $Nom /add
   New-Item -Path C:\Users\$Nom\Documents -ItemType Directory
   New-Item -Path C:\Users\$Nom\Imatges -ItemType Directory
   icacls C:\Users\$Nom\Documents /grant $Nom:(OI)(F)
   icacls C:\Users\$Nom\Imatges /grant $Nom:(OI)(F)
   ```  
   **Explicació:** Script amb paràmetres per crear usuari, grup, carpetes i permisos.

2. Alta d'alumne (usuari, afegir-lo al seu grup i estudi (cicle), carpeta personal, ...)  
   **Exemple de script (AltaAlumne.ps1):**  
   ```powershell
   param($Nom, $Grup, $Cicle, $Password)
   net user $Nom $Password /add
   net localgroup $Grup $Nom /add
   New-Item -Path C:\Users\$Nom\Personal -ItemType Directory
   icacls C:\Users\$Nom\Personal /grant $Nom:(OI)(F)
   ```  
   **Explicació:** Similar, per alumnes.

3. Baixa de professor i esborrar les seves carpetes  
   **Exemple de script (BaixaProfessor.ps1):**  
   ```powershell
   param($Nom)
   net user $Nom /delete
   Remove-Item C:\Users\$Nom -Recurse -Force
   ```  
   **Explicació:** Elimina usuari i directori.

4. Baixa d'alumne i esborrar les seves carpetes  
   **Exemple de script (BaixaAlumne.ps1):**  
   ```powershell
   param($Nom)
   net user $Nom /delete
   Remove-Item C:\Users\$Nom -Recurse -Force
   ```  
   **Explicació:** Similar per alumnes.  


## Exercici 10: Tasques programades. 
  
**Passos per tasques programades:**  
- Obre Task Scheduler.  
- Crea tasca bàsica: Nom "Còpia Seguretat", Trigger diari, Action: Start a program > PowerShell.exe -File <script.ps1>.  
- Per apagada: `shutdown /s /t 0` en tasca a les 16:00.  
**Passos per compartides xarxa:**  
- Click dret a carpeta > Properties > Sharing > Share > Afegeix grups/usuaris.  
- Accedeix amb \\IP\carpeta des de una altra màquina.

## Exercici 11: Permisos de carpetes i fitxers. 

1. Crear un usuari addicional per cada un dels tres departaments.  
   **Comanda:** Igual que Exercici 8, punt 1.

2. Crear una carpeta per cada departament a la que hi han de tenir control total tots els professors del departament corresponent.  
   **Comanda:** Igual que Exercici 8, punt 2.

3. Crear una carpeta per tot l'institut a la que hi han de poder accedir tots els professors.  
   **Comanda:** Igual que Exercici 8, punt 3.

4. Crear un usuari pel director.  
   **Comanda:** Igual que Exercici 8, punt 4.

5. Crear una carpeta on només hi tingui control total el director i la resta de professors només lectura.  
   **Comanda:** Igual que Exercici 8, punt 5.

6. Solucionar el problema dels permisos amb tots usuaris. Per fer-ho haurem de desactivar l'herència dels permisos a la carpeta.  
   **Comanda:** Igual que Exercici 8, punt 6.

7. Afegir les carpetes que hagis creat als scripts de còpies de seguretat.  
   **Pas:** Igual que Exercici 8, punt 7.

8. Finalment, demostra al professor que funcionen correctament els permisos i les còpies.  
   **Pas:** Igual que Exercici 8, punt 8.  
