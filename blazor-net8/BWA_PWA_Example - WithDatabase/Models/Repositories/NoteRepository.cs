using BWA_PWA_Example.Pages;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace BWA_PWA_Example.Models.Repositories
{


    using Dapper;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Threading.Tasks;

    public class NoteRepository
    {
        private readonly string _connectionString;

        public NoteRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<Note>> GetAllNotesAsync()
        {
            using IDbConnection dbConnection = new SqlConnection(_connectionString);
             dbConnection.Open();
            return await dbConnection.QueryAsync<Note>("SELECT * FROM Notes");
        }

        public async Task AddNoteAsync(Note note)
        {
            using IDbConnection dbConnection = new SqlConnection(_connectionString);
             dbConnection.Open();
            await dbConnection.ExecuteAsync("INSERT INTO Notes (Content) VALUES (@Content)", new { note.Content });
        }
    }

}
