namespace test.api;

public class Tests
{
    private List<ObjetoAereo>? doisObjetos
    //construtor
    [SetUp]
    public void Setup()
    {
        doisObjetos = 
                new ObjetoAereo{
                    Id = 1,
                    Latitude = 32.897548,
                    Longitude = -65.0099726,
                    Altitude = 1000
                },
                 new ObjetoAereo{
                    Id = 2,
                    Latitude = 32.897206,
                    Longitude = -65.010466,
                    Altitude = 900
                },};
    }

    [Test]
    public void Test1()
    {

    }
}