use Bufet_UTN

--insert into Proveedores
--values (100, 'Perez', 'Perón 876', 'Quilmes'), (101,'Gimenez','Mitre 750', 'Avellaneda'),(102,'Aguirre','Boedo 634','Bernal')

--insert into Productos
--values (1,'Caramelos',1.5,'Chico'),(2,'Alfajores',45.89,'Mediano'),(3,'Gaseosa',15.80,'Grande')

--insert into Envios
--values (100,1,500),(100,2,1500),(100,3,100),(101,2,55),(101,3,225),(102,1,600),(102,3,300)

--_________________Consultas________________________

--select * from Productos
--order by Nombre asc

--select * from Proveedores
--where Localidad = 'Quilmes'

--select * from Envios
--where Cantidad between 200 and 300

--select SUM(Cantidad) from Envios

--select top 3 Cantidad from Envios

--select dbo.Proveedores.Nombre AS Nombre_Proveedores , dbo.Productos.Nombre as Nombre_Producto from dbo.Proveedores 
--inner join dbo.Envios on dbo.Proveedores.Numero_Proveedor = dbo.Envios.Numero_Proveedor
--inner join dbo.Productos on dbo.Productos.Codigo_Producto = dbo.Envios.Codigo_Producto

--select (dbo.Productos.Precio*dbo.Envios.Cantidad) as Monto_Productos from dbo.Productos inner join dbo.Envios on dbo.Productos.Codigo_Producto = dbo.Envios.Codigo_Producto

--select SUM(dbo.Envios.Cantidad) as Cantidad_Total_Proveedor_102 from dbo.Envios inner join dbo.Proveedores on dbo.Envios.Numero_Proveedor = dbo.Proveedores.Numero_Proveedor
--where Proveedores.Numero_Proveedor = 102

--select dbo.Envios.Codigo_Producto as Codigo_From_Avellaneda from dbo.Envios inner join dbo.Proveedores on dbo.Envios.Numero_Proveedor = dbo.Proveedores.Numero_Proveedor
--where Localidad = 'Avellaneda' 

--select dbo.Proveedores.Domicilio, dbo.Proveedores.Localidad from dbo.Proveedores
--where Domicilio like '%i%' or Localidad like '%i%'

--insert into dbo.Productos
--values (4,'Chocolate',25.35,'Chico')

--select * from dbo.Productos
--where dbo.Productos.Codigo_Producto = 4

--insert into dbo.Proveedores(Numero_Proveedor)
--values (103)

--select * from dbo.Proveedores
--where Numero_Proveedor = 103

--insert into dbo.Proveedores(Numero_Proveedor,Nombre,Localidad)
--values (107,'Rosales','La plata')

--select * from dbo.Proveedores
--where Numero_Proveedor = 107

--update dbo.Productos
--set Precio = 97.50
--where Dimensiones = 'Grande'

--select * from dbo.Productos
--where Dimensiones = 'Grande'

--UPDATE dbo.Productos
--set Dimensiones = 'Mediano'
--FROM dbo.Productos join dbo.Envios on dbo.Productos.Codigo_Producto = dbo.Envios.Codigo_Producto
--where dbo.Envios.Cantidad >= 300 and dbo.Productos.Dimensiones = 'Medianio'

--select * from dbo.Productos
--where Dimensiones = 'Mediano'

--delete from dbo.Envios
--where dbo.Envios.Codigo_Producto = 1
--delete from dbo.Productos
--where dbo.Productos.Codigo_Producto = 1

--select * from dbo.Productos
--where dbo.Productos.Codigo_Producto = 2

--select * from dbo.Envios 
--where dbo.Envios.Codigo_Producto = 2

--delete dbo.Envios
--from dbo.Envios join dbo.Proveedores on dbo.Proveedores.Numero_Proveedor = dbo.Envios.Numero_Proveedor
--where dbo.Envios.Numero_Proveedor != dbo.Proveedores.Numero_Proveedor

--delete from dbo.Proveedores
--where dbo.Proveedores.Numero_Proveedor not in (select dbo.Envios.Numero_Proveedor from dbo.Envios)

--select * from dbo.Envios
--select * from dbo.Proveedores

