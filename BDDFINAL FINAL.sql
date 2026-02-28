create table Carreras
(
	id_carrera int primary key identity,
	nombre varchar (50) not null,
	duracion int not null,
	resolucion varchar(10) not null,
)

create table Perfiles
(
	id_perfil int primary key identity,
	nombre varchar(20) not null,
	Descripcion varchar(100) not null
)

create table Alumnos
(
	matricula int primary key identity,
	nombre varchar(50) not null,
	apellido varchar(50) not null,
	dni int unique not null,
	domicilioCalle varchar(50) not null,
	domicilioNumero int not null,
	telefono varchar(10),
	email varchar(50) unique not null,
	fechaInscripcion date,
	fechaBaja date,
	usuario varchar(50) unique not null,
	contraseña varchar(50) unique not null,
	id_perfil int,
	foreign key (id_perfil) references Perfiles (id_perfil),
)

create table Profesores
(
	id_profesor int primary key identity,
	nombre varchar(50) not null,
	apellido varchar(50) not null,
	dni int unique not null,
	domicilioCalle varchar(50) not null,
	domicilioNumero int not null,
	telefono varchar(10),
	email varchar(50) unique not null,
	fechaInscripcion date,
	fechaBaja date,
	usuario varchar(50) unique not null,
	contraseña varchar(50) unique not null,
	id_perfil int
	foreign key (id_perfil) references Perfiles (id_perfil)
)

create table Personal
(
	id_personal int primary key identity,
	nombre varchar(50) not null,
	apellido varchar(50) not null,
	dni int unique not null,
	domicilioCalle varchar(50) not null,
	domicilioNumero int not null,
	telefono varchar(10),
	email varchar(50) unique not null,
	fechaInscripcion date,
	fechaBaja date,
	usuario varchar(50) unique not null,
	contraseña varchar(50) unique not null,
	id_perfil int,
	foreign key (id_perfil) references Perfiles (id_perfil)
)

create table Instancias
(
	id_instancia int primary key identity,
	nombre varchar(20) not null,
	descripcion varchar (100) not null
)


create table Materias
(
	id_materia int primary key identity,
	id_carreras int,
	nombre varchar(50) not null ,
	año int,
	id_profesor int,
	foreign key (id_carreras) references Carreras (id_carrera),
	foreign key (id_profesor) references Profesores (id_profesor)
)

create table NotasxAlumno
(
	id_notasxalumno int primary key identity,
	matricula int,
	id_materia int,
	id_instancia int not null,
	fecha date not null,
	nota decimal not null,
	libro varchar (20),
	folio varchar (20),
	foreign key (id_materia) references Materias (id_materia),
	foreign key (id_instancia) references Instancias (id_instancia),
	foreign key (matricula) references Alumnos (matricula)
)

create table MateriaxAlumno
(
	id_materiaxalumno int primary key identity,
	matricula int,
	id_materia int,
	foreign key (matricula) references Alumnos (matricula),
	foreign key (id_materia) references Materias (id_materia)
)

create table CarreraxAlumno
(
	id_carreraxalumno int primary key identity,
	Año_Cursada int,
	matricula int,
	id_carrera int,
	foreign key (matricula) references Alumnos (matricula),
	foreign key (id_carrera) references Carreras (id_carrera)
)


create table ProfesorxMateria 
(
	id_profesorxmateria int primary key identity,
	id_materia int,
	id_profesor int,
	foreign key (id_materia) references Materias (id_materia),
	foreign key (id_profesor) references Profesores (id_profesor)
)


-- =====  Insertando perfiles =====

INSERT INTO Perfiles (nombre, Descripcion) 
VALUES 
('Alumno', 'Visualiza exámenes y su rendimiento académico.'),
('Profesor', 'Gestiona alumnos y exámenes, pero sin acceso avanzado.'),
('Personal', 'Gestiona alumnos y carreras, sin modificar usuarios.'),
('Administrador', 'Acceso total a usuarios, carreras y funciones del sistema.');

-- =====  Insertando carreras =====

insert into Carreras (nombre, duracion, resolucion)
values ('Analista de Sistemas', 3, '6790/19');

insert into Carreras (nombre, duracion, resolucion)
values ('Publicidad', 3, '3805/06');

--N =====  Insertando profesores =====

INSERT INTO Profesores (nombre, apellido, dni, domicilioCalle, domicilioNumero, telefono, email, fechaInscripcion, fechaBaja, usuario, contraseña, id_perfil)
VALUES
('Juan', 'Pérez', 12345678, 'Av. Luro', 1234, '2231543212', 'juan.p@hilet.com', '2022-03-01', NULL, '12345678', '12345678', 2),
('María', 'González', 87654321, 'Calle San Martín', 4321, '2231543212', 'mariag@hilet.com', '2022-03-05', NULL, '87654321', '87654321', 2),
('Carlos', 'Fernández', 23456789, 'Calle Rivadavia', 5678, '2231543212', 'carlosf@hilet.com', '2022-03-10', NULL, '23456789', '23456789', 2),
('Laura', 'Rodríguez', 98765432, 'Calle Alvarado', 8765, '2231543212', 'laurar@hilet.com', '2022-03-15', NULL, '98765432', '98765432', 2),
('José', 'Martínez', 34567890, 'Calle Libertad', 3456, '2231543212', 'josem@hilet.com', '2022-03-20', NULL, '34567890', '34567890', 2),
('Ana', 'López', 65432109, 'Calle Colón', 2345, '2231543212', 'anaz@hilet.com', '2022-03-25', NULL, '65432109', '65432109', 2),
('Diego', 'Sánchez', 45678901, 'Calle Tucumán', 6543, '2231543212', 'diego@hilet.com', '2022-03-30', NULL, '45678901', '45678901', 2),
('Lucía', 'García', 56789012, 'Calle 20 Sep', 3210, '2231543212', 'lucia@hilet.com', '2022-04-01', NULL, '56789012', '56789012', 2),
('Fernando', 'Martín', 67890123, 'Av. Independencia', 7890, '2231543212', 'fernandon@hilet.com', '2022-04-05', NULL, '67890123', '67890123', 2),
('Patricia', 'Hernández', 78901234, 'Calle 3 Feb.', 4567, '2231543212', 'patricia@hilet.com', '2022-04-10', NULL, '78901234', '78901234', 2);


-- =====  Insertando materias =====

INSERT INTO Materias (id_carreras, nombre, año, id_profesor)
VALUES
(1, 'Inglés I', 1, 1),
(1, 'Ciencia, Tecnología y Sociedad', 1, 2),
(1, 'Análisis Matemático I', 1, 3),
(1, 'Álgebra', 1, 4),
(1, 'Algoritmos y estructuras de datos I', 1, 5),
(1, 'Sistemas y Organizaciones', 1, 6),
(1, 'Arquitectura de computadoras', 1, 7),
(1, 'Prácticas Profesionalizantes I', 1, 8),
(1, 'Inglés II', 2, 9),
(1, 'Análisis Matemático II', 2, 10),
(1, 'Estadística', 2, 1),
(1, 'Ingeniería de Software I', 2, 2),
(1, 'Algoritmos y estructuras de datos II', 2, 3),
(1, 'Sistemas Operativos', 2, 4),
(1, 'Base de datos', 2, 5),
(1, 'Prácticas Profesionalizantes II', 2, 6),
(1, 'Inglés III', 3, 7),
(1, 'Aspectos legales de la profesión', 3, 8),
(1, 'Seminario de actualización', 3, 9),
(1, 'Redes y comunicaciones', 3, 10),
(1, 'Ingeniería de Software II', 3, 1),
(1, 'Algoritmos y estructuras de datos III', 3, 2),
(1, 'Prácticas Profesionalizantes III', 3, 3),
(2, 'Marketing general', 1, 4),
(2, 'Psicología Comportamiento del Consumidor', 1, 5),
(2, 'Fundamentos del diseño publicitario', 1, 6),
(2, 'Computación 1', 1, 7),
(2, 'Introducción a la publicidad', 1, 8),
(2, 'Producción gráfica', 1, 9),
(2, 'Producción radial', 1, 10),
(2, 'Producción audiovisual', 1, 1),
(2, 'Computación 2', 2, 2),
(2, 'Inglés I', 2, 3),
(2, 'Psicología social', 2, 4),
(2, 'Marketing directo', 2, 5),
(2, 'Arte, cine, literatura e historia de la publicidad', 2, 6),
(2, 'Redacción creativa 1', 2, 7),
(2, 'Dirección de arte 1', 2, 8),
(2, 'Planificación estratégica de medios', 2, 9),
(2, 'Semiología publicitaria', 2, 10),
(2, 'Técnica promocional y pop', 2, 1),
(2, 'Inglés 2', 3, 2),
(2, 'Investigación de mercados', 3, 3),
(2, 'Redacción creativa 2', 3, 4),
(2, 'Dirección de arte 2', 3, 5),
(2, 'Práctica profesional', 3, 6), 
(2, 'Atención de cuentas', 3, 7),
(2, 'Organización y administración de la agencia', 3, 8),
(2, 'Derecho y legislación publicitaria', 3, 9);

-- Insertando Alumnos --

INSERT INTO Alumnos (nombre, apellido, dni, domicilioCalle, domicilioNumero, telefono, email, fechaInscripcion, fechaBaja, usuario, contraseña, id_perfil)
VALUES
('Lucas', 'Martínez', 11122333, 'Av. Colón', 567, '2231543210', 'lucas.m@gmail.com', '2022-01-15', NULL, '11122333', '11122333', 1),
('Sofía', 'González', 22233444, 'Calle San Juan', 234, '2231543211', 'sofia.g@gmail.com', '2022-02-10', NULL, '22233444', '22233444', 1),
('Mateo', 'Pérez', 33344555, 'Calle Rivadavia', 345, '2231543212', 'mateo.p@gmail.com', '2022-03-05', NULL, '33344555', '33344555', 1),
('Valentina', 'Fernández', 44455666, 'Calle Alvarado', 456, '2231543213', 'valentina.f@gmail.com', '2022-04-01', NULL, '44455666', '44455666', 1),
('Juan', 'López', 55566777, 'Av. Independencia', 567, '2231543214', 'juan.l@gmail.com', '2022-05-10', NULL, '55566777', '55566777', 1),
('Camila', 'Rodríguez', 66677888, 'Calle Libertad', 678, '2231543215', 'camila.r@gmail.com', '2022-06-15', NULL, '66677888', '66677888', 1),
('Facundo', 'García', 77788999, 'Calle 20 de Septiembre', 789, '2231543216', 'facundo.g@gmail.com', '2022-07-20', NULL, '77788999', '77788999', 1),
('Mariana', 'Hernández', 88899000, 'Calle 3 de Febrero', 890, '2231543217', 'mariana.h@gmail.com', '2022-08-25', NULL, '88899000', '88899000', 1),
('Ignacio', 'Sánchez', 99900111, 'Calle Tucumán', 901, '2231543218', 'ignacio.s@gmail.com', '2022-09-30', NULL, '99900111', '99900111', 1),
('Florencia', 'Díaz', 10111222, 'Av. Luro', 123, '2231543219', 'florencia.d@gmail.com', '2022-10-15', NULL, '10111222', '10111222', 1);


--- Insertando Personal --

INSERT INTO Personal (nombre, apellido, dni, domicilioCalle, domicilioNumero, telefono, email, fechaInscripcion, fechaBaja, usuario, contraseña, id_perfil) 
VALUES
('Esteban', 'Martínez', 11223344, 'Calle San Martín', 123, '2231543201', 'esteban.m@gmail.com', '2022-01-01', NULL, '11223344', '11223344', 3),
('Lucía', 'González', 22334455, 'Av. Colón', 456, '2231543202', 'lucia.g@gmail.com', '2022-02-01', NULL, '22334455', '22334455', 3),
('Fernando', 'Pérez', 33445566, 'Calle Rivadavia', 789, '2231543203', 'fernando.p@gmail.com', '2022-03-01', NULL, '33445566', '33445566', 3),
('María', 'Rodríguez', 44556677, 'Calle Alvarado', 321, '2231543204', 'maria.r@gmail.com', '2022-04-01', NULL, '44556677', '44556677', 3),
('Javier', 'Sánchez', 55667788, 'Calle Libertad', 654, '2231543205', 'javier.s@gmail.com', '2022-05-01', NULL, '55667788', '55667788', 3),
('aaaaa', 'aaaaaa', 001, 'Calle San Martín', 127, '362344', 'awfaw@gmail.com', '2022-01-01', NULL, 'personal', 'personal', 3);
--N- Insertando Administrador --

INSERT INTO Personal (nombre, apellido, dni, domicilioCalle, domicilioNumero, telefono, email, fechaInscripcion, fechaBaja, usuario, contraseña, id_perfil) 
VALUES 
('Federico', 'Rodriguez', 11111111, 'Calle Guemes', 2200, '2231548766', 'federico.r@gmail.com', '2024-10-06', NULL, 'root', 'root', 4);


--- Insertando instancias --

insert into Instancias (nombre, descripcion) 
values
('Trabajo practico', 'Evaluación aplicada, centrada en la práctica.'),
('Parcial', 'Examen intermedio sobre contenido específico.'),
('Recuperatorio', ' Oportunidad para repetir parciales no aprobados'),
('Flotante', 'Oportunidad para salvar la materia'),
('Final', 'Examen que abarca todo el contenido, decisivo para aprobar.')



-- Insertando profesores en Materias --

INSERT INTO ProfesorxMateria (id_materia, id_profesor)
VALUES
(1, 1), 
(2, 2), 
(3, 3), 
(4, 4), 
(5, 5), 
(6, 6), 
(7, 7), 
(8, 8), 
(9, 9), 
(10, 10), 
(11, 1), 
(12, 2), 
(13, 3), 
(14, 4), 
(15, 5), 
(16, 6), 
(17, 7), 
(18, 8), 
(19, 9), 
(20, 10), 
(21, 1), 
(22, 2), 
(23, 3), 
(24, 4), 
(25, 5), 
(26, 6),
(27, 7),
(28, 8), 
(29, 9), 
(30, 10), 
(31, 1), 
(32, 2), 
(33, 3), 
(34, 4), 
(35, 5), 
(36, 6),
(37, 7), 
(38, 8), 
(39, 9), 
(40, 10), 
(41, 1), 
(42, 2), 
(43, 3), 
(44, 4), 
(45, 5), 
(46, 6), 
(47, 7), 
(48, 8), 
(49, 9)

-- Insertando notas x alumno --
INSERT INTO NotasxAlumno (matricula, id_materia, id_instancia, fecha, nota, libro, folio)
VALUES
-- Registros con libro y folio para la instancia final (id_instancia = 5)
(1, 1, 5, '2022-12-15', 9.0, 'Libro de Matemáticas', 'Folio 1'),
(1, 1, 5, '2022-12-20', 8.5, 'Libro de Física', 'Folio 2'),
(2, 2, 5, '2022-12-15', 7.5, 'Libro de Matemáticas', 'Folio 3'),
(3, 3, 5, '2022-12-20', 6.0, 'Libro de Física', 'Folio 4'),

-- Registros sin libro y folio para otras instancias
(1, 3, 1, '2022-06-30', 8.5, NULL, NULL),
(2, 4, 2, '2022-07-15', 8.0, NULL, NULL),
(3, 1, 3, '2022-08-01', 7.0, NULL, NULL),
(4, 2, 4, '2022-09-10', 9.5, NULL, NULL),
(5, 4, 1, '2022-07-05', 8.0, NULL, NULL),
(6, 4, 2, '2022-09-20', 7.5, NULL, NULL);

-- Insertando Carreras x Alumno --

INSERT INTO CarreraxAlumno (Año_Cursada, matricula, id_carrera)
VALUES
(3, 1, 1),
(2, 2, 1),
(3, 3, 2),
(1, 4, 2)


-- =====  Procedimientos Agregar Alumno =====}
create procedure AgregarAlumno

	@nombre varchar(50),
	@apellido varchar(50), 
	@dni int, 
	@domicilioCalle varchar(50),
	@domicilioNumero int,
	@telefono varchar(10),
	@email varchar(50),
	@fechaInscripcion date,
	@fechaBaja date,
	@usuario varchar(50),
	@contraseña varchar(50),
	@id_perfil int

AS
BEGIN

	insert into Alumnos (Nombre, Apellido, dni, domicilioCalle, domicilioNumero, telefono, email, fechaInscripcion, fechaBaja, usuario, contraseña, id_perfil)
	VALUES (@nombre, @apellido, @dni, @domicilioCalle, @domicilioNumero, @telefono, @email, @fechaInscripcion, @fechaBaja, @usuario, @contraseña, @id_perfil)

END;

-- =====  Procedimiento Mddificar Alumno =====

create procedure ModificarAlumno
	@matricula int,
	@nombre varchar(50),
	@apellido varchar(50), 
	@dni int, 
	@domicilioCalle varchar(50),
	@domicilioNumero int,
	@telefono varchar(10),
	@email varchar(50),
	@fechaInscripcion date,
	@fechaBaja date,
	@usuario varchar(50),
	@contraseña varchar(50)

AS
BEGIN

	update Alumnos set nombre = @nombre, 
					   apellido = @apellido, 
					   dni = @dni, 
					   domicilioCalle = @domicilioCalle, 
					   domicilioNumero = @domicilioNumero,
					   telefono = @telefono,
					   email = @email,
					   fechaInscripcion = @fechaInscripcion,
					   fechaBaja = @fechaBaja,
					   usuario = @usuario,
					   contraseña = @contraseña
					   where matricula = @matricula;
END;

-- =====  Procedimiento Eliminar Alumno =====

CREATE PROCEDURE EliminarAlumno
    @matricula INT,
	@fechaBaja date
AS
BEGIN
    update Alumnos set fechaBaja = @fechaBaja
				   where
						matricula = @matricula
END;
drop procedure EliminarAlumno  -- =============================================================================

-- =====  Procedimiento Agregar Profesor =====
create procedure AgregarProfesor

	@nombre varchar(50),
	@apellido varchar(50), 
	@dni int, 
	@domicilioCalle varchar(50),
	@domicilioNumero int,
	@telefono varchar(10),
	@email varchar(50),
	@fechaInscripcion date,
	@fechaBaja date,
	@usuario varchar(50),
	@contraseña varchar(50),
	@id_perfil int

AS
BEGIN

	insert into Profesores (Nombre, Apellido, dni, domicilioCalle, domicilioNumero, telefono, email, fechaInscripcion, fechaBaja, usuario, contraseña, id_perfil)
	VALUES (@nombre, @Apellido, @dni, @domicilioCalle, @domicilioNumero, @telefono, @email, @fechaInscripcion, @fechaBaja, @usuario, @contraseña, @id_perfil)

END;



-- =====  Procedimiento Modificar Profesor =====

create procedure ModificarProfesor
	@id_profesor int,
	@nombre varchar(50),
	@apellido varchar(50), 
	@dni int, 
	@domicilioCalle varchar(50),
	@domicilioNumero int,
	@telefono varchar(10),
	@email varchar(50),
	@fechaInscripcion date,
	@fechaBaja date,
	@usuario varchar(50),
	@contraseña varchar(50)

AS
BEGIN

	update Profesores set nombre = @nombre, 
					   apellido = @Apellido, 
					   dni = @dni, 
					   domicilioCalle = @domicilioCalle, 
					   domicilioNumero = @domicilioNumero,
					   telefono = @telefono,
					   email = @email,
					   fechaInscripcion = @fechaInscripcion,
					   fechaBaja = @fechaBaja,
					   usuario = @usuario,
					   contraseña = @contraseña
					   where id_profesor = @id_profesor;
END;

-- =====  Procedimiento Eliminar Profesor =====

create procedure EliminarProfesor

	@id_profesor int
	
AS
BEGIN

		delete from Profesores where id_profesor = @id_profesor;

END;

-- =====  Procedimiento Agregar Personal =====

create procedure AgregarPersonal

	@nombre varchar(50),
	@apellido varchar(50), 
	@dni int, 
	@domicilioCalle varchar(50),
	@domicilioNumero int,
	@telefono varchar(10),
	@email varchar(50),
	@fechaInscripcion date,
	@fechaBaja date,
	@usuario varchar(50),
	@contraseña varchar(50),
	@id_perfil int

AS
BEGIN

	insert into Personal (Nombre, Apellido, dni, domicilioCalle, domicilioNumero, telefono, email, fechaInscripcion, fechaBaja, usuario, contraseña, id_perfil)
	VALUES (@nombre, @Apellido, @dni, @domicilioCalle, @domicilioNumero, @telefono, @email, @fechaInscripcion, @fechaBaja, @usuario, @contraseña, @id_perfil)

END;



-- =====  Procedimiento Modificar Personal =====

create procedure ModificarPersonal
	@id_personal int,
	@nombre varchar(50),
	@apellido varchar(50), 
	@dni int, 
	@domicilioCalle varchar(50),
	@domicilioNumero int,
	@telefono varchar(10),
	@email varchar(50),
	@fechaInscripcion date,
	@fechaBaja date,
	@usuario varchar(50),
	@contraseña varchar(50)

AS
BEGIN

	update Personal set nombre = @nombre, 
					   apellido = @Apellido, 
					   dni = @dni, 
					   domicilioCalle = @domicilioCalle, 
					   domicilioNumero = @domicilioNumero,
					   telefono = @telefono,
					   email = @email,
					   fechaInscripcion = @fechaInscripcion,
					   fechaBaja = @fechaBaja,
					   usuario = @usuario,
					   contraseña = @contraseña
					   where id_personal = @id_personal;
END;


-- =====  Procedimiento Eliminar Personal =====

create procedure EliminarPersonal

	@id_personal int
	
AS
BEGIN

		delete from Alumnos where matricula = @id_personal;

END;

-- ====== Procedimiento buscar perfil =====

create procedure BuscarPerfil

	@Usuario varchar (50),
	@contrasena varchar (50),
	@id_perfil int OUTPUT

AS
BEGIN

	if (@Usuario IN (select 
						usuario 
					from
						Alumnos))
	BEGIN
	set @id_perfil = (select id_perfil
						from	
							Alumnos
						where @Usuario = usuario and @contrasena = contraseña)
		select 
			id_perfil
		from
			Alumnos
		Where
			usuario = @Usuario
	END
	else if 
		(@Usuario IN (select 
						usuario 
					from
						Profesores))
	BEGIN
	set @id_perfil = (select id_perfil
						from	
							Profesores
						where @Usuario = usuario and @contrasena = contraseña)
			select 
				id_perfil
			from
				Profesores
			Where
				usuario = @Usuario
	END
	else if 
		(@Usuario IN (select 
							usuario 
						from
							Personal))
	BEGIN
		
		set @id_perfil = (select id_perfil
							from	
								Personal
							where @Usuario = usuario and @contrasena = contraseña)
			select 
				id_perfil
			from
				Personal
			Where
				usuario = @Usuario
	END
END;

drop procedure BuscarPerfil

DECLARE @id_perfil int
exec BuscarPerfil @Usuario = '44556677', @contrasena = '44556677',  @id_perfil = @id_perfil output

-- ====== Procedimiento ProfesorxMateria =====

create procedure Profesor_Y_Materia
	@usuario varchar (40)
AS
BEGIN
	select
	Nombre.nombre,Materia.nombre
	from
	ProfesorxMateria as pxm
	inner join Profesores as Nombre 
	on Nombre.id_profesor = pxm.id_profesor
	inner join Materias as Materia
	on Materia.id_materia = pxm.id_materia
	where
	@usuario = usuario;

END;
-- ====== Procedimiento buscar alumno =====

CREATE PROCEDURE BuscarAlumno
    @nombre VARCHAR(50),
    @apellido VARCHAR(50),
    @matricula INT = NULL,
    @dni VARCHAR(50) = NULL 
AS
BEGIN
    SELECT
        nxm.nota,
        nxm.fecha,
        nxm.libro,
        nxm.folio,
        m.nombre AS Materia,
        i.nombre AS Insatancia,
        al.nombre AS Alumno,
        al.apellido,
        al.matricula
    FROM
        NotasxAlumno AS nxm
    INNER JOIN Alumnos AS al ON al.matricula = nxm.matricula
    INNER JOIN Materias AS m ON m.id_materia = nxm.id_materia
    INNER JOIN Instancias AS i ON i.id_instancia = nxm.id_instancia
    WHERE
        (@nombre IS NULL OR al.nombre COLLATE Latin1_General_CI_AI = @nombre COLLATE Latin1_General_CI_AI) AND
        (@apellido IS NULL OR al.apellido COLLATE Latin1_General_CI_AI = @apellido COLLATE Latin1_General_CI_AI) AND
        (@matricula IS NULL OR al.matricula = @matricula) AND
        (@dni IS NULL OR al.dni = @dni)
END;

drop procedure BuscarAlumno

use TrabajoFinal
--alter table NotasxAlumno
--add matricula int;

EXEC BuscarAlumno @nombre = '',@apellido = '' ,@dni = '', @matricula= '1';

--- Procedimiento para mostrar toda la informaciòn de los alumnos

Create procedure MostrarInformacionAlumnos
    @matricula INT 
AS
BEGIN
		select 
			matricula, 
			nombre, 
			apellido, 
			dni, 
			email ,
			telefono ,
			domicilioCalle ,
			domicilioNumero ,
			usuario ,
			contraseña 
		From 
			Alumnos
		Where 
			matricula = @matricula 
END;

EXEC MostrarInformacionAlumnos @matricula= '2';


-- ====== Trigger para eliminar alumno ========

CREATE TRIGGER trg_BajaAlumno
ON Alumnos
AFTER UPDATE
AS
BEGIN
    IF UPDATE(fechaBaja)
    BEGIN
        DELETE FROM CarreraxAlumno
        WHERE matricula IN (SELECT matricula FROM inserted WHERE fechaBaja IS NOT NULL);

        DELETE FROM MateriaxAlumno
        WHERE matricula IN (SELECT matricula FROM inserted WHERE fechaBaja IS NOT NULL);
    END
END;


-- ====== Trigger para agregar materias ========

CREATE TRIGGER trg_AgregarMaterias
ON CarreraxAlumno
AFTER INSERT
AS
BEGIN
    -- Insertar en MateriaxAlumno las materias correspondientes al alumno
    INSERT INTO MateriaxAlumno (matricula, id_materia)
    SELECT i.matricula, m.id_materia
    FROM inserted AS i
    JOIN Materias AS m
        ON m.id_carreras = i.id_carrera   -- Relaciona la carrera
        AND m.año = i.Año_Cursada         -- Relaciona el año de la carrera con el año de la materia
    WHERE NOT EXISTS (   -- Evita duplicados en caso de que ya esté inscrito en la materia
        SELECT 1
        FROM MateriaxAlumno AS ma
        WHERE ma.matricula = i.matricula
        AND ma.id_materia = m.id_materia
    );
END;


drop trigger trg_AgregarMaterias
-- ======== Procedimiento modificar carreras ============== 

Create procedure ModificarCarrera
	@id int,
	@nombre varchar(50),
	@duracion int,
	@resolucion varchar(10)
AS
BEGIN
	update Carreras set 
						nombre = @nombre,
						duracion = @duracion,
						resolucion = @resolucion
					where
						id_carrera = @id;
END;

-- ====== Trigger para eliminar carrera ========

CREATE TRIGGER trg_BorrarCarrera
ON Carreras
INSTEAD OF DELETE
AS
BEGIN
    DELETE FROM CarreraxAlumno
    WHERE id_carrera IN (SELECT id_carrera FROM deleted);

    DELETE FROM Materias
    WHERE id_carreras IN (SELECT id_carrera FROM deleted);

    DELETE FROM MateriaxAlumno
    WHERE id_materia IN (SELECT id_materia FROM Materias WHERE id_carreras IN (SELECT id_carrera FROM deleted));

    DELETE FROM Carreras
    WHERE id_carrera IN (SELECT id_carrera FROM deleted);
    
END;

-- ================== Procedimiento agregar materias =================

create procedure AgregarMaterias
	@id_carreras int,
	@nombre varchar(50),
	@año int,
	@id_profesor int
AS
BEGIN
	
	insert into Materias (id_carreras, nombre, año, id_profesor)
	VALUES (@id_carreras, @nombre, @año, @id_profesor)

END;

-- ================== Procedimiento modificar materias =================

create procedure ModificarMateria
	@id_materia int,
	@id_carreras int,
	@nombre varchar(50),
	@año int,
	@id_profesor int
AS
BEGIN
	
	update Materias set
					id_carreras = @id_carreras,
					nombre = @nombre,
					año = @año,
					id_profesor = @id_profesor
					where
					id_materia = @id_materia

END;

-- ====== Trigger para eliminar materia ========

CREATE TRIGGER trg_BorrarMateria
ON Materias
INSTEAD OF DELETE
AS
BEGIN
    DELETE FROM MateriaxAlumno
    WHERE id_materia IN (SELECT id_materia FROM deleted)
    AND matricula IN (SELECT matricula FROM Alumnos WHERE fechaBaja IS NULL);
    
	DELETE FROM ProfesorxMateria
    WHERE id_materia IN (SELECT id_materia FROM deleted);

    DELETE FROM Materias
    WHERE id_materia IN (SELECT id_materia FROM deleted);
END;

-- ========== trigger para eliminar alumno de materias
CREATE TRIGGER trg_EliminarAlumnoxMateria
ON CarreraxAlumno
INSTEAD OF DELETE
AS
BEGIN
     DELETE FROM MateriaxAlumno
    WHERE matricula IN (SELECT matricula FROM deleted);
END;
-- ======== Trigger para añadir materias ===========

CREATE TRIGGER trg_InsertarMateria
ON Materias
AFTER INSERT
AS
BEGIN
    INSERT INTO ProfesorxMateria (id_materia, id_profesor)
    SELECT
        m.id_materia,
        m.id_profesor
    FROM inserted m;

END;

select 
	nxa.id_notasxalumno,
	nxa.matricula,
	m.nombre,
	i.nombre,
	nxa.fecha,
	nxa.libro,
	nxa.folio
from 
	NotasxAlumno as nxa
	inner join Materias as m on nxa.id_materia = m.id_materia
	inner join Instancias as i on i.id_instancia = nxa.id_instancia

-- ===================== Procedimiento agregar examen =================

create procedure AgregarExamen
	@matricula int,
	@id_materia int,
	@id_instancia int,
	@fecha date,
	@nota decimal,
	@libro varchar(20),
	@folio varchar(20)
AS
BEGIN
	INSERT INTO NotasxAlumno (matricula, id_materia, id_instancia, fecha, nota, libro, folio)
	VALUES (@matricula, @id_materia, @id_instancia, @fecha, @nota, @libro, @folio)
END;

-- ===================== Procedimiento modificar examen =================

create procedure ModificarExamen
	@id_notasxalumno int,
	@matricula int,
	@id_materia int,
	@id_instancia int,
	@fecha date,
	@nota decimal,
	@libro varchar(20),
	@folio varchar(20)
AS
BEGIN
	update NotasxAlumno set 
							matricula = @matricula,
							id_materia = @id_materia,
							id_instancia = @id_instancia,
							fecha = @fecha,
							nota = @nota,
							libro = @libro,
							folio = @folio
						where
							id_notasxalumno = @id_notasxalumno
END;



-- ================== PROCEDIMIENTO MODIFICAR USUARIO PERSONAL ===================

create procedure ModificarUsuario
	@usuarioNuevo varchar(50),
	@contraseñaNueva varchar(50),
	@ContraseñaPersonal varchar(50)
AS
BEGIN
	update Personal set 
						usuario = @usuarioNuevo,
						contraseña = @contraseñaNueva
					where
						contraseña = @ContraseñaPersonal
END;

-- =========== PROCEDIMIENTO MODIFICAR USUARIO ALUMNO ===============


create procedure ModificarUsuarioAlumno
	@usuarioNuevo varchar(50),
	@contraseñaNueva varchar(50),
	@ContraseñaAlumno varchar(50)
AS
BEGIN
	update Alumnos set 
						usuario = @usuarioNuevo,
						contraseña = @contraseñaNueva
					where
						contraseña = @ContraseñaAlumno
END;

-- =============== Procedimiento BuscarMatricula ==============
CREATE PROCEDURE BuscarMatricula
    @matricula INT,              
    @existe int OUTPUT          
AS
BEGIN
    SET @existe = 0;
    IF EXISTS (SELECT 1 FROM Alumnos WHERE matricula = @matricula)
    BEGIN
        SET @existe = 1;
    END
END;

	


SELECT
    a.matricula,
    a.nombre AS NombreAlumno,
    a.apellido AS ApellidoAlumno,
    m.nombre AS NombreMateria,
    m.año AS AñoMateria,  -- El año ahora se obtiene de la tabla 'Materias'
    i.nombre AS NombreInstancia,
    nxa.nota,
    nxa.fecha,
    nxa.libro,
    nxa.folio
FROM
    Alumnos a
INNER JOIN
    NotasxAlumno nxa ON a.matricula = nxa.matricula
INNER JOIN
    Materias m ON m.id_materia = nxa.id_materia
INNER JOIN
    Instancias i ON i.id_instancia = nxa.id_instancia
WHERE
    a.matricula = 1;


-- ============= Procedimiento para obtener estadisticas =================

CREATE PROCEDURE ObtenerEstadisticasGenerales
    @TotalAlumnos INT OUTPUT,
    @TotalCarreras INT OUTPUT,
    @TotalMaterias INT OUTPUT
AS
BEGIN
    SET @TotalAlumnos = (SELECT COUNT(matricula) FROM Alumnos);

    SET @TotalCarreras = (SELECT COUNT(*) FROM Carreras);

    SET @TotalMaterias = (SELECT COUNT(*) FROM Materias);
END;

-- ============= PROCEDIMIENTO BUSCAR ALUMNO GENERAL ==============

CREATE PROCEDURE BuscarAlumnoGeneral
    @nombre VARCHAR(50),
    @apellido VARCHAR(50),
    @matricula INT = NULL,
    @dni VARCHAR(50) = NULL 
AS
BEGIN
    SELECT
      al.nombre AS Nombre,
                                       al.apellido AS Apellido,
                                       al.dni AS DNI,
                                       al.telefono AS Telfono,
                                       al.email AS Email,
                                       al.fechaInscripcion AS Fechainscripcion,
                                       al.fechaBaja AS Fechabaja,
									   al.matricula AS Matricula
    FROM
        Alumnos AS al
    WHERE
        (@nombre IS NULL OR al.nombre COLLATE Latin1_General_CI_AI = @nombre COLLATE Latin1_General_CI_AI) AND
        (@apellido IS NULL OR al.apellido COLLATE Latin1_General_CI_AI = @apellido COLLATE Latin1_General_CI_AI) AND
        (@matricula IS NULL OR al.matricula = @matricula) AND
        (@dni IS NULL OR al.dni = @dni)
END;

-- ============== PROCEDIMIENTO PROMEDIO NOTA ===========

CREATE PROCEDURE PromedioNota
    @dni INT = NULL,
    @nombre NVARCHAR(50) = NULL,
    @apellido NVARCHAR(50) = NULL,
    @matricula INT = NULL
AS
BEGIN


	SELECT
		AVG(nxm.nota) AS Nota,
		m.nombre AS Materia,
		a.nombre AS Nombre,
		a.apellido AS Apellido
	FROM 
		NotasxAlumno AS nxm
	INNER JOIN 
		Materias AS m ON nxm.id_materia = m.id_materia
	INNER JOIN 
		Alumnos AS a ON nxm.matricula = a.matricula
	WHERE 
        (@nombre IS NULL OR a.nombre COLLATE Latin1_General_CI_AI = @nombre COLLATE Latin1_General_CI_AI) AND
        (@apellido IS NULL OR a.apellido COLLATE Latin1_General_CI_AI = @apellido COLLATE Latin1_General_CI_AI) AND
        (@matricula IS NULL OR a.matricula = @matricula) AND
        (@dni IS NULL OR a.dni = @dni)
	GROUP BY 
		m.nombre, a.nombre, a.apellido;
END;

-- =========== Procedimiento notas x alumno ============

create procedure Notas_Por_Alumno
	@usuario varchar(50)
as
begin
SELECT 
    m.nombre AS materia,
    i.nombre AS instancia,
    nxa.nota,
    nxa.fecha
FROM 
    NotasxAlumno AS nxa
INNER JOIN 
    Materias AS m ON nxa.id_materia = m.id_materia
INNER JOIN 
    Instancias AS i ON nxa.id_instancia = i.id_instancia
INNER JOIN 
    Alumnos AS a ON nxa.matricula = a.matricula 
WHERE
	@usuario = usuario;
end;

-- ========== Procedimiento obtener materias por carrera =========

CREATE PROCEDURE ObtenerMateriasPorCarrera
    @id_carrera INT
AS
BEGIN
    SELECT 
        m.id_materia AS IdMateria,  
        m.nombre AS Materia,
        p.nombre + ' ' + p.apellido AS Profesor 
    FROM 
        Materias m
    INNER JOIN 
        Profesores p ON m.id_profesor = p.id_profesor
    WHERE 
        m.id_carreras = @id_carrera;
END;

-- =============== OBTENER NOTAS X ALUMNO ============

CREATE PROCEDURE ObtenerIdNotasxAlumno
    @matricula INT,
    @id_materia INT,
    @id_instancia INT,
    @id_notasxalumno INT OUTPUT
AS
BEGIN
    SELECT @id_notasxalumno = id_notasxalumno
    FROM NotasxAlumno
    WHERE matricula = @matricula
      AND id_materia = @id_materia
      AND id_instancia = @id_instancia;
END;