-- Crear un nuevo login en SQL Server
CREATE LOGIN NuevoUsuario WITH PASSWORD = 'NuevaContraseña123';


USE OnatrixCMS;

-- Crear un usuario para la base de datos
CREATE USER NuevoUsuario FOR LOGIN NuevoUsuario;

-- Asignar permisos al nuevo usuario (asegúrate de que tenga permisos para leer y escribir)
ALTER ROLE db_owner ADD MEMBER NuevoUsuario;

