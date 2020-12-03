--seleccionar y correr primero solo esto
CREATE DATABASE Mobike;
--luego seleccionar y correr solo esto
USE Mobike;

--luego seleccionar y correr todos los create y alter y al final correr los dos insert
--tirara un error pero de todas formas se crea la tabla asi que no hay problema en eso
CREATE TABLE administrador (
    rut          VARCHAR(10) NOT NULL,
    nombre       VARCHAR(30) NOT NULL,
    contraseña   VARCHAR(30) NOT NULL
);

ALTER TABLE administrador ADD CONSTRAINT administrador_pk PRIMARY KEY ( rut );

CREATE TABLE arriendo (
    codigo_desbloqueo   NUMERIC(6) NOT NULL,
    usuario_rut         VARCHAR(10) NOT NULL
);

ALTER TABLE arriendo ADD CONSTRAINT arriendo_pk PRIMARY KEY ( codigo_desbloqueo );

CREATE TABLE banco (
    nombre_banco   VARCHAR(30) NOT NULL,
    id_banco       NUMERIC(3) NOT NULL
);

ALTER TABLE banco ADD CONSTRAINT banco_pk PRIMARY KEY ( id_banco );

CREATE TABLE bicicleta (
    id_bicicleta                             NUMERIC(3) NOT NULL, 
    estacionamiento_numero_estacionamiento   NUMERIC(5) NOT NULL,
    arriendo_codigo_desbloqueo               NUMERIC(6) NOT NULL,
    marca_id_marca                           NUMERIC(3) NOT NULL
);

CREATE UNIQUE INDEX bicicleta__idx ON
    bicicleta (
        arriendo_codigo_desbloqueo
    ASC );

ALTER TABLE bicicleta ADD CONSTRAINT bicicleta_pk PRIMARY KEY ( id_bicicleta );


CREATE TABLE devolucion (
    valor_total   NUMERIC(8) NOT NULL,
    usuario_rut   VARCHAR(10) NOT NULL
);

CREATE TABLE estacionamiento (
    numero_estacionamiento   NUMERIC(5) NOT NULL,
    cantidad_bicicletas      NUMERIC(2) NOT NULL
);

ALTER TABLE estacionamiento ADD CONSTRAINT estacionamiento_pk PRIMARY KEY ( numero_estacionamiento );

CREATE TABLE funcionario (
    rut          VARCHAR(10) NOT NULL,
    nombre       VARCHAR(30) NOT NULL,
    rol          VARCHAR(30) NOT NULL,
    contraseña   VARCHAR(30) NOT NULL
);

ALTER TABLE funcionario ADD CONSTRAINT funcionario_pk PRIMARY KEY ( rut );

CREATE TABLE marca (
    id_marca   NUMERIC(3) NOT NULL,
    marca      VARCHAR(30) NOT NULL
);

ALTER TABLE marca ADD CONSTRAINT marca_pk PRIMARY KEY ( id_marca );

CREATE TABLE relation_2 (
    banco_id_banco               NUMERIC(3) NOT NULL,
    tipo_cuenta_id_tipo_cuenta   NUMERIC(2) NOT NULL
);

ALTER TABLE relation_2 ADD CONSTRAINT relation_2_pk PRIMARY KEY ( banco_id_banco,
                                                                  tipo_cuenta_id_tipo_cuenta );

CREATE TABLE reportes (
    id_reporte          NUMERIC(3) NOT NULL,
    nombre_usuario      VARCHAR(30) NOT NULL,
    descripcion         VARCHAR(30) NOT NULL,
    rut                 VARCHAR(10) NOT NULL,
    administrador_rut   VARCHAR(10) NULL,
    funcionario_rut     VARCHAR(10) NULL
);

ALTER TABLE reportes ADD CONSTRAINT reportes_pk PRIMARY KEY ( id_reporte );

CREATE TABLE tipo_cuenta (
    id_tipo_cuenta   NUMERIC(2) NOT NULL,
    tipo_cuenta      VARCHAR(30) NOT NULL
);

ALTER TABLE tipo_cuenta ADD CONSTRAINT tipo_cuenta_pk PRIMARY KEY ( id_tipo_cuenta );

CREATE TABLE usuario (
    rut              VARCHAR(10) NOT NULL,
    nombre           VARCHAR(50) NOT NULL,
    email            VARCHAR(50) NOT NULL,
    direccion        VARCHAR(50) NOT NULL,
    trabaja_comuna   CHAR(1) NOT NULL,
	cuenta_bancaria  NUMERIC(10) NOT NULL,
    contraseña       VARCHAR(20) NOT NULL
);

CREATE TABLE usuarios_bloqueados (
    rut_bloqueado    VARCHAR(10) NOT NULL
);

ALTER TABLE usuario ADD CONSTRAINT usuario_pk PRIMARY KEY ( rut );


ALTER TABLE usuarios_bloqueados ADD CONSTRAINT usuario_bloq_pk PRIMARY KEY ( rut_bloqueado );

ALTER TABLE arriendo
    ADD CONSTRAINT arriendos_usuario_fk FOREIGN KEY ( usuario_rut )
        REFERENCES usuario ( rut );

ALTER TABLE bicicleta
    ADD CONSTRAINT bicicletas_arriendo_fk FOREIGN KEY ( arriendo_codigo_desbloqueo )
        REFERENCES arriendo ( codigo_desbloqueo );

ALTER TABLE bicicleta
    ADD CONSTRAINT bicicleta_estacionamiento_fk FOREIGN KEY ( estacionamiento_numero_estacionamiento )
        REFERENCES estacionamiento ( numero_estacionamiento );

ALTER TABLE bicicleta
    ADD CONSTRAINT bicicleta_marca_fk FOREIGN KEY ( marca_id_marca )
        REFERENCES marca ( id_marca );

ALTER TABLE devolucion
    ADD CONSTRAINT devolucion_usuario_fk FOREIGN KEY ( usuario_rut )
        REFERENCES usuario ( rut );

ALTER TABLE relation_2
    ADD CONSTRAINT fk_ass_3 FOREIGN KEY ( banco_id_banco )
        REFERENCES banco ( id_banco );

ALTER TABLE relation_2
    ADD CONSTRAINT fk_ass_4 FOREIGN KEY ( tipo_cuenta_id_tipo_cuenta )
        REFERENCES tipo_cuenta ( id_tipo_cuenta );

ALTER TABLE reportes
    ADD CONSTRAINT reportes_administrador_fk FOREIGN KEY ( administrador_rut )
        REFERENCES administrador ( rut );

ALTER TABLE reportes
    ADD CONSTRAINT reportes_funcionario_fk FOREIGN KEY ( funcionario_rut )
        REFERENCES funcionario ( rut );

ALTER TABLE arriendo
    ADD CONSTRAINT arriendo_usuario_fk FOREIGN KEY ( usuario_rut )
        REFERENCES usuario ( rut );

ALTER TABLE bicicleta
    ADD CONSTRAINT bicicleta_arriendos_fk FOREIGN KEY ( arriendo_codigo_desbloqueo )
        REFERENCES arriendo ( codigo_desbloqueo );

INSERT INTO [dbo].[administrador]
           ([rut]
           ,[nombre]
           ,[contraseña])
     VALUES
           ('123',
           'Josefa'
           ,'123')

INSERT INTO [dbo].[funcionario]
           ([rut]
           ,[nombre]
           ,[rol]
           ,[contraseña])
     VALUES
           ('123',
           'Miguel'
           ,'Seguridad'
           ,'123')
