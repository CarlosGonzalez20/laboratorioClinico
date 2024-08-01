CREATE SCHEMA IF NOT EXISTS laboratorioClinico
DEFAULT CHARACTER SET utf8;
USE laboratorioClinico;

CREATE TABLE IF NOT EXISTS tipoUsuario (
    tipoUsuarioID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nombreTipoUsuario VARCHAR(40) NOT NULL,
    descripcionTipoUsuario TEXT,
    estadoTipoUsuario TINYINT(1)
);

CREATE TABLE IF NOT EXISTS genero (
    generoID INT(1) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nombreGenero VARCHAR(10) NOT NULL,
    estadoGenero TINYINT(1) NOT NULL
);

CREATE TABLE IF NOT EXISTS especialidad (
    especialidadID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nombreEspecialidad VARCHAR(30) NOT NULL,
    descripcionEspecialidad TEXT NOT NULL,
    estadoEspecialidad TINYINT(1) NOT NULL
);

CREATE TABLE IF NOT EXISTS tipoEmpleado (
    tipoEmpleadoID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nombreTipoEmpleado VARCHAR(40) NOT NULL,
    descripcionTipoEmpleado TEXT,
    salarioTipoEmpleado DECIMAL(12,2),
    estadoTipoEmpleado TINYINT(1) NOT NULL
);

CREATE TABLE IF NOT EXISTS cargoPersonalLaboratorio (
    posicionPersonalLabID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nombrePosicionPersonalLab VARCHAR(40) NOT NULL,
    descripcionPosicionPersonalLab TEXT,
    estadoPosicionPersonalLab TINYINT(1) NOT NULL
);

CREATE TABLE IF NOT EXISTS tipoExamen (
    tipoExamenID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nombreTipoExamen VARCHAR(40) NOT NULL,
    descripcionTipoExamen TEXT NOT NULL,
    estadoTipoExamen TINYINT(1) NOT NULL
);

CREATE TABLE IF NOT EXISTS tipoMuestra (
    tipoMuestraID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nombreTipoMuestra VARCHAR(40) NOT NULL,
    descripcionTipoMuestra TEXT NOT NULL,
    estadoTipoMuestra TINYINT(1) NOT NULL
);

CREATE TABLE IF NOT EXISTS areaEspecialidad (
    areaEspecialidadID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nombreAreaEspecialidad VARCHAR(100) NOT NULL,
    descripcionAreaEspecialidad TEXT,
    estadoAreaEspecialidad TINYINT(1) NOT NULL
);

CREATE TABLE IF NOT EXISTS paciente (
    pacienteID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    tipoUsuarioID INT,
    numeroDocumento BIGINT(15) NOT NULL,
    nombrePaciente VARCHAR(40) NOT NULL,
    apellidoPaciente VARCHAR(40) NOT NULL,
    fechaNacimientoPaciente DATE NOT NULL,
    telefonoPaciente BIGINT(15) NOT NULL,
    emailPaciente VARCHAR(30) NOT NULL,
    tipoSangrePaciente VARCHAR(4) NOT NULL,
    generoID INT,
    direccionPaciente TEXT NOT NULL,
    alergiasPaciente TEXT NOT NULL,
    medicamentosActualesPaciente TEXT NOT NULL,
    nombreContactoEmergencia VARCHAR(80) NOT NULL,
    telefonoContactoEmergencia BIGINT(15) NOT NULL,
    relacionContactoEmergencia VARCHAR(50) NOT NULL,
    proveedorSeguro VARCHAR(100),
    fechaRegistro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    estadoPaciente TINYINT(1) NOT NULL,
    FOREIGN KEY (tipoUsuarioID) REFERENCES tipoUsuario (tipoUsuarioID),
    FOREIGN KEY (generoID) REFERENCES genero (generoID)
);

CREATE TABLE IF NOT EXISTS medico (
    medicoID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    tipoUsuarioID INT,
    numeroDocumento BIGINT(15) NOT NULL,
    nombreMedico VARCHAR(40) NOT NULL,
    apellidoMedico VARCHAR(40) NOT NULL,
    generoID INT,
    especialidadID INT,
    fechaNacimientoMedico DATE NOT NULL,
    fechaRegistro DATE NOT NULL,
    telefonoMedico BIGINT(15) NOT NULL,
    emailMedico VARCHAR(30) NOT NULL,
    medicoAsociado TINYINT(1) NOT NULL,
    estadoMedico TINYINT(1) NOT NULL,
    FOREIGN KEY (tipoUsuarioID) REFERENCES tipoUsuario (tipoUsuarioID),
    FOREIGN KEY (generoID) REFERENCES genero (generoID),
    FOREIGN KEY (especialidadID) REFERENCES especialidad (especialidadID)
);

CREATE TABLE IF NOT EXISTS personalLab (
    personalLabID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    posicionPersonalLabID INT,
    numeroIdentificacion BIGINT(15) NOT NULL,
    nombrePersonalLab VARCHAR(40) NOT NULL,
    apellidoPersonalLab VARCHAR(40) NOT NULL,
    fechaNacimientoPersonalLab DATE NOT NULL,
    fechaContratacionPersonalLab DATE NOT NULL,
    horarioPersonalLab VARCHAR(255),
    diasTrabajoPersonalLab VARCHAR(255),
    posicionPersonalLab VARCHAR(60),
    generoID INT,
    telefonoPersonalLab BIGINT(15),
    emailPersonalLab VARCHAR(30),
    estadoPersonalLab TINYINT(1) NOT NULL,
    FOREIGN KEY (posicionPersonalLabID) REFERENCES cargoPersonalLaboratorio (posicionPersonalLabID),
    FOREIGN KEY (generoID) REFERENCES genero (generoID)
);

CREATE TABLE IF NOT EXISTS clinica (
    clinicaID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nombreClinica VARCHAR(40) NOT NULL,
    areaEspecialidadID INT,
    direccionClinica TEXT,
    horarioActividadClinica VARCHAR(255),
    telefonoClinica BIGINT(15),
    emailClinica VARCHAR(30),
    estadoClinica TINYINT(1) NOT NULL,
    FOREIGN KEY (areaEspecialidadID) REFERENCES areaEspecialidad (areaEspecialidadID)
);

CREATE TABLE IF NOT EXISTS examenMedico (
    examenMedicoID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    tipoExamenID INT,
    tiempoEsperaExamenMedico VARCHAR(80),
    costoExamenMedico DECIMAL(10,2),
    estadoExamenMedico TINYINT(1) NOT NULL,
    FOREIGN KEY (tipoExamenID) REFERENCES tipoExamen (tipoExamenID)
);

CREATE TABLE IF NOT EXISTS empleado (
    empleadoID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    tipoEmpleadoID INT,
    clinicaID INT,
    nombreEmpleado VARCHAR(40) NOT NULL,
    apellidoEmpleado VARCHAR(40) NOT NULL,
    numeroIdentificacion BIGINT(15) NOT NULL,
    diasTrabajoEmpleado VARCHAR(255),
    horasTrabajoEmpleado VARCHAR(255),
    telefonoEmpleado BIGINT(15),
    emailEmpleado VARCHAR(30),
    generoID INT,
    fechaNacimientoEmpleado DATE NOT NULL,
    fechaContratacionEmpleado DATE NOT NULL,
    estadoEmpleado TINYINT(1) NOT NULL,
    FOREIGN KEY (tipoEmpleadoID) REFERENCES tipoEmpleado (tipoEmpleadoID),
    FOREIGN KEY (clinicaID) REFERENCES clinica (clinicaID),
    FOREIGN KEY (generoID) REFERENCES genero (generoID)
);

CREATE TABLE IF NOT EXISTS laboratorio (
    laboratorioID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    personalLabID INT,
    clinicaID INT,
    examenMedicoID INT,
    horarioLaboratorio VARCHAR(255),
    actividadLaboratorio TEXT,
    fechaAsignacionLaboratorio DATE,
    estadoLaboratorio TINYINT(1) NOT NULL,
    FOREIGN KEY (personalLabID) REFERENCES personalLab (personalLabID),
    FOREIGN KEY (clinicaID) REFERENCES clinica (clinicaID),
    FOREIGN KEY (examenMedicoID) REFERENCES examenMedico (examenMedicoID)
);

CREATE TABLE IF NOT EXISTS muestra (
    muestraID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    tipoMuestraID INT,
    estadoMuestra TINYINT(1) NOT NULL,
    FOREIGN KEY (tipoMuestraID) REFERENCES tipoMuestra (tipoMuestraID)
);

CREATE TABLE IF NOT EXISTS proveedor (
    proveedorID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nombreProveedor VARCHAR(255) NOT NULL,
    telefonoProveedor VARCHAR(50),
    emailProveedor VARCHAR(255),
    direccionProveedor TEXT,
    fechaRegistroProveedor DATE NOT NULL,
    descripcionProveedor TEXT,
    estadoProveedor TINYINT(1) NOT NULL
);

CREATE TABLE IF NOT EXISTS medicamento (
    medicamentoID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    proveedorID INT,
    codigoBarrasMedicamento VARCHAR(50) NOT NULL,
    nombreMedicamento VARCHAR(255) NOT NULL,
    descripcionMedicamento TEXT,
    cantidadMedicamento INT,
    costoMedicamento DECIMAL(10,2),
    estadoMedicamento TINYINT(1) NOT NULL,
    FOREIGN KEY (proveedorID) REFERENCES proveedor (proveedorID)
);

CREATE TABLE IF NOT EXISTS resultadoPrueba (
    resultadoPruebaID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    fechaEntregaResultado DATE NOT NULL,
    examenMedicoID INT,
    medicamentoID INT,
    estadoResultado TINYINT(1) NOT NULL,
    FOREIGN KEY (examenMedicoID) REFERENCES examenMedico (examenMedicoID),
    FOREIGN KEY (medicamentoID) REFERENCES medicamento (medicamentoID)
);

CREATE TABLE IF NOT EXISTS cita (
    citaID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    medicoID INT,
    pacienteID INT,
    examenMedicoID INT,
    clinicaID INT,
    fechaCita DATE NOT NULL,
    horaCita TIME NOT NULL,
    estadoCita TINYINT(1) NOT NULL,
    FOREIGN KEY (medicoID) REFERENCES medico (medicoID),
    FOREIGN KEY (pacienteID) REFERENCES paciente (pacienteID),
    FOREIGN KEY (examenMedicoID) REFERENCES examenMedico (examenMedicoID),
    FOREIGN KEY (clinicaID) REFERENCES clinica (clinicaID)
);

CREATE TABLE IF NOT EXISTS facturaEncabezado (
    facturaEncabezadoID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    pacienteID INT,
    fechaFactura DATE NOT NULL,
    horaFactura TIME NOT NULL,
    totalFactura DECIMAL(10,2),
    estadoFactura TINYINT(1) NOT NULL,
    FOREIGN KEY (pacienteID) REFERENCES paciente (pacienteID)
);

CREATE TABLE IF NOT EXISTS facturaDetalle (
    facturaDetalleID INT(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    facturaEncabezadoID INT,
    descripcionFacturaDetalle TEXT,
    cantidadFacturaDetalle INT,
    precioUnitarioFacturaDetalle DECIMAL(10,2),
    estadoFacturaDetalle TINYINT(1) NOT NULL,
    FOREIGN KEY (facturaEncabezadoID) REFERENCES facturaEncabezado (facturaEncabezadoID)
);

