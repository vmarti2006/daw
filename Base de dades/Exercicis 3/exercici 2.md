# Consultes
### E1.1.1
```sql
select staff_id, first_name, last_name
    from staff
    where first_name='Lavone' and last_name='O''Reilly';
```
### E1.1.2
```sql
select count(rental_id) as retals, staff_id
    from staff
    where staff_id=2
    group by staff_id
```
### E1.2
```sql
select 
    from actor
    where first_name like '%Z%' or first_name like '%z%';
```
### E1.3
```sql
select title from film
    where "language_id"=5; 
```
### E1.4
```sql
SELECT DISTINCT rental_rate, rental_duration
    FROM film
    ORDER BY rental_rate ASC, rental_duration ASC;
```
### E2.1
```sql

select sum(fim_id)
from film
```
### ex 3
```sql

select grouphor, count(*), as num_acci,
	sum(f_morts) as morts
	avg(f_morts)
    from accidents
    group by  grouphor
```
---
## Exercici having 
### EX 1
```sql
select via, sum(f_morts)
	from accidents
	group by via
	having sum(f_morts) > 100;
```
### EX 2 
```sql
select via, sum(f_morts) as total_morts
	from accidents
	where d_boira = 'Si'
	group by via
	having sum(f_morts) > 2;
```
### EX 3
```sql
select DISTINCT via
	from accidents
	where f_motocicletes_implicades > 2;
```
### EX 4
```sql
select distinct d_superficie, sum(f_morts)
	from accidents
	group by d_superficie
	having sum(f_morts) > 30;
```