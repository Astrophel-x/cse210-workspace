

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }


//uh. if tracking how many times completed, would prolly be here. 
    public override void RecordEvent()
    {
        
    }


    public override bool IsComplete()
    {
        return false;

    }

    public override string GetSaveString()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }



}