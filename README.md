# AreaMath
## Задание 1
### ТЗ
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
Дополнительно, но не обязательно: Юнит-тесты; Легкость добавления других фигур; Вычисление площади фигуры без знания типа фигуры в compile-time; Проверка на то, является ли треугольник прямоугольным
### Реализация
В проекте SDK содержится базовая логика. Класс PointFigure демонстрирует возможность расширения библиотеки. Класс AMath больше предназначен для будущего расширения (пояснения даны в комментариях к классу).

## Задание 2
### ТЗ
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться. Примеры использования содержатся в проекте Unit.

### Релизация
Созданы и заполнены минималистичные таблицы. Реализация содержится в SQL.txt в корне репозитория.
