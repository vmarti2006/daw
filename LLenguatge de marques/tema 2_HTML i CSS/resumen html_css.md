

#  **RESUM DE HTML**

*(Part 1 – Tot el necessari sobre estructura i contingut web)*

---

## 📌 1. Introducció a HTML

* HTML = llenguatge de marques per **estructurar** una pàgina web.
* No és programació.
* Versió actual: **HTML5**.
* Estructura bàsica:

  ```html
  <!DOCTYPE html>
  <html>
    <head>...</head>
    <body>...</body>
  </html>
  ```

---

## 📌 2. Etiquetes Bàsiques

### 🔹 Encapçalaments

`<h1>` fins `<h6>` — jerarquia de títols.

### 🔹 Paràgrafs

`<p>` — blocs de text.

### 🔹 Enllaços

`<a href="...">` — externs o interns.

### 🔹 Span

`<span>` — element *inline* per estilitzar o identificar parts del text.

---

## 📌 3. Llistes

* **Desordenada (`<ul>`)**
* **Ordenada (`<ol>`)**
* Elements interns: `<li>`

---

## 📌 4. Imatges

```html
<img src="imatge.jpg" alt="Descripció">
```

* `alt` és important per **accessibilitat** i SEO.

---

## 📌 5. Taules en HTML

### Elements principals:

* `<table>` — contenidor global
* `<tr>` — fila
* `<th>` — capçalera
* `<td>` — cel·la

### Estructura avançada:

* `<thead>` — capçalera global
* `<tbody>` — cos
* `<tfoot>` — peu de taula

---

## 📌 6. Formularis en HTML

### Estructura:

```html
<form action="" method="post">
```

### Elements:

* `input` (text, password, email, radio, checkbox…)
* `select` + `option`
* `textarea`
* `button type="submit"`

### Validació HTML5:

* `required`
* `pattern`
* `min`, `max`
* `type="email"`

---

## 📌 7. Accessibilitat en Formularis

* Associar camps amb `<label for="id">`
* Text d’ajuda amb `aria-describedby`
* Agrupació de camps:

  ```html
  <fieldset>
    <legend>Títol</legend>
  </fieldset>
  ```

---

## 📌 8. Elements Semàntics HTML5

*(milloren accessibilitat + estructura + SEO)*

| Element     | Funció                  |
| ----------- | ----------------------- |
| `<header>`  | Capçalera / introducció |
| `<footer>`  | Peu de pàgina           |
| `<nav>`     | Navegació               |
| `<section>` | Secció temàtica         |
| `<article>` | Contingut independent   |
| `<aside>`   | Contingut secundari     |

---

## 📌 9. `<div>` i `<span>`

### `<div>`

* Element **block**
* S’usa per estructurar i dissenyar
* No té significat semàntic

### `<span>`

* Element **inline**
* S’usa per estilitzar text puntual

---

# 🟥 **RESUM DE CSS**

*(Part 2 – Tot l’essencial per donar estil a HTML)*

---

## 📌 1. Què és CSS?

* Controla la **presentació visual** d’una pàgina web.
* Separació entre **contingut (HTML)** i **estil (CSS)**.

---

## 📌 2. Formes d’incloure CSS

### 🔹 En línia

```html
<p style="color:red;">
```

### 🔹 Intern al `<head>`

```html
<style>
  p { color: blue; }
</style>
```

### 🔹 Extern (recomanat)

```html
<link rel="stylesheet" href="estils.css">
```

---

## 📌 3. Selectors CSS

### 🔹 Per etiqueta:

```css
p { ... }
```

### 🔹 Per classe:

```css
.classe { ... }
```

### 🔹 Per ID:

```css
#identificador { ... }
```

### 🔹 Selectors combinats (opcional però útil):

```css
div p { ... }      /* descendent */
div > p { ... }    /* fill directe */
p:hover { ... }    /* estat */
```

---

## 📌 4. Herència en CSS

Els fills **hereten**:

* color
* font-family
* font-size
* line-height

No s’hereten:

* margin
* padding
* border

### Forçar herència:

```css
background-color: inherit;
```

---

## 📌 5. Propietats de Text

* `font-family`
* `font-size`
* `text-align`
* `line-height`
* `letter-spacing`
* `font-weight`

---

## 📌 6. Colors i Fons

### Color del text:

```css
color: #333;
```

### Color de fons:

```css
background-color: #f0f0f0;
```

### Imatge de fons:

```css
background-image: url(...);
background-repeat: no-repeat;
background-size: cover;
background-position: center;
```

---

## 📌 7. Unitats de Mesura

| Unitat  | Explicació                   |
| ------- | ---------------------------- |
| **px**  | unitat fixa                  |
| **%**   | relativa al pare             |
| **em**  | relativa al text del pare    |
| **rem** | relativa al text del root    |
| **vw**  | % de l’ample de la finestra  |
| **vh**  | % de l’altura de la finestra |

---

## 🔚 Resum curt final

### **HTML = estructura**

tags, llistes, imatges, taules, formularis, accessibilitat, semàntica, div/span.

### **CSS = aparença**

selectors, herència, colors, fonts, fons, unitats.

---
