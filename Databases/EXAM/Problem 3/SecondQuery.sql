SELECT 
    [Project2].[DepartmentId] AS [DepartmentId], 
    [Project2].[Name] AS [Name], 
    [Project2].[C2] AS [EmployeesCount]
    FROM ( SELECT 
        [Project1].[DepartmentId] AS [DepartmentId], 
        [Project1].[Name] AS [Name], 
        [Project1].[C1] AS [C1], 
        (SELECT 
            COUNT(1) AS [A1]
            FROM [dbo].[Employees] AS [Extent3]
            WHERE [Project1].[DepartmentId] = [Extent3].[DepartmentId]) AS [C2]
        FROM ( SELECT 
            [Extent1].[DepartmentId] AS [DepartmentId], 
            [Extent1].[Name] AS [Name], 
            (SELECT 
                COUNT(1) AS [A1]
                FROM [dbo].[Employees] AS [Extent2]
                WHERE [Extent1].[DepartmentId] = [Extent2].[DepartmentId]) AS [C1]
            FROM [dbo].[Departments] AS [Extent1]
        )  AS [Project1]
    )  AS [Project2]
    ORDER BY [Project2].[C1] DESC