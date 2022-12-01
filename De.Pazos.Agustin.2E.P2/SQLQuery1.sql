INSERT INTO Usuario (nombre,apellido,gmail,pass,dni) VALUES ('ernesto','ASDASD','gmail','asdasd123',12344)
INSERT INTO Usuario (nombre,apellido,gmail,pass,dni) VALUES ('ernesssto2','ASDssASD2','gmail442','asdasd123244',12342242)
INSERT INTO Usuario (nombre,apellido,gmail,pass,dni) VALUES ('Admiiin','aaaa','admind123','asdasd',123242)
SELECT * FROM Usuario
SELECT MAx(id) FROM Usuario
SELECT * FROM Usuario WHERE id = (SELECT MAX(id) FROM Usuario) -- MAX ID

--INSERT ADMIN
INSERT INTO Admin (idUsuario) VALUES (11)
----------------------------------------------------------------------------------------------------------------------------Usuarios
--Usuarios(Alumnos)
SELECT Usuario.id, apellido,nombre,gmail,dni,pass,idAlumno FROM Usuario inner join Alumno on Usuario.id = Alumno.idUsuario 
--Usuarios(Profesor)
SELECT Usuario.id, apellido,nombre,gmail,dni,pass,idProfesor FROM Usuario inner join Profesor on Usuario.id = Profesor.idUsuario
--Usuario(Admin)
SELECT Usuario.id, apellido,nombre,gmail,dni,pass,idAdmin FROM Usuario inner join Admin on Usuario.id = Admin.idUsuario
----------------------------------------------------------------------------------------------------------------------------Usuarios
--SELECT USUARIOS ALUMNOS
SELECT *,idAlumno FROM Usuario inner join Alumno on Usuario.id = Alumno.idUsuario
--SELECT USUARIO PROFESOR
SELECT *,idProfesor FROM Usuario inner join Profesor on Usuario.id = Profesor.idUsuario
--SELECT USUARIO ADMIN
SELECT *,idAdmin FROM Usuario inner join Admin on Usuario.id = Admin.idUsuario

SELECT * FROM Admin
SELECT * FROM Profesor
SELECT * FROM MateriaCursada
SELECT * FROM EXAMEN
SELECT * FROM Usuario


DELETE  FROM Alumno
INSERT INTO Alumno (idUsuario,cantidadMateriasEnCurso) VALUES (10,0)
INSERT INTO Alumno (idUsuario,cantidadMateriasEnCurso) VALUES (1,0)
INSERT INTO Profesor(idUsuario) VALUES (3)
INSERT INTO Examen (id,nombre,materia,fecha,idProfesor) VALUES (1,'Exmanen 1','Matematica 1','1996-02-10',1)
select * from Alumno where idUsuario = 1;
INSERT INTO MateriaCursada (idAlumno,nombre,asistencia,regularidad,notaFinal,notaPrimerParcial,notaSegundoParcial) VALUES (6,'Matematica2',0,'regular',0,0,0),
																														  (6,'Matematica3',0,'regular',0,0,0),
																														  (6,'Matematica4',0,'regular',0,0,0),
																														  (6,'Matematica5',0,'regular',0,0,0),
																														  (6,'Matematica6',0,'regular',0,0,0)

INSERT INTO MateriaCursada (idAlumno,nombre,asistencia,regularidad,notaFinal,notaPrimerParcial,notaSegundoParcial) VALUES (7,'Matematica2',0,'regular',0,0,0) 
INNER JOIN MateriaCursada c ON c.idAlumno = Alumno.idAlumno
select nombre,regularidad from MateriaCursada inner join Alumno on MateriaCursada.idAlumno = Alumno.idAlumno Where Alumno.idAlumno=7
select id,gmail from Usuario inner join Profesor on  Profesor.idUsuario = Usuario.id Where 
INSERT INTO Materia (nombre,cuatrimestre,correlativas,estadoProfesor,idProfesor,idAlumno) VALUES ('Matematica 1', 0,'ninguna',0,1,6)

SELECT * FROM Materia Where Materia.nombre = 'Matematica 1'
SELECT * FROM Materia
 

SELECT *, FROM Usuario inner join Rol WHERE Usuario.pass = 'asdasd1232' and Usuario.gmail = 'gmail2'
SELECT id,nombre,
UPDATE Usuario set permisos = 1 where id = 11;
 
 
SELECT Usuario.id,Usuario.nombre,apellido,dni,pass,gmail,Profesor.idProfesor,Examen.id,Examen.nombre,Examen.materia,Examen.fecha FROM USUARIO inner join Profesor on Profesor.idUsuario = Usuario.id inner join Examen on Profesor.idProfesor = Examen.idProfesor
 
SELECT * FROM Usuario inner join Alumno on Usuario.id = Alumno.idUsuario
SELECT * FROM Usuario inner join Alumno on Usuario.id = Alumno.idUsuario inner join MateriaCursada on MateriaCursada.idAlumno = Alumno.idAlumno



SELECT id, nombre, apellido, gmail, dni FROM Materia m inner join MateriaCursada mc on mc.nombreMateriaC = m.nombreMateria inner join Usuario2 u on u.id = idAlumno Where m.nombreMateria = 'Matematica 1' and mc.estadoCursada = 0

SELECT id,Usuario.nombre,apellido,dni,pass,gmail,Alumno.idAlumno,MateriaCursada.nombre,notaPrimerParcial,notaSegundoParcial,asistencia,regularidad,notaFinal FROM Usuario inner join Alumno on Usuario.id = Alumno.idUsuario inner join MateriaCursada on MateriaCursada.idAlumno = Alumno.idAlumno