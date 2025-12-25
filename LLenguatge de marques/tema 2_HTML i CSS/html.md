## Que es Html ?

- Html (HyperText Markup Language) és un llenguatge de marques utilitzat per crear pàgines web.
- serveix per estructurar i organitzar el contingut de la pàgina web.
- No és un llenguatge de programació, es un llneguatge descriptiu.
- va ser desenvolupat per Tim Berners-Lee el 1991

# Exemple 

```html
<!Doctype html>
<html>
    <head>
        <title>Titol</title>
    </head>
    <body>
        <h1> Benvinguts a la meva web</h1>
        <p>paragraf</p>
    </body>
</html>
```

## Etiquetes principals

- <html>: Conte tot el contingut d'un document HTML
- <head>: Inclou metadades, com el títol i enllaços a arxius CSS o scripts
- <body>: Conté el contigut visible de la pagina web

# Exemple
```html
<!DOCTYPE html>  
<html>  
  <head>  
    <title>Títol de la pàgina</title>  
  </head>  
  <body>  
    <!-- Contingut aquí -->  
  </body>  
</html>
```

Etiquetes amb nivell 

```html
<h1> Titol
<h2> Subtitul 
<!-- etc... -->
```

Etiquetes per a paragraf 

```html
<p>
```

Etiquetes per enllaços 

```html
<a>
<a href=""> La meva pagina </a>
```

- href es important per declarar el enllaç


## Etiqueta ```<span>``` 

```<span>``` sirve para resaltar o aplicar estilo a una parte específica del texto sin romper la línea.

Eso es todo: un contenedor pequeño, en línea, para dar estilo o identificar texto.



## Llistes en HTML

- Llistes ordenades i desordenades
    - Llista desordenada ```<ul>``` utilitzada per a elements sense un ordre específic.
    - Llista ordenada ```<ol>``` Utilitzada per a elements que requereixen un ordre

Exemples

## Exemple de llista desordenada:

```html
<ul>
  <li>Primer element</li>
  <li>Segon element</li>
  <li>Tercer element</li>
</ul>
```

## Exemple de llista ordenada:

```html
<ol>
  <li>Primer pas</li>
  <li>Segon pas</li>
  <li>Últim pas</li>
</ol>
```


## Inserció d'imatges 

Etiquetra d'imatge ```<img>```

- utilitzada per inserir imatges en una pagina web
- Atributs importats: src (font de la imagte) i alt (text alteratiu)

## Exemeple 

``` html
<img src="https://www.example.com/imatge.jpg" alt="Descripció de la imatge" >
```


## Creació d'enllaços 

- Enllaços externs i interns ```(<a>)```
- Enllaços externs: Enllaços que redirigeixen a una pàgina web diferent.
- Enllaços interns: Enllaços que redirigeixen a una secció específica dins de la mateixa pàgina.


- Exemple enllaç extern 

```html
<a href="https://www.example.com">Visita example.com</a>
```

- Exemple enllaç intern

```html 
<a href="#seccio">Vés a la secció</a>
<!-- blah blah -->
<h4 id="seccio">Secció 4</h4>
```


## Taules html


- Etiqueta de una taula es ```<table>``` es lo que crea la tabla
- El ```<tr>``` es table row la fila de tabla 
- El ```<td>``` conte el contigut table data 
- Cel·les d'encapçalament ```(<th>)```: Utilitzades per a definir les cel·les d'encapçalament de la taula, generalment en negreta i centrades.


# Exemple 

```html
<table>
  <tr>
    <td>Hola</td>
    <td>Pepito</td>
  </tr>
  <tr>
    <th>Kevin</th>
    <th>Pepito</th>
  </tr>
</table>
```

## Estructura avançada de taules

- Encapçalament de taula ```(<thead>)```: Utilitzat per a definir el conjunt de cel·les d'encapçalament.
- Corps de taula ```(<tbody>)```: Conté el contingut principal de la taula.

```html
<table> <!-- border="" es para la linia -->
  <thead>
    <tr>
      <td>Nombre</td>
      <td>Apellido</td> <!-- si quisiera hacerlo negrita se usara el th en vez del td -->
    </tr>
    </thead>
    <tbody>
      <tr>
      <td>Pepito</td>
      <td>Palote</td>
      </tr>
    </tbody>
</table>
```
```html
<thead>: Es el encabezado de la tabla (las filas de títulos, como "Nombre", "Edad", "Ciudad").

<tbody>: Es el cuerpo de la tabla (las filas con los datos reales).

En resumen:

<thead> = Títulos.

<tbody> = Datos.
```

## Elements de formulari

- ```<form>```: Definició i atributs principals
- ```<input>```: Tipus i atributs
- ```<select>``` i ```<option>```: Creació de llistes desplegables
- ```<textarea>```: Àrees de text multi-línia


* Formulari basic

```html
    <form action="procesar.php" method="post">
      <!-- Camps del formulari -->
    </form>
```

## 2. Elements de Formulari
```<form>```
- Atributs Principals:
- action: URL a la qual s'envien les dades.
- method: Mètode d'enviament (get o post).
- id i class: Per a estils i scripts.
```<input>```
- Tipus Comuns:

- type="text"
- type="password"
- type="radio"
- type="checkbox"
- type="submit"

### Exemple

```html
  <input type="text" name="nom" placeholder="El teu nom">
```


### Creacio de llistes desplegables 

```<select>``` i ```<option>```
Creació de Llistes Desplegables:

```html
  <label for="pais">País:</label>
  <select id="pais" name="pais">
    <option value="espanya">Espanya</option>
    <option value="francia">França</option>
    <option value="itali">Itàlia</option>
  </select>
```

Per agrupar camps relacionats com botons de ràdio o caselles de selecció, s’usa ```<fieldset>``` per encabir-los i ```<legend>``` per posar la pregunta o títol del grup, així els usuaris saben a què es refereix cada conjunt de camps.

rows: Indica el número de filas (altura) del área de texto.

cols: Indica el número de columnas (ancho) del área de texto, medido en caracteres aproximados.

```<br>``` es un salto de linia como un enter


## Organitzacio html


- 1. Introducció als Elements Semàntics d'HTML5
Els elements semàntics HTML5 permeten estructurar la pàgina de manera que tant els navegadors com els motors de cerca entenguin millor el contingut. A més, milloren l'accessibilitat per a usuaris amb lectors de pantalla.

Els elements que veurem en aquesta sessió són:

- ```<header>```: Encapçalament de la pàgina o secció
- ```<footer>```: Peu de pàgina o secció
- ```<nav>```: Navegació principal
- ```<section>```: Secció genèrica de contingut
- ```<article>```: Contingut independent (entrada de blog, notícia, etc.)
- ```<aside>```: Contingut relacionat però secundari (barra lateral)


### Ejemplo 

```html
<!DOCTYPE html>
<html lang="es">
<head>
  <meta charset="UTF-8">
  <title>Ejemplo de estructura</title>
</head>
<body>

<header> <!-- Header -->
  <h1>Mi sitio web</h1>
  <p>Bienvenido a mi página</p>
</header>

<nav> <!-- Nav -->
  <ul>
    <li><a href="#">Inicio</a></li>
    <li><a href="#">Blog</a></li>
    <li><a href="#">Contacto</a></li>
  </ul>
</nav>

<section> <!-- Section -->
  <h2>Sección principal</h2>
  <article>
    <h3>Noticia importante</h3>
    <p>Este es el contenido de una noticia o artículo independiente.</p>
  </article>

  <article> <!-- Article -->
    <h3>Otro artículo</h3>
    <p>Contenido independiente adicional.</p>
  </article>
</section>

<aside> <!-- Aside -->
  <h4>Barra lateral</h4>
  <p>Enlaces, anuncios o información complementaria.</p>
</aside>

<footer> <!-- Footer -->
  <p>© 2025 Mi sitio web. Todos los derechos reservados.</p>
</footer>

</body>
</html>
```

## CSS

- CSS (Cascading Style Sheets) és el llenguatge utilitzat per definir l'aparença visual dels elements d'una pàgina HTML. Permet controlar aspectes com els colors, mides, tipus de lletra, marges, etc., i està dissenyat per separar la presentació del contingut.


### Exemples
```css
p {
  color: blue;
  font-size: 16px;
}
```

- hi han diversas maneras de inserir estils podem fer-ho en el html direcament o el css.

```html
<p style="color: red;">Això és un paràgraf en vermell.</p>
```

- o be tambe podriem declarar dins de ```<head>``` els ```<style>``` i podriem posar tots els estils dins.

Exemple:

```html
<head>
  <link rel="stylesheet" href="estils.css"> <!-- Enllaç al css -->
  <style></style> <!-- dins del htmls sense css.-->
</head>
```

### Propietats Css

-Texto
-
- font-family: tipo de letra

- font-size: tamaño (px, %, em, rem)

- text-align: izquierda, derecha, centro, justificar

- line-height: espacio entre líneas

- letter-spacing: espacio entre letras

- Color y fondo

- color: color del texto

- background-color: color de fondo

- background-image: imagen de fondo

- background-repeat | position | size: control de imagen

- Unidades de medida

- px → fijo

- % → relativo al padre

- em → relativo a la fuente del padre

- rem → relativo a la fuente raíz

- vw / vh → relativo a la ventana

- Colores

- Nombre: red, blue

- Hex: #ff0000

- RGB: rgb(255,0,0)

- RGBA: rgba(255,0,0,0.5)

- HSL: hsl(0,100%,50%)

- HSLA: hsla(0,100%,50%,0.5)

- Espacios

- margin: espacio fuera

- padding: espacio dentro

Capas de la caixa: Content → Padding → Border → Margin

Propietats:

margin → espai exterior

padding → espai interior

border → contorn

width/height → mida del contingut

Elements:

<div> → bloc, tot aplicable

<span> → línia, només padding/margin laterals

Display:

block → tota la línia

inline → només el contingut

inline-block → mida controlable en línia

Outline: com border, no ocupa espai

Box-shadow: afegeix ombres, profunditat visual