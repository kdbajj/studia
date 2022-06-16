 -- LISTA 9 Zad1
-- a)
SELECT CustomerID,CustomerName,ContactName,Address,City,PostalCode,Country
FROM Customers;
-- b)
 SELECT CustomerName,City,Country
FROM Customers;
-- c)
SELECT SupplierName,Address ||' '|| City ||' '|| PostalCode ||' '|| Country AS FullAdress
FROM Suppliers;
-- d)
SELECT DISTINCT Country
FROM Customers;
-- e) 
SELECT EmployeeID,LastName,FirstName,BirthDate
FROM Employees
ORDER BY BirthDate DESC;


-- f)
 SELECT Country||', '||City||', '|| PostalCode||', '||Address AS FullAddress
FROM Customers
ORDER BY FullAddress ASC;
-- g)
 SELECT PostalCode,SupplierName,Country
FROM Suppliers
WHERE Country LIKE "Japan";
-- h)
 SELECT *
FROM Customers
WHERE Country LIKE "Germany" OR Country LIKE "France";

-- Lista 10
--------------------------------
-- Zad.1
select Country, Count(Country) AS Numer

from customers
group by Country
HAVING Numer>1


-- Zadanie2
select City, Count(City) AS Numer

from customers
WHERE Country = 'France' OR Country = 'Spain'
group by City
having Numer>1


-- Zadanie3
select distinct ShipName,OrderID
from orders
group by ShipName
order by OrderID
 -- ZADANIE 4
select ProductID, sum(Quantity) as liczba
from orderdetails
group by ProductID;

-- ZADANIE 5
select s.SupplierID, s.CompanyName, p.ProductID, p.ProductName
from suppliers AS s, products as p
where s.country="USA" AND p.UnitPrice<20;

-- ZADANIE 5 Z INNER JOIN
select p.ProductID, p.ProductName, s.SupplierID, s.CompanyName
from products as p inner join suppliers as s on p.SupplierID=s.SupplierID
where s.country="USA" AND p.UnitPrice<20;

-- ZADANIE 6

select p.ProductID, p.ProductName, c.CategoryID
from products as p INNER JOIN categories as c on p.CategoryID=c.CategoryID 
where c.CategoryName="Beverages";

-- ZADANIE 7

select p.ProductID, p.ProductName
from products as p, categories as c, suppliers as s
where s.supplierID=p.supplierID AND s.Country="USA" AND c.CategoryName="Beverages";

-- ZADANIE 8

SELECT LastName,FirstName
FROM employees
where ReportsTo is NULL;

-- ZADANIE 9
select e1.LastName,e1.FirstName,e1.EmployeeID,e2.EmployeeID as IDkierownika, e2.FirstName, e2.LastName
from employees as e1 INNER JOIN employees as e2
where e1.ReportsTo=e2.employeeID;

-- ZADANIE 10

SELECT 	e1.EmployeeID,e1.FirstName,e1.LastName,e2.EmployeeID as IDkierownika, e2.FirstName, e2.LastName
from employees as e1 left outer join employees as e2 
on e1.ReportsTo=e2.EmployeeID;

-- ZADANIE 11

select *
from orders as o INNER JOIN customers as c 
ON o.CustomerID=c.CustomerID
WHERE c.Country="France";

-- ZADANIE 12 
select c.CustomerID, COUNT(o.OrderID) as liczbaZamowien
FROM orders AS o INNER JOIN customers as c ON o.CustomerID=c.CustomerID
WHERE c.Country="France" 
group by c.CustomerID
HAVING liczbaZamowien>1;

-- ZADANIE 13
	select c.CustomerID, COUNT(o.OrderID) as LiczbaZamowien , o.OrderID
    FROM orders as o right outer join customers as c on c.CustomerID=o.CustomerID
    where c.Country="France"
	group by c.CustomerID;
-- ZADANIE 14

Select *
FROM employees 
where City=(SELECT City
from employees WHERE FirstName="Robert" AND LastName="King");


-- ZADANIE 15
SELECT *
from orders
Where CustomerID IN (SELECT OrderID FROM Customers WHERE Country="France" GROUP BY CustomerID)
GROUP BY OrderID;