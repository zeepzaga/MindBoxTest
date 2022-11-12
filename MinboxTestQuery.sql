USE TestBase
SELECT ProductName, CategoryName FROM CategoryProduct 
RIGHT JOIN Product ON Product.ProductId = CategoryProduct.ProductId
LEFT JOIN Category ON Category.CategoryId = CategoryProduct.CategoryId