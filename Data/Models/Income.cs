using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Data.Models
{
    public class Income
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string TItle { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public IncomeType Type { get; set; }
      
    }   
    public enum IncomeType
    {
        Salary,
        Scholarship,
        Gift,
        LuckyWinnings
    }
}
