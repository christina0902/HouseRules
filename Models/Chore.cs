namespace HouseRules.Models;
public class Chore 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Difficulty { get; set; }
    public int ChoreFrequencyDays { get; set; }
    public List<ChoreCompletion>? choreCompletions { get; set; }
    public List<ChoreAssignment>? choreAssignments { get; set; }
}