USE [GD2C2013]
GO
/****** Object:  Schema [BUGDEVELOPING]    Script Date: 12/02/2013 14:04:11 ******/
CREATE SCHEMA [BUGDEVELOPING] AUTHORIZATION [gd]
GO
/****** Object:  Table [BUGDEVELOPING].[TIPO_ESPECIALIDAD]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[TIPO_ESPECIALIDAD](
	[tipo_es_id] [numeric](18, 0) NOT NULL,
	[tipo_es_descripcion] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[tipo_es_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [BUGDEVELOPING].[TIPO_CANCELACION]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [BUGDEVELOPING].[TIPO_CANCELACION](
	[tc_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[tc_descripcion] [varchar](255) NULL,
 CONSTRAINT [PK_TIPO_CANCELACION] PRIMARY KEY CLUSTERED 
(
	[tc_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [BUGDEVELOPING].[ROL]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [BUGDEVELOPING].[ROL](
	[ROL_ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[ROL_NOMBRE] [nvarchar](255) NOT NULL,
	[ROL_HABILITACION] [char](2) NOT NULL,
 CONSTRAINT [PK_ROL_1] PRIMARY KEY NONCLUSTERED 
(
	[ROL_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [BUGDEVELOPING].[USUARIO]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[USUARIO](
	[USUARIO_ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[USUARIO_USERNAME] [nvarchar](255) NOT NULL,
	[USUARIO_PASSWORD] [nvarchar](255) NOT NULL,
	[USUARIO_INTENTOS] [tinyint] NOT NULL,
 CONSTRAINT [PK_USUARIO_1] PRIMARY KEY CLUSTERED 
(
	[USUARIO_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [BUGDEVELOPING].[PLAN_MEDICO]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[PLAN_MEDICO](
	[pl_codigo] [numeric](18, 0) NOT NULL,
	[pl_descripcion] [nvarchar](255) NULL,
	[pl_precio_consulta] [numeric](18, 0) NULL,
	[pl_precio_farmacia] [numeric](18, 0) NULL,
 CONSTRAINT [PK_PLAN] PRIMARY KEY CLUSTERED 
(
	[pl_codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [BUGDEVELOPING].[DIA]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [BUGDEVELOPING].[DIA](
	[dia_id] [numeric](18, 0) NOT NULL,
	[dia_nombre] [varchar](255) NULL,
 CONSTRAINT [PK_DIA] PRIMARY KEY CLUSTERED 
(
	[dia_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [BUGDEVELOPING].[MEDICAMENTOS]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[MEDICAMENTOS](
	[m_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[m_descripcion] [nvarchar](255) NULL,
 CONSTRAINT [PK_MEDICAMENTOS] PRIMARY KEY CLUSTERED 
(
	[m_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [BUGDEVELOPING].[FUNCIONALIDAD]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[FUNCIONALIDAD](
	[FUNCIONALIDAD_ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[FUNCIONALIDAD_NOMBRE] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_FUNCIONALIDAD_1] PRIMARY KEY CLUSTERED 
(
	[FUNCIONALIDAD_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [BUGDEVELOPING].[ESPECIALIDAD]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[ESPECIALIDAD](
	[es_id] [numeric](18, 0) NOT NULL,
	[es_descripcion] [nvarchar](255) NULL,
	[es_tipo] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_ESPECIALIDAD] PRIMARY KEY CLUSTERED 
(
	[es_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [BUGDEVELOPING].[FUNROL]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[FUNROL](
	[ROL_ID] [numeric](18, 0) NOT NULL,
	[FUNCIONALIDAD_ID] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_FUNROL_1] PRIMARY KEY CLUSTERED 
(
	[FUNCIONALIDAD_ID] ASC,
	[ROL_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_DIA]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[MIGRAR_DIA]
AS
BEGIN

INSERT INTO BUGDEVELOPING.DIA VALUES (1,'LUNES'),(2,'MARTES'),(3,'MIERCOLES'),(4,'JUEVES'),(5,'VIERNES'),(6,'SABADO'),(7,'DOMINGO')

END
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_MEDICAMENTOS]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[MIGRAR_MEDICAMENTOS]
AS
BEGIN

INSERT INTO BUGDEVELOPING.MEDICAMENTOS
(m_descripcion)
SELECT distinct Bono_Farmacia_Medicamento
from gd_esquema.Maestra


END
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_PLAN_MEDICO]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[MIGRAR_PLAN_MEDICO]
AS
BEGIN

INSERT INTO BUGDEVELOPING.PLAN_MEDICO
(pl_codigo, pl_descripcion, pl_precio_consulta, pl_precio_farmacia)
SELECT DISTINCT Plan_Med_Codigo, Plan_Med_Descripcion, Plan_Med_Precio_Bono_Consulta, Plan_Med_Precio_Bono_Farmacia
FROM GD2C2013.gd_esquema.Maestra


END
GO
/****** Object:  Table [BUGDEVELOPING].[PERSONA]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [BUGDEVELOPING].[PERSONA](
	[pe_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[pe_nombre] [nvarchar](255) NULL,
	[pe_apellido] [nvarchar](255) NULL,
	[pe_direccion] [nvarchar](255) NULL,
	[pe_telefono] [numeric](18, 0) NULL,
	[pe_mail] [nvarchar](255) NULL,
	[pe_sexo] [char](1) NULL,
	[pe_fecha_nac] [date] NULL,
	[pe_tipo_doc] [nvarchar](255) NULL,
	[pe_num_doc] [numeric](18, 0) NOT NULL,
	[pe_usuario_id] [numeric](18, 0) NULL,
 CONSTRAINT [PK_PERSONA] PRIMARY KEY CLUSTERED 
(
	[pe_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [BUGDEVELOPING].[V_PERSONAS_AUX]    Script Date: 12/02/2013 14:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [BUGDEVELOPING].[V_PERSONAS_AUX] AS
SELECT DISTINCT Paciente_Nombre, Paciente_Apellido, Paciente_Direccion, Paciente_Telefono, Paciente_Mail, Paciente_Fecha_Nac, Paciente_Dni
FROM GD2C2013.gd_esquema.Maestra
where Paciente_Dni is not null
UNION
SELECT DISTINCT Medico_Nombre, Medico_Apellido, Medico_Direccion, Medico_Telefono, Medico_Mail, Medico_Fecha_Nac, Medico_Dni
FROM GD2C2013.gd_esquema.Maestra
where Medico_Dni is not null
GO
/****** Object:  View [BUGDEVELOPING].[V_PACIENTE_AUX]    Script Date: 12/02/2013 14:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [BUGDEVELOPING].[V_PACIENTE_AUX] as
 SELECT distinct [Paciente_Nombre]
      ,[Paciente_Apellido]
      ,[Paciente_Dni]
      ,[Paciente_Direccion]
      ,[Paciente_Telefono]
      ,[Paciente_Mail]
      ,[Paciente_Fecha_Nac]
      ,[Plan_Med_Codigo]
      ,[Plan_Med_Descripcion]

  FROM [GD2C2013].[gd_esquema].[Maestra]
GO
/****** Object:  View [BUGDEVELOPING].[V_MEDICO_ESPECIALIDAD_AUX]    Script Date: 12/02/2013 14:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [BUGDEVELOPING].[V_MEDICO_ESPECIALIDAD_AUX] AS
SELECT DISTINCT Medico_Nombre, Medico_Apellido, Medico_Dni, Medico_Direccion, Medico_Telefono, Medico_Fecha_Nac, Especialidad_Descripcion
FROM GD2C2013.gd_esquema.Maestra
WHERE Medico_Dni is not null
GO
/****** Object:  View [BUGDEVELOPING].[V_MEDICO_AUX]    Script Date: 12/02/2013 14:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [BUGDEVELOPING].[V_MEDICO_AUX] as
 SELECT distinct [Medico_Nombre]
      ,[Medico_Apellido]
      ,[Medico_Dni]
      ,[Medico_Direccion]
      ,[Medico_Telefono]
      ,[Medico_Mail]
      ,[Medico_Fecha_Nac]
      
  FROM [GD2C2013].[gd_esquema].[Maestra]
  WHERE Medico_Dni is not null
GO
/****** Object:  View [BUGDEVELOPING].[V_HORARIOSMEDICOS_AUX]    Script Date: 12/02/2013 14:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [BUGDEVELOPING].[V_HORARIOSMEDICOS_AUX] as
select distinct Medico_Nombre,
				Medico_Apellido,
				Medico_Direccion,
				Medico_Telefono,
				Medico_Dni,
				Medico_Fecha_Nac,
				DATENAME(WEEKDAY,Turno_fecha) 'dia semana',
				CONVERT(TIME, MIN(Turno_Fecha))'hora comienzo', 
				CONVERT(TIME, MAX(Turno_Fecha))'hora fin'
				
from gd_esquema.Maestra
where Medico_Dni IS NOT NULL
group by		Medico_Nombre,
				Medico_Apellido,
				Medico_Direccion,
				Medico_Telefono,
				Medico_Dni,
				Medico_Fecha_Nac,
				DATENAME(WEEKDAY,Turno_fecha)
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_TIPO_ESPECIALIDAD]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[MIGRAR_TIPO_ESPECIALIDAD]
AS
BEGIN

/* Migracion de la Tabla TIPO_ESPECIALIDAD */
INSERT INTO BUGDEVELOPING.TIPO_ESPECIALIDAD (tipo_es_id, tipo_es_descripcion)
SELECT DISTINCT Tipo_Especialidad_Codigo, Tipo_Especialidad_Descripcion
FROM gd_esquema.Maestra
WHERE Tipo_Especialidad_Codigo IS NOT NULL

END
GO
/****** Object:  Table [BUGDEVELOPING].[USUARIO_ROL]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[USUARIO_ROL](
	[USUARIO_ID] [numeric](18, 0) NULL,
	[ROL_ID] [numeric](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_ESPECIALIDAD]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[MIGRAR_ESPECIALIDAD]
AS

BEGIN

/* Migracion de la Tabla ESPECIALIDAD */
INSERT INTO BUGDEVELOPING.ESPECIALIDAD (es_id, es_descripcion, es_tipo)
SELECT DISTINCT M.Especialidad_Codigo, M.Especialidad_Descripcion, TE.tipo_es_id  
FROM gd_esquema.Maestra M INNER JOIN BUGDEVELOPING.TIPO_ESPECIALIDAD TE 
ON (TE.tipo_es_id = M.Tipo_Especialidad_Codigo)

END
GO
/****** Object:  Table [BUGDEVELOPING].[PACIENTE]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[PACIENTE](
	[pa_persona] [numeric](18, 0) NOT NULL,
	[pa_estado_civil] [nvarchar](255) NULL,
	[pa_nAfiliado] [numeric](18, 0) NOT NULL,
	[pa_cantidad_asignado] [numeric](18, 0) NULL,
	[pa_plan] [numeric](18, 0) NULL,
	[pa_activo] [bit] NULL,
 CONSTRAINT [PK_PACIENTE_1] PRIMARY KEY CLUSTERED 
(
	[pa_persona] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[pa_nAfiliado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[pa_nAfiliado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_PERSONA]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[MIGRAR_PERSONA]
AS

BEGIN

INSERT INTO BUGDEVELOPING.PERSONA
(BUGDEVELOPING.PERSONA.pe_nombre, BUGDEVELOPING.PERSONA.pe_apellido, BUGDEVELOPING.PERSONA.pe_direccion, BUGDEVELOPING.PERSONA.pe_telefono, BUGDEVELOPING.PERSONA.pe_mail, BUGDEVELOPING.PERSONA.pe_fecha_nac, BUGDEVELOPING.PERSONA.pe_num_doc)
SELECT Paciente_Nombre, Paciente_Apellido, Paciente_Direccion, Paciente_Telefono, Paciente_Mail, Paciente_Fecha_Nac, Paciente_Dni
FROM BUGDEVELOPING.V_PERSONAS_AUX

END
GO
/****** Object:  Table [BUGDEVELOPING].[MEDICO]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[MEDICO](
	[me_persona] [numeric](18, 0) NOT NULL,
	[me_matricula] [numeric](18, 0) NULL,
	[me_activo] [bit] NULL,
 CONSTRAINT [PK_MEDICO] PRIMARY KEY CLUSTERED 
(
	[me_persona] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [BUGDEVELOPING].[COMPRA]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[COMPRA](
	[co_numero] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[co_suma] [decimal](12, 2) NOT NULL,
	[co_cantidad] [numeric](18, 0) NOT NULL,
	[co_afiliado] [numeric](18, 0) NOT NULL,
	[co_fecha] [datetime] NULL,
 CONSTRAINT [PK_COMPRA_1] PRIMARY KEY CLUSTERED 
(
	[co_numero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [BUGDEVELOPING].[BONO]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[BONO](
	[b_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[b_numero_consulta] [numeric](18, 0) NULL,
	[b_numero_farmacia] [numeric](18, 0) NULL,
	[b_plan] [numeric](18, 0) NOT NULL,
	[b_nAfiliado] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_BONO] PRIMARY KEY CLUSTERED 
(
	[b_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [BUGDEVELOPING].[AGENDA_PERSONAL]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[AGENDA_PERSONAL](
	[ag_codigo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[ag_medico] [numeric](18, 0) NOT NULL,
	[ag_desde_dia] [date] NOT NULL,
	[ag_hasta_dia] [date] NOT NULL,
 CONSTRAINT [PK_AGENDA_PERSONAL] PRIMARY KEY CLUSTERED 
(
	[ag_codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [BUGDEVELOPING].[ESPECIALIDAD_MEDICO]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[ESPECIALIDAD_MEDICO](
	[em_medico] [numeric](18, 0) NOT NULL,
	[em_especialidad] [numeric](18, 0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_PACIENTE]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[MIGRAR_PACIENTE]
AS

BEGIN

INSERT INTO BUGDEVELOPING.PACIENTE
(BUGDEVELOPING.PACIENTE.pa_persona,BUGDEVELOPING.PACIENTE.pa_nAfiliado, BUGDEVELOPING.PACIENTE.pa_cantidad_asignado, BUGDEVELOPING.PACIENTE.pa_activo, BUGDEVELOPING.PACIENTE.pa_plan)
SELECT pe_id,(ROW_NUMBER() OVER(order by (SELECT 1))*10) as row_number,0,'True', Plan_Med_Codigo
FROM BUGDEVELOPING.V_PACIENTE_AUX join BUGDEVELOPING.PERSONA on (Paciente_Nombre = pe_nombre and
																 Paciente_Apellido = pe_apellido and
																 Paciente_Dni = pe_num_doc and
																 Paciente_Direccion = pe_direccion and
																 Paciente_Telefono = pe_telefono and
																 Paciente_Fecha_Nac = pe_fecha_nac)
																 

END
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_MEDICO]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[MIGRAR_MEDICO]
AS
BEGIN

/* Migracion de la Tabla MEDICO */
INSERT BUGDEVELOPING.MEDICO (me_persona, me_activo)
SELECT DISTINCT pe_id,'True'
FROM BUGDEVELOPING.PERSONA
WHERE pe_num_doc in (SELECT DISTINCT medico_dni 
                     FROM gd_esquema.Maestra)
                     
END
GO
/****** Object:  Table [BUGDEVELOPING].[PLAN_HISTORIAL]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[PLAN_HISTORIAL](
	[ph_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[ph_afiliado] [numeric](18, 0) NOT NULL,
	[ph_plan] [numeric](18, 0) NOT NULL,
	[ph_fecha_cambio] [datetime] NOT NULL,
	[ph_motivo] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_PLAN_HISTORIAL] PRIMARY KEY CLUSTERED 
(
	[ph_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [BUGDEVELOPING].[V_COMPRA_BONO_AUX]    Script Date: 12/02/2013 14:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [BUGDEVELOPING].[V_COMPRA_BONO_AUX] AS
SELECT co_numero, Bono_Consulta_Numero, Bono_Farmacia_Numero
FROM gd_esquema.Maestra JOIN BUGDEVELOPING.PERSONA ON (Paciente_Dni = pe_num_doc)
						JOIN BUGDEVELOPING.PACIENTE ON (pe_id = pa_persona)
						JOIN BUGDEVELOPING.COMPRA ON (co_afiliado = pa_nAfiliado and co_fecha = Compra_Bono_Fecha)
WHERE Compra_Bono_Fecha is not null
GO
/****** Object:  Table [BUGDEVELOPING].[TURNO]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[TURNO](
	[t_id] [numeric](18, 0) NOT NULL,
	[t_medico] [numeric](18, 0) NULL,
	[t_fecha] [date] NULL,
	[t_hora] [time](7) NULL,
	[t_agenda] [numeric](18, 0) NULL,
	[t_afiliado] [numeric](18, 0) NULL,
 CONSTRAINT [PK_TURNO] PRIMARY KEY CLUSTERED 
(
	[t_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_ESPECIALIDAD_MEDICO]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[MIGRAR_ESPECIALIDAD_MEDICO]
AS
BEGIN

/* Migracion de la Tabla ESPECIALIDAD_MEDICO */
INSERT BUGDEVELOPING.ESPECIALIDAD_MEDICO (em_medico, em_especialidad)
SELECT DISTINCT P.pe_id, tm.Especialidad_Codigo
FROM gd_esquema.Maestra tm JOIN BUGDEVELOPING.PERSONA P
     ON (TM.Medico_Dni = P.pe_num_doc) JOIN BUGDEVELOPING.MEDICO M
     ON (P.pe_id = M.me_persona)
     
END
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_COMPRA]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [BUGDEVELOPING].[MIGRAR_COMPRA]
As
Begin
INSERT INTO BUGDEVELOPING.COMPRA
(co_suma, co_cantidad, co_afiliado, co_fecha)
select isnull((select SUM(Plan_Med_Precio_Bono_Consulta)
						from gd_esquema.Maestra m2
						where m1.Paciente_Dni = m2.Paciente_Dni and m1.Compra_Bono_Fecha = m2.Compra_Bono_Fecha and Bono_Consulta_Numero is not null), 0) + isnull((select SUM(Plan_Med_Precio_Bono_Farmacia)
																																						 from gd_esquema.Maestra m2
																																						 where m1.Paciente_Dni = m2.Paciente_Dni and m1.Compra_Bono_Fecha = m2.Compra_Bono_Fecha and Bono_Farmacia_Numero is not null), 0), COUNT(*), pa_nAfiliado, m1.Compra_Bono_Fecha
from gd_esquema.Maestra m1 JOIN BUGDEVELOPING.PERSONA ON (Paciente_Dni = pe_num_doc)
      JOIN BUGDEVELOPING.PACIENTE ON (pe_id = pa_persona)
where m1.Compra_Bono_Fecha is not null
group by m1.Paciente_Dni, pa_nAfiliado, m1.Compra_Bono_Fecha
order by Compra_Bono_Fecha

end
GO
/****** Object:  Table [BUGDEVELOPING].[COMPRA_BONO]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[COMPRA_BONO](
	[cb_numero] [numeric](18, 0) NOT NULL,
	[cb_bono] [numeric](18, 0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_BONO]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[MIGRAR_BONO]
AS
BEGIN


INSERT INTO BUGDEVELOPING.BONO
(b_numero_consulta, b_numero_farmacia, b_plan, b_nAfiliado)
SELECT Bono_Consulta_Numero, NULL, Plan_Med_Codigo, pa_nAfiliado
FROM GD2C2013.gd_esquema.Maestra JOIN BUGDEVELOPING.PERSONA ON (pe_num_doc = Paciente_Dni)
								 JOIN BUGDEVELOPING.PACIENTE ON (pa_persona = pe_id)
WHERE Bono_Consulta_Numero is not null and Compra_Bono_Fecha IS NOT NULL	

INSERT INTO BUGDEVELOPING.BONO
(b_numero_consulta, b_numero_farmacia, b_plan, b_nAfiliado)
SELECT  NULL, Bono_Farmacia_Numero, Plan_Med_Codigo, pa_nAfiliado
FROM GD2C2013.gd_esquema.Maestra JOIN BUGDEVELOPING.PERSONA ON (pe_num_doc = Paciente_Dni)
								 JOIN BUGDEVELOPING.PACIENTE ON (pa_persona = pe_id)
WHERE Bono_Farmacia_Numero is not null and Compra_Bono_Fecha IS NOT NULL	

END
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[INSERTAR_PERSONA]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[INSERTAR_PERSONA]
(
@NOMBRE VARCHAR(255),
@APELLIDO VARCHAR(255),
@DIRECCION VARCHAR(255),
@TELEFONO VARCHAR(255),
@MAIL VARCHAR(255),
@SEXO CHAR(1),
@FECHA_NAC VARCHAR(255),
@TIPO_DOC VARCHAR(255),
@NRO_DOC VARCHAR(255)
)
AS
BEGIN

IF (@DIRECCION = '')
SET @DIRECCION = NULL

IF (@TELEFONO = '')
BEGIN
SET @TELEFONO = NULL
END
ELSE
BEGIN
SET @TELEFONO = CAST(@TELEFONO AS NUMERIC(18,0))
END


IF (@MAIL = '')
SET @MAIL = NULL


INSERT INTO BUGDEVELOPING.PERSONA (PE_NOMBRE, PE_APELLIDO, PE_DIRECCION, PE_TELEFONO, PE_MAIL, PE_SEXO, PE_FECHA_NAC, PE_TIPO_DOC, PE_NUM_DOC)
VALUES (@NOMBRE, @APELLIDO, @DIRECCION, @TELEFONO, @MAIL, @SEXO, CAST(@FECHA_NAC AS DATE), @TIPO_DOC, CAST(@NRO_DOC AS NUMERIC))

END

select *
from BUGDEVELOPING.MEDICO


SELECT es_descripcion FROM BUGDEVELOPING.ESPECIALIDAD_MEDICO JOIN ESPECIALIDAD ON (em_especialidad = es_id)
GO
/****** Object:  Table [BUGDEVELOPING].[AGENDA_DIA]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[AGENDA_DIA](
	[agd_ag_codigo] [numeric](18, 0) NOT NULL,
	[agd_dia_id] [numeric](18, 0) NOT NULL,
	[agd_hora_inicio] [time](7) NULL,
	[agd_hora_fin] [time](7) NULL,
 CONSTRAINT [PK_AGENDA_DIA_1] PRIMARY KEY CLUSTERED 
(
	[agd_ag_codigo] ASC,
	[agd_dia_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [BUGDEVELOPING].[BONO_FARMACIA]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[BONO_FARMACIA](
	[bf_bono_numero] [numeric](18, 0) NOT NULL,
	[bf_fecha_vencimiento] [datetime] NULL,
	[bf_fecha_prescipcion] [datetime] NULL,
 CONSTRAINT [PK_BONO_FARMACIA] PRIMARY KEY CLUSTERED 
(
	[bf_bono_numero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [BUGDEVELOPING].[CONSULTA]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[CONSULTA](
	[con_numero] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[con_sintoma] [nvarchar](255) NOT NULL,
	[con_enf] [nvarchar](255) NOT NULL,
	[con_turno] [numeric](18, 0) NULL,
	[con_fecha] [nchar](10) NULL,
	[con_hora_inicio] [nchar](10) NULL,
	[con_hora_fin] [nchar](10) NULL,
	[con_hora_llegada] [nchar](10) NULL,
 CONSTRAINT [PK_CONSULTA] PRIMARY KEY CLUSTERED 
(
	[con_numero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [BUGDEVELOPING].[CANCELACION_TURNO]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [BUGDEVELOPING].[CANCELACION_TURNO](
	[ct_turno] [numeric](18, 0) NOT NULL,
	[ct_motivo] [varchar](255) NULL,
	[ct_tipo_cancelacion] [numeric](18, 0) NULL,
 CONSTRAINT [PK_CANCELACION_TURNO] PRIMARY KEY CLUSTERED 
(
	[ct_turno] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_TURNO]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[MIGRAR_TURNO]
AS
BEGIN

INSERT INTO BUGDEVELOPING.TURNO
(t_id, t_medico, t_fecha, t_hora, t_afiliado, t_agenda)
SELECT Turno_Numero, me_persona, CONVERT(DATE,Turno_Fecha), CONVERT(TIME,Turno_Fecha), pa_nAfiliado, ag_codigo
FROM gd_esquema.Maestra JOIN BUGDEVELOPING.PERSONA PM ON (Medico_Dni = PM.pe_num_doc)
						JOIN BUGDEVELOPING.MEDICO ON (PM.pe_id = me_persona)
						JOIN BUGDEVELOPING.PERSONA PP ON (Paciente_Dni = PP.pe_num_doc)
						JOIN BUGDEVELOPING.PACIENTE ON (PP.pe_id = pa_persona)
						JOIN BUGDEVELOPING.AGENDA_PERSONAL ON (me_persona = ag_medico)
WHERE Turno_Numero IS NOT NULL
GROUP BY Turno_Numero, me_persona, Turno_Fecha, pa_nAfiliado, ag_codigo
						
END
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_AGENDA_PERSONAL]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[MIGRAR_AGENDA_PERSONAL]
AS
BEGIN


INSERT INTO BUGDEVELOPING.AGENDA_PERSONAL (ag_medico, ag_desde_dia, ag_hasta_dia)
	SELECT temp.me_persona, MIN(FECHA), MAX(FECHA)
	FROM (SELECT me_persona, CONVERT(DATE,Turno_Fecha) AS FECHA
			FROM gd_esquema.Maestra
			JOIN BUGDEVELOPING.PERSONA ON Medico_Dni = pe_num_doc
			JOIN BUGDEVELOPING.MEDICO ON pe_id = me_persona
			GROUP BY me_persona, Turno_Fecha) temp
	GROUP BY temp.me_persona;
		
	
INSERT INTO BUGDEVELOPING.AGENDA_DIA (agd_ag_codigo, agd_dia_id, agd_hora_inicio, agd_hora_fin)
	SELECT a.ag_codigo, temp.DIA, MIN(temp.HORA), MAX(temp.HORA)
	FROM (SELECT me_persona, CONVERT(DATE,m.Turno_Fecha) AS FECHA, CONVERT(TIME,m.Turno_Fecha) AS HORA, DATEPART(WEEKDAY, m.Turno_Fecha) AS DIA
			FROM gd_esquema.Maestra m
			JOIN BUGDEVELOPING.PERSONA ON m.Medico_Dni = pe_num_doc
			JOIN BUGDEVELOPING.MEDICO ON me_persona = pe_id
			GROUP BY me_persona, m.Turno_Fecha) temp
	JOIN BUGDEVELOPING.AGENDA_PERSONAL a ON a.ag_medico = temp.me_persona
	GROUP BY a.ag_codigo, temp.DIA;


END
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_COMPRA_BONO]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[MIGRAR_COMPRA_BONO]
AS
BEGIN

INSERT INTO BUGDEVELOPING.COMPRA_BONO
(cb_numero, cb_bono)
SELECT co_numero, b_id
FROM BUGDEVELOPING.V_COMPRA_BONO_AUX JOIN BUGDEVELOPING.BONO ON (Bono_Consulta_Numero = b_numero_consulta)
WHERE Bono_Farmacia_Numero is null
UNION
SELECT co_numero, b_id
FROM BUGDEVELOPING.V_COMPRA_BONO_AUX JOIN BUGDEVELOPING.BONO ON (Bono_Farmacia_Numero = b_numero_farmacia)
WHERE Bono_Consulta_Numero is null
ORDER BY co_numero asc

END
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_BONO_FARMACIA]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[MIGRAR_BONO_FARMACIA]
AS
BEGIN

INSERT INTO BUGDEVELOPING.BONO_FARMACIA
(bf_bono_numero, bf_fecha_vencimiento, bf_fecha_prescipcion)
SELECT b_id, Bono_Farmacia_Fecha_Vencimiento, NULL
FROM GD2C2013.gd_esquema.Maestra JOIN BUGDEVELOPING.BONO ON (Bono_Farmacia_Numero = b_numero_farmacia)
WHERE Bono_Farmacia_Numero is not null and Compra_Bono_Fecha is not null




END
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_CONSULTA]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[MIGRAR_CONSULTA]
AS
BEGIN

INSERT INTO BUGDEVELOPING.CONSULTA
(con_sintoma, con_enf, con_turno, con_fecha)
select Consulta_Sintomas, Consulta_Enfermedades, Turno_Numero, Turno_Fecha
from gd_esquema.Maestra
where Turno_Numero IS NOT NULL AND Turno_Fecha IS NOT NULL AND Consulta_Sintomas IS NOT NULL AND Consulta_Enfermedades IS NOT NULL
group by Turno_Numero, Turno_Fecha, Consulta_Sintomas, Consulta_Enfermedades

END
GO
/****** Object:  Table [BUGDEVELOPING].[RECETA_MEDICA]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[RECETA_MEDICA](
	[rm_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[rm_bono] [numeric](18, 0) NOT NULL,
	[rm_consulta] [numeric](18, 0) NULL,
 CONSTRAINT [PK_RECETA_MEDICA] PRIMARY KEY CLUSTERED 
(
	[rm_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[ACTUALIZAR_CONSULTA]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[ACTUALIZAR_CONSULTA]( @FECHA_AT VARCHAR(50), 
									 @HORA_AT VARCHAR(50), @DIAGNOSTICO VARCHAR(500),
									 @SINTOMAS VARCHAR(200),
									 @NRO_CON BIGINT)
									 									 
AS
	BEGIN
		
		DECLARE @FECHA_VALIDA DATETIME
		
		SELECT @FECHA_VALIDA = CONVERT(DATE,con_fecha) FROM BUGDEVELOPING.CONSULTA WHERE CON_NUMERO = @NRO_CON
		
		IF(@FECHA_VALIDA = CONVERT(DATE,@FECHA_AT))
			BEGIN
		
				UPDATE BUGDEVELOPING.CONSULTA SET con_fecha = CONVERT(DATETIME, @FECHA_AT),
													con_hora_fin = CONVERT(TIME(0), @HORA_AT),
													con_sintoma = @SINTOMAS,
													con_enf = @DIAGNOSTICO
											
												WHERE con_numero = @NRO_CON
				SELECT 0
			END
		
		ELSE
			BEGIN
				SELECT 1
			END												

	END
GO
/****** Object:  Table [BUGDEVELOPING].[BONO_CONSULTA]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[BONO_CONSULTA](
	[bc_bono_numero] [numeric](18, 0) NOT NULL,
	[bc_numero_consulta] [numeric](18, 0) NULL,
	[bc_uso] [bit] NOT NULL,
 CONSTRAINT [PK_BONO_CONSULTA] PRIMARY KEY CLUSTERED 
(
	[bc_bono_numero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [BUGDEVELOPING].[MEDICAMENTOS_X_RECETA]    Script Date: 12/02/2013 14:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BUGDEVELOPING].[MEDICAMENTOS_X_RECETA](
	[mxr_receta] [numeric](18, 0) NOT NULL,
	[mxr_medicamento] [numeric](18, 0) NOT NULL,
	[mxr_cantidad] [numeric](18, 0) NOT NULL,
	[mxr_cantidad_aclaracion] [nvarchar](255) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[CONFECCIONAR_RECETA]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[CONFECCIONAR_RECETA](@NUMERO_CONS NUMERIC(18,0), @BONO_FAR NUMERIC(18,0), @FECHA_SIST VARCHAR(50))
AS
	BEGIN
	
		DECLARE @RESULTADO INT
		DECLARE @CONSUMIDO INT
		DECLARE @FECHA_VEN DATETIME
	
		/*verifico que no esté consumido el bono*/
	
		SELECT @CONSUMIDO = COUNT(*) FROM BUGDEVELOPING.RECETA_MEDICA WHERE rm_bono = @BONO_FAR 
		IF(@CONSUMIDO = 0)/*no se consumio*/
			BEGIN
				SELECT @FECHA_VEN = bf_fecha_vencimiento FROM  BUGDEVELOPING.BONO_FARMACIA WHERE bf_bono_numero = @BONO_FAR
				IF(@FECHA_VEN >= CONVERT(datetime, @FECHA_SIST))/*no esta vencido*/
					BEGIN
						INSERT INTO BUGDEVELOPING.RECETA_MEDICA (rm_bono, rm_consulta) VALUES (@BONO_FAR, @NUMERO_CONS)
						SET @RESULTADO = 0
					END
				ELSE/* esta vencido*/
					BEGIN
						SET @RESULTADO = 2
					END	
			END
		ELSE
			BEGIN /*esta consumido*/
				SET @RESULTADO = 1
			END	
		
	
		SELECT @RESULTADO
	END
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_RECETA_MEDICA]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[MIGRAR_RECETA_MEDICA]
AS
BEGIN

INSERT INTO BUGDEVELOPING.RECETA_MEDICA (rm_bono, rm_consulta)
	SELECT b_id, cm.con_numero
	FROM gd_esquema.Maestra m
	JOIN  BUGDEVELOPING.CONSULTA cm
	ON cm.con_turno = m.Turno_Numero
	JOIN BUGDEVELOPING.BONO 
	ON b_numero_farmacia = Bono_Farmacia_Numero
	WHERE m.Bono_Consulta_Numero IS NOT NULL
	AND m.Bono_Farmacia_Medicamento IS NOT NULL
	GROUP BY b_id, cm.con_numero


END
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_BONO_CONSULTA]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[MIGRAR_BONO_CONSULTA]
AS
BEGIN


INSERT INTO BUGDEVELOPING.BONO_CONSULTA
(bc_bono_numero, bc_numero_consulta, bc_uso)
SELECT b_id, NULL, 0
FROM GD2C2013.gd_esquema.Maestra JOIN BUGDEVELOPING.BONO ON (Bono_Consulta_Numero = b_numero_consulta)
WHERE Bono_Consulta_Numero is not null and Compra_Bono_Fecha is not null and Bono_Consulta_Numero not in (select Bono_Consulta_Numero
																										  from gd_esquema.Maestra
																										  where Bono_Consulta_Numero is not null and Turno_Numero is not null)
union
select b_id, NULL, 1
from gd_esquema.Maestra JOIN BUGDEVELOPING.BONO ON (Bono_Consulta_Numero = b_numero_consulta)
where Bono_Consulta_Numero is not null and Turno_Numero is not null
order by b_id asc


END
GO
/****** Object:  StoredProcedure [BUGDEVELOPING].[MIGRAR_MEDICAMENTOS_X_RECETA]    Script Date: 12/02/2013 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [BUGDEVELOPING].[MIGRAR_MEDICAMENTOS_X_RECETA]
AS
BEGIN


INSERT INTO BUGDEVELOPING.MEDICAMENTOS_X_RECETA
(mxr_receta, mxr_medicamento, mxr_cantidad, mxr_cantidad_aclaracion)
SELECT rm_id, m_id, 1, 'UNO'
FROM gd_esquema.Maestra JOIN BUGDEVELOPING.MEDICAMENTOS ON (m_descripcion = Bono_Farmacia_Medicamento)
						JOIN BUGDEVELOPING.BONO ON (Bono_Farmacia_Numero = b_numero_farmacia)
						JOIN BUGDEVELOPING.RECETA_MEDICA ON (b_id = rm_bono)


END
GO
/****** Object:  ForeignKey [FK_AGENDA_DIA_AGENDA_PERSONAL]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[AGENDA_DIA]  WITH CHECK ADD  CONSTRAINT [FK_AGENDA_DIA_AGENDA_PERSONAL] FOREIGN KEY([agd_ag_codigo])
REFERENCES [BUGDEVELOPING].[AGENDA_PERSONAL] ([ag_codigo])
GO
ALTER TABLE [BUGDEVELOPING].[AGENDA_DIA] CHECK CONSTRAINT [FK_AGENDA_DIA_AGENDA_PERSONAL]
GO
/****** Object:  ForeignKey [FK_AGENDA_DIA_DIA]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[AGENDA_DIA]  WITH CHECK ADD  CONSTRAINT [FK_AGENDA_DIA_DIA] FOREIGN KEY([agd_dia_id])
REFERENCES [BUGDEVELOPING].[DIA] ([dia_id])
GO
ALTER TABLE [BUGDEVELOPING].[AGENDA_DIA] CHECK CONSTRAINT [FK_AGENDA_DIA_DIA]
GO
/****** Object:  ForeignKey [FK_AGENDA_PERSONAL_MEDICO]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[AGENDA_PERSONAL]  WITH CHECK ADD  CONSTRAINT [FK_AGENDA_PERSONAL_MEDICO] FOREIGN KEY([ag_medico])
REFERENCES [BUGDEVELOPING].[MEDICO] ([me_persona])
GO
ALTER TABLE [BUGDEVELOPING].[AGENDA_PERSONAL] CHECK CONSTRAINT [FK_AGENDA_PERSONAL_MEDICO]
GO
/****** Object:  ForeignKey [FK_BONO_PACIENTE]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[BONO]  WITH CHECK ADD  CONSTRAINT [FK_BONO_PACIENTE] FOREIGN KEY([b_nAfiliado])
REFERENCES [BUGDEVELOPING].[PACIENTE] ([pa_nAfiliado])
GO
ALTER TABLE [BUGDEVELOPING].[BONO] CHECK CONSTRAINT [FK_BONO_PACIENTE]
GO
/****** Object:  ForeignKey [FK_BONO_PLAN]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[BONO]  WITH CHECK ADD  CONSTRAINT [FK_BONO_PLAN] FOREIGN KEY([b_plan])
REFERENCES [BUGDEVELOPING].[PLAN_MEDICO] ([pl_codigo])
GO
ALTER TABLE [BUGDEVELOPING].[BONO] CHECK CONSTRAINT [FK_BONO_PLAN]
GO
/****** Object:  ForeignKey [FK_BONO_CONSULTA_BONO]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[BONO_CONSULTA]  WITH CHECK ADD  CONSTRAINT [FK_BONO_CONSULTA_BONO] FOREIGN KEY([bc_bono_numero])
REFERENCES [BUGDEVELOPING].[BONO] ([b_id])
GO
ALTER TABLE [BUGDEVELOPING].[BONO_CONSULTA] CHECK CONSTRAINT [FK_BONO_CONSULTA_BONO]
GO
/****** Object:  ForeignKey [FK_BONO_CONSULTA_CONSULTA]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[BONO_CONSULTA]  WITH CHECK ADD  CONSTRAINT [FK_BONO_CONSULTA_CONSULTA] FOREIGN KEY([bc_numero_consulta])
REFERENCES [BUGDEVELOPING].[CONSULTA] ([con_numero])
GO
ALTER TABLE [BUGDEVELOPING].[BONO_CONSULTA] CHECK CONSTRAINT [FK_BONO_CONSULTA_CONSULTA]
GO
/****** Object:  ForeignKey [FK_BONO_FARMACIA_BONO]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[BONO_FARMACIA]  WITH CHECK ADD  CONSTRAINT [FK_BONO_FARMACIA_BONO] FOREIGN KEY([bf_bono_numero])
REFERENCES [BUGDEVELOPING].[BONO] ([b_id])
GO
ALTER TABLE [BUGDEVELOPING].[BONO_FARMACIA] CHECK CONSTRAINT [FK_BONO_FARMACIA_BONO]
GO
/****** Object:  ForeignKey [FK_CANCELACION_TURNO_TIPO_CANCELACION]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[CANCELACION_TURNO]  WITH CHECK ADD  CONSTRAINT [FK_CANCELACION_TURNO_TIPO_CANCELACION] FOREIGN KEY([ct_tipo_cancelacion])
REFERENCES [BUGDEVELOPING].[TIPO_CANCELACION] ([tc_id])
GO
ALTER TABLE [BUGDEVELOPING].[CANCELACION_TURNO] CHECK CONSTRAINT [FK_CANCELACION_TURNO_TIPO_CANCELACION]
GO
/****** Object:  ForeignKey [FK_CANCELACION_TURNO_TURNO]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[CANCELACION_TURNO]  WITH CHECK ADD  CONSTRAINT [FK_CANCELACION_TURNO_TURNO] FOREIGN KEY([ct_turno])
REFERENCES [BUGDEVELOPING].[TURNO] ([t_id])
GO
ALTER TABLE [BUGDEVELOPING].[CANCELACION_TURNO] CHECK CONSTRAINT [FK_CANCELACION_TURNO_TURNO]
GO
/****** Object:  ForeignKey [FK_COMPRA_PACIENTE]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[COMPRA]  WITH CHECK ADD  CONSTRAINT [FK_COMPRA_PACIENTE] FOREIGN KEY([co_afiliado])
REFERENCES [BUGDEVELOPING].[PACIENTE] ([pa_nAfiliado])
GO
ALTER TABLE [BUGDEVELOPING].[COMPRA] CHECK CONSTRAINT [FK_COMPRA_PACIENTE]
GO
/****** Object:  ForeignKey [FK_COMPRA_BONO_BONO]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[COMPRA_BONO]  WITH CHECK ADD  CONSTRAINT [FK_COMPRA_BONO_BONO] FOREIGN KEY([cb_bono])
REFERENCES [BUGDEVELOPING].[BONO] ([b_id])
GO
ALTER TABLE [BUGDEVELOPING].[COMPRA_BONO] CHECK CONSTRAINT [FK_COMPRA_BONO_BONO]
GO
/****** Object:  ForeignKey [FK_COMPRA_BONO_COMPRA]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[COMPRA_BONO]  WITH CHECK ADD  CONSTRAINT [FK_COMPRA_BONO_COMPRA] FOREIGN KEY([cb_numero])
REFERENCES [BUGDEVELOPING].[COMPRA] ([co_numero])
GO
ALTER TABLE [BUGDEVELOPING].[COMPRA_BONO] CHECK CONSTRAINT [FK_COMPRA_BONO_COMPRA]
GO
/****** Object:  ForeignKey [FK_CONSULTA_TURNO]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[CONSULTA]  WITH CHECK ADD  CONSTRAINT [FK_CONSULTA_TURNO] FOREIGN KEY([con_turno])
REFERENCES [BUGDEVELOPING].[TURNO] ([t_id])
GO
ALTER TABLE [BUGDEVELOPING].[CONSULTA] CHECK CONSTRAINT [FK_CONSULTA_TURNO]
GO
/****** Object:  ForeignKey [FK_ESPECIALIDAD_TIPO_ESPECIALIDAD]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[ESPECIALIDAD]  WITH CHECK ADD  CONSTRAINT [FK_ESPECIALIDAD_TIPO_ESPECIALIDAD] FOREIGN KEY([es_tipo])
REFERENCES [BUGDEVELOPING].[TIPO_ESPECIALIDAD] ([tipo_es_id])
GO
ALTER TABLE [BUGDEVELOPING].[ESPECIALIDAD] CHECK CONSTRAINT [FK_ESPECIALIDAD_TIPO_ESPECIALIDAD]
GO
/****** Object:  ForeignKey [FK_ESPECIALIDAD_MEDICO_ESPECIALIDAD]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[ESPECIALIDAD_MEDICO]  WITH CHECK ADD  CONSTRAINT [FK_ESPECIALIDAD_MEDICO_ESPECIALIDAD] FOREIGN KEY([em_especialidad])
REFERENCES [BUGDEVELOPING].[ESPECIALIDAD] ([es_id])
GO
ALTER TABLE [BUGDEVELOPING].[ESPECIALIDAD_MEDICO] CHECK CONSTRAINT [FK_ESPECIALIDAD_MEDICO_ESPECIALIDAD]
GO
/****** Object:  ForeignKey [FK_ESPECIALIDAD_MEDICO_MEDICO]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[ESPECIALIDAD_MEDICO]  WITH CHECK ADD  CONSTRAINT [FK_ESPECIALIDAD_MEDICO_MEDICO] FOREIGN KEY([em_medico])
REFERENCES [BUGDEVELOPING].[MEDICO] ([me_persona])
GO
ALTER TABLE [BUGDEVELOPING].[ESPECIALIDAD_MEDICO] CHECK CONSTRAINT [FK_ESPECIALIDAD_MEDICO_MEDICO]
GO
/****** Object:  ForeignKey [FK_FUNROL_FUNCIONALIDAD]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[FUNROL]  WITH CHECK ADD  CONSTRAINT [FK_FUNROL_FUNCIONALIDAD] FOREIGN KEY([FUNCIONALIDAD_ID])
REFERENCES [BUGDEVELOPING].[FUNCIONALIDAD] ([FUNCIONALIDAD_ID])
GO
ALTER TABLE [BUGDEVELOPING].[FUNROL] CHECK CONSTRAINT [FK_FUNROL_FUNCIONALIDAD]
GO
/****** Object:  ForeignKey [FK_FUNROL_ROL]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[FUNROL]  WITH CHECK ADD  CONSTRAINT [FK_FUNROL_ROL] FOREIGN KEY([ROL_ID])
REFERENCES [BUGDEVELOPING].[ROL] ([ROL_ID])
GO
ALTER TABLE [BUGDEVELOPING].[FUNROL] CHECK CONSTRAINT [FK_FUNROL_ROL]
GO
/****** Object:  ForeignKey [FK_MEDICAMENTOS_X_RECETA_MEDICAMENTOS]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[MEDICAMENTOS_X_RECETA]  WITH CHECK ADD  CONSTRAINT [FK_MEDICAMENTOS_X_RECETA_MEDICAMENTOS] FOREIGN KEY([mxr_medicamento])
REFERENCES [BUGDEVELOPING].[MEDICAMENTOS] ([m_id])
GO
ALTER TABLE [BUGDEVELOPING].[MEDICAMENTOS_X_RECETA] CHECK CONSTRAINT [FK_MEDICAMENTOS_X_RECETA_MEDICAMENTOS]
GO
/****** Object:  ForeignKey [FK_MEDICAMENTOS_X_RECETA_RECETA_MEDICA]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[MEDICAMENTOS_X_RECETA]  WITH CHECK ADD  CONSTRAINT [FK_MEDICAMENTOS_X_RECETA_RECETA_MEDICA] FOREIGN KEY([mxr_receta])
REFERENCES [BUGDEVELOPING].[RECETA_MEDICA] ([rm_id])
GO
ALTER TABLE [BUGDEVELOPING].[MEDICAMENTOS_X_RECETA] CHECK CONSTRAINT [FK_MEDICAMENTOS_X_RECETA_RECETA_MEDICA]
GO
/****** Object:  ForeignKey [FK_MEDICO_PERSONA]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[MEDICO]  WITH CHECK ADD  CONSTRAINT [FK_MEDICO_PERSONA] FOREIGN KEY([me_persona])
REFERENCES [BUGDEVELOPING].[PERSONA] ([pe_id])
GO
ALTER TABLE [BUGDEVELOPING].[MEDICO] CHECK CONSTRAINT [FK_MEDICO_PERSONA]
GO
/****** Object:  ForeignKey [FK_PACIENTE_PERSONA]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[PACIENTE]  WITH CHECK ADD  CONSTRAINT [FK_PACIENTE_PERSONA] FOREIGN KEY([pa_persona])
REFERENCES [BUGDEVELOPING].[PERSONA] ([pe_id])
GO
ALTER TABLE [BUGDEVELOPING].[PACIENTE] CHECK CONSTRAINT [FK_PACIENTE_PERSONA]
GO
/****** Object:  ForeignKey [FK_PACIENTE_PLAN_MEDICO]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[PACIENTE]  WITH CHECK ADD  CONSTRAINT [FK_PACIENTE_PLAN_MEDICO] FOREIGN KEY([pa_plan])
REFERENCES [BUGDEVELOPING].[PLAN_MEDICO] ([pl_codigo])
GO
ALTER TABLE [BUGDEVELOPING].[PACIENTE] CHECK CONSTRAINT [FK_PACIENTE_PLAN_MEDICO]
GO
/****** Object:  ForeignKey [FK_USUARIO_PERSONA]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[PERSONA]  WITH CHECK ADD  CONSTRAINT [FK_USUARIO_PERSONA] FOREIGN KEY([pe_usuario_id])
REFERENCES [BUGDEVELOPING].[USUARIO] ([USUARIO_ID])
GO
ALTER TABLE [BUGDEVELOPING].[PERSONA] CHECK CONSTRAINT [FK_USUARIO_PERSONA]
GO
/****** Object:  ForeignKey [FK_PLAN_HISTORIAL_PACIENTE]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[PLAN_HISTORIAL]  WITH CHECK ADD  CONSTRAINT [FK_PLAN_HISTORIAL_PACIENTE] FOREIGN KEY([ph_afiliado])
REFERENCES [BUGDEVELOPING].[PACIENTE] ([pa_nAfiliado])
GO
ALTER TABLE [BUGDEVELOPING].[PLAN_HISTORIAL] CHECK CONSTRAINT [FK_PLAN_HISTORIAL_PACIENTE]
GO
/****** Object:  ForeignKey [FK_PLAN_HISTORIAL_PLAN]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[PLAN_HISTORIAL]  WITH CHECK ADD  CONSTRAINT [FK_PLAN_HISTORIAL_PLAN] FOREIGN KEY([ph_plan])
REFERENCES [BUGDEVELOPING].[PLAN_MEDICO] ([pl_codigo])
GO
ALTER TABLE [BUGDEVELOPING].[PLAN_HISTORIAL] CHECK CONSTRAINT [FK_PLAN_HISTORIAL_PLAN]
GO
/****** Object:  ForeignKey [FK_RECETA_MEDICA_BONO_FARMACIA]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[RECETA_MEDICA]  WITH CHECK ADD  CONSTRAINT [FK_RECETA_MEDICA_BONO_FARMACIA] FOREIGN KEY([rm_bono])
REFERENCES [BUGDEVELOPING].[BONO_FARMACIA] ([bf_bono_numero])
GO
ALTER TABLE [BUGDEVELOPING].[RECETA_MEDICA] CHECK CONSTRAINT [FK_RECETA_MEDICA_BONO_FARMACIA]
GO
/****** Object:  ForeignKey [FK_RECETA_MEDICA_CONSULTA]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[RECETA_MEDICA]  WITH CHECK ADD  CONSTRAINT [FK_RECETA_MEDICA_CONSULTA] FOREIGN KEY([rm_consulta])
REFERENCES [BUGDEVELOPING].[CONSULTA] ([con_numero])
GO
ALTER TABLE [BUGDEVELOPING].[RECETA_MEDICA] CHECK CONSTRAINT [FK_RECETA_MEDICA_CONSULTA]
GO
/****** Object:  ForeignKey [FK_TURNO_AGENDA_PERSONAL]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[TURNO]  WITH CHECK ADD  CONSTRAINT [FK_TURNO_AGENDA_PERSONAL] FOREIGN KEY([t_agenda])
REFERENCES [BUGDEVELOPING].[AGENDA_PERSONAL] ([ag_codigo])
GO
ALTER TABLE [BUGDEVELOPING].[TURNO] CHECK CONSTRAINT [FK_TURNO_AGENDA_PERSONAL]
GO
/****** Object:  ForeignKey [FK_TURNO_MEDICO]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[TURNO]  WITH CHECK ADD  CONSTRAINT [FK_TURNO_MEDICO] FOREIGN KEY([t_medico])
REFERENCES [BUGDEVELOPING].[MEDICO] ([me_persona])
GO
ALTER TABLE [BUGDEVELOPING].[TURNO] CHECK CONSTRAINT [FK_TURNO_MEDICO]
GO
/****** Object:  ForeignKey [FK_TURNO_PACIENTE]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[TURNO]  WITH CHECK ADD  CONSTRAINT [FK_TURNO_PACIENTE] FOREIGN KEY([t_afiliado])
REFERENCES [BUGDEVELOPING].[PACIENTE] ([pa_nAfiliado])
GO
ALTER TABLE [BUGDEVELOPING].[TURNO] CHECK CONSTRAINT [FK_TURNO_PACIENTE]
GO
/****** Object:  ForeignKey [FK_USUARIO_ROL_ROL]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[USUARIO_ROL]  WITH CHECK ADD  CONSTRAINT [FK_USUARIO_ROL_ROL] FOREIGN KEY([ROL_ID])
REFERENCES [BUGDEVELOPING].[ROL] ([ROL_ID])
GO
ALTER TABLE [BUGDEVELOPING].[USUARIO_ROL] CHECK CONSTRAINT [FK_USUARIO_ROL_ROL]
GO
/****** Object:  ForeignKey [FK_USUARIO_ROL_USUARIO]    Script Date: 12/02/2013 14:04:08 ******/
ALTER TABLE [BUGDEVELOPING].[USUARIO_ROL]  WITH CHECK ADD  CONSTRAINT [FK_USUARIO_ROL_USUARIO] FOREIGN KEY([USUARIO_ID])
REFERENCES [BUGDEVELOPING].[USUARIO] ([USUARIO_ID])
GO
ALTER TABLE [BUGDEVELOPING].[USUARIO_ROL] CHECK CONSTRAINT [FK_USUARIO_ROL_USUARIO]
GO
/*INICIO DE MIGRACION*/

EXECUTE BUGDEVELOPING.MIGRAR_PERSONA
GO

EXECUTE BUGDEVELOPING.MIGRAR_PLAN_MEDICO
GO

EXECUTE BUGDEVELOPING.MIGRAR_PACIENTE
GO

EXECUTE BUGDEVELOPING.MIGRAR_MEDICO
GO

EXECUTE BUGDEVELOPING.MIGRAR_TIPO_ESPECIALIDAD
GO

EXECUTE BUGDEVELOPING.MIGRAR_ESPECIALIDAD
GO

EXECUTE BUGDEVELOPING.MIGRAR_ESPECIALIDAD_MEDICO
GO

EXECUTE BUGDEVELOPING.MIGRAR_BONO
GO

EXECUTE BUGDEVELOPING.MIGRAR_BONO_CONSULTA
GO

EXECUTE BUGDEVELOPING.MIGRAR_BONO_FARMACIA
GO

EXECUTE BUGDEVELOPING.MIGRAR_DIA
GO

EXECUTE BUGDEVELOPING.MIGRAR_AGENDA_PERSONAL
GO

EXECUTE BUGDEVELOPING.MIGRAR_TURNO
GO

EXECUTE BUGDEVELOPING.MIGRAR_CONSULTA
GO

EXECUTE BUGDEVELOPING.MIGRAR_RECETA_MEDICA
GO

EXECUTE BUGDEVELOPING.MIGRAR_MEDICAMENTOS
GO

EXECUTE BUGDEVELOPING.MIGRAR_MEDICAMENTOS_X_RECETA
GO

EXECUTE BUGDEVELOPING.MIGRAR_COMPRA
GO

EXECUTE BUGDEVELOPING.MIGRAR_COMPRA_BONO
GO

/* USUARIO ADMIN POR DEFAULT */

INSERT INTO BUGDEVELOPING.USUARIO

(USUARIO_USERNAME, USUARIO_PASSWORD, USUARIO_INTENTOS) VALUES
/*todos los usuarios predefinidos, tienen el mismo hash de  password 'w23e'*/
('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9b',3), /*administrador del sistema*/
('juanPerez','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9b',3),/*empleado administrativo*/
('andresLopez','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9b',3),/* afiliado */
('rodrigoPetraca','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9b',3)/*profesional*/
/***************************************************************************************/

/* CREACION DE LISTA DE FUNCIONALIDADES */

INSERT INTO BUGDEVELOPING.FUNCIONALIDAD

(FUNCIONALIDAD_NOMBRE)

VALUES

('Administrcion de Roles'),
('Administracion de Afiliados'), 
('Administracion de Profesionales'),
('Registrar Agenda'),
('Compra de Bonos'),
('Pedido de Turnos'),
('Registro de Llegadas de Paciente'),
('Registro de Resultado de Atencion'),
('Cancelar Atención Médica'),
('Emisión de Receta'),
('Estadísticas')

/***************************************************************************************/

/* CREACION DE ROLES PREDEFINIDOS PARA EL ADMINISTRADOR, ADMINISTRATIVO, AFILIADO Y PROFESIONAL */

INSERT INTO BUGDEVELOPING.ROL

(ROL_NOMBRE, ROL_HABILITACION)

VALUES

('Administrador del Sistema',1),
('Administrativo',1),
('Afiliado',1),
('Profesional',1)

/***************************************************************************************/

/* ASIGNACION DE FUNCIONALIDADES A CADA ROL */

INSERT INTO BUGDEVELOPING.FUNROL

(ROL_ID, FUNCIONALIDAD_ID)

VALUES 
/* funcionalidades del administrador */
(1,1),
(1,2),
(1,3),
(1,4),
(1,5),
(1,6),
(1,7),
(1,8),
(1,9),
(1,10),
(1,11),
/* funcionalides del administrativo */
(2,2),
(2,3),
(2,5),
(2,7),
(2,11),
/* funcionalides del afiliado */
(3,5),
(3,6),
(3,9),
/* funcionalides del profesional */
(4,4),
(4,8),
(4,9),
(4,10)

/***************************************************************************************/

/* ASIGNACION DE ROLES A CADA USUARIO */

INSERT INTO BUGDEVELOPING.USUARIO_ROL
(USUARIO_ID, ROL_ID)

VALUES
/* Roles del Administrador*/
(1,1),
(1,2),
(1,3),
(1,4),
/* Roles del Administrativo*/
(2,2),
/* Roles del Afiliado*/
(3,3),
/* Roles del Profesional*/
(4,4)

/* CREO EL AFILIADO PARA LOGIN */

INSERT INTO BUGDEVELOPING.PERSONA (PE_NOMBRE, PE_APELLIDO, PE_DIRECCION, PE_TELEFONO, PE_MAIL, PE_SEXO, PE_FECHA_NAC, PE_TIPO_DOC, PE_NUM_DOC, PE_USUARIO_ID)
	VALUES ('Andres', 'Lopez', 'Av. Corrientes 1532', 1149852535, 'andres.lopez@gmail.com', 'M', '1986-05-24', 'DNI', 31251445, 3);

INSERT INTO BUGDEVELOPING.PACIENTE (PA_PERSONA, PA_ESTADO_CIVIL, PA_NAFILIADO, PA_CANTIDAD_ASIGNADO, PA_PLAN, PA_ACTIVO)
    VALUES((SELECT PE_ID FROM BUGDEVELOPING.PERSONA WHERE PE_NUM_DOC = 31251445 AND PE_NOMBRE = 'Andres' AND PE_APELLIDO = 'Lopez'), 'Soltero', (SELECT MAX(PA_NAFILIADO) + 10 FROM BUGDEVELOPING.PACIENTE), 0, 555555, 1)

/***************************************************************************************/

/* CREO EL PROFESIONAL PARA LOGIN */

INSERT INTO BUGDEVELOPING.PERSONA (PE_NOMBRE, PE_APELLIDO, PE_DIRECCION, PE_TELEFONO, PE_MAIL, PE_SEXO, PE_FECHA_NAC, PE_TIPO_DOC, PE_NUM_DOC, PE_USUARIO_ID)
	VALUES ('Rodrigo', 'Petraca', 'Av. Rivadavia 4532', 1159441133, 'dr.rodrigo.petraca@hotmail.com', 'M', '1966-10-10', 'DNI', 15625148, 4)

INSERT INTO BUGDEVELOPING.MEDICO (ME_PERSONA, ME_MATRICULA, ME_ACTIVO)
	VALUES ((SELECT PE_ID FROM BUGDEVELOPING.PERSONA WHERE PE_NUM_DOC = 15625148 AND PE_NOMBRE = 'Rodrigo' AND PE_APELLIDO = 'Petraca'), 1525628, 1)
	
/*ASIGNO ESPECIALIDAD AL PROFESIONAL*/

INSERT INTO BUGDEVELOPING.ESPECIALIDAD_MEDICO (em_especialidad, em_medico)
	VALUES(10037, 7455)/* asigno Oftalmología */	
	
/*************************************************** CREACION TIPOS CANCELACION ******************************************************************/

INSERT INTO BUGDEVELOPING.TIPO_CANCELACION (tc_descripcion) VALUES ('CANCELADO POR PROFESIONAL'),('CANCELADO POR AFILIADO'),('CANCELADO POR BAJA DEL PROFESIONAL'),('CANCELADO POR BAJA DEL AFILIADO');

/* INICIO DE LOS DROPS - BORRA PROCEDIMIENTOS Y VISTAS CREADAS - */
/* DROPS DE LOS PROCEDURES */

DROP PROCEDURE BUGDEVELOPING.MIGRAR_PERSONA
GO

DROP PROCEDURE BUGDEVELOPING.MIGRAR_PLAN_MEDICO
GO

DROP PROCEDURE BUGDEVELOPING.MIGRAR_PACIENTE
GO

DROP PROCEDURE BUGDEVELOPING.MIGRAR_MEDICO
GO

DROP PROCEDURE BUGDEVELOPING.MIGRAR_TIPO_ESPECIALIDAD
GO

DROP PROCEDURE BUGDEVELOPING.MIGRAR_ESPECIALIDAD
GO

DROP PROCEDURE BUGDEVELOPING.MIGRAR_ESPECIALIDAD_MEDICO
GO

DROP PROCEDURE BUGDEVELOPING.MIGRAR_BONO
GO

DROP PROCEDURE BUGDEVELOPING.MIGRAR_BONO_CONSULTA
GO

DROP PROCEDURE BUGDEVELOPING.MIGRAR_BONO_FARMACIA
GO

DROP PROCEDURE BUGDEVELOPING.MIGRAR_CONSULTA
GO

DROP PROCEDURE BUGDEVELOPING.MIGRAR_TURNO
GO

DROP PROCEDURE BUGDEVELOPING.MIGRAR_AGENDA_PERSONAL
GO

DROP PROCEDURE BUGDEVELOPING.MIGRAR_MEDICAMENTOS
GO

DROP PROCEDURE BUGDEVELOPING.MIGRAR_RECETA_MEDICA
GO

DROP PROCEDURE BUGDEVELOPING.MIGRAR_MEDICAMENTOS_X_RECETA
GO

DROP PROCEDURE BUGDEVELOPING.MIGRAR_COMPRA
GO

DROP PROCEDURE BUGDEVELOPING.MIGRAR_COMPRA_BONO
GO

DROP PROCEDURE BUGDEVELOPING.MIGRAR_DIA
GO


/* DROPS DE LAS VISTAS */ 

DROP VIEW BUGDEVELOPING.V_HorariosMedicos_AUX
GO

DROP VIEW BUGDEVELOPING.V_MEDICO_AUX
GO

DROP VIEW BUGDEVELOPING.V_MEDICO_ESPECIALIDAD_AUX
GO

DROP VIEW BUGDEVELOPING.V_PACIENTE_AUX
GO

DROP VIEW BUGDEVELOPING.V_PERSONAS_AUX
GO

DROP VIEW BUGDEVELOPING.V_COMPRA_BONO_AUX
GO

/* FIN DE LOS DROPS */