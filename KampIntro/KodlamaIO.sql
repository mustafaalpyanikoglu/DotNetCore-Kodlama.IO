--Select
--ANSI
select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

select * from Customers where City = 'London'

--case insensitive // Sql küçük-büyük harfe duyarsız
select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products where CategoryID=1 order by UnitPrice desc  --ascending//artan  --descending//düşen

select count(*) from Products where CategoryID=2

select CategoryID,count(*) from Products where UnitPrice>20
group by CategoryID having count(*)<10

select p.ProductID,p.ProductName,p.UnitPrice,c.CategoryName from 
Products p inner join Categories c on p.CategoryID=c.CategoryID
where p.UnitPrice>10

--DTO Data Transformation object

select * from Products p left join [Order Details] od on p.ProductID = od.ProductID
inner join Orders o on o.OrderID = od.OrderID

select * from Customers c left join Orders o on c.CustomerID=o.CustomerID
where o.CustomerID is null




