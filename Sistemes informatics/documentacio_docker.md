# 📝 Apuntes de Docker (Imágenes, Contenedores, Volúmenes y Redes)

---

## I. Conceptos Fundamentales

| Concepto | Definición | Analogía |
| :--- | :--- | :--- |
| **IMAGEN** | Paquete estático con todo lo necesario para ejecutar una aplicación (plantilla). | Una plantilla de sistema operativo (ej. Ubuntu sin ejecutar). |
| **CONTENEDOR** | Una instancia en ejecución de una Imagen (un sistema en funcionamiento). | Un sistema operativo en funcionamiento basado en la imagen. |
| **VOLUMEN** | Espacio de almacenamiento gestionado por Docker en el sistema *host*, separado del contenedor. | Un disco duro externo que se conecta al contenedor. |
| **DOCKER COMPOSE** | Herramienta para definir y ejecutar aplicaciones multi-contenedor (ej. Node.js + Redis). | Un *script* que arranca todos los servicios de tu aplicación a la vez. |

---

## II. Gestión Básica de Imágenes y Contenedores

| Tarea | Comando | Explicación |
| :--- | :--- | :--- |
| **Descargar Imagen** | `docker pull ubuntu` | Baja la imagen (ej. Ubuntu) desde Docker Hub. |
| **Listar Imágenes** | `docker images` | Muestra las imágenes descargadas en el sistema. |
| **Crear y Ejecutar Contenedor** | `docker run -it ubuntu` | Ejecuta un contenedor interactivo (`-it`) basado en la imagen. |
| **Listar Contenedores** | `docker ps -a` | Muestra todos los contenedores creados (activos e inactivos). |
| **Eliminar Contenedor** | `docker rm <id_del_contenidor>` | Borra un contenedor específico. |
| **Acceder a Contenedor en Ejecución** | `docker exec -it <nom> bash` | Ejecuta un comando (`bash`) dentro de un contenedor que ya está en marcha (`docker exec`). |
| **Copiar Archivos** | `docker cp "ruta_host/archivo" <id_docker>:/ruta_contenedor/` | Copia archivos entre el sistema *host* y el contenedor. |

---

## III. Creación de Imágenes Personalizadas (Dockerfile)

Un **Dockerfile** es un documento de texto sin extensión que contiene instrucciones para construir una Imagen.

| Instrucción | Función | Ejemplo |
| :--- | :--- | :--- |
| **FROM** | Define la imagen base (punto de partida). | `FROM ubuntu:latest` |
| **RUN** | Ejecuta un comando durante la construcción de la imagen (ej. instala paquetes). | `RUN apt-get update && apt-get install -y apache2` |
| **EXPOSE** | Documenta el puerto que la aplicación utilizará. | `EXPOSE 80` |
| **CMD** | Comando por defecto que se ejecuta al iniciar el contenedor. | `CMD ["apachectl", "-D", "FOREGROUND"]` |

**Comandos Clave:**
* **Construcción:** `docker build -t <nombre_imagen> .`
* **Ejecución con mapeo de puertos:** `docker run -d -p 8080:80 --name apache-joe-container apache-joe`

---

## IV. Persistencia de Datos con Volúmenes

Los volúmenes aseguran que los datos no se pierdan al eliminar el contenedor y permiten compartir datos.

| Tarea | Comando | Explicación |
| :--- | :--- | :--- |
| **Crear Volúmen** | `docker volume create my-volume` | Crea un volumen gestionado por Docker. |
| **Listar Volúmenes** | `docker volume ls` | Muestra los volúmenes existentes. |
| **Montar Volúmen** | `docker run -v my-volume:/data nginx` | Monta `my-volume` en la ruta `/data` dentro del contenedor. |
| **Montar Directorio Local (Bind Mount)** | `docker run -v c:/Volum-docker:/data busybox` | Mapea un directorio local (`c:/Volum-docker`) directamente al contenedor. |

---

## V. Gestión Multi-Contenedor (Docker Compose)

Se utiliza el archivo `docker-compose.yml` para definir y orquestar varios servicios (ej. servidor y base de datos).

| Componente | Función |
| :--- | :--- |
| **`version`** | Especifica la versión de Docker Compose (ej. `'3.8'`). |
| **`services`** | Lista los servicios de la aplicación. |
| **`build`** | Indica la ruta del Dockerfile para construir la imagen. |
| **`image`** | Especifica la imagen a usar (ej. `"redis:alpine"`). |
| **`depends_on`** | Asegura que un servicio se inicie antes que otro. |
| **`ports`** | Mapea puertos (ej. `"3000:3000"`). |

---

## VI. Redes en Docker

Las redes aíslan los contenedores; solo pueden comunicarse si están en la misma red.

| Tarea | Comando | Explicación |
| :--- | :--- | :--- |
| **Crear Red** | `docker network create Xarxa1` | Crea una red personalizada. |
| **Conectar Contenedor al Iniciar** | `docker run -dit --name alpine1 --network Xarxa1 alpine sh` | Conecta un contenedor a la red al ejecutarse. |
| **Conectar a Red Existente** | `docker network connect Xarxa2 alpine3` | Conecta un contenedor en funcionamiento a una red adicional. |