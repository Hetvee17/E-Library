using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BookManagement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private const string ConnectionString = @"Data Source=LAPTOP-VL1LT548\SQLEXPRESS;Initial Catalog=elibraryDB;Integrated Security=true";

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string Insert(InsertBook book)
        {
            string msg;
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO book_master_tbl(book_id,book_name,genre,author_name,publisher_name,publish_date,language,edition,book_cost,no_of_pages,book_description,actual_stock,current_stock,book_img_link) values(@book_id,@book_name,@genre,@author_name,@publisher_name,@publish_date,@language,@edition,@book_cost,@no_of_pages,@book_description,@actual_stock,@current_stock,@book_img_link)", con);
                cmd.Parameters.AddWithValue("@book_id", book.Id);
                cmd.Parameters.AddWithValue("@book_name", book.BookName);
                cmd.Parameters.AddWithValue("@genre", book.Genre);
                cmd.Parameters.AddWithValue("@author_name", book.AuthorName);
                cmd.Parameters.AddWithValue("@publisher_name", book.PublisherName);
                cmd.Parameters.AddWithValue("@publish_date", book.PublishDate);
                cmd.Parameters.AddWithValue("@language", book.Language);
                cmd.Parameters.AddWithValue("@edition", book.Edition);
                cmd.Parameters.AddWithValue("@book_cost", book.BookCost);
                cmd.Parameters.AddWithValue("@no_of_pages", book.Pages);
                cmd.Parameters.AddWithValue("@book_description", book.BookDescription);
                cmd.Parameters.AddWithValue("@actual_stock", book.ActualStock);
                cmd.Parameters.AddWithValue("@current_stock", book.CurrentStock);
                cmd.Parameters.AddWithValue("@book_img_link", book.BookImage);

                cmd.ExecuteNonQuery();
                con.Close();
                msg = ("<script>alert('Book added Successfully');</script>");

            }
            catch (Exception ex)
            {
                msg = ("<script>alert('" + ex.Message + "');</script>");
            }
            return msg;
        }

        public gettestdata GetInfo()
        {
            gettestdata g = new gettestdata();
            SqlConnection con = new SqlConnection(ConnectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from book_master_tbl where book_id = @book_id");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            g.booktab = dt;
            return g;
        }
        public string Update(UpdateBook book)
        {
            string msg;
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE book_master_tbl set book_name=@book_name, genre=@genre, author_name=@author_name, publisher_name=@publisher_name, publish_date=@publish_date, language=@language, edition=@edition, book_cost=@book_cost, no_of_pages=@no_of_pages, book_description=@book_description, actual_stock=@actual_stock, current_stock=@current_stock, book_img_link=@book_img_link where book_id = @book_id", con);
                cmd.Parameters.AddWithValue("@book_id", book.Id);
                cmd.Parameters.AddWithValue("@book_name", book.BookName);
                cmd.Parameters.AddWithValue("@genre", book.Genre);
                cmd.Parameters.AddWithValue("@author_name", book.AuthorName);
                cmd.Parameters.AddWithValue("@publisher_name", book.PublisherName);
                cmd.Parameters.AddWithValue("@publish_date", book.PublishDate);
                cmd.Parameters.AddWithValue("@language", book.Language);
                cmd.Parameters.AddWithValue("@edition", book.Edition);
                cmd.Parameters.AddWithValue("@book_cost", book.BookCost);
                cmd.Parameters.AddWithValue("@no_of_pages", book.Pages);
                cmd.Parameters.AddWithValue("@book_description", book.BookDescription);
                cmd.Parameters.AddWithValue("@actual_stock", book.ActualStock);
                cmd.Parameters.AddWithValue("@current_stock", book.CurrentStock);
                cmd.Parameters.AddWithValue("@book_img_link", book.BookImage);
                cmd.ExecuteNonQuery();
                con.Close();
                msg = ("<script>alert('Book updated Successfully');</script>");
            }
            catch (Exception ex)
            {
                msg = ("<script>alert('" + ex.Message + "');</script>");
            }
            return msg;
        }
    }
}
