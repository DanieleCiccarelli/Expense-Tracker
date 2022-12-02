using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        //CategoryId
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Note { get; set; }

        public DateTime? Date { get; set; } = DateTime.Now;
    }
}
