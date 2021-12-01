using CreatorKitCode;

public class AddHealthEffect : UsableItem.UsageEffect
{
    public int HealthPoints;

    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(HealthPoints);

        return true;
    }
}
