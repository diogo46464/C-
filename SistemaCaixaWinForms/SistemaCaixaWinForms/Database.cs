using Microsoft.Data.Sqlite;
using System;
using System.IO;

public static class Database {
    private static string dbPath = "caixa.db";

    public static SqliteConnection GetConnection() {
        return new SqliteConnection($"Data Source={dbPath}");
    }

public static void CriarTabelas() {
        using var connection = GetConnection();
        connection.Open();

        var cmd = connection.CreateCommand();

        cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Transacoes (
                      id INTEGER PRIMARY KEY AUTOINCREMENT,
                      Tipo TEXT NOT NULL,
                      Valor REAL NOT NULL,
                      Descricao TEXT,
                      Data DATE NOT NULL


           ) ;

                CREATE TABLE IF NOT EXISTS Cobrancas (
                      Id INTEGER PRIMARY KEY AUTOINCREMENT,
                      Cliente TEXT,
                      Valor REAL NOT NULL,
                      DataVencimento DATE NOT NULL,
                      Pago BOOLEAN DEFAULT 0
           );
        ";
        cmd.ExecuteNonQuery();
    }
}
