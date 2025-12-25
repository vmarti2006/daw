# Resum SQL — Apunts Bàsics

## 1. Projecció (π)

Escull columnes específiques d’una taula.

```sql
SELECT columna1, columna2 FROM taula;
```

**Exemple:**

```sql
SELECT nom, edat FROM alumnes;
```

**Exercici:**
Mostra només els noms dels alumnes de Barcelona.

---

## 2. SELECT senzilla

Sintaxi bàsica:

```sql
SELECT columnes FROM taula;
```

`SELECT *` → selecciona totes les columnes (evitar en producció).

Es poden fer càlculs i posar àlies:

```sql
SELECT nom, edat, edat + 1 AS edat_propera FROM alumnes;
```

**Exercici:**
Mostra el nom i el salari mensual (`salari/12`) dels empleats.

---

## 3. WHERE

Filtra files basant-se en condicions.

```sql
SELECT nom FROM alumnes
WHERE edat BETWEEN 16 AND 18;
```

**Exercici:**
Mostra els alumnes que fan el curs “2n” i tenen més de 18 anys.

---

## 4. ORDER BY

Ordena els resultats.

```sql
SELECT nom, edat FROM alumnes
ORDER BY edat DESC;
```

**Exercici:**
Mostra els productes ordenats pel preu de menor a major.

---

## 5. Funcions d’agregació

Principals: `COUNT`, `SUM`, `AVG`, `MIN`, `MAX`.

```sql
SELECT COUNT(*) FROM alumnes;
SELECT AVG(edat) FROM alumnes;
```

**Exercici:**
Calcula la mitjana de salari dels empleats del departament “IT”.

---

## 6. GROUP BY

Agrupa files per columnes.

```sql
SELECT curs, COUNT(*)
FROM alumnes
GROUP BY curs;
```

**Exercici:**
Mostra quants alumnes hi ha per cada ciutat.

---

## 7. HAVING

Filtra grups després de fer un `GROUP BY`.

```sql
SELECT curs, COUNT(*)
FROM alumnes
GROUP BY curs
HAVING COUNT(*) > 5;
```

**Exercici:**
Mostra les ciutats amb més de 10 alumnes.

---

## 8. Producte cartesià

Combina totes les files de dues taules → `|R1| × |R2|`.

```sql
SELECT *
FROM Clients
CROSS JOIN Productes;
```

**Exercici:**
Si tens 4 colors i 3 mides, quantes combinacions es generen?

---

## 9. Joins

### INNER JOIN

Només mostra files amb coincidència en les dues taules.

```sql
SELECT a.nom, c.nom_curs
FROM alumnes a
INNER JOIN cursos c
ON a.curs_id = c.id;
```

### LEFT JOIN

Totes les files de l’esquerra + coincidències de la dreta.

### RIGHT JOIN

Totes les files de la dreta + coincidències de l’esquerra.

### FULL JOIN

Totes les files de les dues taules.

### CROSS JOIN

Producte cartesià.

**Exercici:**
Mostra el nom dels gossos i la seva raça, incloent els que no tenen raça definida.
