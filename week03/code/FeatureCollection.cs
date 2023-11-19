public class FeatureCollection
{
    public List<Feature> Features { get; set; }
}

public  class Feature
{
    public Properties Properties { get; set; }
}

public  class Properties
{
    public double Mag { get; set; }
    public string Place { get; set; }
    public long Time { get; set; }
    public long Updated { get; set; }
    public object Tz { get; set; }
    public Uri Url { get; set; }
    public Uri Detail { get; set; }
    public long? Felt { get; set; }
    public double? Cdi { get; set; }
    public double? Mmi { get; set; }
    public string Alert { get; set; }
    public string Status { get; set; }
    public long Tsunami { get; set; }
    public long Sig { get; set; }
    public string Net { get; set; }
    public string Code { get; set; }
    public string Ids { get; set; }
    public string Sources { get; set; }
    public string Types { get; set; }
    public long? Nst { get; set; }
    public double? Dmin { get; set; }
    public double Rms { get; set; }
    public double? Gap { get; set; }
    public string MagType { get; set; }
    public string Type { get; set; }
    public string Title { get; set; }
}
