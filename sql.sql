SELECT p.Name, c.Name
FROM Products p
FULL JOIN ProductsCategories pc
	ON p.Id = pc.ProductId
FULL JOIN Categories c
	ON pc.CategoryId = c.Id;
ORDER BY p.Name;
