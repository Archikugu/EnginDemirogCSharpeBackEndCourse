--Select // comment line burada -- 
--ANSII standardantında oracle da da mysql de çalışır
Select * from Customers
--Burası bir tablo 
Select ContactName,CompanyName, City from Customers
--Alias
Select ContactName Adi ,CompanyName SirketAdi, City Sehir from Customers
--Sehri london olanları getirme
Select * from Customers where City = 'London'

--Sql Case insensitive büyük küçük harfe duyarsızdır.

--categoryID = 1 yada 3 olanları getir (dinamik yapı) 
select * from Products where categoryID = 1 or CategoryID = 3

--2 sartıda geçerli olan sorguyu getir (and)
select * from Products where categoryID = 1 and UnitPrice >= 10

--order by sırala tüm ürünler seç ama ismine göre sırala
select * from Products order by ProductName 
select * from Products order by CategoryID,ProductName
select * from Products order by UnitPrice asc --ascendind artan defultu asc yani
select * from Products order by UnitPrice desc --descending azalan
select * from Products where categoryID =1 order by UnitPrice desc

--Kaç adet ,Adet burada alias yine
Select count(*) Adet from Products where CategoryID = 2

--Yönetim dedi ki hangi kategoride kaç farklı ürünümüz var diye sordu 
--1 kolon ve sayı istiyoruz

select * from Products group by CategoryID
--bu çalışmaz burada * kullanılmaz bu yüzden

--Bütün kategorileri tekrar etmeyecek şekilde sırala
select categoryId,COUNT(*) from Products group by CategoryID
--group by yapılınca arkada tablo oluşturuluyormuş gibi düşünebiliriz.

--içerisinde 10 dan az olan ürünleri ver
select categoryId,COUNT(*) from Products where UnitPrice>20 group by CategoryID having COUNT(*)<10

--inner join on şart demek 
select * from Products inner join Categories on Products.CategoryID=Categories.CategoryID

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName from Products inner join Categories on Products.CategoryID=Categories.CategoryID where Products.UnitPrice>10

--DTO Data Transformation object
--Tablo ismini almak için boşlukta hata verdiği için köşeli paranteze aldık aliaslarda genelde kısaltma kullanırız
Select * from Products p inner join [Order Details] od on  p.ProductID = od.ProductID
--inner join sadece iki tabloda eşleşenleri getirir

--yönetim sana dediki satılmayan ürünleri getir kampanya yapıp satalım dedi 
Select * from Products p left join [Order Details] od on  p.ProductID = od.ProductID

select * from customers c left join Orders o on c.CustomerID=o.CustomerID 
--solda olup sağda olmayınlar 

select * from customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null


-- ikiden fazla tobloyu birleştirmek için
select * from Products p inner join [Order Details] od on p.ProductID=od.ProductID inner join Orders o on o.OrderID = od.OrderId

