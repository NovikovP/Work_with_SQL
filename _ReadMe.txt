Примеры работы с SQL

1. FireBirdAndInterBase - взаимодействиe различных приложений написанных на .NET с базами данных FireBird и InterBase
	чтобы подключиться к базе данных нам потребуется Коннектор: «FirebirdClient-2.5.0-Alpha2.msi» — возможно есть новее.
	После установки в Program Files появится папочка FirebirdClient 2.0 — в ней лежат необходимые библиотеки.
	Добавляем оттуда в наш проект через «Add Reference» библиотеку: FirebirdSql.Data.FirebirdClient.dll
	FirebirdClient-2.5.0-Alpha2.msi — проверял работает как с FireBird так и с InterBase замечательно работает.

2. MySQLConnection - класс для работы с MySQL
	Класс Sqlishe содержит две функции run_mysql — которая предназначена для выполнения запросов типа INSERT, UPDATE 
	и DELETE — и вернёт 0 либо 1 в зависимости от результатов действия, run_mysql_return — которая предназначена для
	выполнения запросов SELECT — для поиска единственного значения и вернёт 0 либо значение.
	Использовать функцию можно в любой части кода, не заморачиваясь на прописывания коннектов и т.п. вот так:
	string parama = Sqlishe.run_mysql_return("select ostatok from cards where articul='0001'");

3. MySQLLib -пример более совершенного класса для работы с базой данных.
	Смысл как и прежде в минимизации кода и приведения его (кода) в более удобочитаемый вид.
	В примере ниже, в отдельном классе реализованы не только методы выполняющие запросы 
	типа (Scalar и NonQuery) но и метод возвращающий набор данных в DataTable. При этом продумана обработка 
	исключительных ситуаций.
	Пример использования:
	MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
	result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset("select * from table_name", "Database=base;Data Source=localhost;User Id=root;Password=pass");

            if (result.HasError == false)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = result.ResultData.DefaultView;
            }
            else
            {
                MessageBox.Show(result.ErrorText);
            }

	как используя этот класс вывести данные в несколько textbox(ов).
	к примеру есть запрос, SELECT fio,adress,info FROM users WHERE id='10'
	Вот так:
	//Проверяем есть ли в выборке вообще хоть что-то?
	if (result.ResultData.DefaultView.Table.Rows.Count > 0)
	{
	  //Помещаем значения в текстовые поля.
	  textbox_fio.Text = result.ResultData.DefaultView.Table.Rows[0]["fio"].ToString();
	  textbox_adress.Text = result.ResultData.DefaultView.Table.Rows[0]["adress"].ToString();
	  textbox_info.Text = result.ResultData.DefaultView.Table.Rows[0]["info"].ToString();
	}

	можно делать и вставку, изменение, и удаление позиций, для этого есть метод:
	MySqlLib.MySqlData.MySqlExecute.SqlNoneQuery
	Вот, пример того как заставить его работать:
	MySqlLib.MySqlData.MySqlExecute.MyResult result = new MySqlLib.MySqlData.MySqlExecute.MyResult();
            result = MySqlLib.MySqlData.MySqlExecute.SqlNoneQuery("insert into table (field1, field2) values ('value1','value2')", "Database=inventar_alleya;Data Source=localhost;User Id=root;Password=240580");     
            if (result.HasError == false)
            {
                MessageBox.Show("Запрос успешно выполнен!");
            }
            else
            {
                MessageBox.Show(result.ErrorText);
            }

