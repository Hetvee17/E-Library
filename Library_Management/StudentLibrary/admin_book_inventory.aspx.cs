using StudentLibrary.ServiceReference1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentLibrary
{
    public partial class admin_book_inventory : System.Web.UI.Page
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        static string global_filepath;
        static int global_actual_stock, global_current_stock, global_issued_books;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string genres = "";
            foreach (int i in ListBox1.GetSelectedIndices())
            {
                genres = genres + ListBox1.Items[i] + ",";
            }
            // genres = Adventure,Self Help,
            genres = genres.Remove(genres.Length - 1);

            string filepath = "~/book_inventory/books1.png";
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(Server.MapPath("book_inventory/" + filename));
            filepath = "~/book_inventory/" + filename;

            InsertBook book = new InsertBook();

            book.Id = TextBox1.Text;
            book.BookName = TextBox2.Text;
            book.Genre = genres;
            book.AuthorName = TextBox13.Text;
            book.PublisherName = TextBox12.Text;
            book.PublishDate = TextBox3.Text;
            book.Language = DropDownList1.SelectedItem.Value;
            book.Edition = TextBox9.Text;
            book.BookCost = TextBox10.Text;
            book.Pages = TextBox11.Text;
            book.BookDescription = TextBox6.Text;
            book.ActualStock = TextBox4.Text;
            book.CurrentStock = TextBox5.Text;
            book.BookImage = filepath;

            string res = client.Insert(book);
            Response.Write("<script>alert('Book added successfully.');</script>");
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int actual_stock = Convert.ToInt32(TextBox4.Text.Trim());
            int current_stock = Convert.ToInt32(TextBox5.Text.Trim());

            if (global_actual_stock == actual_stock)
            {

            }
            else
            {
                if (actual_stock < global_issued_books)
                {
                    Response.Write("<script>alert('Actual Stock value cannot be less than the Issued books');</script>");
                    return;


                }
                else
                {
                    current_stock = actual_stock - global_issued_books;
                    TextBox5.Text = "" + current_stock;
                }
            }

            string genres = "";
            foreach (int i in ListBox1.GetSelectedIndices())
            {
                genres = genres + ListBox1.Items[i] + ",";
            }
            genres = genres.Remove(genres.Length - 1);

            string filepath = "~/book_inventory/books1";
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            if (filename == "" || filename == null)
            {
                filepath = global_filepath;

            }
            else
            {
                FileUpload1.SaveAs(Server.MapPath("book_inventory/" + filename));
                filepath = "~/book_inventory/" + filename;
            }
            UpdateBook book = new UpdateBook();

            book.Id = TextBox1.Text;
            book.BookName = TextBox2.Text;
            book.Genre = genres;
            book.AuthorName = TextBox13.Text;
            book.PublisherName = TextBox12.Text;
            book.PublishDate = TextBox3.Text;
            book.Language = DropDownList1.SelectedItem.Value;
            book.Edition = TextBox9.Text;
            book.BookCost = TextBox10.Text;
            book.Pages = TextBox11.Text;
            book.BookDescription = TextBox6.Text;
            book.ActualStock = TextBox4.Text;
            book.CurrentStock = TextBox5.Text;
            book.BookImage = filepath;

            string res = client.Update(book);
            Response.Write("<script>alert('Book updated successfully.');</script>");
            GridView1.DataBind();
        }
    }
}