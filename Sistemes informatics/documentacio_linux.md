# 🐧 Chuleta Linux – Pràctiques Ubuntu 24.04

## 🧭 Navegació i gestió de directoris

```bash
cd ~                      # Anar al directori HOME
pwd                       # Mostrar el directori actual
mkdir nom_directori       # Crear un directori
cd nom_directori          # Entrar en un directori
tree                      # Mostrar estructura (instal·lar amb sudo apt install tree)
```
## 📄 Gestió d'arxius

```bash
cp origen destí           # Copiar arxius
mv origen destí           # Moure arxius
rm fitxer                 # Esborrar fitxer
nano fitxer.txt           # Editar amb nano
joe fitxer.txt            # Editar amb joe (instal·lar amb sudo apt install joe)
cat fitxer.txt            # Mostrar contingut
```
## 🔍 Cerca i filtratge

```bash
grep 'usuari' auth.log > auth-usuari.log   # Cerca autenticacions i guarda-les
tail /etc/passwd > nous.txt                # Mostrar últimes línies i guardar
```

## 🔗 Enllaços (links)

```bash
ln -s ../auth.log auth       # Enllaç simbòlic
ln ../passwd usuaris         # Enllaç rígid
```

## 👥 Usuaris i grups

```bash
sudo groupadd nom_grup               # Crear grup
sudo useradd -m nom_usuari           # Crear usuari amb directori
sudo passwd nom_usuari               # Assignar contrasenya
sudo usermod -aG nom_grup nom_usuari # Afegir usuari a grup
su - nom_usuari                      # Canviar d'usuari
```

## 🔐 Permisos

```bash
ls -lisa                             # Veure permisos i propietaris
sudo chown usuari fitxer             # Canviar propietari
sudo chgrp grup fitxer               # Canviar grup
chmod 750 directori                  # Assignar permisos
```

## 📌 Rutes absolutes i relatives

```bash
cp /etc/passwd ~/Escriptori/        # Ruta absoluta
cp /var/log/auth.log Escriptori/    # Ruta relativa
mv Escriptori/passwd ~/             # Ruta relativa
mkdir ~/Escriptori/Fotos_Setembre   # Crear amb ruta absoluta
mkdir Escriptori/Fotos_Octubre      # Crear amb ruta relativa
```

## 🕒 Programació de tasques (cron)

```bash
crontab -e                          # Editar tasques de l'usuari
sudo crontab -e                     # Editar tasques del root
* * * * * comando                   # Format de cron
free >> ~/info_memoria.txt         # Guardar memòria cada hora
/sbin/shutdown -h now              # Apagar sistema
grep shutdown /var/log/syslog      # Veure registre d'apagada
```
## 🧨 Processos

```bash
ps aux | grep nano                  # Buscar procés amb pipe
kill PID                           # Matar procés
```

## 🎯 Comodins (wildcards)

```bash
/bin/sh                             # Canviar shell
export PS1='vinomc $'               # Personalitzar prompt

ls p*                               # Fitxers que comencen per p
ls *.rar                            # Fitxers que acaben en .rar
ls a*z                              # Comencen per a i acaben per z
ls ???                              # Fitxers amb 3 caràcters
ls ?t*                              # Segona lletra t
ls [0-9]*                           # Comencen per número
ls ??[A-Z,]*                        # Tercera lletra majúscula o coma
ls *[^a-df-x]                       # No acaben en lletres a-d o f-x
ls [!0-9]*[^a-z]                    # No comencen per número ni acaben en minúscula
ls ~/Escriptori/Fotos_*/           # Ruta amb comodins
rm ~/Escriptori/Fotos_*/imatge.jpg # Esborrar amb comodins
```