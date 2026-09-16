-- Ejecutar una sola vez contra la base beck_diaz_db (LocalDB) antes de usar la
-- sección Usuarios del Administrador con datos reales.
ALTER TABLE Usuario ADD nombre NVARCHAR(50) NOT NULL DEFAULT('');
ALTER TABLE Usuario ADD apellido NVARCHAR(50) NOT NULL DEFAULT('');
ALTER TABLE Usuario ADD ultimo_acceso DATETIME NULL;
