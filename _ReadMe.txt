ѕримеры работы с SQL

1. FireBirdAndInterBase - взаимодействиe различных приложений написанных на .NET с базами данных FireBird и InterBase
	чтобы подключитьс€ к базе данных нам потребуетс€  оннектор: ЂFirebirdClient-2.5.0-Alpha2.msiї Ч возможно есть новее.
	ѕосле установки в Program Files по€витс€ папочка FirebirdClient 2.0 Ч в ней лежат необходимые библиотеки.
	ƒобавл€ем оттуда в наш проект через ЂAdd Referenceї библиотеку: FirebirdSql.Data.FirebirdClient.dll
	FirebirdClient-2.5.0-Alpha2.msi Ч провер€л работает как с FireBird так и с InterBase замечательно работает.

2. MySQLConnection - класс дл€ работы с MySQL
	 ласс Sqlishe содержит две функции run_mysql Ч котора€ предназначена дл€ выполнени€ запросов типа INSERT, UPDATE 
	и DELETE Ч и вернЄт 0 либо 1 в зависимости от результатов действи€, run_mysql_return Ч котора€ предназначена дл€
	выполнени€ запросов SELECT Ч дл€ поиска единственного значени€ и вернЄт 0 либо значение.
	»спользовать функцию можно в любой части кода, не заморачива€сь на прописывани€ коннектов и т.п. вот так:
	string parama = Sqlishe.run_mysql_return("select ostatok from cards where articul='0001'");

3. 