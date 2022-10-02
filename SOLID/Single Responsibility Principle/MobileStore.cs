public class MobileStore
{
    List<Phone> phones = new List<Phone>();

    public IPhoneReader Reader { get; set; }
    public IPhoneBinder Binder { get; set; }
    public IPhoneValidator Validator { get; set; }
    public IPhoneSaver Saver { get; set; }

    public MobileStore(IPhoneReader reader, IPhoneBinder binder, IPhoneSaver saver, IPhoneValidator validator)
    {
        this.Reader = reader;
        this.Binder = binder;
        this.Saver = saver;
        this.Validator = validator;
    }

    public void Process()
    {
        string?[] data = Reader.GetInputData();
        Phone phone = Binder.CreatePhone(data);

        if(Validator.IsValid(phone))
        {
            Saver.Save(phone, "store.txt");
            Console.WriteLine("Данные успешно обработаня");
        }
        else 
            Console.WriteLine("Некорректные данные");
    }
}