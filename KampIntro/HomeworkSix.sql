select p.ProductName,sum(od.UnitPrice*od.Quantity) as KazanılanMiktar from Products p 
inner join [Order Details] od on p.ProductID=od.ProductID
inner join Orders o on o.OrderID=od.OrderID 
group by p.ProductName
order by KazanılanMiktar desc
