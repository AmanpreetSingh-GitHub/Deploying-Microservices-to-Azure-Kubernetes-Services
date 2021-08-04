-- Create database for Master data
CREATE DATABASE [MasterData];
GO

-- Create table for Empployee Status
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EmployeeStatus](
	[StatusId] [int] NOT NULL,
	[Description] [nchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_EmployeeStatus] PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

--Insert data in Employee Status table
INSERT INTO [dbo].[EmployeeStatus]
           ([StatusId], [Description], [IsDeleted])
     VALUES
           (1, 'Active', 0);
INSERT INTO [dbo].[EmployeeStatus]
           ([StatusId], [Description], [IsDeleted])
     VALUES
           (2, 'Inactive', 0);
INSERT INTO [dbo].[EmployeeStatus]
           ([StatusId], [Description], [IsDeleted])
     VALUES
           (3, 'Waiting', 0);
GO
