using System;
using SQLite;

namespace auladesabado
{
	public interface ISQLiteService
	{

		SQLiteConnection GetConnection(string databaseName);

		long GetSize(string databaseName);

	}
}
