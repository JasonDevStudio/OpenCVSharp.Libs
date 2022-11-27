using HiOpenCVLibs.Shapes;

namespace HiOpenCVLibs;

public class AddIn
{
    public void RegsisterTypes()
    {
        GlobaService.ContainerBuilder.RegisterType<CircleShape>().Keyed<IShape>(ShapeTypes.Circle).PropertiesAutowired();
        GlobaService.ContainerBuilder.RegisterType<RectangleShape>().Keyed<IShape>(ShapeTypes.Rectangle).PropertiesAutowired();
        GlobaService.ContainerBuilder.RegisterType<PentagramShape>().Keyed<IShape>(ShapeTypes.Pentagram).PropertiesAutowired();

        GlobaService.Container = GlobaService.ContainerBuilder.Build();
    }
}
