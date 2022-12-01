/*CREATE TABLE [dbo].[Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idRol] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[dni] [int] NOT NULL,
	[pass] [varchar](50) NOT NULL,
	[gmail] [varchar](50) NOT NULL
 CONSTRAINT [PK_Usuario2] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Roles](
	[id] [int] NOT NULL,
	[rol] [varchar](50) NOT NULL);

CREATE TABLE [dbo].[MateriaCursada](
	[idAlumno] [int] NOT NULL,
	[nombreMateriaC] [varchar](50) NOT NULL,
	[notaPrimerParcial] [int] NULL,
	[notaSegundoParcial] [int] NULL,
	[asistencia] [int] NOT NULL,
	[regularidad] [int] NOT NULL,
	[estadoCursada] [int] NOT NULL,
	[notaFinal] [int] NULL)


CREATE TABLE [dbo].[Materia](
	[idMateria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[cuatrimestre] [int] NOT NULL,
	[correlativas] [varchar](50) NULL,
	[estadoProfesor] [int] NULL,
	[idProfesor] [int] NULL);

CREATE TABLE [dbo].[Examen](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[materia] [varchar](50) NOT NULL,
	[idProfesor] [int] NOT NULL)*/


GO
USE [TEST3]
GO
SELECT * FROM Usuario2 u inner join MateriaCursada m on u.id = m.idAlumno Where u.id = 7
SELECT nombreMateriaC,notaPrimerParcial,notaSegundoParcial,asistencia,regularidad,estadoCursada,notaFinal, id FROM Usuario2 inner join MateriaCursada on Usuario2.id = MateriaCursada.idAlumno WHERE Usuario2.id = 1
--INSERT INTO Roles (id,rol) VALUES(1,'Admin') --ROLES
--INSERT INTO Roles (id,rol) VALUES(2,'Alumno') --ROLES
--INSERT INTO Roles (id,rol) VALUES(3,'Profesor') --ROLES
SELECT * FROM Roles
SELECT * FROM Materia
INSERT INTO Usuario (idRol,nombre,apellido,dni,pass,gmail) VALUES (2,'laura','real',4122312,'asdasd','laura@gmail.com')
INSERT INTO Usuario (idRol,nombre,apellido,dni,pass,gmail) VALUES (2,'agustin','de pazos',412312,'asdasd','depazosagustin@gmail.com')
INSERT INTO Usuario (idRol,nombre,apellido,dni,pass,gmail) VALUES (3,'ernesto','villegas',22222,'asdasd1','ernesto@gmail.com')
INSERT INTO Usuario (idRol,nombre,apellido,dni,pass,gmail) VALUES (1,'administrador','adm',22122,'asdasd','admin@gmail.com')
-------------------------------------------------------------------
INSERT INTO Materia (nombre,cuatrimestre) VALUES ('Matematica 1',0)

INSERT INTO Materia (nombreMateria,cuatrimestre,correlativas,estadoProfesor,idProfesor) VALUES ('Matematica 2',1,'Matematica 1',1,3)
DELETE Materia WHERE idMateria = 13
DELETE MateriaCursada WHERE idAlumno = 1 and nombreMateriaC = 'Matematica 2'
--------------------------------------------------------------------
SELECT nombreMateria FROM Materia inner join MateriaCursada on Materia.nombreMateria = MateriaCursada.NombreMateriaC Where MateriaCursada.estadoCursada = 0 and MateriaCursada.idAlumno = 1
--------------------------------------------------------------------
--Alumnos
SELECT * FROM Usuario2 inner join MateriaCursada on Usuario2.id = MaTeriaCursada.idAlumno WHERE idRol = 2
--------------------------------------------------------------------
--PROFESORES
SELECT * FROM Usuario2 WHERE Usuario2.idRol = 3
SELECT * FROM Usuario2 inner join Roles on Usuario2.idRol = Roles.id WHERE Roles.rol = 'Profesor'
-------------------------------------------------------------------
------------------------Materias Cursadas----------------------------------
INSERT INTO MateriaCursada (idAlumno,nombre,asistencia,regularidad,estadoCursada,notaPrimerParcial,notaSegundoParcial,notaFinal) VALUES (1,'Matematica 1',1,1,0,0,0,0)
--UPDATE MateriaCursada set notaPrimerParcial = 0, notaSegundoParcial = 0 ,notaFinal = 0 Where idAlumno = 1
SELECT * FROM MateriaCursada
SELECT * FROM Materia inner join MateriaCursada on Materia.nombre = MateriaCursada.nombre inner join Usuario2 on MateriaCursada.idAlumno = Usuario2.id WHERE estadoCursada = 0
--addmateriascursando
SELECT MateriaCursada.nombre,notaPrimerParcial,notaSegundoParcial,asistencia,regularidad,estadoCursada,notaFinal FROM Usuario2 inner join MateriaCursada on Usuario2.id = MateriaCursada.idAlumno WHERE Usuario2.id = 1
---------------------------------------------------------------------------

--------------------------MATERIAS------------------------------------------

SELECT * FROM Materia inner join MateriaCursada on Materia.nombre = MateriaCursada.nombre Where estadoProfesor = 1 and estadoCursada = 0 
SELECT nombre FROM Materia WHERE Materia.idProfesor is not null
SELECT * FROM Materia WHERE nombre = 'Matematica 1'
SELECT * FROM Materia WHERE Materia.nombre = 'Matematica 1'
UPDATE Materia set Materia.idProfesor = null where Materia.nombre = 'Matematica 2'
UPDATE Materia set estadoProfesor = null where Materia.nombre = 'Matematica 2';----------ASIGNAR MATERIA PROFESOR POR NOMBRE D MATERIA
SELECT * FROM Materia WHERE Materia.nombre = 'mamatematica 1' and Usuario2.nombre = 'ernesto'
----------------------------------------------------------------USUARIO
SELECT * FROM Usuario2 WHERE CONCAT(nombre, ' ', apellido) = 'ernesto villegas'
SELECT * FROM Usuario
DELETE FROM Usuario2 WHERE Usuario2.id = 5
SELECT * FROM Usuario2 WHERE Usuario2.gmail = 'depazosagustin@gmail.com'or Usuario2.dni = 1111 or Usuario2.apellido = 'aaaa'
SELECT * FROM Usuario2 inner join Roles on Usuario2.idRol = Roles.id WHERE Usuario2.pass = 'asd' or Usuario2.gmail = 'depazosagustin@gmail.com'
SELECT * FROM Materia inner join Usuario2 on Usuario2.id = Materia.idMateria Where idProfesor = 2
SELECT COUNT(*) FROM Usuario2 WHERE Usuario2.gmail = 'depazosagustin@gmail.com'

SELECT id FROM Usuario2 WHERE id = (SELECT MAX(id) FROM Usuario2)
SELECT * FROM Materia inner join Usuario2 on Usuario2.id = Materia.idProfesor Where idProfesor = 2





SELECT * FROM Usuario
UPDATE MateriaCursada set asistencia = 0 WHERE notaPrimerParcial = 8
SELECT * FROM Roles
SELECT * FROM Materia
SELECT * FROM MateriaCursada
SELECT * FROM Examen
SELECT id,nombre,apellido,gmail,dni FROM Materia inner join MateriaCursada on MateriaCursada.nombreMateriaC = Materia.nombreMateria inner join Usuario2 on Usuario2.id = idAlumno Where Materia.nombreMateria = 'Matematica 1' and idProfesor = 2 and idRol =2

	SELECT Materia.id,Materia.nombre,Materia.cuatrimestre,Materia.correlativas,Materia.estadoProfesor,cuatrimestre,Usuario2.nombre,apellido,dni,pass,gmail FROM Materia inner join Usuario2 on Materia.idProfesor = Usuario2.id

SELECT * FROM Materia inner join MateriaCursada on Materia.nombreMateria = MateriaCursada.NombreMateriaC Where MateriaCursada.estadoCursada = 0
SELECT nombreMateriaC,notaPrimerParcial,notaSegundoParcial,asistencia,regularidad,estadoCursada,notaFinal FROM MateriaCursada inner join Usuario2 on Usuario2.id = MateriaCursada.idAlumno WHERE idAlumno = 7


DELETE MateriaCursada Where idAlumno = 1
SELECT COUNT(*) MateriasCursada FROM MateriaCursada WHERE idAlumno = 1 AND estadoCursada = 0-- CANTIDAD DMATERIAS CURSADAS

SELECT id,nombre,apellido,gmail,dni,pass FROM Materia inner join MateriaCursada on MateriaCursada.nombreMateriaC = Materia.nombreMateria inner join Usuario2 on Usuario2.id = idAlumno Where Materia.nombreMateria = 'Matematica 1' and idProfesor = 2 and idRol =2


SELECT id,nombre,apellido,gmail,dni,pass FROM Materia m inner join MateriaCursada mc on mc.nombreMateriaC = m.nombreMateria inner join Usuario2 u on u.id = idAlumno Where m.nombreMateria = 'Matematica 1' and mc.estadoCursada = 0

 SELECT * FROM MateriaCursada m inner join Usuario2 u on u.id = m.idAlumno WHERE nombreMateriaC = 'Matematica 1' and estadoCursada = 0
UPDATE MateriaCursada set regularidad = 1 FROM MateriaCursada m inner join Usuario2 u on u.id = m.idAlumno WHERE nombreMateriaC = 'Matematica 1' and estadoCursada = 0
