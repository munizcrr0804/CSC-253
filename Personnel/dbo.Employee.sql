CREATE TABLE [dbo].[Employee] (
    [EmployeeId]    INT        NOT NULL,
    [Name]          NCHAR (24) NOT NULL,
    [Position]      NCHAR (20) NOT NULL,
    [HourlyPayRate] NCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([EmployeeId] ASC)
);

