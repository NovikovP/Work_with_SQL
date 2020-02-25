������� ������ � SQL

1. FireBirdAndInterBase - �������������e ��������� ���������� ���������� �� .NET � ������ ������ FireBird � InterBase
	����� ������������ � ���� ������ ��� ����������� ���������: �FirebirdClient-2.5.0-Alpha2.msi� � �������� ���� �����.
	����� ��������� � Program Files �������� ������� FirebirdClient 2.0 � � ��� ����� ����������� ����������.
	��������� ������ � ��� ������ ����� �Add Reference� ����������: FirebirdSql.Data.FirebirdClient.dll
	FirebirdClient-2.5.0-Alpha2.msi � �������� �������� ��� � FireBird ��� � � InterBase ������������ ��������.

2. MySQLConnection - ����� ��� ������ � MySQL
	����� Sqlishe �������� ��� ������� run_mysql � ������� ������������� ��� ���������� �������� ���� INSERT, UPDATE 
	� DELETE � � ����� 0 ���� 1 � ����������� �� ����������� ��������, run_mysql_return � ������� ������������� ���
	���������� �������� SELECT � ��� ������ ������������� �������� � ����� 0 ���� ��������.
	������������ ������� ����� � ����� ����� ����, �� ������������� �� ������������ ��������� � �.�. ��� ���:
	string parama = Sqlishe.run_mysql_return("select ostatok from cards where articul='0001'");

3. MySQLLib -������ ����� ������������ ������ ��� ������ � ����� ������.
	����� ��� � ������ � ����������� ���� � ���������� ��� (����) � ����� ������������� ���.
	� ������� ����, � ��������� ������ ����������� �� ������ ������ ����������� ������� 
	���� (Scalar � NonQuery) �� � ����� ������������ ����� ������ � DataTable. ��� ���� ��������� ��������� 
	�������������� ��������.
	������ �������������:
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

	��� ��������� ���� ����� ������� ������ � ��������� textbox(��).
	� ������� ���� ������, SELECT fio,adress,info FROM users WHERE id='10'
	��� ���:
	//��������� ���� �� � ������� ������ ���� ���-��?
	if (result.ResultData.DefaultView.Table.Rows.Count > 0)
	{
	  //�������� �������� � ��������� ����.
	  textbox_fio.Text = result.ResultData.DefaultView.Table.Rows[0]["fio"].ToString();
	  textbox_adress.Text = result.ResultData.DefaultView.Table.Rows[0]["adress"].ToString();
	  textbox_info.Text = result.ResultData.DefaultView.Table.Rows[0]["info"].ToString();
	}

	����� ������ � �������, ���������, � �������� �������, ��� ����� ���� �����:
	MySqlLib.MySqlData.MySqlExecute.SqlNoneQuery
	���, ������ ���� ��� ��������� ��� ��������:
	MySqlLib.MySqlData.MySqlExecute.MyResult result = new MySqlLib.MySqlData.MySqlExecute.MyResult();
            result = MySqlLib.MySqlData.MySqlExecute.SqlNoneQuery("insert into table (field1, field2) values ('value1','value2')", "Database=inventar_alleya;Data Source=localhost;User Id=root;Password=240580");     
            if (result.HasError == false)
            {
                MessageBox.Show("������ ������� ��������!");
            }
            else
            {
                MessageBox.Show(result.ErrorText);
            }

