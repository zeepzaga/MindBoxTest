# C# Задача про площади треугольника и круга

Не совсем понял этот пункт:
- Вычисление площади фигуры без знания типа фигуры в compile-time

## Получить площадь фигуры:
Для всех фигур (и для тех которые можно добавить в будущем) используется метод `GetArea`, который возвращает площадь фигур. 

*Для круга pi\*R^2, для треугольника "Формула Герона".*
## Круг: 
```
var circle = new Circle(radius);
```
Где `radius` — значение радиуса круга
## Треугольник: 
```
var triangle = new Triangle(aSide, bSide, cSide);
```
### Проверка на то, является ли треугольник прямоугольным
Для проверки является ли треугольник прямоугольным используется метод `IsTriangleRectangular()`

Где `aSide` — значение первой стороны треугольника, `bSide` и `cSide`, соответсвенно, значения второй и третьей стороны.
# SQL Задача
- InicializationTestBase — запрос на создание тестовой БД, таблицы и данные

- MinboxTestQuery — запрос с ответом на задачу
## Для удобства выведу запрос с ответом на задачу в readme:
```
SELECT ProductName, CategoryName FROM CategoryProduct 
RIGHT JOIN Product ON Product.ProductId = CategoryProduct.ProductId
LEFT JOIN Category ON Category.CategoryId = CategoryProduct.CategoryId
```

 

