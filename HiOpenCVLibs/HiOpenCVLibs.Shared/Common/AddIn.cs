using HiOpenCVLibs.Shapes;

namespace HiOpenCVLibs;

public class AddIn
{
    public void RegsisterTypes()
    {
        GlobaService.ContainerBuilder.RegisterType<CirclePointShape>().Keyed<IPointShape>(ShapeTypes.Circle).PropertiesAutowired();
        GlobaService.ContainerBuilder.RegisterType<RectangleShape>().Keyed<IPointShape>(ShapeTypes.Rectangle).PropertiesAutowired();
        GlobaService.ContainerBuilder.RegisterType<PentagramPointShape>().Keyed<IPointShape>(ShapeTypes.Pentagram).PropertiesAutowired();

        GlobaService.Container = GlobaService.ContainerBuilder.Build();
    }
}
