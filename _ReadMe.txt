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

3. 