namespace HouseRules.Models.DTOs;
public class ChoreDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Difficulty { get; set; }
    public int ChoreFrequencyDays { get; set; }
    public List<ChoreCompletionDTO> choreCompletions { get; set; }
        public List<ChoreAssignmentsDTO> choreAssignments { get; set; }

}