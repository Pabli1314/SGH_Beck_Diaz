USE beck_diaz_db;

-- Insertar roles
INSERT INTO Rol (nom_rol) VALUES ('Administrador'), ('Supervisor'), ('Recepcionista');
SELECT * FROM Rol;

--Insertar usuarios de distintos roles
INSERT INTO Usuario (nom_usuario, pasword, estado, id_rol) 
VALUES ('admin', 'Admin123', 1, 1);

INSERT INTO Usuario (nom_usuario, pasword, estado, id_rol) 
VALUES ('supervisor', 'Super123', 1, 2);

INSERT INTO Usuario (nom_usuario, pasword, estado, id_rol) 
VALUES ('recepcion', 'Recep123', 1, 3);

INSERT INTO Usuario(nom_usuario, pasword, estado, id_rol) VALUES ('recep1', 'Elrecepcionista', 1, 3);
UPDATE Usuario SET pasword = 'Admin123' WHERE id_usuario = 4
SELECT * FROM Usuario

-- Verificar si los datos estan correctos.
SELECT u.nom_usuario, r.nom_rol FROM Usuario u INNER JOIN Rol r ON u.id_rol = r.id_rol;

-- Cargar Tipos de Habitación
INSERT INTO Tipo_habitacion (descripcion) VALUES 
('Individual Standard'),
('Doble Matrimonial'),
('Suite Executive');

-- Cargar Estados (Siguiendo la codificación de colores del ERS)
INSERT INTO Estado_habitacion (nom_estado_habitacion) VALUES 
('Disponible'),    -- id_estado: 1 (Verde)
('Ocupada'),       -- id_estado: 2 (Rojo)
('Limpieza');     -- id_estado: 3 (Amarillo)

SELECT * FROM Estado_habitacion
--------------------------------------------------
-- 2. REGISTROS PARA LA TABLA HABITACION
--------------------------------------------------

-- Nota: Respeta el CHECK (piso IN (1,2,3))
INSERT INTO habitacion (nro_habitacion, piso, cant_camas, tarifa_base, id_tipo_habitacion, id_estado) VALUES 
-- Piso 1
(101, 1, 1, 15000.00, 1, 1), -- Individual, Disponible
(102, 1, 1, 15000.00, 1, 2), -- Individual, Ocupada
(103, 1, 2, 22000.00, 2, 3);-- Doble, Limpieza

INSERT INTO habitacion (nro_habitacion, piso, cant_camas, tarifa_base, id_tipo_habitacion, id_estado) VALUES 
-- Piso 2
(201, 2, 2, 22000.00, 2, 1), -- Doble, Disponible
(202, 2, 2, 22000.00, 2, 1), -- Doble, Disponible
(203, 2, 3, 35000.00, 3, 3); -- Suite, Limpieza


INSERT INTO habitacion (nro_habitacion, piso, cant_camas, tarifa_base, id_tipo_habitacion, id_estado) VALUES
-- Piso 3
(301, 3, 3, 35000.00, 3, 1), -- Suite, Disponible
(302, 3, 3, 35000.00, 3, 2); -- Suite, Ocupada
GO

--------------------------------------------------
-- 3. VERIFICACIÓN DE DATOS
--------------------------------------------------
SELECT 
    h.nro_habitacion,
    h.piso,
    h.cant_camas,
    h.tarifa_base,
    th.descripcion AS tipo,
    eh.nom_estado_habitacion AS estado
FROM habitacion h
INNER JOIN Tipo_habitacion th ON h.id_tipo_habitacion = th.id_tipo_habitacion
INNER JOIN Estado_habitacion eh ON h.id_estado = eh.id_estado;


------------------- INSERTAR METODOS DE PAGO
INSERT INTO metodo_pago (nom_metodo_pago) VALUES ('Efectivo'), ('Transferencia'), ('Tarjeta');
SELECT * FROM metodo_pago;

------ PROCEDIMIENTOS ALMACENADOS -------
GO
CREATE PROCEDURE sp_ValidarUsuario
    @nomUsuario NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        u.id_usuario, 
        u.nom_usuario, 
        u.pasword, 
        u.estado, 
        u.id_rol,
        r.nom_rol
    FROM Usuario u
    INNER JOIN Rol r ON u.id_rol = r.id_rol
    WHERE u.nom_usuario = @nomUsuario;
END
GO

EXEC sp_ValidarUsuario @nomUsuario = 'recep1';