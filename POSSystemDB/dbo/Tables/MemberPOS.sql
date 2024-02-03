CREATE TABLE [dbo].[MemberPOS]
(
	MemberId INT PRIMARY KEY,
    FirstName NVARCHAR(255),
    LastName NVARCHAR(255),
    Email NVARCHAR(255),
    PhoneNumber NVARCHAR(50),
    Points INT,
    StartDate DATETIME
)
