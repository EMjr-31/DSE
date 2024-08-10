Create database Biblioteca
Use Biblioteca
create table Usuarios(
id int identity primary key,
Nombre varchar(250),
Apellido varchar(250)
);

create table Autores (
id int identity primary key,
Nombre varchar(250),
Apellido varchar(250)
);

create table Editoriales(
id int identity primary key,
Nombre varchar(250)
);

create table libros(
id int identity primary key,
Nombre varchar(250),
CodigoAutor int not null,
CodigoEditorial int not null, 
FechaLanzamiento date, 
Foreign Key (CodigoAutor) references Autores(id), 
Foreign Key (CodigoEditorial) references Editoriales(id) 
)

create table Prestamos(
id int identity primary key,
CodigoLibro int not null, 
CodigoUsuario int not null,
FechaDePrestamo date,
Foreign Key (CodigoUsuario) references Usuarios(id), 
Foreign Key (CodigoLibro) references libros(id) 
)