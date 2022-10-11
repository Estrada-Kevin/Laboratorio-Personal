USE [EMPRESA_DB]

--select * from dbo.EMPLEADOS

--select NOMBRE from dbo.PUESTOS 

--select * from dbo.EMPLEADOS
--where ESTA_ACTIVO = 1

--select * from dbo.EMPLEADOS
--where SALARIO > 200000.00

--select * from dbo.EMPLEADOS
--where FECHA_ALTA <= '07-06-2012'

--select * from dbo.EMPLEADOS
--where MAIL is NULL;

--select * from dbo.EMPLEADOS
----where MAIL is not null;

--select * from dbo.EMPLEADOS
--where MAIL LIKE '%gmail.com'

--select * from dbo.EMPLEADOS
--where APELLIDO LIKE 'B%'

--select * from dbo.EMPLEADOS
--where ESTA_ACTIVO = 1 and SALARIO>300000

--select * from dbo.EMPLEADOS
--where MAIL is NULL and ESTA_ACTIVO = 0

--select * from dbo.EMPLEADOS
--where MAIL is not null and NOMBRE LIKE '%a%'

--select * from dbo.EMPLEADOS
--where SALARIO > 250000.00 and FECHA_ALTA >= '01-01-2000'

--select * from dbo.EMPLEADOS
--where SALARIO between 100000 and 250000

--select * from dbo.EMPLEADOS
--where SALARIO not between 100000 and 250000

--select * from dbo.PUESTOS
--where NIVEL_AUTORIZACION = 0 or NIVEL_AUTORIZACION = 1 or NIVEL_AUTORIZACION = 2

--select * from dbo.PUESTOS
--where NIVEL_AUTORIZACION != 0 and NIVEL_AUTORIZACION != 1 and NIVEL_AUTORIZACION != 2

--select * from dbo.EMPLEADOS
--where ESTA_ACTIVO = 1 order by APELLIDO ASC


--select top 3 * from dbo.EMPLEADOS order by FECHA_ALTA asc

--select top 3 * from dbo.EMPLEADOS order by SALARIO desc

--select * from dbo.EMPLEADOS order by SALARIO desc

--select distinct NIVEL_AUTORIZACION from dbo.PUESTOS 	

--select dbo.EMPLEADOS.*,dbo.PUESTOS.NOMBRE as NOMBRE_PUESTO from dbo.EMPLEADOS inner join dbo.PUESTOS on dbo.PUESTOS.ID_PUESTO = dbo.EMPLEADOS.ID_PUESTO

--select * from EMPLEADOS inner join dbo.PUESTOS on dbo.PUESTOS.ID_PUESTO = dbo.EMPLEADOS.ID_PUESTO
--where NIVEL_AUTORIZACION = 3

--select dbo.EMPLEADOS.NOMBRE,dbo.EMPLEADOS.APELLIDO,dbo.PUESTOS.NOMBRE as PUESTO from dbo.EMPLEADOS inner join dbo.PUESTOS on dbo.PUESTOS.ID_PUESTO = dbo.EMPLEADOS.ID_PUESTO
--order by APELLIDO asc

--select dbo.EMPLEADOS.NOMBRE,dbo.EMPLEADOS.APELLIDO,dbo.PUESTOS.NOMBRE as PUESTO from dbo.EMPLEADOS inner join dbo.PUESTOS on dbo.PUESTOS.ID_PUESTO = dbo.EMPLEADOS.ID_PUESTO
--order by NOMBRE asc

--select dbo.EMPLEADOS.NOMBRE,dbo.EMPLEADOS.APELLIDO,dbo.PUESTOS.NOMBRE as PUESTO from dbo.EMPLEADOS inner join dbo.PUESTOS on dbo.PUESTOS.ID_PUESTO = dbo.EMPLEADOS.ID_PUESTO
--where ESTA_ACTIVO = 1 order by NIVEL_AUTORIZACION asc

--select dbo.PUESTOS.NOMBRE from dbo.PUESTOS left join dbo.EMPLEADOS on dbo.PUESTOS.ID_PUESTO = dbo.EMPLEADOS.ID_PUESTO
--where dbo.PUESTOS.ID_PUESTO = 6

--select dbo.PUESTOS.NOMBRE from dbo.EMPLEADOS right join dbo.PUESTOS on dbo.PUESTOS.ID_PUESTO = dbo.EMPLEADOS.ID_PUESTO
--where dbo.PUESTOS.ID_PUESTO != 6

--select AVG(SALARIO) AS PROMEDIO from dbo.EMPLEADOS
--where ESTA_ACTIVO = 1

--select SUM(SALARIO) as SUMA_SALARIOS from dbo.EMPLEADOS
--where ESTA_ACTIVO = 1

--select COUNT(SALARIO) as CUANTOS_GANAN_MAS_QUE_250K from dbo.EMPLEADOS
--where SALARIO > 250000

--select COUNT(FECHA_ALTA) as INGRESARON_ANTES_DEL_2010 from dbo.EMPLEADOS
--where FECHA_ALTA < '01-01-2010'

--select top 1 dbo.EMPLEADOS.SALARIO from dbo.EMPLEADOS order by SALARIO desc

--select NIVEL_AUTORIZACION from dbo.PUESTOS 
--where NIVEL_AUTORIZACION < 1

--select CONCAT(NOMBRE,' ',APELLIDO) as NOMBRES_COMPLETOS_CONCATENADO from dbo.EMPLEADOS

--select CONCAT(dbo.EMPLEADOS.NOMBRE, ' ',APELLIDO) as NOMBRE_COMPLETO,dbo.PUESTOS.NOMBRE,dbo.PUESTOS.NIVEL_AUTORIZACION from dbo.EMPLEADOS inner join dbo.PUESTOS on dbo.EMPLEADOS.ID_PUESTO = dbo.PUESTOS.ID_PUESTO

--select CONCAT(dbo.EMPLEADOS.NOMBRE,' ',APELLIDO) as NOMBRE_COMPLETO,dbo.PUESTOS.NOMBRE,dbo.PUESTOS.NIVEL_AUTORIZACION from dbo.EMPLEADOS right join dbo.PUESTOS on dbo.EMPLEADOS.ID_PUESTO = dbo.PUESTOS.ID_PUESTO

--select COUNT(dbo.EMPLEADOS.ID_EMPLEADO)as EMPLEADO_POR_PUESTO from dbo.EMPLEADOS
--group by ID_PUESTO 

--select AVG(SALARIO) from dbo.EMPLEADOS
--group by ID_PUESTO

--select top 1 NOMBRE,APELLIDO,SALARIO from dbo.EMPLEADOS
--order by SALARIO desc

--select dbo.EMPLEADOS.NOMBRE from dbo.EMPLEADOS inner join dbo.PUESTOS on dbo.PUESTOS.ID_PUESTO = dbo.EMPLEADOS.ID_PUESTO
--where NIVEL_AUTORIZACION > 2

--select dbo.EMPLEADOS.NOMBRE, MAX(NIVEL_AUTORIZACION) AS MAXIMO_NIVEL_AUTORIZACION from dbo.PUESTOS inner join dbo.EMPLEADOS on dbo.PUESTOS.ID_PUESTO = dbo.EMPLEADOS.ID_PUESTO
--group by dbo.EMPLEADOS.NOMBRE
--having MAX(NIVEL_AUTORIZACION) = 3

--select top 1 * from dbo.EMPLEADOS
--order by FECHA_ALTA asc

--select AVG(SALARIO) AS SALARIO_MAYOR_AL_PROMEDIO, NOMBRE from dbo.EMPLEADOS
--group by NOMBRE
--having AVG(SALARIO) > 305246.335

--select COUNT(ID_EMPLEADO)from dbo.EMPLEADOS
--where SALARIO >=  305246.335

--UPDATE dbo.EMPLEADOS
--SET MAIL = 'mbrock@yahoo.com' 
--where ID_EMPLEADO = 183     

--UPDATE dbo.EMPLEADOS
--set ID_PUESTO = 4, SALARIO = 210000.00
--where ID_EMPLEADO=183

--UPDATE dbo.EMPLEADOS
--set SALARIO = SALARIO * 1.25
--where SALARIO < 250000

--UPDATE dbo.EMPLEADOS
--set FECHA_BAJA = '11-10-2022'
--set ESTA_ACTIVO = 0
--where ID_EMPLEADO = 181

--DELETE FROM dbo.EMPLEADOS
--where ESTA_ACTIVO = 0





