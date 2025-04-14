using System.ComponentModel.DataAnnotations;

namespace BulkyWeb2.Models
{
    public class Cayegory
    {
        //we will be creating the properties here  and now all the properties
        //that we will create in category class will be basically the cpoloumns
        //that we want in category class
        [Key]
        public int Category__Id { get; set; } //Primary key of the table

        
        public string Name { get; set; }

        
        public int DisplayOrder { get; set; }
    }
}
