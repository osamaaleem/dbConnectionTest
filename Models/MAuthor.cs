using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dbConnectionTest.Models
{
    public class MAuthor
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public char Gender { set; get; }
        public string BookName { set; get; }
        public int BookPrice { set; get; }
        public string BookType { set; get; }
        public List<SelectListItem> BookTypeList()
        {
            List<SelectListItem> bookType = new List<SelectListItem>();
            bookType.Add(new SelectListItem { Text ="Poetry", Value ="Poetry" });
            bookType.Add(new SelectListItem { Text = "Science Fiction", Value ="Fiction" });
            bookType.Add(new SelectListItem { Text = "Short Story", Value = "Story" });
            return bookType;
        }
        public string Publisher { set; get; }
        public int PublishYear { set; get; }
        public int InsertToDb(MAuthor mAuthor)
        {
            int rowEffected;
            string dbConnection = @"data source = OSAMA-PC\SQLEXPRESS; initial catalog = TestDB; integrated security = True";
            SqlConnection con = new SqlConnection(dbConnection);
            con.Open();
            string query = "INSERT INTO dbo.author (name, age, gender, bookName, bookPrice, bookType, publisher, publishYear) VALUES('"+mAuthor.Name+"','"+mAuthor.Age+"','"+mAuthor.Gender+"','"+mAuthor.BookName+"','"+mAuthor.BookPrice+"','"+mAuthor.BookType+"','"+mAuthor.Publisher+"','"+mAuthor.PublishYear+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            rowEffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowEffected;
        }
    }
}







