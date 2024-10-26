
// bir class birden fazla interface'i implement edebilir!!!
// 
public class HoverCraft : IHavaTasit, IKaraTasit
{

    // interfaceden gelen Name metodu burada implement edilebilir!!!
    public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    // HoverCraft hem karada hem de hava da seyehat edebilen bir araç türüdür
    // bunun için, hem havataşiti hemde karataşıtı interfacesini implement edebilir


    public void Dur()
    {
        throw new NotImplementedException();
    }

    public void Git()
    {
        throw new NotImplementedException();
    }

    public void Kon()
    {
        throw new NotImplementedException();
    }

    public void Uc()
    {
        throw new NotImplementedException();
    }
}