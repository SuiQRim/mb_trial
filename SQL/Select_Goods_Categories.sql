SELECT g.Name, c.Name
FROM Goods AS g
LEFT JOIN Goods_Categories AS gc
	ON gc.GoodId = g.Id
LEFT JOIN Categories AS c
	ON c.Id = gc.CategoryId