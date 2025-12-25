# 🦁 Base de Datos del Zoológico

Este proyecto modela un zoológico con sus especies, animales individuales, componentes alimentarios (tipos de comida) y las dietas asignadas a cada animal.
También gestiona las zonas del zoo y los continentes de las especies.

---

## 🧱 Crear la base de datos

```sql
CREATE DATABASE zoologic;
USE zoologic;
```
📘 **Nota:** Creamos y seleccionamos la base de datos donde trabajaremos.

---

## 🐾 Crear tabla `especies`

```sql
CREATE TABLE especies (
    id INT NOT NULL,
    nom VARCHAR(50) NOT NULL,
    CONSTRAINT pk_especies 
        PRIMARY KEY (id),
    CONSTRAINT uq_nom_especie 
        UNIQUE (nom)
);
```
📘 **Nota:** Cada especie tiene un identificador único y un nombre. La clave primaria garantiza que el id no se repita. La clave única evita nombres duplicados.

---

## 🦁 Crear tabla `animals`

```sql
CREATE TABLE animals (
    id_especie INT NOT NULL,
    id_animal_especie INT NOT NULL,
    nom VARCHAR(50) NOT NULL,
    CONSTRAINT pk_animals 
        PRIMARY KEY (id_especie, id_animal_especie),
    CONSTRAINT uq_nom_animal 
        UNIQUE (id_especie, nom),
    CONSTRAINT fk_animals_especies 
        FOREIGN KEY (id_especie)
        REFERENCES especies(id)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
);
```
📘 **Nota:** Un animal se identifica por su especie y su número dentro de ella. Ejemplo: Lleó 1 (Simba), Lleó 2 (Nala).

---

## 🥩 Crear tabla `components`

```sql
CREATE TABLE components (
    id INT NOT NULL,
    nom VARCHAR(50) NOT NULL,
    CONSTRAINT pk_components
        PRIMARY KEY (id),
    CONSTRAINT uq_nom_component
        UNIQUE (nom)
);
```
📘 **Nota:** Los componentes son los tipos de alimento (carne, fruta, etc.). Cada uno tiene un id y un nombre único.

---

## 🍽️ Crear tabla `dietes`

```sql
CREATE TABLE dietes (
    id_component INT NOT NULL,
    id_especie INT NOT NULL,
    id_animal_especie INT NOT NULL,
    quantitat DECIMAL(5,2) NOT NULL,
    CONSTRAINT pk_dietes 
        PRIMARY KEY (id_component, id_especie, id_animal_especie),
    CONSTRAINT fk_dietes_components 
        FOREIGN KEY (id_component)
        REFERENCES components(id)
        ON UPDATE CASCADE
        ON DELETE RESTRICT,
    CONSTRAINT fk_dietes_animals 
        FOREIGN KEY (id_especie, id_animal_especie)
        REFERENCES animals(id_especie, id_animal_especie)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
);
```
📘 **Nota:** Indica qué y cuánto come cada animal. Un animal puede tener varios componentes en su dieta.

---

## 🧾 Insertar datos en `especies`

```sql
INSERT INTO especies (id, nom) VALUES
(100, 'Lleó'),
(101, 'Tigre'),
(102, 'Elefant'),
```
📘 **Nota:** Insertamos las especies del zoológico.

---

## 🦓 Insertar datos en `animals`

```sql
INSERT INTO animals (id_especie, id_animal_especie, nom) VALUES
(100, 1, 'Simba'),
(100, 2, 'Nala'),
(101, 1, 'Rajah'),
```
📘 **Nota:** Cada animal pertenece a una especie y tiene un nombre propio.

---

## 🥗 Insertar datos en `components`

```sql
INSERT INTO components (id, nom) VALUES
(1000, 'Carn vermella'),
(1001, 'Carn blanca'),
(1002, 'Peix'),

```
📘 **Nota:** Tipos de alimento disponibles.

---

## 🧮 Insertar datos en `dietes`

```sql
INSERT INTO dietes (id_component, id_especie, id_animal_especie, quantitat) VALUES
(1000, 100, 1, 5),
(1004, 100, 1, 1),
(1000, 100, 2, 4.5),

```
📘 **Nota:** Cada fila indica la dieta de un animal.

---

## 🧪 Comprobación de claves foráneas

| Acción | Resultado esperado |
|--------|------------------|
| Borrar especie con animales | ❌ Error — registros dependientes |
| Borrar componente con dietas | ❌ Error — registros dependientes |
| Borrar animal con dieta | ❌ Error — registros dependientes |
| Actualizar id de especie | ✅ Se actualiza en cascada |
| Actualizar id de componente | ✅ Se actualiza en cascada |

---

## 🌍 Modificaciones del esquema

### ➕ Añadir columna `continent`

```sql
ALTER TABLE especies ADD continent VARCHAR(50) NULL;
```
📘 **Nota:** Indicar el continente de origen.

### 🏞️ Crear tabla `zones`

```sql
CREATE TABLE zones (
    id INT NOT NULL,
    nom VARCHAR(50) NOT NULL,
    CONSTRAINT pk_zones PRIMARY KEY (id),
    CONSTRAINT uq_nom_zona UNIQUE (nom)
);
```
📘 **Nota:** Define las zonas del zoológico.

### ➕ Insertar zonas

```sql
INSERT INTO zones (id, nom) VALUES
(1, 'Savana'),
(2, 'Aquàtic'),
(3, 'Bosc');
```

### 🦒 Añadir columna `zona_id` a animals

```sql
ALTER TABLE animals ADD zona_id INT NULL;

ALTER TABLE animals
ADD CONSTRAINT fk_animals_zones 
FOREIGN KEY (zona_id)
REFERENCES zones(id)
ON UPDATE CASCADE
ON DELETE SET NULL;
```
📘 **Nota:** Si se borra una zona, los animales quedan con `NULL`. Cambios de id se propagan.

### 🧾 Asignar zonas a animales

```sql
UPDATE animals SET zona_id = 1 WHERE id_especie IN (100, 101);
UPDATE animals SET zona_id = 3 WHERE id_especie = 102;
UPDATE animals SET zona_id = 2 WHERE id_especie = 103;
```
📘 **Nota:** Savana = leones/tigres, Bosc = elefante, Aquàtic = pingüinos.

### ⚖️ Añadir restricción CHECK

```sql
ALTER TABLE dietes
ADD CONSTRAINT quantitat_major_0 CHECK (quantitat > 0);
```
📘 **Nota:** Evita cantidades negativas o cero.

### ⚖️ Añadir columna con valor por defecto

```sql
ALTER TABLE dietes
ADD unitat_mesura VARCHAR(10) NOT NULL DEFAULT 'kg';
```
📘 **Nota:** Unidad de medida predeterminada.

### 🎂 Añadir fecha de nacimiento a animales

```sql
ALTER TABLE animals
ADD data_naixement DATE NULL;
```
📘 **Nota:** Permite registrar la fecha de nacimiento.

---

## 🧹 Limpieza final

### ❌ Eliminar restricción CHECK

```sql
ALTER TABLE dietes DROP 
    CONSTRAINT quantitat_major_0;
```

### ❌ Eliminar claves foráneas

```sql
ALTER TABLE dietes DROP 
    CONSTRAINT fk_dietes_components;
ALTER TABLE dietes DROP 
    CONSTRAINT fk_dietes_animals;
ALTER TABLE animals DROP 
    CONSTRAINT fk_animals_especies;
ALTER TABLE animals DROP 
    CONSTRAINT fk_animals_zones;
```

### 🧼 Vaciar tablas

```sql
TRUNCATE TABLE dietes;
TRUNCATE TABLE animals;
TRUNCATE TABLE especies;
TRUNCATE TABLE components;
TRUNCATE TABLE zones;
```

### 🗑️ Eliminar tablas

```sql
DROP TABLE dietes;
DROP TABLE animals;
DROP TABLE especies;
DROP TABLE components;
DROP TABLE zones;
```
📘 **Nota:** Base de datos limpia para un nuevo uso.
