Примеры работы с SQL

1. FireBirdAndInterBase - взаимодействиe различных приложений написанных на .NET с базами данных FireBird и InterBase
	чтобы подключиться к базе данных нам потребуется Коннектор: «FirebirdClient-2.5.0-Alpha2.msi» — возможно есть новее.
	После установки в Program Files появится папочка FirebirdClient 2.0 — в ней лежат необходимые библиотеки.
	Добавляем оттуда в наш проект через «Add Reference» библиотеку: FirebirdSql.Data.FirebirdClient.dll
	FirebirdClient-2.5.0-Alpha2.msi — проверял работает как с FireBird так и с InterBase замечательно работает.

2. 