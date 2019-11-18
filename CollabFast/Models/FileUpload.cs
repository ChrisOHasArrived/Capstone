using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CollabFast.Models
{
    public class FileUpload
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public String FileName { get; set; }
        public String FileType { get; set; }
        public String Owner { get; set; }
        public DateTime DateUploaded { get; set; }
       
    }
}