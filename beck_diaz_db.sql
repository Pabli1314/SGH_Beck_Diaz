CREATE DATABASE beck_diaz_db;

USE beck_diaz_db;

-- Tabla: Tipo_habitacion
CREATE TABLE Tipo_habitacion (
    id_tipo_habitacion INT IDENTITY(1,1),
    descripcion VARCHAR(100) NOT NULL
    CONSTRAINT PK_tipo_habitacion_id PRIMARY KEY (id_tipo_habitacion)
);

-- Tabla: Estado_habitacion
CREATE TABLE Estado_habitacion (
    id_estado INT IDENTITY(1,1),
    nom_estado_habitacion VARCHAR(50) NOT NULL
    CONSTRAINT PK_estado_habitacion_id PRIMARY KEY (id_estado)
);

-- Tabla: Rol
CREATE TABLE Rol (
    id_rol INT IDENTITY(1,1),
    nom_rol VARCHAR(50) NOT NULL
    CONSTRAINT PK_rol_id PRIMARY KEY (id_rol)
);

-- Tabla: metodo_pago
CREATE TABLE metodo_pago (
    id_metodo INT IDENTITY(1,1),
    nom_metodo_pago VARCHAR(50) NOT NULL
    CONSTRAINT PK_metodo_pago_id PRIMARY KEY (id_metodo)
);

-- Tabla: Huesped
CREATE TABLE Huesped (
    dni_huesped VARCHAR(8),
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    telefono VARCHAR(20) NOT NULL,
    direccion VARCHAR(50) NOT NULL, 
    CONSTRAINT PK_huesped_dni PRIMARY KEY (dni_huesped),
    CONSTRAINT CK_huesped_dni CHECK (dni_huesped NOT LIKE '%[^0-9]%'),
    CONSTRAINT UQ_huesped_telefono UNIQUE(telefono)
);


--------------------------------------------------
-- 2. TABLAS CON DEPENDENCIAS PRIMARIAS
--------------------------------------------------

-- Tabla: habitacion
CREATE TABLE habitacion (
    nro_habitacion INT,
    piso INT NOT NULL,
    cant_camas INT NOT NULL,
    tarifa_base DECIMAL(10, 2) NOT NULL,
    id_tipo_habitacion INT NOT NULL,
    id_estado INT NOT NULL,
    CONSTRAINT PK_habitacion_nro PRIMARY KEY(nro_habitacion),
    CONSTRAINT CH_habitacion_piso CHECK (piso IN (1,2,3)),
    CONSTRAINT FK_Habitacion_Tipo FOREIGN KEY (id_tipo_habitacion) REFERENCES Tipo_habitacion(id_tipo_habitacion),
    CONSTRAINT FK_Habitacion_Estado FOREIGN KEY (id_estado) REFERENCES Estado_habitacion(id_estado)
);


-- Tabla: Usuario
CREATE TABLE Usuario (
    id_usuario INT IDENTITY(1,1),
    nom_usuario VARCHAR(50) NOT NULL UNIQUE,
    pasword VARCHAR(256) NOT NULL,
    estado BIT NOT NULL DEFAULT 1, -- Usamos BIT para valores booleanos (1 = Activo, 0 = Inactivo)
    id_rol INT NOT NULL,
    CONSTRAINT PK_usuario_id PRIMARY KEY(id_usuario),
    CONSTRAINT FK_Usuario_Rol FOREIGN KEY (id_rol) REFERENCES Rol(id_rol)
);

-- Tabla: Turno_caja
CREATE TABLE Turno_caja (
    id_turno INT IDENTITY(1,1),
    fecha_apertura DATE NOT NULL,
    hora_apertura TIME NOT NULL,
    fecha_cierre DATE NULL,
    hora_cierre TIME NULL,
    monto_inicial DECIMAL(10, 2) NOT NULL,
    monto_final DECIMAL(10, 2) NULL,
    observaciones VARCHAR(255) NULL,
    id_usuario INT NOT NULL,
    CONSTRAINT PK_turno_caja_id PRIMARY KEY (id_turno),
    CONSTRAINT FK_TurnoCaja_Usuario FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario)
);

--------------------------------------------------
-- 3. TABLAS CON DEPENDENCIAS MÚLTIPLES
--------------------------------------------------

-- Tabla: hospedaje
CREATE TABLE hospedaje (
    id_hospedaje INT IDENTITY(1,1),
    fecha_entrada DATE CONSTRAINT DF_fecha_entrada DEFAULT CONVERT(DATE, GETDATE()),
    hora_entrada TIME CONSTRAINT DF_fecha_salida DEFAULT CONVERT(TIME, GETDATE()),
    fecha_salida DATE NOT NULL,
    hora_salida TIME NOT NULL,
    id_metodo INT NOT NULL,
    nro_habitacion INT NOT NULL,
    id_turno INT NOT NULL,
    dni_huesped VARCHAR(8) NOT NULL,
    CONSTRAINT PK_Rhospedaje_id PRIMARY KEY(id_hospedaje),
    CONSTRAINT FK_hospedaje_Metodo FOREIGN KEY (id_metodo) REFERENCES metodo_pago(id_metodo),
    CONSTRAINT FK_hospedaje_Habitacion FOREIGN KEY (nro_habitacion) REFERENCES habitacion(nro_habitacion),
    CONSTRAINT FK_hospedaje_Turno FOREIGN KEY (id_turno) REFERENCES Turno_caja(id_turno),
    CONSTRAINT FK_hospedaje_Huesped FOREIGN KEY (dni_huesped) REFERENCES Huesped(dni_huesped)
);

-- Tabla: registro_limpieza
CREATE TABLE registro_limpieza (
    id_limpieza INT IDENTITY(1,1),
    fecha_limpieza DATE CONSTRAINT DF_fecha_limpieza DEFAULT CONVERT(DATE, GETDATE()),
    hora_inicio TIME NOT NULL,
    hora_fin TIME NOT NULL,
    nro_habitacion INT NOT NULL,
    id_usuario INT NOT NULL,
    CONSTRAINT PK_limpieza_id PRIMARY KEY(id_limpieza),
    CONSTRAINT FK_Limpieza_Habitacion FOREIGN KEY (nro_habitacion) REFERENCES habitacion(nro_habitacion),
    CONSTRAINT FK_Limpieza_Usuario FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario)
);



