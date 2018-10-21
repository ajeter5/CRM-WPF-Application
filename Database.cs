using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Customer_Relationship_Management_Application
{
    class Database
    {
        public static void CreateDatabase()
        {
            #region CommandText
            //SQL Script to drop database if it exists and create or create if it doesn't exist
            string createDBCmd = @"
            IF EXISTS (SELECT * FROM sys.databases WHERE name = 'CRMDatabase')
            begin 
	            EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'CRMDatabase'
	            use [master]
	            ALTER DATABASE [CRMDatabase] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
	            DROP DATABASE [CRMDatabase]
            END

            CREATE DATABASE CRMDatabase;";

            //SQL Script to create the three database tables: Person, Customer, and Prospective Customer
            string createTablesCmd = @"
            CREATE TABLE CRMDatabase.dbo.Person
            (ID INT IDENTITY(1,1) PRIMARY KEY,
            Name VARCHAR(MAX),
            Age INT,
            Gender VARCHAR(MAX),
            Email VARCHAR(MAX))

            CREATE TABLE CRMDatabase.dbo.Customer
            (ID INT IDENTITY(1,1) PRIMARY KEY,
            Name VARCHAR(MAX),
            Age INT,
            Gender VARCHAR(MAX),
            Email VARCHAR(MAX),
            CustomerStatus VARCHAR(MAX));

            ALTER TABLE CRMDatabase.dbo.Customer ADD CONSTRAINT [FK_CustomerId] FOREIGN KEY([ID])
            REFERENCES CRMDatabase.dbo.Person ([ID])

            CREATE TABLE CRMDatabase.dbo.Prospect
            (ID INT IDENTITY(1,1) PRIMARY KEY,
            Name VARCHAR(MAX),
            Age INT,
            Gender VARCHAR(MAX),
            Email VARCHAR(MAX),
            CommunicationChannel VARCHAR(MAX))

            ALTER TABLE CRMDatabase.dbo.Prospect ADD CONSTRAINT [FK_ProspectId] FOREIGN KEY([ID])
            REFERENCES CRMDatabase.dbo.Person ([ID])";
            #endregion CommandText

            SqlConnection connection = new SqlConnection("Server=localhost;Database=;Trusted_Connection=True;");
            connection.Open();

            //Create sql commands for DB and Tables create
            SqlCommand createDBCommand = new SqlCommand(createDBCmd, connection);
            SqlCommand createTablesCommand = new SqlCommand(createTablesCmd, connection);

            //Create CRMDatabase if it doesn't exist
            //Drop CRMDatabase if it exists and create CRMDatabase and tables
            using (connection)
            {
                createDBCommand.ExecuteNonQuery();
                createTablesCommand.ExecuteNonQuery();
            }
        }
    }
}
