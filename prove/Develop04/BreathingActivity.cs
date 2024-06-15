class BreathingActivity : Activities
{
    public BreathingActivity(int durParam, string nameParam, string descriptionParam)
        : base(durParam, nameParam, descriptionParam) //just refer to parent
    {
        //refering to paraent param 
    }
    public async Task PerformActivity()
    {
        await StartActivity();

        for (int i = 0; i < activityDuration; i += 6) // 6 seconds for each breathing cycle
        {
            Console.WriteLine("Breathe in... ");
            await Task.Delay(3000); // Pause for 3 seconds
            Console.WriteLine("Breathe out... ");
            await Task.Delay(3000); // Pause for 3 seconds
        }

        await EndActivity();
    }
}
