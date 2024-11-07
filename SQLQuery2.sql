SELECT name FROM sys.databases;

USE [master];
GO
SELECT * FROM sys.server_principals WHERE name = 'DESKTOP-UTV51JK\Admin';

USE [scholarly_student]; -- Switch to your database
GO

-- Create user for the Windows login
CREATE USER [DESKTOP-UTV51JK\Admin] FOR LOGIN [DESKTOP-UTV51JK\Admin];
GO

-- Grant db_owner role to the user
ALTER ROLE db_owner ADD MEMBER [DESKTOP-UTV51JK\Admin];
GO

SELECT * FROM sys.server_principals WHERE name = 'DESKTOP-UTV51JK\Admin';

USE [scholarly_student]; -- Replace with your database name
GO

CREATE USER [DESKTOP-UTV51JK\Admin] FOR LOGIN [DESKTOP-UTV51JK\Admin];
GO

ALTER ROLE db_owner ADD MEMBER [DESKTOP-UTV51JK\Admin];
GO