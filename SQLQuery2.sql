--Select
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers
Select * from Customers where City='London'
Select * from Products where categoryId=1
Select * from Products where CategoryID=1 or CategoryID=3
Select * from Products where CategoryID=1 and UnitPrice>=10
Select * from Products order by ProductName
Select * from Products order by ProductName,categoryId
Select * from Products order by UnitPrice asc
Select * from Products order by UnitPrice desc
Select * from Products where CategoryID=1 order by UnitPrice desc
select count(*) from Products
select count(*) from Products where CategoryID=2
select categoryID from Products group by CategoryID
select count(*) from Products group by CategoryID
select categoryID,count(*) from Products group by CategoryID
select categoryID,count(*) Adet from Products group by CategoryID
select categoryID,count(*) Adet from Products group by CategoryID having count(*)<10
select categoryID,count(*) Adet from Products where UnitsInStock<10  group by CategoryID having count(*)<10
select Products.ProductID,Products.ProductName, Products.UnitPrice, Categories.CategoryName
from products inner join Categories
on Products.CategoryID= Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation Object
--inner join sadece eşlesenleri getir
select * from Products p inner join [Order Details] od
on p.ProductID= od.ProductID

--left solda olup sagda olmayanları getir
select * from Products p left join [Order Details] od
on p.ProductID= od.ProductID
inner join Orders o
on o.OrderId = od.OrderId


select * from Customers c inner join [Orders] o
on c.CustomerID= o.CustomerID


select * from Customers c left join [Orders] o
on c.CustomerID= o.CustomerID
where o.CustomerID is null

