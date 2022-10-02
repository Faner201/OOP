class Program 
{
    static void Main(string[] args)
    {
        MobileStore store = new MobileStore(
            new ConsolePhoneReader(), new GeneralPhoneBinder(), 
            new TextPhoneSaver(), new GeneralPhoneValidator()
        );
        store.Process();
    }
}
