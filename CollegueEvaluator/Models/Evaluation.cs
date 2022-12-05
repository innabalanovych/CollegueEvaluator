using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegueEvaluator.Models
{
	[Table("Evaluations")]
	public class Evaluation
	{
        [Key]
		public string Id { get; set; }
		public string UserId { get; set; }
		public string EvaluatedUserName { get; set; }
		public string Responsibility { get; set; }
		public string Performance { get; set; }
		public string СommunicationSkills { get; set; }
		public string Qualification { get; set; }
	}
}
