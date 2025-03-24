public class SupportChain
{
    public static IHandler CreateSupportChain()
    {
        var low = new LowLevelSupport();
        var middle = new MiddleLevelSupport();
        var high = new HighLevelSupport();

        low.SetNext(middle).SetNext(high);
        return low;
    }
}
