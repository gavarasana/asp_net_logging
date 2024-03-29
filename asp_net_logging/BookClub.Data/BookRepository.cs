﻿using System.Collections.Generic;
using System.Data;
using System.Linq;
using BookClub.Entities;
using Dapper;
using Microsoft.Extensions.Logging;

namespace BookClub.Data
{
    public class BookRepository : IBookRepository
    {
        private readonly IDbConnection _db;
        private readonly ILogger _logger;

        public BookRepository(IDbConnection db, ILogger<BookRepository> logger)
        {
            _db = db;
            _logger = logger; // loggerFactory.CreateLogger("Database");
        }

        public List<Book> GetAllBooks()
        {
            using (_logger.BeginScope("GetAllBooks: Doing BAD database work"))
            {
                // most beneficial for some kind of db transaction potentially
                _logger.LogInformation("Inside Get all books method in book repository");

                throw new DataException("DB Server not found");
                //var books = _db.Query<Book>("GetAllBooks", commandType: CommandType.StoredProcedure)
                //    .ToList();
                //return books;
            }
            
        }

        public List<Book> GetAllBooksBAD()
        {
            using (_logger.BeginScope("Doing BAD database work"))
            {                
                //_logger.LogDebug(DataEvents.GetMany, "Debugging information for stored proc: {ProcName}", 
                //                 "GetAllBooks");
                _logger.RepoCallGetMany("GetAllBooksBAD");

                var books = _db.Query<Book>("GetAllBooks_DoesNotExist", commandType: CommandType.StoredProcedure)
                    .ToList();
                return books;
            }

        }

        public void SubmitNewBook(Book bookToSubmit, int submitter)
        {
            _db.Execute("InsertBook", new {
                bookToSubmit.Title,
                bookToSubmit.Author,
                bookToSubmit.Classification,
                bookToSubmit.Genre,
                bookToSubmit.Isbn,
                submitter
            }, commandType: CommandType.StoredProcedure);
        }
    }
}
