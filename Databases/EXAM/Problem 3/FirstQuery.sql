SELECT 
    [Project1].[C2] AS [FullName], 
    [Project1].[YearSalary] AS [YearSalary]
    FROM ( SELECT 
        [Extent1].[YearSalary] AS [YearSalary], 
        1 AS [C1], 
        [Extent1].[FirstName] + N' ' + [Extent1].[LastName] AS [C2]
        FROM [dbo].[Employees] AS [Extent1]
        WHERE (cast(100000 as decimal(18)) <= [Extent1].[YearSalary]) AND ([Extent1].[YearSalary] <= cast(150000 as decimal(18)))
    )  AS [Project1]
    ORDER BY [Project1].[YearSalary] ASC