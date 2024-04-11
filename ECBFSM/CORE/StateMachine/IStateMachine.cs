public interface IStateMachine<I> where I : IBaseFeatures
{
    public void ChooseConfig(SM_BUILDER<I> sm_config);

    public void ResetState();

    public void Run();

}