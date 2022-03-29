using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BookManagement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string Insert(InsertBook book);

        //[OperationContract]
        //DataSet Getbook(string book_id);

        [OperationContract]
        string Update(UpdateBook book);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "BookManagement.ContractType".
    [DataContract]
    public class InsertBook
    {
        string book_id = string.Empty;
        string book_name = string.Empty;
        string genre = string.Empty;
        string author_name = string.Empty;
        string publisher_name = string.Empty;
        string publish_date = string.Empty;
        string language = string.Empty;
        string edition = string.Empty;
        string book_cost = string.Empty;
        string no_of_pages = string.Empty;
        string book_description = string.Empty;
        string actual_stock = string.Empty;
        string current_stock = string.Empty;
        string book_img_link = string.Empty;


        [DataMember]
        public string Id
        {
            get { return book_id; }
            set { book_id = value; }
        }

        [DataMember]
        public string BookName
        {
            get { return book_name; }
            set { book_name = value; }
        }

        [DataMember]
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        [DataMember]
        public string AuthorName
        {
            get { return author_name; }
            set { author_name = value; }
        }

        [DataMember]
        public string PublisherName
        {
            get { return publisher_name; }
            set { publisher_name = value; }
        }

        [DataMember]
        public string PublishDate
        {
            get { return publish_date; }
            set { publish_date = value; }
        }

        [DataMember]
        public string Language
        {
            get { return language; }
            set { language = value; }
        }

        [DataMember]
        public string Edition
        {
            get { return edition; }
            set { edition = value; }
        }

        [DataMember]
        public string BookCost
        {
            get { return book_cost; }
            set { book_cost = value; }
        }

        [DataMember]
        public string Pages
        {
            get { return no_of_pages; }
            set { no_of_pages = value; }
        }

        [DataMember]
        public string BookDescription
        {
            get { return book_description; }
            set { book_description = value; }
        }

        [DataMember]
        public string ActualStock
        {
            get { return actual_stock; }
            set { actual_stock = value; }
        }
        [DataMember]
        public string CurrentStock
        {
            get { return current_stock; }
            set { current_stock = value; }
        }

        [DataMember]
        public string BookImage
        {
            get { return book_img_link; }
            set { book_img_link = value; }
        }
    }

    //[DataContract]
    //public class DataSet
    //{
    //    [DataMember]
    //    public DataSet booktab
    //    {
    //        get;
    //        set;
    //    }
    //}    

    [DataContract]
    public class UpdateBook
    {
        string book_id;
        string book_name;
        string genre;
        string author_name;
        string publisher_name;
        string publish_date;
        string language;
        string edition;
        string book_cost;
        string no_of_pages;
        string book_description;
        string actual_stock;
        string current_stock;
        string book_img_link;

        [DataMember]
        public string Id
        {
            get { return book_id; }
            set { book_id = value; }
        }

        [DataMember]
        public string BookName
        {
            get { return book_name; }
            set { book_name = value; }
        }

        [DataMember]
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        [DataMember]
        public string AuthorName
        {
            get { return author_name; }
            set { author_name = value; }
        }

        [DataMember]
        public string PublisherName
        {
            get { return publisher_name; }
            set { publisher_name = value; }
        }

        [DataMember]
        public string PublishDate
        {
            get { return publish_date; }
            set { publish_date = value; }
        }

        [DataMember]
        public string Language
        {
            get { return language; }
            set { language = value; }
        }

        [DataMember]
        public string Edition
        {
            get { return edition; }
            set { edition = value; }
        }

        [DataMember]
        public string BookCost
        {
            get { return book_cost; }
            set { book_cost = value; }
        }

        [DataMember]
        public string Pages
        {
            get { return no_of_pages; }
            set { no_of_pages = value; }
        }

        [DataMember]
        public string BookDescription
        {
            get { return book_description; }
            set { book_description = value; }
        }

        [DataMember]
        public string ActualStock
        {
            get { return actual_stock; }
            set { actual_stock = value; }
        }
        [DataMember]
        public string CurrentStock
        {
            get { return current_stock; }
            set { current_stock = value; }
        }

        [DataMember]
        public string BookImage
        {
            get { return book_img_link; }
            set { book_img_link = value; }
        }
    }
}
