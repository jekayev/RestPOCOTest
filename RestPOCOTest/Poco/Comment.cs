using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestPOCOTest.Poco
{
    [Table("comments")]
    public partial class Comment
    {
        [Column("commentId")]
        public int CommentId { get; set; }
        [Column("camperId")]
        public int? CamperId { get; set; }
        [Column("comment")]
        [StringLength(1000)]
        public string Comment1 { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("timestamp", TypeName = "datetime")]
        public DateTime? Timestamp { get; set; }
    }
}