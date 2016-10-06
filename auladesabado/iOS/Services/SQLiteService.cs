using System;
using SQLite;
using Xamarin.Forms;
using System.IO;

[assembly:Dependency(typeof(auladesabado.iOS.SQLiteService))]
namespace auladesabado.iOS
{
	public class SQLiteService :ISQLiteService

	{

		string GetPath(string dataBaseName)
		{
			if (string.IsNullOrWhiteSpace(dataBaseName))
			{

				throw new ArgumentException("Database inválido", nameof(dataBaseName));
			}

			var sqliteFileName = $"{dataBaseName}.db3";

			var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var libraryPath = Path.Combine(documentPath, "..", "Library");
			var path = Path.Combine(libraryPath, sqliteFileName);

			return path;

		}

		public SQLiteService()
		{
		}

		public SQLiteConnection GetConnection(string databaseName)
		{
			return new SQLiteConnection(GetPath(databaseName));
		}

		public long GetSize(string databaseName)
		{
			var fileInfo =  new FileInfo(databaseName);

			return fileInfo != null ? fileInfo.Length : 0;
		}
	}
}
