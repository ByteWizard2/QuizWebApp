using Microsoft.EntityFrameworkCore;

namespace QuizAPI.Models
{
    public class QuizDbContext : DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options):base(options) 
        {
            
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Participant> Participants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasData(
               new Question { QnId = 1, QnInWords = "What does HTML stand for?", ImageName = null, Option1 = "Hyper Trainer Marking Language", Option2 = "Hyper Text Marketing Language", Option3 = "Hyper Text Markup Language", Option4 = "Hyper Text Markup Leveler", Answer = 3 },
                new Question { QnId = 2, QnInWords = "The brain of any computer system is", ImageName = null, Option1 = "ALU", Option2 = "Memory", Option3 = "CPU", Option4 = "Control unit", Answer = 3 },
                new Question { QnId = 3, QnInWords = "Which of the following computer languages is used for artificial intelligence?", ImageName = null, Option1 = "FORTRAN", Option2 = "PROLOG", Option3 = "C", Option4 = "COBOL", Answer = 2 },
                new Question { QnId = 4, QnInWords = "What is the primary requisite of a good computer programmer?", ImageName = null, Option1 = "Mathematical Mind", Option2 = "Artistic mind", Option3 = "Logical Mind", Option4 = "Scientific Knowledge", Answer = 3 },
                new Question { QnId = 5, QnInWords = "Name the device.", ImageName = "mouse.png", Option1 = "Keyboard", Option2 = "Monitor", Option3 = "Mouse", Option4 = "Graphics Card", Answer = 3 },
                new Question { QnId = 6, QnInWords = "The first mechanical computer designed by Charles Babbage was called?", ImageName = null, Option1 = "Analytical Engine", Option2 = "Calculator", Option3 = "Processor", Option4 = "Abacus", Answer = 1 },
                new Question { QnId = 7, QnInWords = "One byte is equivalent to?", ImageName = null, Option1 = "4 bits", Option2 = "8 bits", Option3 = "16 bits", Option4 = "32 bits", Answer = 2 },
                new Question { QnId = 8, QnInWords = "Web pages are written using?", ImageName = null, Option1 = "FTP", Option2 = "UML", Option3 = "HTML", Option4 = "URL", Answer = 3 },
                new Question { QnId = 9, QnInWords = "Which of the following is NOT an operating system?", ImageName = null, Option1 = "Dos", Option2 = "Unix", Option3 = "Window NT", Option4 = "CSS", Answer = 4 },
                new Question { QnId = 10, QnInWords = "What is the full form of IP?", ImageName = null, Option1 = "Interface Program", Option2 = "Interface Protocol", Option3 = "Internet program", Option4 = "Internet Protocol", Answer = 4 }
            );
        }
    }
}
