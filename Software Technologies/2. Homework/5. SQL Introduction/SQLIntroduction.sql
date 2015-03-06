--4) Write a SQL query to find all information about all departments (use "TelerikAcademy" database).

SELECT *
FROM Departments;

--5)Write a SQL query to find all department names.

select Name
from Departments

--6)Write a SQL query to find the salary of each employee.

select FirstName + ' ' + LastName AS [FullName], Salary
from Employees

--7)Write a SQL to find the full name of each employee.

select FirstName + ' ' + LastName AS [FullName]
from Employees

--8)Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses"."

select FirstName + '.' + LastName + '@telerik.com' AS [Full Email Addresses]
from Employees

--9)Write a SQL query to find all different employee salaries.

select distinct salary
from Employees

--10)Write a SQL query to find all information about the employees whose job title is “Sales Representative“.

select *
from Employees
where JobTitle = 'Sales Representative'

--11)Write a SQL query to find the names of all employees whose first name starts with "SA".

select FirstName + ' ' + LastName AS [Full name]
from Employees
WHERE FirstName LIKE 'SA%'

--12)Write a SQL query to find the names of all employees whose last name contains "ei".

select FirstName + ' ' + LastName AS [Full Name]
from Employees
where LastName like '%ei%'

--13)Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].

select *
from Employees
where Salary between 20000 and 30000

--14)Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

select *
from Employees
where Salary in (25000, 14000, 12500, 23600)

--15)Write a SQL query to find all employees that do not have manager.

select *
from Employees
where ManagerID is null

--16)Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.

select *
from Employees
where Salary > 50000
order by Salary desc 

--17)Write a SQL query to find the top 5 best paid employees.

select top 5 * 
from Employees
order by Salary desc

--18)Write a SQL query to find all employees along with their address. Use inner join with ON clause.

select *
from Employees e join Addresses a
 on e.AddressID = a.AddressID

--19)Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).

select *
from Employees e ,Addresses a
where e.AddressID = a.AddressID
 

--20)Write a SQL query to find all employees along with their manager.

SELECT CONCAT (e.FirstName, ' ', e.LastName) AS FullName, CONCAT (m.FirstName, ' ', m.LastName) AS ManagerFullName
FROM Employees e, Employees m
WHERE e.ManagerID = m.EmployeeID

--21)Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.

select *
from Employees e, Employees m, Addresses a
where m.EmployeeID = e.ManagerID and m.ManagerID = a.AddressID

--22)Write a SQL query to find all departments and all town names as a single list. Use UNION.

select Name
from Departments
union
select Name
from Towns

--23)Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.

SELECT CONCAT(e.FirstName, ' ', e.LastName) AS FullName,  CONCAT(m.FirstName, ' ', m.LastName) ManagerFullName
FROM Employees m
RIGHT JOIN Employees e
ON e.ManagerID = m.EmployeeID

SELECT CONCAT(e.FirstName, ' ', e.LastName) AS FullName,  CONCAT(m.FirstName, ' ', m.LastName) ManagerFullName
FROM Employees e
LEFT JOIN Employees m
ON e.ManagerID = m.EmployeeID


--24)Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.

SELECT CONCAT(e.FirstName, ' ', e.LastName) AS FullName, d.Name, e.HireDate
FROM Employees e, Departments d
WHERE e.DepartmentID = d.DepartmentID AND 
d.Name IN('Sales', 'Finance') AND 
year(e.HireDate) BETWEEN 1995 AND 2005
