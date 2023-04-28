USE [School]
GO
/****** Object:  Table [dbo].[Clase]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clase](
	[ClaseId] [int] IDENTITY(1,1) NOT NULL,
	[SchoolId] [int] NOT NULL,
	[Clase_Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CourseId] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [varchar](50) NOT NULL,
	[SchoolId] [int] NOT NULL,
	[Descripcion] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[GradeId] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NOT NULL,
	[CourseId] [int] NOT NULL,
	[Grade] [float] NOT NULL,
	[Comment] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[GradeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[School]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[School](
	[SchoolId] [int] IDENTITY(1,1) NOT NULL,
	[id] [int] NOT NULL,
	[SchoolName] [varchar](50) NOT NULL,
	[Descripcion] [varchar](1000) NULL,
	[Direccion] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[SchoolId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[ClaseId] [int] NOT NULL,
	[Student_Name] [varchar](100) NOT NULL,
	[Student_Number] [varchar](20) NOT NULL,
	[Total_Grade] [float] NULL,
	[Direccion] [varchar](100) NULL,
	[Telefono] [varchar](20) NULL,
	[EMail] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student_Course]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Course](
	[StudentId] [int] NOT NULL,
	[CourseId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[TeacherId] [int] IDENTITY(1,1) NOT NULL,
	[SchoolId] [int] NOT NULL,
	[TeacherName] [varchar](50) NOT NULL,
	[Descripcion] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher_Course]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher_Course](
	[TeacherId] [int] NOT NULL,
	[CourseId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[clave] [varchar](100) NOT NULL,
 CONSTRAINT [Pk_ID] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_EMAIL] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Clase]  WITH CHECK ADD  CONSTRAINT [FK_SchoolId] FOREIGN KEY([SchoolId])
REFERENCES [dbo].[School] ([SchoolId])
GO
ALTER TABLE [dbo].[Clase] CHECK CONSTRAINT [FK_SchoolId]
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [Fk_SchoolId1] FOREIGN KEY([SchoolId])
REFERENCES [dbo].[School] ([SchoolId])
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [Fk_SchoolId1]
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD  CONSTRAINT [Fk_CourseId2] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([CourseId])
GO
ALTER TABLE [dbo].[Grade] CHECK CONSTRAINT [Fk_CourseId2]
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD  CONSTRAINT [Fk_StudentId1] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[Grade] CHECK CONSTRAINT [Fk_StudentId1]
GO
ALTER TABLE [dbo].[School]  WITH CHECK ADD  CONSTRAINT [FK_id] FOREIGN KEY([id])
REFERENCES [dbo].[usuario] ([id])
GO
ALTER TABLE [dbo].[School] CHECK CONSTRAINT [FK_id]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [Fk_ClaseId] FOREIGN KEY([ClaseId])
REFERENCES [dbo].[Clase] ([ClaseId])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [Fk_ClaseId]
GO
ALTER TABLE [dbo].[Student_Course]  WITH CHECK ADD  CONSTRAINT [Fk_CourseId] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([CourseId])
GO
ALTER TABLE [dbo].[Student_Course] CHECK CONSTRAINT [Fk_CourseId]
GO
ALTER TABLE [dbo].[Student_Course]  WITH CHECK ADD  CONSTRAINT [Fk_StudentId] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[Student_Course] CHECK CONSTRAINT [Fk_StudentId]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [Fk_SchoolId2] FOREIGN KEY([SchoolId])
REFERENCES [dbo].[School] ([SchoolId])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [Fk_SchoolId2]
GO
ALTER TABLE [dbo].[Teacher_Course]  WITH CHECK ADD  CONSTRAINT [Fk_CourseId1] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([CourseId])
GO
ALTER TABLE [dbo].[Teacher_Course] CHECK CONSTRAINT [Fk_CourseId1]
GO
ALTER TABLE [dbo].[Teacher_Course]  WITH CHECK ADD  CONSTRAINT [Fk_TeacherId] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teacher] ([TeacherId])
GO
ALTER TABLE [dbo].[Teacher_Course] CHECK CONSTRAINT [Fk_TeacherId]
GO
/****** Object:  StoredProcedure [dbo].[sp_BorrarClase]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_BorrarClase]

@id int

as
begin 
Delete Clase where ClaseId = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_BorrarCourse]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_BorrarCourse]

@id int

as
begin 
Delete Course where CourseId = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_BorrarGrade]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_BorrarGrade]

@id int

as
begin 
Delete Grade where GradeId = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_borrarSchool]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_borrarSchool]

@id int

as
begin 
Delete School where SchoolId = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_BorrarStudent]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_BorrarStudent]

@id int

as
begin 
Delete Student where StudentId = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_BorrarTeacher]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_BorrarTeacher]

@id int

as
begin 
Delete Teacher where TeacherId = @id
end
GO
/****** Object:  StoredProcedure [dbo].[SP_IngresarClase]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_IngresarClase]

@SchoolId int,
@Clase_Nombre varchar (50),
@Descripcion varchar (1000)
as 
begin
insert into Clase(SchoolId,Clase_Nombre,Descripcion) values (@SchoolId,@Clase_Nombre, @Descripcion)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_IngresarCourse]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_IngresarCourse]

@SchoolId int,
@CourseName varchar (50),
@Descripcion varchar (1000)

as 
begin
insert into Course(SchoolId,CourseName,Descripcion ) values (@SchoolId,@CourseName, @Descripcion)
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_IngresarGrade]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_IngresarGrade]

@StudentId int,
@CourseId int,
@Grade float,
@Comment varchar (1000)

as 
begin
insert into Grade(StudentId,CourseId,Grade,Comment ) values (@StudentId,@CourseId,@Grade,@Comment)
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_IngresarSchool]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_IngresarSchool]

@id int,
@SchoolName varchar (50),
@Descripcion varchar (1000),
@Direccion varchar(50),
@Telefono varchar(50)
as 
begin
insert into School(id,SchoolName,Descripcion,Direccion,Telefono) values (@id,@SchoolName, @Descripcion,@Direccion,@Telefono)
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_IngresarStudent]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_IngresarStudent]

@ClaseId int,
@Student_Name varchar (50),
@Student_Number varchar (20),
@Total_Grade float,
@Direccion varchar(100),
@Telefono varchar(20),
@Email varchar(100)
as 
begin
insert into Student(ClaseId,Student_Name,Student_Number,Total_Grade,Direccion,Telefono,Email ) values (@ClaseId,@Student_Name, @Student_Number,@Total_Grade,@Direccion,@Telefono,@Email)
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_IngresarTeacher]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_IngresarTeacher]

@SchoolId int,
@TeacherName varchar (50),
@Descripcion varchar (1000)

as 
begin
insert into Teacher(SchoolId,TeacherName,Descripcion ) values (@SchoolId,@TeacherName,@Descripcion)
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_ListadoClase]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_ListadoClase]

as 
begin 
select * from Clase
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_Listadocourse]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Listadocourse]

as 
begin 
select * from Course
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_ListadoGrade]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ListadoGrade]

as 
begin 
select * from Grade
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_ListadoSchool]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ListadoSchool]

as 
begin 
select * from School
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_ListadoStudent]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ListadoStudent]

as 
begin 
select * from Student
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_ListadoTeacher]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ListadoTeacher]

as 
begin 
select * from Teacher
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_ModificarSchool]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ModificarSchool]
@SchoolId int,
@id int,
@SchoolName varchar (50),
@Descripcion varchar (1000),
@Direccion varchar(50),
@Telefono varchar(50)
as 
begin
update School set id = @id, SchoolName = @SchoolName, Descripcion = @Descripcion,Direccion = @Descripcion ,Telefono = @Telefono  where SchoolId = @SchoolId
end
GO
/****** Object:  StoredProcedure [dbo].[ValidarLogin]    Script Date: 27/04/2023 09:59:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[ValidarLogin]

@email varchar (100) = '',
@clave varchar (100) = ''

as 
begin
select email, clave from usuario where email=@email and clave =@clave
end 
GO
