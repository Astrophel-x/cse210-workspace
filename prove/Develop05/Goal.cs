
// base ## Goal (abstract)

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points; //[would be overridden?]

    //private bool _IsComplete = false;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract string GetName();
    public abstract string GetDescription();
    public abstract int GetPoints();



    public abstract void RecordEvent();




    public abstract string GetStatus();

    public abstract bool IsComplete();

//for human eyes, details
    public virtual string GetGoalSummary()
    {
        if (IsComplete() == true)
        {
            return $"[X] {GetName()} : {GetDescription()}";
        }
        else
        {
            return $"[ ] {GetName()} : {GetDescription()}";
        }
    }

// for the computer/save file
    public abstract string GetSaveString();

}