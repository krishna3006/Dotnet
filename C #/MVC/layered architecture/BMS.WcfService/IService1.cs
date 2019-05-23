using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BMS.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBookService" in both code and config file together.
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        bool DeleteBook(int BookID);

        [OperationContract]
        bool UpdateBook(Book bookID);

        [OperationContract]
        bool AddBook(Book book);

        [OperationContract]
        Book SearchBook(int id);

        [OperationContract]
        List<Book> ShowBook();
    }
       
    [DataContract]
    public class Book
        {
            [DataMember]
            public int? ID { get; set; }
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public decimal? Price { get; set; }
            [DataMember]
            public string Description { get; set; }
        }    
    
}
