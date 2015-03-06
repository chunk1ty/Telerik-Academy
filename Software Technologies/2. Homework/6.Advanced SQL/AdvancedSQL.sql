1)
select FirstName + ' ' + LastName as [Name], Salary
from Employees e
where  e.Salary = (select MIN(Salary) from Employees);

2)
select FirstName + ' ' + LastName as [Name], Salary
from Employees
where  Salary  <= (
SELECT 1.1 * MIN(Salary) FROM Employees)

3)
select FirstName + ' ' + LastName as [Full name], Salary, DepartmentID
from Employees e
where Salary = (
	select MIN(salary) from Employees
	where DepartmentID = e.DepartmentID
)
	
4)
select avg(Salary)
from Employees
where DepartmentID = 1

5)
select avg(Salary)
from Employees e, Departments d
where e.DepartmentID = d.DepartmentID and
d.Name = 'Sales'

6)
select count(*)
from Employees e, Departments d
where e.DepartmentID = d.DepartmentID and
d.Name = 'Sales'

7)
select count(*) 
from Employees
where ManagerID is not null

8)
select count(*) 
from Employees
where ManagerID is null

9)
select DepartmentID, avg(Salary) as Salary
from Employees
group by DepartmentID

10)
select d.Name,t.Name,COUNT(*)
from Employees e
	join Departments d
	  on e.DepartmentID = d.DepartmentID
	join Addresses a
	  on e.AddressID = a.AddressID
	join Towns t
	  on a.TownID = t.TownID
group by d.Name, t.Name

11)
select m.FirstName + ' ' + m.LastName as [Manager Full Name]
from Employees e, Employees m
where e.ManagerID = m.EmployeeID
group by m.FirstName, m.LastName
having COUNT(*) = 5

12)
select e.FirstName + ' ' + e.LastName as [Employee Name], isnull(m.FirstName,'no') + isnull(m. LastName,' manager') as [Manager name]
from Employees e 
left join Employees m
	on e.ManagerID = m.EmployeeID

13)
select LastName
from Employees
where LEN(LastName) = 5

14)
select CONVERT(VARCHAR(24),GETDATE(),113)

15)
create table Users (
	UsersId int identity(1,1),
	Username nvarchar(50) not null,
	UserPassword nvarchar(50) not null,
	FullName nvarchar(100),
	LastLogin date
	CONSTRAINT PK_Users primary key(UsersId),
	constraint PK_Password check (len(UserPassword) >= 5),
	CONSTRAINT UK_UsersName UNIQUE(Username) 
	)

-16)
CREATE VIEW RecentUsers
AS
	SELECT Username, LastLogin
	FROM Users
	WHERE DAY(GETDATE() - LastLogin) = 1
	
17)
create table Groups (
	GroupID int identity(1,1),
	Name nvarchar(20) not null,
	constraint PK_GroupID primary key (GroupID),
	constraint UE_Name unique (Name)
)

18)
alter table Users
add GroupsID int

alter table Users
add constraint FK_Users_Groups foreign key(GroupID)
references Groups(GroupID)

19)
insert into Groups values  ('Programmers'),
						   ('Policeman'),
						   ('Thirthgroup');

insert into Users values('Pavliken', 'pavkata', 'Pavel Ivanov', GETDATE(), 2),
						('Dimitrin', 'mitaka', 'Dimitar Dimitrov', GETDATE(), 3),
						('Kalkata', 'kalata', 'Kaloqn Kaloqnov', GETDATE(), 1)
						
20)
update Users
set Username = 'Andriyan'
where Username = 'Dimitrin'

21)
delete from Users
where UserName = 'Andriyan';

22)
insert into Users
	select 
		SUBSTRING(FirstName,0,5) + LOWER(LastName),
		SUBSTRING(FirstName,0,5) + LOWER(LastName),
		FirstName + ' ' + LastName,
		NULL,
		1
	from Employees
	
23)
update Users
set UserPassword = null
where LastLogin <= '2010-03-10';

24)
delete from Users
where UserPassword is null

25)
select JobTitle, DepartmentID, avg(Salary) 
from Employees
group by JobTitle, DepartmentID

26)
select JobTitle, DepartmentID, min(FirstName + ' ' + LastName),min(Salary) 
from Employees
group by JobTitle, DepartmentID

27)
select top 1 Name, count(EmployeeID)
from Employees e
	join Addresses a
	on e.AddressID = a.AddressID
	join Towns t
	on a.TownID = t.TownID
group by Name
order by count(EmployeeID) desc

28)