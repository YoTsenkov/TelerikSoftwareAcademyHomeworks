
namespace StudentSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Homework
    {
        private DateTime? timeSent;
        public int HomeworkId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime? TimeSent
        {
            get 
            { 
                return this.timeSent; 
            }
            set
            { 
                this.timeSent = value;
            }
        }
        
       /* private DateTime SanitizeDate(DateTime unsanitizedDate)
        {           
            return new DateTime(unsanitizedDate.Year, unsanitizedDate.Month,
                    unsanitizedDate.Day, unsanitizedDate.Hour, unsanitizedDate.Minute,
                    unsanitizedDate.Second);
        }*/
    }
}
